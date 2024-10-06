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
    internal class ProtfolioItemCConfigurations : IEntityTypeConfiguration<Protfolio_item>
    {
        public void Configure(EntityTypeBuilder<Protfolio_item> P)
        {
            P.HasKey(x => x.Id);
            P.Property(x => x.Bio).HasColumnType("text");
            P.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(50);

            P.HasMany(p=>p.Protfolio_Image)
                .WithOne(p=>p.Protfolio_Item)
                .HasForeignKey(p=>p.ProtfolioId);
        }
    }
}
