using System.Reflection;
using EntityFrameworkConsoleApp.Entities;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkConsoleApp.DataBaseEntity
{
    public class NorthwindDatabase : DbContext
    {
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<SatisDetay> SatisDetaylar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Northwind;User Id=sa;Password=Pp123456*-;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SatisDetay>().HasNoKey();
        }
    }
}