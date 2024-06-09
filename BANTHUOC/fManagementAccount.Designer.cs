namespace BANTHUOC
{
    partial class fManagementAccount
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
            gioitinh = new TextBox();
            label8 = new Label();
            email = new TextBox();
            sdt = new TextBox();
            diachi = new TextBox();
            ngaysinh = new TextBox();
            chucvu = new TextBox();
            hoten = new TextBox();
            thoat = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gioitinh
            // 
            gioitinh.Location = new Point(605, 422);
            gioitinh.Margin = new Padding(2);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(213, 31);
            gioitinh.TabIndex = 54;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(605, 381);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 53;
            label8.Text = "Giới tính";
            // 
            // email
            // 
            email.Location = new Point(949, 525);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(196, 31);
            email.TabIndex = 50;
            // 
            // sdt
            // 
            sdt.Location = new Point(949, 422);
            sdt.Margin = new Padding(2);
            sdt.Name = "sdt";
            sdt.Size = new Size(196, 31);
            sdt.TabIndex = 49;
            // 
            // diachi
            // 
            diachi.Location = new Point(605, 626);
            diachi.Margin = new Padding(2);
            diachi.Name = "diachi";
            diachi.Size = new Size(540, 31);
            diachi.TabIndex = 48;
            // 
            // ngaysinh
            // 
            ngaysinh.AcceptsReturn = true;
            ngaysinh.Location = new Point(605, 525);
            ngaysinh.Margin = new Padding(2);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(213, 31);
            ngaysinh.TabIndex = 47;
            // 
            // chucvu
            // 
            chucvu.Location = new Point(949, 330);
            chucvu.Margin = new Padding(2);
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(196, 31);
            chucvu.TabIndex = 46;
            // 
            // hoten
            // 
            hoten.Location = new Point(605, 330);
            hoten.Margin = new Padding(2);
            hoten.Name = "hoten";
            hoten.Size = new Size(213, 31);
            hoten.TabIndex = 45;
            // 
            // thoat
            // 
            thoat.BackgroundImage = Properties.Resources.thoat;
            thoat.BackgroundImageLayout = ImageLayout.Zoom;
            thoat.Location = new Point(769, 688);
            thoat.Margin = new Padding(2);
            thoat.Name = "thoat";
            thoat.Size = new Size(235, 51);
            thoat.TabIndex = 44;
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(949, 291);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 43;
            label7.Text = "Chức vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 580);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 42;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(949, 381);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 41;
            label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(949, 479);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 39;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 479);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 38;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 291);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 37;
            label1.Text = "Họ và tên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.account;
            pictureBox1.Location = new Point(142, 291);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 368);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // fManagementAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 712);
            Controls.Add(gioitinh);
            Controls.Add(label8);
            Controls.Add(email);
            Controls.Add(sdt);
            Controls.Add(diachi);
            Controls.Add(ngaysinh);
            Controls.Add(chucvu);
            Controls.Add(hoten);
            Controls.Add(thoat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "fManagementAccount";
            Text = "Thông tin tài khoản";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox gioitinh;
        private Label label8;
        private TextBox email;
        private TextBox sdt;
        private TextBox diachi;
        private TextBox ngaysinh;
        private TextBox chucvu;
        private TextBox hoten;
        private Button thoat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}