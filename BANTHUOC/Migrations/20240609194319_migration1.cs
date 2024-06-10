using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BANTHUOC.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Kiểm tra và tạo bảng CTHDNhapHang nếu chưa tồn tại
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='CTHDNhapHang' AND xtype='U')
                CREATE TABLE [CTHDNhapHang] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [import_invoice_id] BIGINT NOT NULL,
                    [drug_id] BIGINT NOT NULL,
                    [import_price] DECIMAL(18,2) NOT NULL,
                    [quantity] INT NOT NULL,
                    [amount] DECIMAL(18,2) NOT NULL,
                    [expiry_date] DATETIME2 NOT NULL,
                    CONSTRAINT [PK_CTHDNhapHang] PRIMARY KEY ([id])
                );");

            // Kiểm tra và tạo bảng DonViTinh nếu chưa tồn tại
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DonViTinh' AND xtype='U')
                CREATE TABLE [DonViTinh] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [unit_name] NVARCHAR(MAX) NOT NULL,
                    CONSTRAINT [PK_DonViTinh] PRIMARY KEY ([id])
                );");

            // Kiểm tra và tạo bảng HoaDonNhapHang nếu chưa tồn tại
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='HoaDonNhapHang' AND xtype='U')
                CREATE TABLE [HoaDonNhapHang] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [total_amount] DECIMAL(18,2) NOT NULL,
                    [creat_at] DATETIME2 NOT NULL,
                    [employee_id] BIGINT NOT NULL,
                    CONSTRAINT [PK_HoaDonNhapHang] PRIMARY KEY ([id])
                );");

            // Các bảng khác
            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LoaiDuocPham' AND xtype='U')
                CREATE TABLE [LoaiDuocPham] (
                    [category_id] BIGINT NOT NULL IDENTITY(1, 1),
                    [category_name] NVARCHAR(MAX) NOT NULL,
                    [description] NVARCHAR(MAX) NOT NULL,
                    CONSTRAINT [PK_LoaiDuocPham] PRIMARY KEY ([category_id])
                );");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='NhaCungCap' AND xtype='U')
                CREATE TABLE [NhaCungCap] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [supplier_name] NVARCHAR(MAX) NOT NULL,
                    [description] NVARCHAR(MAX) NOT NULL,
                    [address] NVARCHAR(MAX) NOT NULL,
                    [phone_number] INT NOT NULL,
                    CONSTRAINT [PK_NhaCungCap] PRIMARY KEY ([id])
                );");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='NhanVien' AND xtype='U')
                CREATE TABLE [NhanVien] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [full_name] NVARCHAR(MAX) NOT NULL,
                    [staff_gender] NVARCHAR(MAX) NOT NULL,
                    [date_of_birth] DATETIME2 NOT NULL,
                    [staff_address] NVARCHAR(MAX) NOT NULL,
                    [phone_number] INT NOT NULL,
                    [role_id] BIGINT NOT NULL,
                    [staff_email] NVARCHAR(MAX),
                    [password] NVARCHAR(MAX) NOT NULL,
                    [created_at] DATETIME2 NOT NULL,
                    CONSTRAINT [PK_NhanVien] PRIMARY KEY ([id])
                );");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Role' AND xtype='U')
                CREATE TABLE [Role] (
                    [Id] BIGINT NOT NULL IDENTITY(1, 1),
                    [RoleName] NVARCHAR(MAX) NOT NULL,
                    CONSTRAINT [PK_Role] PRIMARY KEY ([Id])
                );");

            migrationBuilder.Sql(@"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Thuoc' AND xtype='U')
                CREATE TABLE [Thuoc] (
                    [id] BIGINT NOT NULL IDENTITY(1, 1),
                    [drug_name] NVARCHAR(MAX) NOT NULL,
                    [category_id] BIGINT NOT NULL,
                    [supplier_id] BIGINT NOT NULL,
                    [unit_of_measure_id] BIGINT NOT NULL,
                    [image] NVARCHAR(MAX),
                    [content] NVARCHAR(MAX) NOT NULL,
                    [packing] NVARCHAR(MAX) NOT NULL,
                    [quantity] INT NOT NULL,
                    [price] DECIMAL(18,2) NOT NULL,
                    [description] NVARCHAR(MAX),
                    [usage_instructions] NVARCHAR(MAX),
                    [side_effects] NVARCHAR(MAX),
                    [contraindications] NVARCHAR(MAX),
                    [expiry_date] DATETIME2 NOT NULL,
                    CONSTRAINT [PK_Thuoc] PRIMARY KEY ([id]),
                    CONSTRAINT [FK_Thuoc_DonViTinh_unit_of_measure_id] FOREIGN KEY ([unit_of_measure_id]) REFERENCES [DonViTinh] ([id]) ON DELETE CASCADE,
                    CONSTRAINT [FK_Thuoc_LoaiDuocPham_category_id] FOREIGN KEY ([category_id]) REFERENCES [LoaiDuocPham] ([category_id]) ON DELETE CASCADE,
                    CONSTRAINT [FK_Thuoc_NhaCungCap_supplier_id] FOREIGN KEY ([supplier_id]) REFERENCES [NhaCungCap] ([id]) ON DELETE CASCADE
                );");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_category_id",
                table: "Thuoc",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_supplier_id",
                table: "Thuoc",
                column: "supplier_id");

            migrationBuilder.CreateIndex(
                name: "IX_Thuoc_unit_of_measure_id",
                table: "Thuoc",
                column: "unit_of_measure_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTHDNhapHang");

            migrationBuilder.DropTable(
                name: "HoaDonNhapHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Thuoc");

            migrationBuilder.DropTable(
                name: "DonViTinh");

            migrationBuilder.DropTable(
                name: "LoaiDuocPham");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
