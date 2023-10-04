using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.DAL.Data;

namespace Turbo.DAL.DbContext
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<BanTypeCategory> BanTypeCategories { get; set; }
        public DbSet<CityCategory> CityCategories { get; set; }
        public DbSet<ColorCategory> ColorCategories { get; set; }
        public DbSet<EngineCapacityCategory> EngineCapacities { get; set; }
        public DbSet<FuelTypeCategory> FuelTypeCategories { get; set; }
        public DbSet<GearBoxCategory> GearBoxCategories { get; set; }
        public DbSet<GearCategory> GearCategories { get; set; }
        public DbSet<HowManyOwnerCategory> HowManies { get; set; }
        public DbSet<MarkaCategory> MarkaCategories { get; set; }
        public DbSet<MarketAssembledCategory> MarketAssembleds { get; set; }
        public DbSet<ModelCategory> ModelCategories { get; set; }
        public DbSet<VehicleSupplyCategory> VehicleSupplyCategories { get; set; }
        public DbSet<YearCategory> YearCategories { get; set; }

    }
}
