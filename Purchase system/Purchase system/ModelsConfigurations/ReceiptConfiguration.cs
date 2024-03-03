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
    internal class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
    {
        public void Configure(EntityTypeBuilder<Receipt> builder)
        {
            #region Table
            builder.ToTable("Receipts");
            builder.HasKey(P => P.Id);
            #endregion

            #region Id Property
            builder.Property(R => R.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("int");
            #endregion

            #region TotalPrice Property
            builder.Property(R => R.TotalPrice)
                   .HasColumnName("TotalPrice")
                   .HasColumnType("decimal")
                   .IsRequired(true);
            #endregion

            #region PaymentTime Property
            builder.Property(R => R.PaymentTime)
                   .HasColumnName("PaymentTime")
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .IsRequired(true);
            #endregion
        }
    }
}
