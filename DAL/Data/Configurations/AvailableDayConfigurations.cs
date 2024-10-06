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
    internal class AvailableDayConfigurations : IEntityTypeConfiguration<Available_Day>
    {
        public void Configure(EntityTypeBuilder<Available_Day> A)
        {
            A.HasKey(a=> a.Id);

            A.HasOne(a=>a.Provider)
                .WithMany(p=>p.Available_Day)
                .HasForeignKey(a=>a.ProviderId);
        }
    }
}
