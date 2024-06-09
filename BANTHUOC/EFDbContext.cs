using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BANTHUOC.Models; //truy xuất đến các lớp: Customer,…
using System.Configuration;
namespace BANTHUOC
{
    internal class EFDbContext : DbContext
    {
        public DbSet<DrugCategory> LoaiDuocPham { get; set; }
        public DbSet<Drug> Thuoc { get; set; }
        public DbSet<Supplier> NhaCungCap { get; set; }
        public DbSet<Unit> DonViTinh { get; set; }
        public void ConfigureServices(IServiceCollection services)
        => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    }

}