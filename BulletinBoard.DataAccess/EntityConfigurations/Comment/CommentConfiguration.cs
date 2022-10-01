using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.Comment
{
    public class CommentConfiguration : IEntityTypeConfiguration<Domain.Comment>
    {
        public void Configure(EntityTypeBuilder<Domain.Comment> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(comment => comment.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Content).HasMaxLength(1000);

            builder.HasOne(c => c.Owner)
                .WithMany(owner => owner.Comments);

            builder.HasOne(c => c.Bulletin)
                .WithMany(bulletin => bulletin.Comments);
        }
    }
}
