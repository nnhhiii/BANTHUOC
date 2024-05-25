namespace BANTHUOC
{
    partial class fNewSupplier
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
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            lblDescription = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(123, 207);
            lblName.Name = "lblName";
            lblName.Size = new Size(203, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Tên nhà cung cấp";
            // 
            // txtName
            // 
            txtName.Location = new Point(333, 200);
            txtName.Name = "txtName";
            txtName.Size = new Size(369, 39);
            txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(123, 459);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 32);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(123, 328);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(77, 32);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Mô tả";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(123, 585);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(156, 32);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(333, 585);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(369, 39);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(333, 459);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(369, 39);
            txtAddress.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(333, 328);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(369, 39);
            txtDescription.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(728, 711);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(926, 711);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 46);
            btnClose.TabIndex = 9;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // fNewSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 851);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblDescription);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "fNewSupplier";
            Text = "Thêm mới nhà cung cấp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblAddress;
        private Label lblDescription;
        private Label lblPhoneNumber;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnClose;
    }
}