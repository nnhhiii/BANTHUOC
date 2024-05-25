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
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(984, 660);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 19;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(786, 660);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 18;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(391, 277);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(369, 39);
            txtDescription.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(391, 408);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(369, 39);
            txtAddress.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(391, 534);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(369, 39);
            txtPhoneNumber.TabIndex = 15;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(181, 534);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(156, 32);
            lblPhoneNumber.TabIndex = 14;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(181, 277);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(77, 32);
            lblDescription.TabIndex = 13;
            lblDescription.Text = "Mô tả";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(181, 408);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 32);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Địa chỉ";
            // 
            // txtName
            // 
            txtName.Location = new Point(391, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(369, 39);
            txtName.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(181, 156);
            lblName.Name = "lblName";
            lblName.Size = new Size(203, 32);
            lblName.TabIndex = 10;
            lblName.Text = "Tên nhà cung cấp";
            // 
            // fEditSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 855);
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
            Name = "fEditSupplier";
            Text = "Sửa đổi nhà cung cấp";
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
    }
}