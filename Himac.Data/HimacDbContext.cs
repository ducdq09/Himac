using Himac.Model.Models;
using System.Data.Entity;

namespace Himac.Data
{
    public class HimacDbContext : DbContext
    {
        public HimacDbContext() : base("HimacConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<LoaiVanBan> LoaiVanBans { get; set; }
        public DbSet<VanBan> VanBans { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}