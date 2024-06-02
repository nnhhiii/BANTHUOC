namespace BANTHUOC
{
    partial class fStatisticSale
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
            mahoadon = new DataGridViewTextBoxColumn();
            trangthai = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            ngaythanhtoan = new DataGridViewTextBoxColumn();
            mathuoc = new DataGridViewTextBoxColumn();
            tenthuoc = new DataGridViewTextBoxColumn();
            hamluong = new DataGridViewTextBoxColumn();
            hangsanxuat = new DataGridViewTextBoxColumn();
            machitiethoadon = new DataGridViewTextBoxColumn();
            donvi = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            giabantheodonvi = new DataGridViewTextBoxColumn();
            thanhtien = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btSave = new Button();
            btClose = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mahoadon, trangthai, username, ngaythanhtoan, mathuoc, tenthuoc, hamluong, hangsanxuat, machitiethoadon, donvi, soluong, giabantheodonvi, thanhtien });
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1406, 341);
            dataGridView1.TabIndex = 0;
            // 
            // mahoadon
            // 
            mahoadon.HeaderText = "Mã Hóa Đơn";
            mahoadon.MinimumWidth = 6;
            mahoadon.Name = "mahoadon";
            mahoadon.Width = 125;
            // 
            // trangthai
            // 
            trangthai.HeaderText = "Trạng Thái";
            trangthai.MinimumWidth = 6;
            trangthai.Name = "trangthai";
            trangthai.Width = 125;
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.Width = 125;
            // 
            // ngaythanhtoan
            // 
            ngaythanhtoan.HeaderText = "Ngày Thanh Toán";
            ngaythanhtoan.MinimumWidth = 6;
            ngaythanhtoan.Name = "ngaythanhtoan";
            ngaythanhtoan.Width = 125;
            // 
            // mathuoc
            // 
            mathuoc.HeaderText = "Mã Thuốc";
            mathuoc.MinimumWidth = 6;
            mathuoc.Name = "mathuoc";
            mathuoc.Width = 125;
            // 
            // tenthuoc
            // 
            tenthuoc.HeaderText = "Tên Thuốc";
            tenthuoc.MinimumWidth = 6;
            tenthuoc.Name = "tenthuoc";
            tenthuoc.Width = 125;
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
            // machitiethoadon
            // 
            machitiethoadon.HeaderText = "Mã Chi Tiết Hóa Đơn";
            machitiethoadon.MinimumWidth = 6;
            machitiethoadon.Name = "machitiethoadon";
            machitiethoadon.Width = 125;
            // 
            // donvi
            // 
            donvi.HeaderText = "Đơn Vị";
            donvi.MinimumWidth = 6;
            donvi.Name = "donvi";
            donvi.Width = 125;
            // 
            // soluong
            // 
            soluong.HeaderText = "Số Lượng";
            soluong.MinimumWidth = 6;
            soluong.Name = "soluong";
            soluong.Width = 125;
            // 
            // giabantheodonvi
            // 
            giabantheodonvi.HeaderText = "Giá Bán Theo Đơn Vị";
            giabantheodonvi.MinimumWidth = 6;
            giabantheodonvi.Name = "giabantheodonvi";
            giabantheodonvi.Width = 125;
            // 
            // thanhtien
            // 
            thanhtien.HeaderText = "Thành Tiền";
            thanhtien.MinimumWidth = 6;
            thanhtien.Name = "thanhtien";
            thanhtien.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 766);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 1;
            label1.Text = "Tổng tiền bán hàng";
            // 
            // btSave
            // 
            btSave.Location = new Point(1060, 783);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 3;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            btClose.Location = new Point(1189, 783);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 4;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(87, 789);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 5;
            // 
            // fStatisticSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 787);
            Controls.Add(maskedTextBox1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "fStatisticSale";
            Text = "fDrugSalesStatisticsManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mahoadon;
        private DataGridViewTextBoxColumn trangthai;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn ngaythanhtoan;
        private DataGridViewTextBoxColumn mathuoc;
        private DataGridViewTextBoxColumn tenthuoc;
        private DataGridViewTextBoxColumn hamluong;
        private DataGridViewTextBoxColumn hangsanxuat;
        private DataGridViewTextBoxColumn machitiethoadon;
        private DataGridViewTextBoxColumn donvi;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn giabantheodonvi;
        private DataGridViewTextBoxColumn thanhtien;
        private Label label1;
        private Button btSave;
        private Button btClose;
        private MaskedTextBox maskedTextBox1;
    }
}