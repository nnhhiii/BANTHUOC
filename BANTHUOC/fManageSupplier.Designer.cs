namespace BANTHUOC
{
    partial class fManageSupplier
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
            SupplierID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnFind = new Button();
            lblFind = new Label();
            txtFind = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SupplierID, SupplierName, Description, Address, PhoneNumber, Edit, Delete });
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1341, 523);
            dataGridView1.TabIndex = 0;
            // 
            // SupplierID
            // 
            SupplierID.HeaderText = "ID";
            SupplierID.MinimumWidth = 10;
            SupplierID.Name = "SupplierID";
            SupplierID.Width = 200;
            // 
            // SupplierName
            // 
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 10;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 200;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.Width = 200;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 10;
            Address.Name = "Address";
            Address.Width = 200;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 10;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 200;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 10;
            Edit.Name = "Edit";
            Edit.Width = 200;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 10;
            Delete.Name = "Delete";
            Delete.Width = 200;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1262, 32);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 53);
            btnFind.TabIndex = 1;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(789, 53);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(162, 32);
            lblFind.TabIndex = 2;
            lblFind.Text = "Nhà cung cấp";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(974, 46);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(261, 39);
            txtFind.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // fManageSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 867);
            Controls.Add(btnAdd);
            Controls.Add(txtFind);
            Controls.Add(lblFind);
            Controls.Add(btnFind);
            Controls.Add(dataGridView1);
            Name = "fManageSupplier";
            Text = "QUẢN LÝ NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SupplierID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnFind;
        private Label lblFind;
        private TextBox txtFind;
        private Button btnAdd;
    }
}