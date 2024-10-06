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
            C.HasKey(c=>c.Id);

            C.HasOne(C=>C.City)
                .WithOne(c=>c.Customer)
                .HasForeignKey<Customer>(c=>c.Id);
            //Review
            C.HasMany(C => C.Reviews)
                .WithOne(R => R.Customer)
                .HasForeignKey(R => R.CustomerId);

        }
    }
}
