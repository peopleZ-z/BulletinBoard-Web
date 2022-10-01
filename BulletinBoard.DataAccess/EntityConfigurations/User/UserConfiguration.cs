using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.User
{
    public class UserConfiguration : IEntityTypeConfiguration<Domain.User>
    {
        public void Configure(EntityTypeBuilder<Domain.User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(user => user.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Nickname).HasMaxLength(200);

            builder.HasOne(u => u.Role)
                .WithMany(role => role.Users);

            builder.HasMany(u => u.Bulletins)
                .WithOne(bulletin => bulletin.Owner)
                .HasForeignKey(bulletin => bulletin.Id);

            builder.HasMany(u => u.Comments)
                .WithOne(comment => comment.Owner)
                .HasForeignKey(comment => comment.OwnerId);


        }
    }
}
