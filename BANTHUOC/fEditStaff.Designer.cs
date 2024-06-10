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
            sdt = new TextBox();
            hoten = new TextBox();
            thoat = new Button();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            gioitinh = new ComboBox();
            chucvu = new ComboBox();
            label9 = new Label();
            password = new TextBox();
            ngaysinh = new DateTimePicker();
            email = new TextBox();
            diachi = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            btBrowse = new Button();
            txtImageFile = new TextBox();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Image = Properties.Resources.savebtn;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(723, 703);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 51);
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
            label8.Location = new Point(527, 329);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 90;
            label8.Text = "Giới tính";
            // 
            // sdt
            // 
            sdt.Location = new Point(802, 362);
            sdt.Margin = new Padding(2);
            sdt.Name = "sdt";
            sdt.Size = new Size(158, 27);
            sdt.TabIndex = 87;
            // 
            // hoten
            // 
            hoten.Location = new Point(527, 288);
            hoten.Margin = new Padding(2);
            hoten.Name = "hoten";
            hoten.Size = new Size(171, 27);
            hoten.TabIndex = 83;
            // 
            // thoat
            // 
            thoat.BackgroundImage = Properties.Resources.thoat;
            thoat.BackgroundImageLayout = ImageLayout.Zoom;
            thoat.Location = new Point(888, 703);
            thoat.Margin = new Padding(2);
            thoat.Name = "thoat";
            thoat.Size = new Size(99, 51);
            thoat.TabIndex = 82;
            thoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(802, 257);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 81;
            label7.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(802, 329);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 79;
            label5.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 257);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 75;
            label1.Text = "Họ và tên";
            // 
            // gioitinh
            // 
            gioitinh.FormattingEnabled = true;
            gioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioitinh.Location = new Point(530, 365);
            gioitinh.Margin = new Padding(2);
            gioitinh.Name = "gioitinh";
            gioitinh.Size = new Size(168, 28);
            gioitinh.TabIndex = 93;
            // 
            // chucvu
            // 
            chucvu.FormattingEnabled = true;
            chucvu.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            chucvu.Location = new Point(802, 286);
            chucvu.Margin = new Padding(2);
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(158, 28);
            chucvu.TabIndex = 95;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(802, 493);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 106;
            label9.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(802, 527);
            password.Margin = new Padding(2);
            password.Name = "password";
            password.Size = new Size(158, 27);
            password.TabIndex = 105;
            // 
            // ngaysinh
            // 
            ngaysinh.Format = DateTimePickerFormat.Short;
            ngaysinh.Location = new Point(530, 445);
            ngaysinh.Margin = new Padding(2);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(171, 27);
            ngaysinh.TabIndex = 104;
            // 
            // email
            // 
            email.Location = new Point(802, 447);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(158, 27);
            email.TabIndex = 103;
            // 
            // diachi
            // 
            diachi.Location = new Point(526, 619);
            diachi.Margin = new Padding(2);
            diachi.Name = "diachi";
            diachi.Size = new Size(432, 27);
            diachi.TabIndex = 102;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 583);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 101;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 410);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 100;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 410);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 99;
            label2.Text = "Ngày sinh";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(85, 562);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 110;
            label14.Text = "Tập tin hình";
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(407, 557);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(92, 29);
            btBrowse.TabIndex = 109;
            btBrowse.Text = "Chọn ảnh";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(198, 559);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(203, 27);
            txtImageFile.TabIndex = 108;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = Properties.Resources.no_image;
            pictureBox1.Image = Properties.Resources.account;
            pictureBox1.Location = new Point(95, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 284);
            pictureBox1.TabIndex = 107;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fEditStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 939);
            Controls.Add(label14);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(password);
            Controls.Add(ngaysinh);
            Controls.Add(email);
            Controls.Add(diachi);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chucvu);
            Controls.Add(gioitinh);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(sdt);
            Controls.Add(hoten);
            Controls.Add(thoat);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "fEditStaff";
            Text = "Sửa đổi thông tin nhân viên";
            Load += fEditStaff_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label8;
        private TextBox sdt;
        private TextBox hoten;
        private Button thoat;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label1;
        private ToolTip toolTip1;
        private ComboBox gioitinh;
        private ComboBox chucvu;
        private Label label9;
        private TextBox password;
        private DateTimePicker ngaysinh;
        private TextBox email;
        private TextBox diachi;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label14;
        private Button btBrowse;
        private TextBox txtImageFile;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}