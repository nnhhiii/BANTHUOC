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
            tabControl1 = new TabControl();
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
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1368, 163);
            tabControl1.TabIndex = 1;
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
            tabPage1.Padding = new Padding(3);
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
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(button12);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1360, 130);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Image = Properties.Resources.dang_xuat;
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(340, 6);
            button9.Name = "button9";
            button9.Size = new Size(110, 109);
            button9.TabIndex = 8;
            button9.Text = "Đăng xuất";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.BackgroundImageLayout = ImageLayout.None;
            button10.Image = Properties.Resources.tai_khoan;
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(228, 6);
            button10.Name = "button10";
            button10.Size = new Size(106, 109);
            button10.TabIndex = 7;
            button10.Text = "Tài khoản";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.BackgroundImageLayout = ImageLayout.None;
            button11.Image = Properties.Resources.thuoc;
            button11.ImageAlign = ContentAlignment.TopCenter;
            button11.Location = new Point(116, 6);
            button11.Name = "button11";
            button11.Size = new Size(106, 109);
            button11.TabIndex = 6;
            button11.Text = "Thông tin thuốc";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.BackgroundImageLayout = ImageLayout.None;
            button12.Image = Properties.Resources.ban_thuoc;
            button12.ImageAlign = ContentAlignment.TopCenter;
            button12.Location = new Point(6, 6);
            button12.Name = "button12";
            button12.Size = new Size(104, 109);
            button12.TabIndex = 5;
            button12.Text = "Bán thuốc";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 597);
            Controls.Add(tabControl1);
            IsMdiContainer = true;
            Name = "fMain";
            Text = "Quản lý hiệu thuốc";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
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
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}
