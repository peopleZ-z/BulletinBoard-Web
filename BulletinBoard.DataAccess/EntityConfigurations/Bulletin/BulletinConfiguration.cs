using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.Bulletin
{
    public class BulletinConfiguration : IEntityTypeConfiguration<Domain.Bulletin>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Bulletin> builder)
        {
            builder.ToTable("Bulletins");

            builder.HasKey(bulletin => bulletin.Id);
            builder.Property(bulletin => bulletin.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.Title).HasMaxLength(200);

            builder.Property(b => b.Description).HasMaxLength(1000);

            builder.Property(b => b.Contact).HasMaxLength(500);

            //builder.Property(b => b.Price);

            builder.Property(b => b.Created).ValueGeneratedOnAdd();

            builder.Property(b => b.Updated).ValueGeneratedOnUpdate();

            builder.HasOne(b => b.Owner)
                .WithMany(owner => owner.Bulletins);

            builder.HasMany(b => b.Categories)
                .WithMany(category => category.Bulletins);

            builder.HasMany(b => b.Comments)
                .WithOne(photo => photo.Bulletin)
                .HasForeignKey(photo => photo.BulletinId);

            builder.HasMany(b => b.Photos)
                .WithOne(photo => photo.Bulletin)
                .HasForeignKey(photo => photo.BulletinId);
        }
    }
}
