using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Context
{
    public class AppalicationDBContext:DbContext
    {
        public AppalicationDBContext():base()
        {

        }
        public AppalicationDBContext(DbContextOptions<AppalicationDBContext> option) : base(option)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Person>(); // This line is crucial
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Available_Day> Available_Day { get; set;}
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Protfolio_image> Protfolio_images { get; set; }
        public DbSet<Protfolio_item> Protfolio_items { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Review> Reviews { get; set; }  
        public DbSet<SavedProvider> SavedProviders { get; set; }

    }
}
