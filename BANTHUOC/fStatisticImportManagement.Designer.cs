namespace BANTHUOC
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            tenthuoc = new DataGridViewTextBoxColumn();
            donvinhap = new DataGridViewTextBoxColumn();
            giatriquydoi = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            soluongnhap = new DataGridViewTextBoxColumn();
            gianhap = new DataGridViewTextBoxColumn();
            mota = new DataGridViewTextBoxColumn();
            nhaynhap = new DataGridViewTextBoxColumn();
            thanhvien = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            hamluong = new DataGridViewTextBoxColumn();
            hangsanxuat = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btSave = new Button();
            btClose = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tenthuoc, donvinhap, giatriquydoi, id, soluongnhap, gianhap, mota, nhaynhap, thanhvien, username, hamluong, hangsanxuat });
            dataGridView1.Location = new Point(12, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1327, 342);
            dataGridView1.TabIndex = 0;
            // 
            // tenthuoc
            // 
            tenthuoc.HeaderText = "Tên thuốc";
            tenthuoc.MinimumWidth = 6;
            tenthuoc.Name = "tenthuoc";
            tenthuoc.Width = 125;
            // 
            // donvinhap
            // 
            donvinhap.HeaderText = "Đơn vị nhập";
            donvinhap.MinimumWidth = 6;
            donvinhap.Name = "donvinhap";
            donvinhap.Width = 125;
            // 
            // giatriquydoi
            // 
            giatriquydoi.HeaderText = "Giá Trị Quy Đổi";
            giatriquydoi.MinimumWidth = 6;
            giatriquydoi.Name = "giatriquydoi";
            giatriquydoi.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "Mã Nhập Hàng";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // soluongnhap
            // 
            soluongnhap.HeaderText = "Số Lượng Nhập";
            soluongnhap.MinimumWidth = 6;
            soluongnhap.Name = "soluongnhap";
            soluongnhap.Width = 125;
            // 
            // gianhap
            // 
            gianhap.HeaderText = "Giá Nhập";
            gianhap.MinimumWidth = 6;
            gianhap.Name = "gianhap";
            gianhap.Width = 125;
            // 
            // mota
            // 
            mota.HeaderText = "Mô Tả";
            mota.MinimumWidth = 6;
            mota.Name = "mota";
            mota.Width = 125;
            // 
            // nhaynhap
            // 
            nhaynhap.HeaderText = "Ngày Nhập";
            nhaynhap.MinimumWidth = 6;
            nhaynhap.Name = "nhaynhap";
            nhaynhap.Width = 125;
            // 
            // thanhvien
            // 
            thanhvien.HeaderText = "Thành Viên";
            thanhvien.MinimumWidth = 6;
            thanhvien.Name = "thanhvien";
            thanhvien.Width = 125;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.Width = 125;
            // 
            // hamluong
            // 
            hamluong.HeaderText = "Hàm Lượng";
            hamluong.MinimumWidth = 6;
            hamluong.Name = "hamluong";
            hamluong.Width = 125;
            // 
            // hangsanxuat
            // 
            hangsanxuat.HeaderText = "Hãng Sản Xuất";
            hangsanxuat.MinimumWidth = 6;
            hangsanxuat.Name = "hangsanxuat";
            hangsanxuat.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(63, 377);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 1;
            label1.Text = "Tổng tiền nhập thuốc";
            // 
            // btSave
            // 
            btSave.Location = new Point(1092, 386);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 3;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            btClose.Location = new Point(1214, 386);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 4;
            btClose.Text = "Thoát";
            btClose.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(63, 400);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Thống kê nhập thuốc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tenthuoc;
        private DataGridViewTextBoxColumn donvinhap;
        private DataGridViewTextBoxColumn giatriquydoi;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn soluongnhap;
        private DataGridViewTextBoxColumn gianhap;
        private DataGridViewTextBoxColumn mota;
        private DataGridViewTextBoxColumn nhaynhap;
        private DataGridViewTextBoxColumn thanhvien;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn hamluong;
        private DataGridViewTextBoxColumn hangsanxuat;
        private Label label1;
        private Button btSave;
        private Button btClose;
        private MaskedTextBox maskedTextBox1;
    }
}