namespace BANTHUOC
{
    partial class fMainForEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            btnLogout = new Button();
            taikhoan = new Button();
            thongtinThuoc = new Button();
            banthuoc = new Button();
            btBanthuoc = new TabControl();
            tabPage2.SuspendLayout();
            btBanthuoc.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLogout);
            tabPage2.Controls.Add(taikhoan);
            tabPage2.Controls.Add(thongtinThuoc);
            tabPage2.Controls.Add(banthuoc);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
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
            taikhoan.Click += taikhoan_Click;
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
            // btBanthuoc
            // 
            btBanthuoc.Controls.Add(tabPage2);
            btBanthuoc.Location = new Point(1, 1);
            btBanthuoc.Name = "btBanthuoc";
            btBanthuoc.SelectedIndex = 0;
            btBanthuoc.Size = new Size(1368, 163);
            btBanthuoc.TabIndex = 2;
            // 
            // fMainForEmp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 450);
            Controls.Add(btBanthuoc);
            Name = "fMainForEmp";
            Text = "fMainForEmp";
            tabPage2.ResumeLayout(false);
            btBanthuoc.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Button btnLogout;
        private Button taikhoan;
        private Button thongtinThuoc;
        private Button banthuoc;
        private TabControl btBanthuoc;
    }
}