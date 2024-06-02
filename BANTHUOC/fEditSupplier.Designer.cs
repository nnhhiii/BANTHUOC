namespace BANTHUOC
{
    partial class fEditSupplier
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
            components = new System.ComponentModel.Container();
            btnClose = new Button();
            btnSave = new Button();
            txtDescription = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            lblDescription = new Label();
            lblAddress = new Label();
            txtName = new TextBox();
            lblName = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(578, 522);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 29);
            btnClose.TabIndex = 19;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(456, 522);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(213, 283);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 27);
            txtDescription.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(213, 365);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(213, 444);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(229, 27);
            txtPhoneNumber.TabIndex = 15;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(83, 444);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(97, 20);
            lblPhoneNumber.TabIndex = 14;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(83, 283);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 20);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Mô tả";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(83, 365);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 20);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtName
            // 
            txtName.Location = new Point(213, 203);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(83, 208);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Tên nhà cung cấp";
            // 
            // fEditSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 599);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblDescription);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(2);
            Name = "fEditSupplier";
            Text = "Sửa đổi nhà cung cấp";
            Load += fEditSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private TextBox txtDescription;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblDescription;
        private Label lblAddress;
        private TextBox txtName;
        private Label lblName;
        private ToolTip toolTip1;
    }
}