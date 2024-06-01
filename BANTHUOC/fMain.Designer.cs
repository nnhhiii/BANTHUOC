﻿using static System.Net.Mime.MediaTypeNames;
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
            button9 = new Button();
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
            btBanthuoc.Location = new Point(1, 4);
            btBanthuoc.Margin = new Padding(4);
            btBanthuoc.Name = "btBanthuoc";
            btBanthuoc.SelectedIndex = 0;
            btBanthuoc.Size = new Size(1710, 204);
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
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4);
            tabPage1.Size = new Size(1702, 166);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_thongke_kho
            // 
            btn_thongke_kho.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_kho.Image = Properties.Resources.thong_ke_ton;
            btn_thongke_kho.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_kho.Location = new Point(958, 0);
            btn_thongke_kho.Margin = new Padding(4);
            btn_thongke_kho.Name = "btn_thongke_kho";
            btn_thongke_kho.Size = new Size(125, 136);
            btn_thongke_kho.TabIndex = 8;
            btn_thongke_kho.Text = "Thống kê tồn kho";
            btn_thongke_kho.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_kho.UseVisualStyleBackColor = true;
            // 
            // btn_thongke_ban
            // 
            btn_thongke_ban.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_ban.Image = Properties.Resources.thong_ke_ban_hang;
            btn_thongke_ban.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_ban.Location = new Point(821, 0);
            btn_thongke_ban.Margin = new Padding(4);
            btn_thongke_ban.Name = "btn_thongke_ban";
            btn_thongke_ban.Size = new Size(129, 136);
            btn_thongke_ban.TabIndex = 7;
            btn_thongke_ban.Text = "Thống kê bán hàng";
            btn_thongke_ban.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_ban.UseVisualStyleBackColor = true;
            // 
            // btn_thongke_nhap
            // 
            btn_thongke_nhap.BackgroundImageLayout = ImageLayout.None;
            btn_thongke_nhap.Image = Properties.Resources.thong_ke_nhap;
            btn_thongke_nhap.ImageAlign = ContentAlignment.TopCenter;
            btn_thongke_nhap.Location = new Point(682, 0);
            btn_thongke_nhap.Margin = new Padding(4);
            btn_thongke_nhap.Name = "btn_thongke_nhap";
            btn_thongke_nhap.Size = new Size(131, 136);
            btn_thongke_nhap.TabIndex = 6;
            btn_thongke_nhap.Text = "Thống kê nhập hàng";
            btn_thongke_nhap.TextAlign = ContentAlignment.BottomCenter;
            btn_thongke_nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_thongke_nhap.UseVisualStyleBackColor = true;
            // 
            // btn_nhap
            // 
            btn_nhap.BackgroundImageLayout = ImageLayout.None;
            btn_nhap.Image = Properties.Resources.nhap_thuoc;
            btn_nhap.ImageAlign = ContentAlignment.TopCenter;
            btn_nhap.Location = new Point(546, 0);
            btn_nhap.Margin = new Padding(4);
            btn_nhap.Name = "btn_nhap";
            btn_nhap.Size = new Size(129, 136);
            btn_nhap.TabIndex = 5;
            btn_nhap.Text = "Nhập thuốc";
            btn_nhap.TextAlign = ContentAlignment.BottomCenter;
            btn_nhap.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_nhap.UseVisualStyleBackColor = true;
            // 
            // btn_thuoc
            // 
            btn_thuoc.BackgroundImageLayout = ImageLayout.None;
            btn_thuoc.Image = Properties.Resources.thuoc;
            btn_thuoc.ImageAlign = ContentAlignment.TopCenter;
            btn_thuoc.Location = new Point(415, 0);
            btn_thuoc.Margin = new Padding(4);
            btn_thuoc.Name = "btn_thuoc";
            btn_thuoc.Size = new Size(124, 136);
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
            btn_loai.Location = new Point(275, 0);
            btn_loai.Margin = new Padding(4);
            btn_loai.Name = "btn_loai";
            btn_loai.Size = new Size(132, 136);
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
            btn_ncc.Location = new Point(135, 0);
            btn_ncc.Margin = new Padding(4);
            btn_ncc.Name = "btn_ncc";
            btn_ncc.Size = new Size(132, 136);
            btn_ncc.TabIndex = 2;
            btn_ncc.Text = "Nhà cung cấp";
            btn_ncc.TextAlign = ContentAlignment.BottomCenter;
            btn_ncc.UseVisualStyleBackColor = true;
            // 
            // btn_nv
            // 
            btn_nv.BackgroundImageLayout = ImageLayout.None;
            btn_nv.Image = Properties.Resources.nhan_vien;
            btn_nv.ImageAlign = ContentAlignment.TopCenter;
            btn_nv.Location = new Point(8, 0);
            btn_nv.Margin = new Padding(4);
            btn_nv.Name = "btn_nv";
            btn_nv.Size = new Size(120, 136);
            btn_nv.TabIndex = 1;
            btn_nv.Text = "Nhân viên";
            btn_nv.TextAlign = ContentAlignment.BottomCenter;
            btn_nv.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(taikhoan);
            tabPage2.Controls.Add(thongtinThuoc);
            tabPage2.Controls.Add(banthuoc);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4);
            tabPage2.Size = new Size(1702, 166);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bán hàng";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Image = Properties.Resources.dang_xuat;
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(425, 8);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(138, 136);
            button9.TabIndex = 8;
            button9.Text = "Đăng xuất";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = true;
            // 
            // taikhoan
            // 
            taikhoan.BackgroundImageLayout = ImageLayout.None;
            taikhoan.Image = Properties.Resources.tai_khoan;
            taikhoan.ImageAlign = ContentAlignment.TopCenter;
            taikhoan.Location = new Point(285, 8);
            taikhoan.Margin = new Padding(4);
            taikhoan.Name = "taikhoan";
            taikhoan.Size = new Size(132, 136);
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
            thongtinThuoc.Location = new Point(145, 8);
            thongtinThuoc.Margin = new Padding(4);
            thongtinThuoc.Name = "thongtinThuoc";
            thongtinThuoc.Size = new Size(132, 136);
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
            banthuoc.Location = new Point(8, 8);
            banthuoc.Margin = new Padding(4);
            banthuoc.Name = "banthuoc";
            banthuoc.Size = new Size(130, 136);
            banthuoc.TabIndex = 5;
            banthuoc.Text = "Bán thuốc";
            banthuoc.TextAlign = ContentAlignment.BottomCenter;
            banthuoc.UseVisualStyleBackColor = true;
            banthuoc.Click += banthuoc_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1726, 746);
            Controls.Add(btBanthuoc);
            IsMdiContainer = true;
            Margin = new Padding(4);
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
        private Button button9;
        private Button taikhoan;
        private Button thongtinThuoc;
        private Button banthuoc;
    }
}
