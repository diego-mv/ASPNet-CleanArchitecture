using CleanArchitecture.Application.Constants;
using CleanArchitecture.Application.Contracts.Identity;
using CleanArchitecture.Application.Models.Identity;
using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanArchitecture.Identity.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager, 
                           SignInManager<ApplicationUser> signInManager,
                           IOptions<JwtSettings> jwtSettings)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtSettings = jwtSettings.Value;
        }

        public async Task<AuthResponse> Login(AuthRequest request)
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                throw new Exception($"Credenciales no válidas");
            }

            SignInResult result = await _signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                throw new Exception($"Credenciales no válidas");
            }
            var token = await GenerateToken(user);

            return new AuthResponse
            {
                Id = user.Id,
                Email = user.Email,
                Username = user.UserName,
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest request)
        {
            ApplicationUser userExistent = await _userManager.FindByNameAsync(request.Username);
            if (userExistent != null)
            {
                throw new Exception($"Ya existe un usuario con el username {request.Username}");
            }
            ApplicationUser emailExistent = await _userManager.FindByEmailAsync(request.Email);
            if (emailExistent != null)
            {
                throw new Exception($"Ya existe un usuario con el email {request.Email}");
            }

            ApplicationUser user = new ApplicationUser
            {
                Email = request.Email,
                Name = request.Name,
                Surname = request.Surname,
                UserName = request.Username,
                EmailConfirmed = true
            };
            IdentityResult result = await _userManager.CreateAsync(user);
            var token = await GenerateToken(user);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Operator");
                return new RegistrationResponse
                {
                    Email = user.Email,
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    UserId = user.Id,
                    Username = user.UserName,
                };
            }

            throw new Exception($"{result.Errors}");
        }

        private async Task<JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            foreach (var role in roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }
            var claims = new[]
            {
                new Claim(CustomClaimsTypes.Uid, user.Id),
                new Claim(CustomClaimsTypes.Username, user.UserName),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
            }.Union(userClaims).Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                                            issuer: _jwtSettings.Issuer,
                                            audience: _jwtSettings.Audience,
                                            claims: claims,
                                            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                                            signingCredentials: signingCredentials
                                            );
            return jwtSecurityToken;
        }
    }
}
