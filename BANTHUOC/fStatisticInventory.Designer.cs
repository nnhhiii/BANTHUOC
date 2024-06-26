﻿namespace BANTHUOC
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
            btnClose = new Button();
            label1 = new Label();
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
            dataGridView1.Location = new Point(65, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1170, 426);
            dataGridView1.TabIndex = 0;
            // 
            // tenthuoc
            // 
            tenthuoc.DataPropertyName = "DrugName";
            tenthuoc.HeaderText = "Tên Thuốc";
            tenthuoc.MinimumWidth = 6;
            tenthuoc.Name = "tenthuoc";
            tenthuoc.Width = 125;
            // 
            // loaithuoc
            // 
            loaithuoc.DataPropertyName = "CategoryName";
            loaithuoc.HeaderText = "Loại Thuốc";
            loaithuoc.MinimumWidth = 6;
            loaithuoc.Name = "loaithuoc";
            loaithuoc.Width = 125;
            // 
            // nhacungcap
            // 
            nhacungcap.DataPropertyName = "SupplierName";
            nhacungcap.HeaderText = "Nhà Cung Cấp";
            nhacungcap.MinimumWidth = 6;
            nhacungcap.Name = "nhacungcap";
            nhacungcap.Width = 125;
            // 
            // donvinhap
            // 
            donvinhap.DataPropertyName = "UnitName";
            donvinhap.HeaderText = "Đơn Vị Nhập";
            donvinhap.MinimumWidth = 6;
            donvinhap.Name = "donvinhap";
            donvinhap.Width = 125;
            // 
            // ngayhethan
            // 
            ngayhethan.DataPropertyName = "ExpiryDate";
            ngayhethan.HeaderText = "Ngày Hết Hạn";
            ngayhethan.MinimumWidth = 6;
            ngayhethan.Name = "ngayhethan";
            ngayhethan.Width = 125;
            // 
            // soluongnhap
            // 
            soluongnhap.DataPropertyName = "TotalImportQuantity";
            soluongnhap.HeaderText = "Số Lượng Nhập";
            soluongnhap.MinimumWidth = 6;
            soluongnhap.Name = "soluongnhap";
            soluongnhap.Width = 125;
            // 
            // soluongban
            // 
            soluongban.DataPropertyName = "TotalSaleQuantity";
            soluongban.HeaderText = "Số Lượng Bán";
            soluongban.MinimumWidth = 6;
            soluongban.Name = "soluongban";
            soluongban.Width = 125;
            // 
            // soluongton
            // 
            soluongton.DataPropertyName = "StockQuantity";
            soluongton.HeaderText = "Số Lượng Tồn";
            soluongton.MinimumWidth = 6;
            soluongton.Name = "soluongton";
            soluongton.Width = 125;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.thoat;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1050, 696);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 61);
            btnClose.TabIndex = 85;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(544, 170);
            label1.Name = "label1";
            label1.Size = new Size(264, 35);
            label1.TabIndex = 86;
            label1.Text = "THỐNG KÊ TỒN KHO";
            // 
            // fStatisticInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 792);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Name = "fStatisticInventory";
            Text = "Thống kê tồn kho";
            WindowState = FormWindowState.Maximized;
            Load += fStatisticInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnClose;
        private Label label1;
    }
}