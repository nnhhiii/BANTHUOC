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
        public DbSet<Staff> NhanVien { get; set; }
        public DbSet<ImportInvoice> HoaDonNhapHang { get; set; }
        public DbSet<ImportDetail> CTHDNhapHang { get; set; }
        public DbSet<Role> Role { get; set; }
        public object Staffs { get; internal set; }

        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<EFDbContext>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drug>()
                .Property(d => d.price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ImportDetail>()
                .Property(id => id.amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ImportDetail>()
                .Property(id => id.import_price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ImportInvoice>()
                .Property(ii => ii.total_amount)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
