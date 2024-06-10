namespace BANTHUOC
{
    partial class fManageDrug
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
            cbDrugCategory = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            label1 = new Label();
            txtName = new TextBox();
            lblFind = new Label();
            btnFind = new Button();
            SuspendLayout();
            // 
            // cbDrugCategory
            // 
            cbDrugCategory.FormattingEnabled = true;
            cbDrugCategory.Location = new Point(289, 251);
            cbDrugCategory.Name = "cbDrugCategory";
            cbDrugCategory.Size = new Size(208, 28);
            cbDrugCategory.TabIndex = 1;
            cbDrugCategory.SelectedIndexChanged += cbDrugCategory_SelectedIndexChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 315);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1900, 650);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(35, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 64);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Nhập mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(518, 167);
            label1.Name = "label1";
            label1.Size = new Size(218, 35);
            label1.TabIndex = 12;
            label1.Text = "QUẢN LÝ THUỐC";
            // 
            // txtName
            // 
            txtName.Location = new Point(996, 244);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 27);
            txtName.TabIndex = 17;
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(864, 251);
            lblFind.Margin = new Padding(2, 0, 2, 0);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(86, 20);
            lblFind.TabIndex = 16;
            lblFind.Text = "Nhập thuốc";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(1193, 239);
            btnFind.Margin = new Padding(2);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(102, 37);
            btnFind.TabIndex = 15;
            btnFind.Text = "Tìm kiếm";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // fManageDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 730);
            Controls.Add(txtName);
            Controls.Add(lblFind);
            Controls.Add(btnFind);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbDrugCategory);
            Name = "fManageDrug";
            Text = "fDrugManagement";
            WindowState = FormWindowState.Maximized;
            Activated += fDrugManagement_Activated;
            Load += fDrugManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbDrugCategory;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Label label1;
        private TextBox txtName;
        private Label lblFind;
        private Button btnFind;
    }
}