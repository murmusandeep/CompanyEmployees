using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "b49b9efc-20af-4d3f-bcb9-4c23556db8c6",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    ConcurrencyStamp = "b49b9efc-20af-4d3f-bcb9-4c23556db8c6"
                },
                new IdentityRole
                {
                    Id = "c2301d1f-9f45-4a84-a0a1-d0b60a74b312",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ConcurrencyStamp = "c2301d1f-9f45-4a84-a0a1-d0b60a74b312"
                }
            );
        }
    }
}
