namespace BANTHUOC
{
    partial class fStatisticImport
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
            btnClose = new Button();
            ImportInvoiceId = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            StaffFullName = new DataGridViewTextBoxColumn();
            StaffEmail = new DataGridViewTextBoxColumn();
            importDetail = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ImportInvoiceId, CreatedAt, TotalAmount, StaffFullName, StaffEmail, importDetail });
            dataGridView1.Location = new Point(63, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1255, 432);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = Properties.Resources.thoat;
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Location = new Point(1202, 694);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 51);
            btnClose.TabIndex = 83;
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
            // CreatedAt
            // 
            CreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CreatedAt.DataPropertyName = "CreatedAt";
            CreatedAt.HeaderText = "Ngày Nhập";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.Width = 113;
            // 
            // TotalAmount
            // 
            TotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TotalAmount.DataPropertyName = "TotalAmount";
            TotalAmount.HeaderText = "Tổng tiền";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 101;
            // 
            // StaffFullName
            // 
            StaffFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            StaffFullName.DataPropertyName = "StaffFullName";
            StaffFullName.HeaderText = "Họ Tên";
            StaffFullName.MinimumWidth = 6;
            StaffFullName.Name = "StaffFullName";
            StaffFullName.Width = 85;
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
            // importDetail
            // 
            importDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            importDetail.HeaderText = "Chi Tiết Hóa Đơn Nhập Hàng";
            importDetail.MinimumWidth = 6;
            importDetail.Name = "importDetail";
            importDetail.Resizable = DataGridViewTriState.True;
            importDetail.SortMode = DataGridViewColumnSortMode.Automatic;
            importDetail.Text = "Chi tiết";
            importDetail.UseColumnTextForButtonValue = true;
            importDetail.Width = 179;
            // 
            // fStatisticImport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 802);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Name = "fStatisticImport";
            Text = "Thống kê nhập thuốc";
            WindowState = FormWindowState.Maximized;
            Load += fStatisticImport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnClose;
        private DataGridViewTextBoxColumn ImportInvoiceId;
        private DataGridViewTextBoxColumn CreatedAt;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn StaffFullName;
        private DataGridViewTextBoxColumn StaffEmail;
        private DataGridViewButtonColumn importDetail;
    }
}