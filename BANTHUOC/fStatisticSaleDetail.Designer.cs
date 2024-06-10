﻿namespace BANTHUOC
{
    partial class fStatisticSaleDetail
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
            ImportDetailId = new DataGridViewTextBoxColumn();
            ImportInvoiceId = new DataGridViewTextBoxColumn();
            DrugName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            UnitName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ImportPrice = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImportDetailId, ImportInvoiceId, DrugName, SupplierName, Content, UnitName, Quantity, ImportPrice });
            dataGridView1.Location = new Point(32, 275);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1247, 369);
            dataGridView1.TabIndex = 1;
            // 
            // ImportDetailId
            // 
            ImportDetailId.DataPropertyName = "ImportDetailId";
            ImportDetailId.HeaderText = "Mã CTHD Bán Hàng";
            ImportDetailId.MinimumWidth = 6;
            ImportDetailId.Name = "ImportDetailId";
            ImportDetailId.Width = 125;
            // 
            // ImportInvoiceId
            // 
            ImportInvoiceId.DataPropertyName = "ImportInvoiceId";
            ImportInvoiceId.HeaderText = "Mã Hóa Đơn ";
            ImportInvoiceId.MinimumWidth = 6;
            ImportInvoiceId.Name = "ImportInvoiceId";
            ImportInvoiceId.Width = 125;
            // 
            // DrugName
            // 
            DrugName.DataPropertyName = "DrugName";
            DrugName.HeaderText = "Tên Thuốc";
            DrugName.MinimumWidth = 6;
            DrugName.Name = "DrugName";
            DrugName.Width = 125;
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Nhà Cung Cấp";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 125;
            // 
            // Content
            // 
            Content.DataPropertyName = "Content";
            Content.HeaderText = "Hàm Lượng";
            Content.MinimumWidth = 6;
            Content.Name = "Content";
            Content.Width = 125;
            // 
            // UnitName
            // 
            UnitName.DataPropertyName = "UnitName";
            UnitName.HeaderText = "Đơn Vị";
            UnitName.MinimumWidth = 6;
            UnitName.Name = "UnitName";
            UnitName.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // ImportPrice
            // 
            ImportPrice.DataPropertyName = "ImportPrice";
            ImportPrice.HeaderText = "Đơn giá";
            ImportPrice.MinimumWidth = 6;
            ImportPrice.Name = "ImportPrice";
            ImportPrice.Width = 125;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.thoat;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1147, 731);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 61);
            btnClose.TabIndex = 84;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fStatisticSaleDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 862);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Name = "fStatisticSaleDetail";
            Text = "fStatisticSaleDetail";
            WindowState = FormWindowState.Maximized;
            Load += fStatisticSaleDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ImportDetailId;
        private DataGridViewTextBoxColumn ImportInvoiceId;
        private DataGridViewTextBoxColumn DrugName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn UnitName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ImportPrice;
        private Button btnClose;
    }
}