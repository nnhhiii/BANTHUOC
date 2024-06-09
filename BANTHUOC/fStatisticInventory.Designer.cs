namespace BANTHUOC
{
    partial class fStatisticInventory
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
            loaithuoc = new DataGridViewTextBoxColumn();
            nhacungcap = new DataGridViewTextBoxColumn();
            donvinhap = new DataGridViewTextBoxColumn();
            ngayhethan = new DataGridViewTextBoxColumn();
            soluongnhap = new DataGridViewTextBoxColumn();
            soluongban = new DataGridViewTextBoxColumn();
            soluongton = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tenthuoc, loaithuoc, nhacungcap, donvinhap, ngayhethan, soluongnhap, soluongban, soluongton });
            dataGridView1.Location = new Point(12, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1079, 426);
            dataGridView1.TabIndex = 0;
            // 
            // tenthuoc
            // 
            tenthuoc.HeaderText = "Tên Thuốc";
            tenthuoc.MinimumWidth = 6;
            tenthuoc.Name = "tenthuoc";
            tenthuoc.Width = 125;
            // 
            // loaithuoc
            // 
            loaithuoc.HeaderText = "Loại Thuốc";
            loaithuoc.MinimumWidth = 6;
            loaithuoc.Name = "loaithuoc";
            loaithuoc.Width = 125;
            // 
            // nhacungcap
            // 
            nhacungcap.HeaderText = "Nhà Cung Cấp";
            nhacungcap.MinimumWidth = 6;
            nhacungcap.Name = "nhacungcap";
            nhacungcap.Width = 125;
            // 
            // donvinhap
            // 
            donvinhap.HeaderText = "Đơn Vị Nhập";
            donvinhap.MinimumWidth = 6;
            donvinhap.Name = "donvinhap";
            donvinhap.Width = 125;
            // 
            // ngayhethan
            // 
            ngayhethan.HeaderText = "Ngày Hết Hạn";
            ngayhethan.MinimumWidth = 6;
            ngayhethan.Name = "ngayhethan";
            ngayhethan.Width = 125;
            // 
            // soluongnhap
            // 
            soluongnhap.HeaderText = "Số Lượng Nhập";
            soluongnhap.MinimumWidth = 6;
            soluongnhap.Name = "soluongnhap";
            soluongnhap.Width = 125;
            // 
            // soluongban
            // 
            soluongban.HeaderText = "Số Lượng Bán";
            soluongban.MinimumWidth = 6;
            soluongban.Name = "soluongban";
            soluongban.Width = 125;
            // 
            // soluongton
            // 
            soluongton.HeaderText = "Số Lượng Tồn";
            soluongton.MinimumWidth = 6;
            soluongton.Name = "soluongton";
            soluongton.Width = 125;
            // 
            // fStatisticInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 792);
            Controls.Add(dataGridView1);
            Name = "fStatisticInventory";
            Text = "Thống kê tồn kho";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tenthuoc;
        private DataGridViewTextBoxColumn loaithuoc;
        private DataGridViewTextBoxColumn nhacungcap;
        private DataGridViewTextBoxColumn donvinhap;
        private DataGridViewTextBoxColumn ngayhethan;
        private DataGridViewTextBoxColumn soluongnhap;
        private DataGridViewTextBoxColumn soluongban;
        private DataGridViewTextBoxColumn soluongton;
    }
}