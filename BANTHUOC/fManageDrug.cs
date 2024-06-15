using BANTHUOC.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BANTHUOC
{
    public partial class fManageDrug : Form
    {
        private Staff loggedInEmployee;
        public fManageDrug(Staff loggedInEmployee)
        {
            InitializeComponent();
            this.loggedInEmployee = loggedInEmployee;
        }


        private void fDrugManagement_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                // Thiết lập DisplayMember và ValueMember cho ComboBox
                cbDrugCategory.DisplayMember = "category_name";
                cbDrugCategory.ValueMember = "category_id";

                // Lấy danh sách các loại thuốc từ cơ sở dữ liệu và đặt làm DataSource cho ComboBox
                cbDrugCategory.DataSource = db.LoaiDuocPham
                    .Select(c => new { c.category_id, c.category_name })
                    .ToList();
            }
        }


        private void DisplayDrugData(long categoryId, string drugName = "")
        {
            flowLayoutPanel1.Controls.Clear();
            using (var db = new EFDbContext())
            {
                var drugsQuery = db.Thuoc
                .Include(t => t.DrugCategory)
                .Where(t => t.category_id == categoryId);

                if (!string.IsNullOrEmpty(drugName))
                {
                    drugsQuery = drugsQuery.Where(t => t.drug_name.Contains(drugName));
                }

                var drugs = drugsQuery.ToList();

                int y = 0;
                foreach (var drug in drugs)
                {
                    Panel panel = new Panel();
                    panel.BackColor = Color.White;
                    panel.Size = new Size(530, 270);
                    panel.Location = new Point(12, y);
                    panel.Margin = new Padding(15);
                    //
                    // ảnh
                    //
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(11, 26);
                    pictureBox.Size = new Size(162, 182);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (!string.IsNullOrEmpty(drug.image))
                    {
                        string imagePath = Path.Combine(Utility.ImagePath, drug.image);
                        if (File.Exists(imagePath))
                        {
                            pictureBox.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            // nếu ko có trong thư mục Images/thuoc
                            pictureBox.Image = Properties.Resources.no_image;
                        }
                    }
                    else
                    {
                        // image trong db null
                        pictureBox.Image = Properties.Resources.no_image;
                    }
                    //
                    // tên thuốc
                    //
                    Label drugNameLabel = new Label();
                    drugNameLabel.AutoSize = true;
                    drugNameLabel.Location = new Point(222, 14);
                    drugNameLabel.Font = new Font("Arial", 14, FontStyle.Bold);
                    drugNameLabel.ForeColor = Color.DarkSlateGray;
                    drugNameLabel.Text = drug.drug_name;
                    //
                    // loại thuốc
                    //
                    Label loaiLabel = new Label();
                    loaiLabel.AutoSize = true;
                    loaiLabel.Location = new Point(267, 146);
                    loaiLabel.Size = new Size(50, 20);
                    loaiLabel.Text = drug.DrugCategory.category_name;
                    //
                    // số lượng
                    //
                    Label soLuongLabel = new Label();
                    soLuongLabel.AutoSize = true;
                    soLuongLabel.Location = new Point(267, 105);
                    soLuongLabel.Text = drug.quantity.ToString();
                    //
                    // giá bán
                    //
                    Label giaBanLabel = new Label();
                    giaBanLabel.AutoSize = true;
                    giaBanLabel.Location = new Point(267, 62);
                    giaBanLabel.Size = new Size(50, 20);
                    giaBanLabel.Text = drug.price.ToString("C");
                    //
                    // đóng gói
                    //
                    Label dongGoiLabel = new Label();
                    dongGoiLabel.AutoSize = true;
                    dongGoiLabel.Location = new Point(267, 181);
                    dongGoiLabel.Text = drug.packing;

                    Label label4 = new Label();
                    label4.Location = new Point(179, 180);
                    label4.Size = new Size(78, 50);
                    label4.Text = "Quy cách đóng gói";

                    Label label3 = new Label();
                    label3.AutoSize = true;
                    label3.Location = new Point(179, 146);
                    label3.Size = new Size(78, 20);
                    label3.TabIndex = 3;
                    label3.Text = "Loại thuốc";

                    Label label2 = new Label();
                    label2.AutoSize = true;
                    label2.Location = new Point(179, 105);
                    label2.Size = new Size(69, 20);
                    label2.TabIndex = 2;
                    label2.Text = "Số lượng";

                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Location = new Point(179, 62);
                    label1.Size = new Size(60, 20);
                    label1.TabIndex = 1;
                    label1.Text = "Giá bán";



                    panel.BackColor = SystemColors.ButtonHighlight;
                    panel.Controls.Add(drugNameLabel);
                    panel.Controls.Add(dongGoiLabel);
                    panel.Controls.Add(loaiLabel);
                    panel.Controls.Add(soLuongLabel);
                    panel.Controls.Add(giaBanLabel);
                    panel.Controls.Add(label4);
                    panel.Controls.Add(label3);
                    panel.Controls.Add(label2);
                    panel.Controls.Add(label1);
                    panel.Controls.Add(pictureBox);

                    panel.Click += (s, e) => OpenEditDrugForm(drug.id);

                    flowLayoutPanel1.Controls.Add(panel);

                    y += panel.Size.Height + panel.Margin.Bottom;
                }
            }
        }
        private void OpenEditDrugForm(long drugId)
        {
            if (Utility.IsOpeningForm("fEditDrug"))
                return;
            fEditDrug f = new fEditDrug(drugId);
            f.Show();
        }
        private void cbDrugCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            long selectedCategoryId = Convert.ToInt64(cbDrugCategory.SelectedValue);
            DisplayDrugData(selectedCategoryId);
        }
        private void fDrugManagement_Activated(object sender, EventArgs e)
        {
            cbDrugCategory_SelectedIndexChanged(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewDrug"))
                return;
            fNewDrug f = new fNewDrug(loggedInEmployee);
            f.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            long selectedCategoryId = Convert.ToInt64(cbDrugCategory.SelectedValue);
            string drugName = txtName.Text.Trim();
            DisplayDrugData(selectedCategoryId, drugName);
        }
    }
}
