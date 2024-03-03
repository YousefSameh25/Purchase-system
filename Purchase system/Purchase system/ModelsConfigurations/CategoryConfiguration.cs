using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Purchase_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.ModelsConfigurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Table
            builder.ToTable("Categories");
            builder.HasKey(C => C.Id);
            #endregion

            #region Id Property
            builder.Property(C => C.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("int");
            #endregion

            #region Name Property
            builder.Property(C => C.Name)
                   .HasColumnName("Name")
                   .HasColumnType("varchar")
                   .IsRequired(true)
                   .HasMaxLength(50);
            #endregion
        }
    }
}
