using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.Photo
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Domain.Photo>
    {
        public void Configure(EntityTypeBuilder<Domain.Photo> builder)
        {
            builder.ToTable("Photos");

            builder.HasKey(photo => photo.Id);
            builder.Property(ph => ph.Id).ValueGeneratedOnAdd();

            builder.Property(ph => ph.FileReference).HasMaxLength(1000);

            builder.Property(ph => ph.Title).HasMaxLength(500);

            builder.HasOne(ph => ph.Bulletin)
                .WithMany(bulletin => bulletin.Photos);
        }
    }
}
