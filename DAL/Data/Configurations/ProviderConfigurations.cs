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
    internal class ProviderConfigurations : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> P)
        {
            P.HasKey(x=>x.Id);
            P.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(50);
            P.Property(x => x.Email).HasColumnType("nvarchar").HasMaxLength(50);
            P.Property(x => x.PasswordHash).HasColumnType("nvarchar");
            P.Property(x => x.Address).HasColumnType("nvarchar");
            P.Property(x => x.Bio).HasColumnType("text");
            //City
            P.HasOne(p => p.City)
            .WithOne(c => c.provider)
            .HasForeignKey<Provider>(p => p.CityId);
            //Service
            P.HasOne(p => p.Service)
             .WithMany(s => s.Providers)
             .HasForeignKey(p => p.ServiceId);
            //Protfolio_item
            P.HasMany(p => p.Protfolio_Item)
             .WithOne(P => P.Provider)
             .HasForeignKey(p => p.ProviderId).OnDelete(DeleteBehavior.Cascade);
            //Review
            P.HasMany(p => p.Reviews)
             .WithOne(R => R.Provider)
             .HasForeignKey(R => R.ProviderId);

            
            
        }
    }
}
