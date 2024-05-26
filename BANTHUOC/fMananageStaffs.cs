using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fMananageStaffs : Form
    {
        public fMananageStaffs()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            DateofBirth = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewCheckBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            DateCreate = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnAdd = new Button();
            btnFind = new Button();
            txtFind = new TextBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, DateofBirth, Address, PhoneNumber, RoleID, Email, Password, DateCreate, Edit, Delete });
            dataGridView1.Location = new Point(46, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1356, 525);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "Staff ID";
            ID.MinimumWidth = 10;
            ID.Name = "ID";
            ID.Width = 200;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 10;
            FullName.Name = "FullName";
            FullName.Width = 200;
            // 
            // DateofBirth
            // 
            DateofBirth.HeaderText = "Date of Birth";
            DateofBirth.MinimumWidth = 10;
            DateofBirth.Name = "DateofBirth";
            DateofBirth.Width = 200;
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
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 10;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Width = 200;
            // 
            // RoleID
            // 
            RoleID.HeaderText = "Role";
            RoleID.MinimumWidth = 10;
            RoleID.Name = "RoleID";
            RoleID.Width = 200;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.Width = 200;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 10;
            Password.Name = "Password";
            Password.Width = 200;
            // 
            // DateCreate
            // 
            DateCreate.HeaderText = "First Working Day";
            DateCreate.MinimumWidth = 10;
            DateCreate.Name = "DateCreate";
            DateCreate.Width = 200;
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
            // btnAdd
            // 
            btnAdd.Location = new Point(62, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1252, 81);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(150, 46);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(839, 85);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(376, 39);
            txtFind.TabIndex = 4;
            // 
            // fMananageStaffs
            // 
            ClientSize = new Size(1576, 983);
            Controls.Add(txtFind);
            Controls.Add(btnFind);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "fMananageStaffs";
            Text = "Quản lý nhân viên";
            WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn DateofBirth;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewCheckBoxColumn RoleID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn DateCreate;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Button btnAdd;
        private Button btnFind;
        private TextBox txtFind;
    }
}
