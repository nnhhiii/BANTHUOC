namespace BANTHUOC
{
    partial class fNewDrug
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
            toolTip1 = new ToolTip(components);
            loaiThuoc = new ComboBox();
            label14 = new Label();
            btBrowse = new Button();
            txtImageFile = new TextBox();
            nhaCungCap = new ComboBox();
            moTa = new RichTextBox();
            chongChiDinh = new RichTextBox();
            huongDanSuDung = new RichTextBox();
            hamLuong = new RichTextBox();
            dongGoi = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            tenThuoc = new RichTextBox();
            tacDungPhu = new RichTextBox();
            btnClose = new Button();
            btnSave = new Button();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            giaNhap = new NumericUpDown();
            label15 = new Label();
            soLuongTheoDonViBan = new NumericUpDown();
            giaBan = new NumericUpDown();
            donViBan = new ComboBox();
            hanSuDung = new DateTimePicker();
            label11 = new Label();
            label10 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)giaNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)giaBan).BeginInit();
            SuspendLayout();
            // 
            // loaiThuoc
            // 
            loaiThuoc.FormattingEnabled = true;
            loaiThuoc.Location = new Point(765, 131);
            loaiThuoc.Name = "loaiThuoc";
            loaiThuoc.Size = new Size(322, 28);
            loaiThuoc.TabIndex = 72;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(112, 343);
            label14.Name = "label14";
            label14.Size = new Size(87, 20);
            label14.TabIndex = 71;
            label14.Text = "Tập tin hình";
            // 
            // btBrowse
            // 
            btBrowse.Location = new Point(434, 338);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(92, 29);
            btBrowse.TabIndex = 70;
            btBrowse.Text = "Chọn ảnh";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(246, 340);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(182, 27);
            txtImageFile.TabIndex = 69;
            // 
            // nhaCungCap
            // 
            nhaCungCap.FormattingEnabled = true;
            nhaCungCap.Location = new Point(765, 188);
            nhaCungCap.Name = "nhaCungCap";
            nhaCungCap.Size = new Size(322, 28);
            nhaCungCap.TabIndex = 64;
            // 
            // moTa
            // 
            moTa.Location = new Point(246, 608);
            moTa.Name = "moTa";
            moTa.Size = new Size(268, 64);
            moTa.TabIndex = 63;
            moTa.Text = "";
            // 
            // chongChiDinh
            // 
            chongChiDinh.Location = new Point(246, 550);
            chongChiDinh.Name = "chongChiDinh";
            chongChiDinh.Size = new Size(262, 42);
            chongChiDinh.TabIndex = 62;
            chongChiDinh.Text = "";
            // 
            // huongDanSuDung
            // 
            huongDanSuDung.Location = new Point(246, 393);
            huongDanSuDung.Name = "huongDanSuDung";
            huongDanSuDung.Size = new Size(262, 64);
            huongDanSuDung.TabIndex = 61;
            huongDanSuDung.Text = "";
            // 
            // hamLuong
            // 
            hamLuong.Location = new Point(765, 239);
            hamLuong.Name = "hamLuong";
            hamLuong.Size = new Size(322, 30);
            hamLuong.TabIndex = 60;
            hamLuong.Text = "";
            // 
            // dongGoi
            // 
            dongGoi.Location = new Point(765, 291);
            dongGoi.Name = "dongGoi";
            dongGoi.Size = new Size(322, 30);
            dongGoi.TabIndex = 59;
            dongGoi.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tenThuoc
            // 
            tenThuoc.Location = new Point(765, 71);
            tenThuoc.Name = "tenThuoc";
            tenThuoc.Size = new Size(322, 30);
            tenThuoc.TabIndex = 58;
            tenThuoc.Text = "";
            // 
            // tacDungPhu
            // 
            tacDungPhu.Location = new Point(246, 482);
            tacDungPhu.Name = "tacDungPhu";
            tacDungPhu.Size = new Size(262, 48);
            tacDungPhu.TabIndex = 57;
            tacDungPhu.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(995, 691);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 55);
            btnClose.TabIndex = 56;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(835, 691);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 55);
            btnSave.TabIndex = 55;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(579, 239);
            label13.Name = "label13";
            label13.Size = new Size(84, 20);
            label13.TabIndex = 54;
            label13.Text = "Hàm lượng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(579, 294);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 53;
            label12.Text = "Quy cách đóng gói";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(112, 482);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 50;
            label9.Text = "Tác dụng phụ";
            // 
            // label8
            // 
            label8.Location = new Point(112, 396);
            label8.Name = "label8";
            label8.Size = new Size(108, 47);
            label8.TabIndex = 49;
            label8.Text = "Hướng dẫn sử dụng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 553);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 48;
            label7.Text = "Chống chỉ định";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 608);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 47;
            label6.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 188);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 44;
            label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(579, 131);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 43;
            label2.Text = "Loại thuốc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 81);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 42;
            label1.Text = "Tên thuốc";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.no_image;
            pictureBox1.Image = Properties.Resources.no_image;
            pictureBox1.Location = new Point(122, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(404, 267);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // giaNhap
            // 
            giaNhap.Location = new Point(765, 355);
            giaNhap.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            giaNhap.Name = "giaNhap";
            giaNhap.Size = new Size(322, 27);
            giaNhap.TabIndex = 118;
            giaNhap.ValueChanged += giaNhap_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(579, 355);
            label15.Name = "label15";
            label15.Size = new Size(68, 20);
            label15.TabIndex = 117;
            label15.Text = "Giá nhập";
            // 
            // soLuongTheoDonViBan
            // 
            soLuongTheoDonViBan.Location = new Point(765, 536);
            soLuongTheoDonViBan.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            soLuongTheoDonViBan.Name = "soLuongTheoDonViBan";
            soLuongTheoDonViBan.Size = new Size(322, 27);
            soLuongTheoDonViBan.TabIndex = 116;
            soLuongTheoDonViBan.ValueChanged += soLuongTheoDonViBan_ValueChanged;
            // 
            // giaBan
            // 
            giaBan.Location = new Point(765, 413);
            giaBan.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            giaBan.Name = "giaBan";
            giaBan.Size = new Size(322, 27);
            giaBan.TabIndex = 115;
            giaBan.ValueChanged += giaBan_ValueChanged;
            // 
            // donViBan
            // 
            donViBan.FormattingEnabled = true;
            donViBan.Location = new Point(765, 472);
            donViBan.Name = "donViBan";
            donViBan.Size = new Size(322, 28);
            donViBan.TabIndex = 113;
            // 
            // hanSuDung
            // 
            hanSuDung.Format = DateTimePickerFormat.Short;
            hanSuDung.Location = new Point(765, 608);
            hanSuDung.Name = "hanSuDung";
            hanSuDung.Size = new Size(322, 27);
            hanSuDung.TabIndex = 114;
            // 
            // label11
            // 
            label11.Location = new Point(579, 528);
            label11.Name = "label11";
            label11.Size = new Size(134, 54);
            label11.TabIndex = 112;
            label11.Text = "Số lượng theo đơn vị bán";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(579, 610);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 111;
            label10.Text = "Hạn sử dụng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(579, 472);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 110;
            label5.Text = "Đơn vị bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(579, 413);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 109;
            label4.Text = "Giá bán";
            // 
            // fNewDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 785);
            Controls.Add(giaNhap);
            Controls.Add(label15);
            Controls.Add(soLuongTheoDonViBan);
            Controls.Add(giaBan);
            Controls.Add(donViBan);
            Controls.Add(hanSuDung);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(loaiThuoc);
            Controls.Add(label14);
            Controls.Add(btBrowse);
            Controls.Add(txtImageFile);
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
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "fNewDrug";
            Text = "Nhập hàng mới";
            Load += fNewDrug_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)giaNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)soLuongTheoDonViBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)giaBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private ComboBox loaiThuoc;
        private Label label14;
        private Button btBrowse;
        private TextBox txtImageFile;
        private ComboBox nhaCungCap;
        private RichTextBox moTa;
        private RichTextBox chongChiDinh;
        private RichTextBox huongDanSuDung;
        private RichTextBox hamLuong;
        private RichTextBox dongGoi;
        private OpenFileDialog openFileDialog1;
        private RichTextBox tenThuoc;
        private RichTextBox tacDungPhu;
        private Button btnClose;
        private Button btnSave;
        private Label label13;
        private Label label12;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private NumericUpDown giaNhap;
        private Label label15;
        private NumericUpDown soLuongTheoDonViBan;
        private NumericUpDown giaBan;
        private ComboBox donViBan;
        private DateTimePicker hanSuDung;
        private Label label11;
        private Label label10;
        private Label label5;
        private Label label4;
    }
}