namespace BANTHUOC
{
    partial class fManageDrugCategory
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
            category_id = new DataGridViewTextBoxColumn();
            category_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            btnEdit = new DataGridViewButtonColumn();
            btnDelete = new DataGridViewButtonColumn();
            btnCategoryAdd = new Button();
            label1 = new Label();
            txtName = new TextBox();
            lblFind = new Label();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { category_id, category_name, description, btnEdit, btnDelete });
            dataGridView1.Location = new Point(59, 309);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1380, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // category_id
            // 
            category_id.DataPropertyName = "category_id";
            category_id.HeaderText = "Id";
            category_id.MinimumWidth = 6;
            category_id.Name = "category_id";
            category_id.Width = 125;
            // 
            // category_name
            // 
            category_name.DataPropertyName = "category_name";
            category_name.HeaderText = "Tên loại thuốc";
            category_name.MinimumWidth = 6;
            category_name.Name = "category_name";
            category_name.Width = 400;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "Mô tả";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.Width = 400;
            // 
            // btnEdit
            // 
            btnEdit.HeaderText = "Sửa";
            btnEdit.MinimumWidth = 6;
            btnEdit.Name = "btnEdit";
            btnEdit.Resizable = DataGridViewTriState.True;
            btnEdit.SortMode = DataGridViewColumnSortMode.Automatic;
            btnEdit.Text = "Sửa";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Xóa";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Resizable = DataGridViewTriState.True;
            btnDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDelete.Text = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 125;
            // 
            // btnCategoryAdd
            // 
            btnCategoryAdd.Location = new Point(128, 226);
            btnCategoryAdd.Name = "btnCategoryAdd";
            btnCategoryAdd.Size = new Size(130, 54);
            btnCategoryAdd.TabIndex = 1;
            btnCategoryAdd.Text = "Nhập mới";
            btnCategoryAdd.UseVisualStyleBackColor = true;
            btnCategoryAdd.Click += btnCategoryAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(551, 183);
            label1.Name = "label1";
            label1.Size = new Size(282, 35);
            label1.TabIndex = 11;
            label1.Text = "QUẢN LÝ LOẠI THUỐC";
            // 
            // txtName
            // 
            txtName.Location = new Point(981, 253);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 14;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(849, 260);
            lblFind.Margin = new Padding(2, 0, 2, 0);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(115, 20);
            lblFind.TabIndex = 13;
            lblFind.Text = "Nhập loại thuốc";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1178, 248);
            btnFind.Margin = new Padding(2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(102, 37);
            btnFind.TabIndex = 12;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // fManageDrugCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 670);
            Controls.Add(txtName);
            Controls.Add(lblFind);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Controls.Add(btnCategoryAdd);
            Controls.Add(dataGridView1);
            Name = "fManageDrugCategory";
            Text = "Quản Lý Loại Thuốc";
            WindowState = FormWindowState.Maximized;
            Activated += fDrugCategoryManagement_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCategoryAdd;
        private DataGridViewTextBoxColumn category_id;
        private DataGridViewTextBoxColumn category_name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewButtonColumn btnEdit;
        private DataGridViewButtonColumn btnDelete;
        private Label label1;
        private TextBox txtName;
        private Label lblFind;
        private Button btnFind;
    }
}