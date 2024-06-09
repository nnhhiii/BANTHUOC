using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BANTHUOC
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btBanthuoc = new TabControl();
            tabPage1 = new TabPage();
            btn_thongke_kho = new Button();
            btn_thongke_ban = new Button();
            btn_thongke_nhap = new Button();
            btn_nhap = new Button();
            btn_thuoc = new Button();
            btn_loai = new Button();
            btn_ncc = new Button();
            btn_nv = new Button();
            tabPage2 = new TabPage();
            btnLogout = new Button();
            taikhoan = new Button();
            thongtinThuoc = new Button();
            banthuoc = new Button();
            btBanthuoc.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btBanthuoc
            // 
            btBanthuoc.Controls.Add(tabPage1);
            btBanthuoc.Controls.Add(tabPage2);
            btBanthuoc.Location = new Point(1, 3);
            btBanthuoc.Name = "btBanthuoc";
            btBanthuoc.SelectedIndex = 0;
            btBanthuoc.Size = new Size(1368, 163);
            btBanthuoc.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_thongke_kho);
            tabPage1.Controls.Add(btn_thongke_ban);
            tabPage1.Controls.Add(btn_thongke_nhap);
            tabPage1.Controls.Add(btn_nhap);
            tabPage1.Controls.Add(btn_thuoc);
            tabPage1.Controls.Add(btn_loai);
            tabPage1.Controls.Add(btn_ncc);
            tabPage1.Controls.Add(btn_nv);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 3, 3, 3);
            tabPage1.Size = new Size(1360, 130);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_thongke_kho
            // 
            btn_thongke_kho.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_kho.Image = Properties.Resources.thong_ke_ton;
            btn_thongke_kho.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_kho.Location = new Point(766, 0);
            btn_thongke_kho.Name = "btn_thongke_kho";
            btn_thongke_kho.Size = new Size(100, 109);
            btn_thongke_kho.TabIndex = 8;
            btn_thongke_kho.Text = "Thống kê tồn kho";
            btn_thongke_kho.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_kho.UseVisualStyleBackColor = true;
            btn_thongke_kho.Click += btn_thongke_kho_Click;
            // 
            // btn_thongke_ban
            // 
            btn_thongke_ban.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_ban.Image = Properties.Resources.thong_ke_ban_hang;
            btn_thongke_ban.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_ban.Location = new Point(657, 0);
            btn_thongke_ban.Name = "btn_thongke_ban";
            btn_thongke_ban.Size = new Size(103, 109);
            btn_thongke_ban.TabIndex = 7;
            btn_thongke_ban.Text = "Thống kê bán hàng";
            btn_thongke_ban.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_ban.UseVisualStyleBackColor = true;
            btn_thongke_ban.Click += btn_thongke_ban_Click;
            // 
            // btn_thongke_nhap
            // 
            btn_thongke_nhap.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_nhap.Image = Properties.Resources.thong_ke_nhap;
            btn_thongke_nhap.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_nhap.Location = new Point(546, 0);
            btn_thongke_nhap.Name = "btn_thongke_nhap";
            btn_thongke_nhap.Size = new Size(105, 109);
            btn_thongke_nhap.TabIndex = 6;
            btn_thongke_nhap.Text = "Thống kê nhập hàng";
            btn_thongke_nhap.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_thongke_nhap.UseVisualStyleBackColor = true;
            btn_thongke_nhap.Click += btn_thongke_nhap_Click;
            // 
            // btn_nhap
            // 
            btn_nhap.BackgroundImageLayout = ImageLayout.None;
            btn_nhap.Image = Properties.Resources.nhap_thuoc;
            btn_nhap.ImageAlign = ContentAlignment.TopCenter;
            btn_nhap.Location = new Point(437, 0);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(103, 109);
            btn_nhap.TabIndex = 5;
            btn_nhap.Text = "Nhập thuốc";
            btn_nhap.TextAlign = ContentAlignment.BottomCenter;
            btn_nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_nhap.UseVisualStyleBackColor = true;
            btn_nhap.Click += btn_nhap_Click;
            // 
            // btn_thuoc
            // 
            btn_thuoc.BackgroundImageLayout = ImageLayout.None;
            btn_thuoc.Image = Properties.Resources.thuoc;
            btn_thuoc.ImageAlign = ContentAlignment.TopCenter;
            btn_thuoc.Location = new Point(332, 0);
            btn_thuoc.Name = "btn_thuoc";
            btn_thuoc.Size = new Size(99, 109);
            btn_thuoc.TabIndex = 4;
            btn_thuoc.Text = "Thuốc";
            btn_thuoc.TextAlign = ContentAlignment.BottomCenter;
            btn_thuoc.UseVisualStyleBackColor = true;
            btn_thuoc.Click += btn_thuoc_Click;
            // 
            // btn_loai
            // 
            btn_loai.BackgroundImageLayout = ImageLayout.None;
            btn_loai.Image = Properties.Resources.loai_thuoc;
            btn_loai.ImageAlign = ContentAlignment.TopCenter;
            btn_loai.Location = new Point(220, 0);
            btn_loai.Name = "btn_loai";
            btn_loai.Size = new Size(106, 109);
            btn_loai.TabIndex = 3;
            btn_loai.Text = "Loại thuốc";
            btn_loai.TextAlign = ContentAlignment.BottomCenter;
            btn_loai.UseVisualStyleBackColor = true;
            btn_loai.Click += btn_loai_Click;
            // 
            // btn_ncc
            // 
            btn_ncc.BackgroundImageLayout = ImageLayout.None;
            btn_ncc.Image = Properties.Resources.nha_cung_cap;
            btn_ncc.ImageAlign = ContentAlignment.TopCenter;
            btn_ncc.Location = new Point(108, 0);
            btn_ncc.Name = "btn_ncc";
            btn_ncc.Size = new Size(106, 109);
            btn_ncc.TabIndex = 2;
            btn_ncc.Text = "Nhà cung cấp";
            btn_ncc.TextAlign = ContentAlignment.BottomCenter;
            btn_ncc.UseVisualStyleBackColor = true;
            btn_ncc.Click += btn_ncc_Click;
            // 
            // btn_nv
            // 
            btn_nv.BackgroundImageLayout = ImageLayout.None;
            btn_nv.Image = Properties.Resources.nhan_vien;
            btn_nv.ImageAlign = ContentAlignment.TopCenter;
            btn_nv.Location = new Point(6, 0);
            btn_nv.Name = "btn_nv";
            btn_nv.Size = new Size(96, 109);
            btn_nv.TabIndex = 1;
            btn_nv.Text = "Nhân viên";
            btn_nv.TextAlign = ContentAlignment.BottomCenter;
            btn_nv.UseVisualStyleBackColor = true;
            btn_nv.Click += btn_nv_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(taikhoan);
            tabPage2.Controls.Add(thongtinThuoc);
            tabPage2.Controls.Add(banthuoc);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 3, 3, 3);
            tabPage2.Size = new Size(1360, 130);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.Image = Properties.Resources.dang_xuat;
            btnLogout.ImageAlign = ContentAlignment.TopCenter;
            btnLogout.Location = new Point(340, 6);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(110, 109);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TextAlign = ContentAlignment.BottomCenter;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // taikhoan
            // 
            taikhoan.BackgroundImageLayout = ImageLayout.None;
            taikhoan.Image = Properties.Resources.tai_khoan;
            taikhoan.ImageAlign = ContentAlignment.TopCenter;
            taikhoan.Location = new Point(228, 6);
            taikhoan.Name = "taikhoan";
            taikhoan.Size = new Size(106, 109);
            taikhoan.TabIndex = 7;
            taikhoan.Text = "Tài khoản";
            taikhoan.TextAlign = ContentAlignment.BottomCenter;
            taikhoan.UseVisualStyleBackColor = true;
            taikhoan.Click += taikhoan_Click_1;
            // 
            // thongtinThuoc
            // 
            thongtinThuoc.BackgroundImageLayout = ImageLayout.None;
            thongtinThuoc.Image = Properties.Resources.thuoc;
            thongtinThuoc.ImageAlign = ContentAlignment.TopCenter;
            thongtinThuoc.Location = new Point(116, 6);
            thongtinThuoc.Name = "thongtinThuoc";
            thongtinThuoc.Size = new Size(106, 109);
            thongtinThuoc.TabIndex = 6;
            thongtinThuoc.Text = "Thông tin thuốc";
            thongtinThuoc.TextAlign = ContentAlignment.BottomCenter;
            thongtinThuoc.UseVisualStyleBackColor = true;
            thongtinThuoc.Click += thongtinThuoc_Click;
            // 
            // banthuoc
            // 
            banthuoc.BackgroundImageLayout = ImageLayout.None;
            banthuoc.Image = Properties.Resources.ban_thuoc;
            banthuoc.ImageAlign = ContentAlignment.TopCenter;
            banthuoc.Location = new Point(6, 6);
            banthuoc.Name = "banthuoc";
            banthuoc.Size = new Size(104, 109);
            banthuoc.TabIndex = 5;
            banthuoc.Text = "Bán thuốc";
            banthuoc.TextAlign = ContentAlignment.BottomCenter;
            banthuoc.UseVisualStyleBackColor = true;
            banthuoc.Click += banthuoc_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 597);
            Controls.Add(btBanthuoc);
            IsMdiContainer = true;
            Name = "fMain";
            Text = "Quản lý hiệu thuốc";
            WindowState = FormWindowState.Maximized;
            btBanthuoc.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl btBanthuoc;
        private TabPage tabPage1;
        private Button btn_thongke_kho;
        private Button btn_thongke_ban;
        private Button btn_thongke_nhap;
        private Button btn_nhap;
        private Button btn_thuoc;
        private Button btn_loai;
        private Button btn_ncc;
        private Button btn_nv;
        private TabPage tabPage2;
        private Button btnLogout;
        private Button taikhoan;
        private Button thongtinThuoc;
        private Button banthuoc;
    }
}
