using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard.DataAccess.EntityConfigurations.Category
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Category>
    {
        public void Configure(EntityTypeBuilder<Domain.Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(category => category.Title);

            builder.Property(c => c.Title).HasMaxLength(100);

            builder.HasMany(c => c.Bulletins)
                .WithMany(bulletin => bulletin.Categories);


        }
    }
}
