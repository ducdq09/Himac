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

        public DbSet<LinhVuc> LinhVucs { get; set; }
        public DbSet<LoaiVanBan> LoaiVanBans { get; set; }
        public DbSet<VanBan> VanBans { get; set; }
        public DbSet<LoaiTinTuc> LoaiTinTucs { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        public DbSet<LoaiHoiDap> LoaiHoiDaps { get; set; }
        public DbSet<HoiDap> HoiDaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}