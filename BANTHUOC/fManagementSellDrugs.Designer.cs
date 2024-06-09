namespace BANTHUOC
{
    partial class fManagementSellDrugs
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chonThuoc = new ComboBox();
            soluong = new ComboBox();
            thanhtien = new ComboBox();
            giaban = new TextBox();
            soluonton = new TextBox();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            drug_name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            donvi = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ttien = new DataGridViewTextBoxColumn();
            hinhanh = new DataGridViewTextBoxColumn();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            TONGTIEN = new TextBox();
            thanhtoan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 191);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Chọn thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(539, 191);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(539, 276);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "Thành tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 276);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 3;
            label4.Text = "Số lượng tồn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Giá bán";
            // 
            // chonThuoc
            // 
            chonThuoc.FormattingEnabled = true;
            chonThuoc.Location = new Point(19, 230);
            chonThuoc.Margin = new Padding(2, 2, 2, 2);
            chonThuoc.Name = "chonThuoc";
            chonThuoc.Size = new Size(146, 28);
            chonThuoc.TabIndex = 6;
            // 
            // soluong
            // 
            soluong.FormattingEnabled = true;
            soluong.Location = new Point(539, 230);
            soluong.Margin = new Padding(2, 2, 2, 2);
            soluong.Name = "soluong";
            soluong.Size = new Size(146, 28);
            soluong.TabIndex = 7;
            // 
            // thanhtien
            // 
            thanhtien.FormattingEnabled = true;
            thanhtien.Location = new Point(539, 314);
            thanhtien.Margin = new Padding(2, 2, 2, 2);
            thanhtien.Name = "thanhtien";
            thanhtien.Size = new Size(146, 28);
            thanhtien.TabIndex = 8;
            // 
            // giaban
            // 
            giaban.Location = new Point(19, 314);
            giaban.Margin = new Padding(2, 2, 2, 2);
            giaban.Name = "giaban";
            giaban.Size = new Size(146, 27);
            giaban.TabIndex = 9;
            // 
            // soluonton
            // 
            soluonton.Location = new Point(264, 314);
            soluonton.Margin = new Padding(2, 2, 2, 2);
            soluonton.Name = "soluonton";
            soluonton.Size = new Size(148, 27);
            soluonton.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, drug_name, Column1, gia, donvi, Column4, ttien, hinhanh });
            dataGridView1.Location = new Point(19, 369);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1284, 268);
            dataGridView1.TabIndex = 11;
            // 
            // id
            // 
            id.HeaderText = "Mã thuốc";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // drug_name
            // 
            drug_name.HeaderText = "Tên thuốc";
            drug_name.MinimumWidth = 8;
            drug_name.Name = "drug_name";
            drug_name.Width = 150;
            // 
            // Column1
            // 
            Column1.HeaderText = "Hàm lượng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // gia
            // 
            gia.HeaderText = "Giá bán";
            gia.MinimumWidth = 8;
            gia.Name = "gia";
            gia.Width = 150;
            // 
            // donvi
            // 
            donvi.HeaderText = "Số lượng";
            donvi.MinimumWidth = 8;
            donvi.Name = "donvi";
            donvi.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Đơn vị";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // ttien
            // 
            ttien.HeaderText = "Thành tiền";
            ttien.MinimumWidth = 8;
            ttien.Name = "ttien";
            ttien.Width = 150;
            // 
            // hinhanh
            // 
            hinhanh.HeaderText = "Hình ảnh";
            hinhanh.MinimumWidth = 8;
            hinhanh.Name = "hinhanh";
            hinhanh.Width = 200;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 191);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 12;
            label6.Text = "Đơn vị";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 230);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(29, 678);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 14;
            label7.Text = "Tổng thành tiền";
            // 
            // TONGTIEN
            // 
            TONGTIEN.Location = new Point(175, 674);
            TONGTIEN.Margin = new Padding(2, 2, 2, 2);
            TONGTIEN.Name = "TONGTIEN";
            TONGTIEN.Size = new Size(185, 27);
            TONGTIEN.TabIndex = 15;
            // 
            // thanhtoan
            // 
            thanhtoan.BackColor = Color.LightBlue;
            thanhtoan.ForeColor = Color.White;
            thanhtoan.Location = new Point(909, 654);
            thanhtoan.Margin = new Padding(2, 2, 2, 2);
            thanhtoan.Name = "thanhtoan";
            thanhtoan.Size = new Size(139, 69);
            thanhtoan.TabIndex = 16;
            thanhtoan.Text = "Thanh toán";
            thanhtoan.UseVisualStyleBackColor = false;
            // 
            // fManagementSellDrugs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 741);
            Controls.Add(thanhtoan);
            Controls.Add(TONGTIEN);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(soluonton);
            Controls.Add(giaban);
            Controls.Add(thanhtien);
            Controls.Add(soluong);
            Controls.Add(chonThuoc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fManagementSellDrugs";
            Text = "Bán thuốc";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox chonThuoc;
        private ComboBox soluong;
        private ComboBox thanhtien;
        private TextBox giaban;
        private TextBox soluonton;
        private DataGridView dataGridView1;
        private Label label6;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn drug_name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn donvi;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn ttien;
        private DataGridViewTextBoxColumn hinhanh;
        private Label label7;
        private TextBox TONGTIEN;
        private Button thanhtoan;
    }
}