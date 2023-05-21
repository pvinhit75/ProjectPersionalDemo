using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectPersional.Data.Entities;
using ProjectPersional.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPersional.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>;
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(c => c.Id);  

            builder.Property(c => c.Status).HasDefaultValue(Status.Active);
        }
    }
}
