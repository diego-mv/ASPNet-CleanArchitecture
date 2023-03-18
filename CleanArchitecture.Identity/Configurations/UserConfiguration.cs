using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(
                    new ApplicationUser
                    {
                        Id = "86bc9e15-426f-4269-bb30-c2bc84c0978d",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "admin@localhost.com".ToUpper(),
                        Name = "Admin",
                        Surname = "Admin",
                        UserName = "admin",
                        NormalizedUserName = "admin".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "Admin123!"),
                        EmailConfirmed = true,
                    },
                    new ApplicationUser
                    {
                        Id = "a0729849-48f2-464d-82d4-e963de711103",
                        Email = "user@localhost.com",
                        NormalizedEmail = "user@localhost.com".ToUpper(),
                        Name = "User",
                        Surname = "User",
                        UserName = "user",
                        NormalizedUserName = "user".ToUpper(),
                        PasswordHash = hasher.HashPassword(null, "User123!"),
                        EmailConfirmed = true,
                    }
                );
        }
    }
}
