using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.Role
{
    public class RoleConfiguration : IEntityTypeConfiguration<Domain.Role>
    {
        public void Configure(EntityTypeBuilder<Domain.Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(role => role.Id);
            builder.Property(role => role.Description).ValueGeneratedOnAdd();

            builder.Property(r => r.Title).HasMaxLength(100);

            builder.Property(r => r.Description).HasMaxLength(500);

            builder.HasMany(r => r.Users)
                .WithOne(user => user.Role)
                .HasForeignKey(user => user.RoleId);
        }
    }
}
