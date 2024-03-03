using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;
using Purchase_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase_system.ModelsConfigurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Table
            builder.ToTable("Products");
            builder.HasKey(P => P.Id);
            #endregion

            #region Name Property
            builder.Property(P => P.Name)
                   .HasColumnName("Name")
                   .HasColumnType("varchar")
                   .IsRequired(true)
                   .HasMaxLength(50);
            #endregion

            #region Id Property
            builder.Property(P => P.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("int");
            #endregion

            #region ProductionDate Property
            builder.Property(P => P.ProductionDate)
                   .HasColumnName("ProductionDate")
                   .IsRequired(true);
            #endregion

            #region ExpiryDate Property
            builder.Property(P => P.ExpiryDate)
                   .HasColumnName("ExpiryDate");
            #endregion

            #region Price Property
            builder.Property(P => P.Price)
                   .HasColumnName("Price")
                   .HasColumnType("decimal")
                   .IsRequired(true);
            #endregion
        }
    }
}
