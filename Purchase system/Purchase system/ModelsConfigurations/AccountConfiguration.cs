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
    internal class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            #region Table
            builder.ToTable("Accounts");
            builder.HasKey(A => A.Id);
            #endregion

            #region Id Property
            builder.Property(A => A.Id)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("Id")
                   .HasColumnType("int");
            #endregion

            #region Name Property
            builder.Property(P => P.Name)
                   .HasColumnName("Name")
                   .IsRequired(true)
                   .HasMaxLength(50);
            #endregion

            #region Email Property
            builder.Property(A => A.Email)
                   .HasColumnName("Email")
                   .IsRequired(true);
            #endregion

            #region Password Property
            builder.Property(A => A.Password)
                   .HasColumnName("Password")
                   .IsRequired(true);
            #endregion

            #region PhoneNumber Property
            builder.Property(A => A.PhoneNumber)
                   .HasColumnName("PhoneNumber")
                   .IsRequired(true);
            #endregion

            #region Balance Property
            builder.Property(A => A.Balance)
                   .HasColumnName("Balance")
                   .IsRequired(true);
            #endregion

        }
    }
}
