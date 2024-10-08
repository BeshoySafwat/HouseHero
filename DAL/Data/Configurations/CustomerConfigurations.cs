using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Configurations
{
    internal class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> C)
        {
            C.ToTable("Customers");
            C.HasKey(x => x.Id);
            C.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(50);
            C.Property(x => x.Email).HasColumnType("nvarchar").HasMaxLength(50);
            C.Property(x => x.PasswordHashed).HasColumnType("nvarchar");
            C.Property(x => x.Address).HasColumnType("nvarchar");
            C.Property(x => x.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(20);

            //Review
            C.HasMany(C => C.Reviews)
                .WithOne(R => R.Customer)
                .HasForeignKey(R => R.CustomerId);

            //City
            C.HasOne(p => p.City)
            .WithMany(c => c.Customers)
            .HasForeignKey(p => p.CityId);
        }
    }
}
