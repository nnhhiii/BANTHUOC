using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fManageDrugInfo : Form
    {
        private EFDbContext db = new EFDbContext();
        public fManageDrugInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fManageDrugInfo_Load(object sender, EventArgs e)
        {
            tenThuoc.DisplayMember = "drug_name";
            tenThuoc.ValueMember = "id";
            tenThuoc.DataSource = db.Thuoc
                .Select(c => new { c.id, c.drug_name })
                .ToList();
        }

        private void tenThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            long DrugID = Convert.ToInt64(tenThuoc.SelectedValue);

            // Lấy thông tin chi tiết của thuốc
            var drug = db.Thuoc
                .Include(d => d.DrugCategory)
                .Include(d => d.Supplier)
                .Include(d => d.Unit)
                .SingleOrDefault(p => p.id == DrugID);

            if (drug != null)
            {
                giaBan.Text = drug.price.ToString();
                // Hiển thị các thông tin khác
                loaiThuoc.Text = drug.DrugCategory.category_name;
                nhaCungCap.Text = drug.Supplier.supplier_name;
                donVi.Text = drug.Unit.unit_name;
                hamLuong.Text = drug.content;
                dongGoi.Text = drug.packing;
                soLuong.Text = drug.quantity.ToString();
                moTa.Text = drug.description;
                huongDanSuDung.Text = drug.usage_instructions;
                tacDungPhu.Text = drug.side_effects;
                chongChiDinh.Text = drug.contraindications;
                hanSuDung.Text = drug.expiry_date.ToShortDateString();
                txtImageFile.Text = string.IsNullOrWhiteSpace(drug.image) ? null : Utility.ImagePath + drug.image;
                pictureBox1.ImageLocation = txtImageFile.Text; //Hiển thị hình
            }

        }
    }
}
