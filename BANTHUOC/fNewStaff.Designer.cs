namespace BANTHUOC
{
    partial class fNewStaff
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
            toolTip1 = new ToolTip(components);
            ngaysinh = new DateTimePicker();
            chucvu = new ComboBox();
            password = new TextBox();
            label9 = new Label();
            gioiTinh = new ComboBox();
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
            btnSave.Location = new Point(736, 696);
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
            // email
            // 
            email.Location = new Point(802, 444);
            email.Margin = new Padding(2);
            email.Name = "email";
            email.Size = new Size(158, 27);
            email.TabIndex = 88;
            // 
            // sdt
            // 
            sdt.Location = new Point(802, 362);
            sdt.Margin = new Padding(2);
            sdt.Name = "sdt";
            sdt.Size = new Size(158, 27);
            sdt.TabIndex = 87;
            // 
            // diachi
            // 
            diachi.Location = new Point(526, 616);
            diachi.Margin = new Padding(2);
            diachi.Name = "diachi";
            diachi.Size = new Size(432, 27);
            diachi.TabIndex = 86;
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
            thoat.Location = new Point(880, 696);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 580);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 80;
            label6.Text = "Địa chỉ";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(802, 407);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 77;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 407);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 76;
            label2.Text = "Ngày sinh";
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
            // ngaysinh
            // 
            ngaysinh.Format = DateTimePickerFormat.Short;
            ngaysinh.Location = new Point(530, 442);
            ngaysinh.Margin = new Padding(2);
            ngaysinh.Name = "ngaysinh";
            ngaysinh.Size = new Size(171, 27);
            ngaysinh.TabIndex = 94;
            // 
            // chucvu
            // 
            chucvu.FormattingEnabled = true;
            chucvu.Location = new Point(802, 286);
            chucvu.Margin = new Padding(2);
            chucvu.Name = "chucvu";
            chucvu.Size = new Size(158, 28);
            chucvu.TabIndex = 95;
            // 
            // password
            // 
            password.Location = new Point(802, 524);
            password.Margin = new Padding(2);
            password.Name = "password";
            password.Size = new Size(158, 27);
            password.TabIndex = 97;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(802, 490);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 98;
            label9.Text = "Password";
            // 
            // gioiTinh
            // 
            gioiTinh.FormattingEnabled = true;
            gioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            gioiTinh.Location = new Point(527, 362);
            gioiTinh.Margin = new Padding(2);
            gioiTinh.Name = "gioiTinh";
            gioiTinh.Size = new Size(171, 28);
            gioiTinh.TabIndex = 99;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(78, 548);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 103;
            label14.Text = "Tập tin hình";
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(400, 543);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(92, 29);
            btBrowse.TabIndex = 102;
            btBrowse.Text = "Chọn ảnh";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(191, 545);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(203, 27);
            txtImageFile.TabIndex = 101;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.no_image;
            pictureBox1.Image = Properties.Resources.no_image;
            pictureBox1.Location = new Point(88, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(375, 284);
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fNewStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 810);
            Controls.Add(label14);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(pictureBox1);
            Controls.Add(gioiTinh);
            Controls.Add(label9);
            Controls.Add(password);
            Controls.Add(chucvu);
            Controls.Add(ngaysinh);
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
            Margin = new Padding(2);
            Name = "fNewStaff";
            Text = "Thêm Nhân Viên mới";
            Load += fNewStaff_Load;
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
        private ToolTip toolTip1;
        private DateTimePicker ngaysinh;
        private ComboBox chucvu;
        private TextBox password;
        private Label label9;
        private ComboBox gioiTinh;
        private Label label14;
        private Button btBrowse;
        private TextBox txtImageFile;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}