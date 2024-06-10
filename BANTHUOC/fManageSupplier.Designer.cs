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
            ID = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnFind = new Button();
            lblFind = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, SupplierName, Description, Address, PhoneNumber, Edit, Delete });
            dataGridView1.Location = new Point(48, 310);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1320, 432);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // SupplierName
            // 
            SupplierName.DataPropertyName = "supplier_name";
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 10;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 200;
            // 
            // Description
            // 
            Description.DataPropertyName = "description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 10;
            Description.Name = "Description";
            Description.Width = 200;
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 10;
            Address.Name = "Address";
            Address.Width = 200;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "phone_number";
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
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 10;
            Delete.Name = "Delete";
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1089, 257);
            btnFind.Margin = new Padding(2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(102, 37);
            btnFind.TabIndex = 1;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(777, 269);
            lblFind.Margin = new Padding(2, 0, 2, 0);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(100, 20);
            lblFind.TabIndex = 2;
            lblFind.Text = "Nhà cung cấp";
            // 
            // txtName
            // 
            txtName.Location = new Point(892, 262);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 238);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 51);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Nhập mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(463, 180);
            label1.Name = "label1";
            label1.Size = new Size(323, 35);
            label1.TabIndex = 10;
            label1.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            // 
            // fManageSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 699);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lblFind);
            Controls.Add(btnFind);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "fManageSupplier";
            Text = "QUẢN LÝ NHÀ CUNG CẤP";
            WindowState = FormWindowState.Maximized;
            Activated += fManageSupplier_Activated;
            Load += fManageSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnFind;
        private Label lblFind;
        private TextBox txtName;
        private Button btnAdd;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label label1;
    }
}