using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole> builder)
        {
            builder.HasData(
                    new IdentityUserRole
                    {
                        RoleId = "59515a00-372d-420b-a497-58ff6030a81c",
                        UserId = "86bc9e15-426f-4269-bb30-c2bc84c0978d"
                    },
                    new IdentityUserRole
                    {
                        RoleId = "23889b32-70b1-47a1-85e4-ebf0f4e08ecc",
                        UserId = "a0729849-48f2-464d-82d4-e963de711103"
                    }
                );
        }
    }
}
