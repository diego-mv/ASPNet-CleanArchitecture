using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                    new IdentityRole
                    {
                        Id = "59515a00-372d-420b-a497-58ff6030a81c",
                        Name = "Administrator",
                        NormalizedName= "ADMINISTRATOR",
                    },
                    new IdentityRole
                    {
                        Id = "23889b32-70b1-47a1-85e4-ebf0f4e08ecc",
                        Name = "Operator",
                        NormalizedName = "OPERATOR",
                    }
                );
        }
    }
}
