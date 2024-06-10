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
            toolTip1 = new ToolTip(components);
            txtDescription = new RichTextBox();
            btnClose = new Button();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(247, 284);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(244, 101);
            txtDescription.TabIndex = 65;
            txtDescription.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(776, 330);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 55);
            btnClose.TabIndex = 64;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(621, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 55);
            btnSave.TabIndex = 63;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 287);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 62;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 219);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 61;
            label1.Text = "Tên loại thuốc";
            // 
            // txtName
            // 
            txtName.Location = new Point(247, 212);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 60;
            // 
            // fEditDrugCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 450);
            Controls.Add(txtDescription);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "fEditDrugCategory";
            Text = "Sửa loại thuốc";
            Load += fEditDrugCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip1;
        private RichTextBox txtDescription;
        private Button btnClose;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox txtName;
    }
}