namespace BANTHUOC
{
    partial class fManageStaff
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
            id = new DataGridViewTextBoxColumn();
            full_name = new DataGridViewTextBoxColumn();
            staff_gender = new DataGridViewTextBoxColumn();
            date_of_birth = new DataGridViewTextBoxColumn();
            staff_address = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            role_id = new DataGridViewTextBoxColumn();
            staff_email = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            txtName = new TextBox();
            btFind = new Button();
            btNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, full_name, staff_gender, date_of_birth, staff_address, phone_number, role_id, staff_email, password, created_at, Edit, Delete });
            dataGridView1.Location = new Point(12, 315);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1356, 374);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "StaffID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // full_name
            // 
            full_name.DataPropertyName = "full_name";
            full_name.HeaderText = "Họ tên";
            full_name.MinimumWidth = 6;
            full_name.Name = "full_name";
            full_name.Width = 125;
            // 
            // staff_gender
            // 
            staff_gender.DataPropertyName = "staff_gender";
            staff_gender.HeaderText = "Giới tính";
            staff_gender.MinimumWidth = 6;
            staff_gender.Name = "staff_gender";
            staff_gender.Resizable = DataGridViewTriState.True;
            staff_gender.Width = 125;
            // 
            // date_of_birth
            // 
            date_of_birth.DataPropertyName = "date_of_birth";
            date_of_birth.HeaderText = "Ngày sinh";
            date_of_birth.MinimumWidth = 6;
            date_of_birth.Name = "date_of_birth";
            date_of_birth.Width = 125;
            // 
            // staff_address
            // 
            staff_address.DataPropertyName = "staff_address";
            staff_address.HeaderText = "Địa chỉ";
            staff_address.MinimumWidth = 6;
            staff_address.Name = "staff_address";
            staff_address.Width = 125;
            // 
            // phone_number
            // 
            phone_number.DataPropertyName = "phone_number";
            phone_number.HeaderText = "Số điện thoại";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.Width = 125;
            // 
            // role_id
            // 
            role_id.DataPropertyName = "role_id";
            role_id.HeaderText = "Chức vụ";
            role_id.MinimumWidth = 6;
            role_id.Name = "role_id";
            role_id.Width = 125;
            // 
            // staff_email
            // 
            staff_email.DataPropertyName = "staff_email";
            staff_email.HeaderText = "Email";
            staff_email.MinimumWidth = 6;
            staff_email.Name = "staff_email";
            staff_email.Width = 125;
            // 
            // password
            // 
            password.DataPropertyName = "password";
            password.HeaderText = "Mật khẩu";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.Width = 125;
            // 
            // created_at
            // 
            created_at.DataPropertyName = "created_at";
            created_at.HeaderText = "Thời gian tạo";
            created_at.MinimumWidth = 6;
            created_at.Name = "created_at";
            created_at.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(416, 219);
            label1.Name = "label1";
            label1.Size = new Size(259, 35);
            label1.TabIndex = 9;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txtName
            // 
            txtName.Location = new Point(926, 242);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // btFind
            // 
            btFind.Location = new Point(1091, 241);
            btFind.Name = "btFind";
            btFind.Size = new Size(94, 29);
            btFind.TabIndex = 7;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // btNew
            // 
            btNew.Location = new Point(44, 242);
            btNew.Name = "btNew";
            btNew.Size = new Size(94, 29);
            btNew.TabIndex = 6;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // fManageStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1412, 626);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Name = "fManageStaff";
            Text = "fManageStaff";
            WindowState = FormWindowState.Maximized;
            Activated += fManageStaff_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtName;
        private Button btFind;
        private Button btNew;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn staff_gender;
        private DataGridViewTextBoxColumn date_of_birth;
        private DataGridViewTextBoxColumn staff_address;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn role_id;
        private DataGridViewTextBoxColumn staff_email;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}