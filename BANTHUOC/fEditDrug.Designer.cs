namespace BANTHUOC
{
    partial class fEditDrug
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            tacDungPhu = new RichTextBox();
            tenThuoc = new RichTextBox();
            dongGoi = new RichTextBox();
            hamLuong = new RichTextBox();
            huongDanSuDung = new RichTextBox();
            chongChiDinh = new RichTextBox();
            moTa = new RichTextBox();
            nhaCungCap = new ComboBox();
            donViBan = new ComboBox();
            hanSuDung = new DateTimePicker();
            giaBan = new NumericUpDown();
            soLuongTheoDonViBan = new NumericUpDown();
            label14 = new Label();
            btBrowse = new Button();
            txtImageFile = new TextBox();
            loaiThuoc = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)giaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.no_image;
            pictureBox1.Location = new Point(37, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 201);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 50);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 100);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Loại thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 157);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhà cung cấp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 322);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 381);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 5;
            label5.Text = "Đơn vị bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 507);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 6;
            label6.Text = "Mô tả";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 452);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 7;
            label7.Text = "Chống chỉ định";
            // 
            // label8
            // 
            label8.Location = new Point(27, 295);
            label8.Name = "label8";
            label8.Size = new Size(108, 47);
            label8.TabIndex = 8;
            label8.Text = "Hướng dẫn sử dụng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 381);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 9;
            label9.Text = "Tác dụng phụ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(475, 507);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 10;
            label10.Text = "Hạn sử dụng";
            // 
            // label11
            // 
            label11.Location = new Point(475, 437);
            label11.Name = "label11";
            label11.Size = new Size(134, 54);
            label11.TabIndex = 11;
            label11.Text = "Số lượng theo đơn vị bán";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(475, 263);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 12;
            label12.Text = "Quy cách đóng gói";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(475, 208);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 13;
            label13.Text = "Hàm lượng";
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(750, 590);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 55);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(910, 590);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 55);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tacDungPhu
            // 
            tacDungPhu.Location = new Point(161, 381);
            tacDungPhu.Name = "tacDungPhu";
            tacDungPhu.Size = new Size(262, 48);
            tacDungPhu.TabIndex = 17;
            tacDungPhu.Text = "";
            // 
            // tenThuoc
            // 
            tenThuoc.Location = new Point(661, 40);
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Size = new Size(322, 30);
            tenThuoc.TabIndex = 18;
            tenThuoc.Text = "";
            // 
            // dongGoi
            // 
            dongGoi.Location = new Point(661, 260);
            dongGoi.Name = "dongGoi";
            dongGoi.Size = new Size(322, 30);
            dongGoi.TabIndex = 19;
            dongGoi.Text = "";
            // 
            // hamLuong
            // 
            hamLuong.Location = new Point(661, 208);
            hamLuong.Name = "hamLuong";
            hamLuong.Size = new Size(322, 30);
            hamLuong.TabIndex = 20;
            hamLuong.Text = "";
            // 
            // huongDanSuDung
            // 
            huongDanSuDung.Location = new Point(161, 292);
            huongDanSuDung.Name = "huongDanSuDung";
            huongDanSuDung.Size = new Size(262, 64);
            huongDanSuDung.TabIndex = 22;
            huongDanSuDung.Text = "";
            // 
            // chongChiDinh
            // 
            chongChiDinh.Location = new Point(161, 449);
            chongChiDinh.Name = "chongChiDinh";
            chongChiDinh.Size = new Size(262, 42);
            chongChiDinh.TabIndex = 23;
            chongChiDinh.Text = "";
            // 
            // moTa
            // 
            moTa.Location = new Point(161, 507);
            moTa.Name = "moTa";
            moTa.Size = new Size(262, 64);
            moTa.TabIndex = 24;
            moTa.Text = "";
            // 
            // nhaCungCap
            // 
            nhaCungCap.FormattingEnabled = true;
            nhaCungCap.Location = new Point(661, 157);
            nhaCungCap.Name = "nhaCungCap";
            nhaCungCap.Size = new Size(322, 28);
            nhaCungCap.TabIndex = 25;
            // 
            // donViBan
            // 
            donViBan.FormattingEnabled = true;
            donViBan.Location = new Point(661, 381);
            donViBan.Name = "donViBan";
            donViBan.Size = new Size(322, 28);
            donViBan.TabIndex = 26;
            // 
            // hanSuDung
            // 
            hanSuDung.Format = DateTimePickerFormat.Short;
            hanSuDung.Location = new Point(661, 505);
            hanSuDung.Name = "hanSuDung";
            hanSuDung.Size = new Size(322, 27);
            hanSuDung.TabIndex = 27;
            // 
            // giaBan
            // 
            giaBan.Location = new Point(661, 322);
            giaBan.Name = "giaBan";
            giaBan.Size = new Size(322, 27);
            giaBan.TabIndex = 28;
            // 
            // soLuongTheoDonViBan
            // 
            soLuongTheoDonViBan.Location = new Point(661, 445);
            soLuongTheoDonViBan.Name = "soLuongTheoDonViBan";
            soLuongTheoDonViBan.Size = new Size(322, 27);
            soLuongTheoDonViBan.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 242);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 38;
            label14.Text = "Tập tin hình";
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(301, 237);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(122, 29);
            btBrowse.TabIndex = 37;
            btBrowse.Text = "Chọn ảnh";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(161, 239);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(121, 27);
            txtImageFile.TabIndex = 36;
            // 
            // loaiThuoc
            // 
            loaiThuoc.FormattingEnabled = true;
            loaiThuoc.Location = new Point(661, 100);
            loaiThuoc.Name = "loaiThuoc";
            loaiThuoc.Size = new Size(322, 28);
            loaiThuoc.TabIndex = 39;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.delete;
            btnDelete.Location = new Point(577, 590);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 55);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Xóa thuốc";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // fEditDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 657);
            Controls.Add(btnDelete);
            Controls.Add(loaiThuoc);
            Controls.Add(label14);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
            Controls.Add(soLuongTheoDonViBan);
            Controls.Add(giaBan);
            Controls.Add(hanSuDung);
            Controls.Add(donViBan);
            Controls.Add(nhaCungCap);
            Controls.Add(moTa);
            Controls.Add(chongChiDinh);
            Controls.Add(huongDanSuDung);
            Controls.Add(hamLuong);
            Controls.Add(dongGoi);
            Controls.Add(tenThuoc);
            Controls.Add(tacDungPhu);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "fEditDrug";
            Text = "Cập nhật thuốc";
            Load += fEditDrug_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)giaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnSave;
        private Button btnClose;
        private RichTextBox tacDungPhu;
        private RichTextBox tenThuoc;
        private RichTextBox dongGoi;
        private RichTextBox hamLuong;
        private RichTextBox huongDanSuDung;
        private RichTextBox chongChiDinh;
        private RichTextBox moTa;
        private ComboBox nhaCungCap;
        private ComboBox donViBan;
        private DateTimePicker hanSuDung;
        private NumericUpDown giaBan;
        private NumericUpDown soLuongTheoDonViBan;
        private Label label14;
        private Button btBrowse;
        private TextBox txtImageFile;
        private ComboBox loaiThuoc;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private Button btnDelete;
    }
}