namespace BANTHUOC
{
    partial class fStatisticImportDetail
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
            TongTien = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            btnClose = new Button();
            ImportInvoiceId = new DataGridViewTextBoxColumn();
            ImportDetailId = new DataGridViewTextBoxColumn();
            DrugName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Content = new DataGridViewTextBoxColumn();
            UnitName = new DataGridViewTextBoxColumn();
            ImportPrice = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImportInvoiceId, ImportDetailId, DrugName, SupplierName, Content, UnitName, ImportPrice, Quantity, Amount, ExpiryDate });
            dataGridView1.Location = new Point(40, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1255, 432);
            dataGridView1.TabIndex = 87;
            // 
            // TongTien
            // 
            TongTien.Location = new Point(40, 750);
            TongTien.Name = "TongTien";
            TongTien.Size = new Size(154, 27);
            TongTien.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 727);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 90;
            label2.Text = "Tổng Tiền Nhập";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(550, 180);
            label1.Name = "label1";
            label1.Size = new Size(322, 35);
            label1.TabIndex = 89;
            label1.Text = "CHI TIẾT HÓA ĐƠN NHẬP";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.thoat;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1179, 738);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 51);
            btnClose.TabIndex = 88;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ImportInvoiceId
            // 
            ImportInvoiceId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImportInvoiceId.DataPropertyName = "ImportInvoiceId";
            ImportInvoiceId.HeaderText = "Mã Nhập Hàng";
            ImportInvoiceId.MinimumWidth = 6;
            ImportInvoiceId.Name = "ImportInvoiceId";
            ImportInvoiceId.Width = 139;
            // 
            // ImportDetailId
            // 
            ImportDetailId.DataPropertyName = "ImportDetailId";
            ImportDetailId.HeaderText = "Mã Chi Tiết";
            ImportDetailId.MinimumWidth = 6;
            ImportDetailId.Name = "ImportDetailId";
            ImportDetailId.Width = 125;
            // 
            // DrugName
            // 
            DrugName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DrugName.DataPropertyName = "DrugName";
            DrugName.HeaderText = "Tên Thuốc";
            DrugName.MinimumWidth = 6;
            DrugName.Name = "DrugName";
            DrugName.Width = 105;
            // 
            // SupplierName
            // 
            SupplierName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SupplierName.DataPropertyName = "SupplierName";
            SupplierName.HeaderText = "Nhà Cung Cấp";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 133;
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
            // ImportPrice
            // 
            ImportPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ImportPrice.DataPropertyName = "ImportPrice";
            ImportPrice.HeaderText = "Giá Nhập";
            ImportPrice.MinimumWidth = 6;
            ImportPrice.Name = "ImportPrice";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Số Lượng Nhập";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // Amount
            // 
            Amount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Tổng tiền";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            Amount.Width = 93;
            // 
            // ExpiryDate
            // 
            ExpiryDate.DataPropertyName = "ExpiryDate";
            ExpiryDate.HeaderText = "Hạn Sử Dụng";
            ExpiryDate.MinimumWidth = 6;
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.Width = 125;
            // 
            // fStatisticImportDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 913);
            Controls.Add(dataGridView1);
            Controls.Add(TongTien);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Name = "fStatisticImportDetail";
            Text = "fStatisticImportDetail";
            Load += fStatisticImportDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox TongTien;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private DataGridViewTextBoxColumn ImportInvoiceId;
        private DataGridViewTextBoxColumn ImportDetailId;
        private DataGridViewTextBoxColumn DrugName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Content;
        private DataGridViewTextBoxColumn UnitName;
        private DataGridViewTextBoxColumn ImportPrice;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ExpiryDate;
    }
}