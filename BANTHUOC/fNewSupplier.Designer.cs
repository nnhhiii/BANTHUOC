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
            components = new System.ComponentModel.Container();
            lblName = new Label();
            txtName = new TextBox();
            lblAddress = new Label();
            lblDescription = new Label();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            thoat = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(72, 225);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Tên nhà cung cấp";
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 221);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(72, 383);
            lblAddress.Margin = new Padding(2, 0, 2, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(55, 20);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Địa chỉ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(72, 301);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(48, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Mô tả";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(72, 462);
            lblPhoneNumber.Margin = new Padding(2, 0, 2, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(97, 20);
            lblPhoneNumber.TabIndex = 4;
            lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(201, 462);
            txtPhoneNumber.Margin = new Padding(2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(229, 27);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(201, 383);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(229, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(201, 301);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(229, 27);
            txtDescription.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
            btnSave.Image = Properties.Resources.savebtn;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(493, 542);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 51);
            btnSave.TabIndex = 94;
            btnSave.Text = "Lưu";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // thoat
            // 
            thoat.BackgroundImage = Properties.Resources.thoat;
            thoat.BackgroundImageLayout = ImageLayout.Zoom;
            thoat.Location = new Point(637, 542);
            thoat.Margin = new Padding(2);
            thoat.Name = "thoat";
            thoat.Size = new Size(99, 51);
            thoat.TabIndex = 93;
            thoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            thoat.UseVisualStyleBackColor = true;
            thoat.Click += thoat_Click;
            // 
            // fNewSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 894);
            Controls.Add(btnSave);
            Controls.Add(thoat);
            Controls.Add(txtDescription);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblDescription);
            Controls.Add(lblAddress);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(2);
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
        private Button btnSave;
        private Button thoat;
        private ToolTip toolTip1;
    }
}