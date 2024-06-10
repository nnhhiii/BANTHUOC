using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using BANTHUOC.Models;

namespace BANTHUOC
{
    public partial class fNewDrugCategory : Form
    {
        DrugCategory drugCategory;
        public fNewDrugCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên loại thuốc?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }


            try
            {
                //Tạo loại thuốc mới
                drugCategory = new DrugCategory(); //Tạo một thể hiện (đối tượng) khách hàng mới
                drugCategory.category_name = txtName.Text;
                drugCategory.description = txtDescription.Text;

                using (var db = new EFDbContext())
                {
                    db.LoaiDuocPham.Add(drugCategory); //Thêm khách hàng vào bối cảnh mô hình
                    db.SaveChanges(); //Lưu các thay đổi vào csdl
                }
                //Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtDescription.Text = null;
                toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
