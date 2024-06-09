namespace BANTHUOC
{
    partial class fEditStaff
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
            components = new System.ComponentModel.Container();
            btnSave = new Button();
            label8 = new Label();
            email = new TextBox();
            sdt = new TextBox();
            diachi = new TextBox();
            hoten = new TextBox();
            thoat = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            gioitinh = new ComboBox();
            ngaysinh = new DateTimePicker();
            chucvu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Image = Properties.Resources.savebtn;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(912, 754);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 64);
            btnSave.TabIndex = 92;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(659, 411);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 90;
            label8.Text = "Giới tính";
            // 
            // email
            // 
            email.Location = new Point(1002, 555);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(196, 31);
            email.TabIndex = 88;
            // 
            // sdt
            // 
            sdt.Location = new Point(1002, 452);
            sdt.Margin = new Padding(2);
            sdt.Name = "sdt";
            sdt.Size = new Size(196, 31);
            sdt.TabIndex = 87;
            // 
            // diachi
            // 
            diachi.Location = new Point(659, 656);
            diachi.Margin = new Padding(2);
            diachi.Name = "diachi";
            diachi.Size = new Size(539, 31);
            diachi.TabIndex = 86;
            // 
            // hoten
            // 
            hoten.Location = new Point(659, 360);
            hoten.Margin = new Padding(2);
            hoten.Name = "hoten";
            hoten.Size = new Size(213, 31);
            hoten.TabIndex = 83;
            // 
            // thoat
            // 
            thoat.BackgroundImage = Properties.Resources.thoat;
            thoat.BackgroundImageLayout = ImageLayout.Zoom;
            thoat.Location = new Point(1092, 754);
            thoat.Margin = new Padding(2);
            thoat.Name = "thoat";
            thoat.Size = new Size(124, 64);
            thoat.TabIndex = 82;
            thoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1002, 321);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 81;
            label7.Text = "Chức vụ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(659, 610);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 80;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1002, 411);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 79;
            label5.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1002, 509);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 77;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(658, 509);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 76;
            label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 321);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 75;
            label1.Text = "Họ và tên";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.account;
            pictureBox1.ErrorImage = Properties.Resources.no_image;
            pictureBox1.Location = new Point(196, 321);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 368);
            pictureBox1.TabIndex = 74;
            pictureBox1.TabStop = false;
            // 
            // gioitinh
            // 
            gioitinh.FormattingEnabled = true;
            gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioitinh.Location = new Point(663, 456);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(209, 33);
            gioitinh.TabIndex = 93;
            // 
            // ngaysinh
            // 
            ngaysinh.Format = DateTimePickerFormat.Short;
            ngaysinh.Location = new Point(663, 553);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(213, 31);
            ngaysinh.TabIndex = 94;
            // 
            // chucvu
            // 
            chucvu.FormattingEnabled = true;
            chucvu.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            chucvu.Location = new Point(1002, 358);
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(196, 33);
            chucvu.TabIndex = 95;
            // 
            // fEditStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1546, 828);
            Controls.Add(chucvu);
            Controls.Add(ngaysinh);
            Controls.Add(gioitinh);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(email);
            Controls.Add(sdt);
            Controls.Add(diachi);
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
            Name = "fEditStaff";
            Text = "Sửa đổi thông tin nhân viên";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label8;
        private TextBox email;
        private TextBox sdt;
        private TextBox diachi;
        private TextBox hoten;
        private Button thoat;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private ComboBox gioitinh;
        private DateTimePicker ngaysinh;
        private ComboBox chucvu;
    }
}