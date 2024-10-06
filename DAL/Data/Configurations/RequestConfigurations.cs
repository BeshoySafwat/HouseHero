using Azure.Core;
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
    internal class RequestConfigurations : IEntityTypeConfiguration<Requests>
    {
        public void Configure(EntityTypeBuilder<Requests> R)
        {
            R.HasKey(R => R.Id);

            R.Property(r => r.RequestDate).HasDefaultValue(DateTime.Now);

            R.HasOne(R=>R.Provider)
                .WithMany(R => R.Requests)
                .HasForeignKey(R=>R.ProviderId);
            R.HasOne(R=>R.Service)
                .WithMany(R => R.Requests)
                .HasForeignKey(R=>R.ServiceId);
            R.HasOne(R=>R.Customer)
                .WithMany(R => R.Requests)
                .HasForeignKey(R=>R.CustomerId);

        }
    }
}
