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
            label1 = new Label();
            TongTien = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            InvoiceId = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            StaffFullName = new DataGridViewTextBoxColumn();
            StaffEmail = new DataGridViewTextBoxColumn();
            invoiceDetail = new DataGridViewButtonColumn();
            btnClose = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            // TongTien
            // 
            TongTien.Location = new Point(87, 789);
            TongTien.Name = "TongTien";
            TongTien.Size = new Size(154, 27);
            TongTien.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { InvoiceId, CreatedAt, TotalAmount, StaffFullName, StaffEmail, invoiceDetail });
            dataGridView1.Location = new Point(88, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1255, 432);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // InvoiceId
            // 
            InvoiceId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            InvoiceId.DataPropertyName = "InvoiceId";
            InvoiceId.HeaderText = "Mã Bán Hàng";
            InvoiceId.MinimumWidth = 6;
            InvoiceId.Name = "InvoiceId";
            InvoiceId.Width = 118;
            // 
            // CreatedAt
            // 
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "Ngày Thanh Toán";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 140;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Tổng tiền";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 93;
            // 
            // StaffFullName
            // 
            StaffFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StaffFullName.DataPropertyName = "StaffFullName";
            StaffFullName.HeaderText = "Họ Tên";
            StaffFullName.MinimumWidth = 6;
            StaffFullName.Name = "StaffFullName";
            StaffFullName.Width = 79;
            // 
            // StaffEmail
            // 
            StaffEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StaffEmail.DataPropertyName = "StaffEmail";
            StaffEmail.HeaderText = "Email";
            StaffEmail.MinimumWidth = 6;
            StaffEmail.Name = "StaffEmail";
            StaffEmail.Width = 75;
            // 
            // invoiceDetail
            // 
            invoiceDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            invoiceDetail.HeaderText = "Chi Tiết Hóa Đơn Bán Hàng";
            invoiceDetail.MinimumWidth = 6;
            invoiceDetail.Name = "invoiceDetail";
            invoiceDetail.Resizable = DataGridViewTriState.True;
            invoiceDetail.SortMode = DataGridViewColumnSortMode.Automatic;
            invoiceDetail.Text = "Chi tiết";
            invoiceDetail.UseColumnTextForButtonValue = true;
            invoiceDetail.Width = 143;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.thoat;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1124, 765);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(116, 61);
            btnClose.TabIndex = 84;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(587, 169);
            label2.Name = "label2";
            label2.Size = new Size(412, 35);
            label2.TabIndex = 85;
            label2.Text = "THỐNG KÊ HÓA ĐƠN BÁN HÀNG";
            // 
            // fStatisticSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 907);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(TongTien);
            Controls.Add(label1);
            Name = "fStatisticSale";
            Text = "THỐNG KÊ HÓA ĐƠN BÁN HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += fStatisticSale_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaskedTextBox TongTien;
        private DataGridView dataGridView1;
        private Button btnClose;
        private DataGridViewTextBoxColumn InvoiceId;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn StaffFullName;
        private DataGridViewTextBoxColumn StaffEmail;
        private DataGridViewButtonColumn invoiceDetail;
        private Label label2;
    }
}