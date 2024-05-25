namespace BANTHUOC
{
    partial class fEditDrugCategory
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
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(671, 269);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(506, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Cập nhật";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 368);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 278);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên loại thuốc";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(299, 368);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(125, 27);
            txtDescription.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(299, 271);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 6;
            // 
            // fEditDrugCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Name = "fEditDrugCategory";
            Text = "Sửa loại thuốc";
            Load += fEditDrugCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtName;
        private ToolTip toolTip1;
    }
}