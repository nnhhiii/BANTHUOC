namespace BANTHUOC
{
    partial class fNewDrugCategory
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            toolTip1 = new ToolTip(components);
            btnClose = new Button();
            btnSave = new Button();
            txtDescription = new RichTextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(243, 227);
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 234);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 2;
            label1.Text = "Tên loại thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 302);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 3;
            label2.Text = "Mô tả";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(772, 345);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 55);
            btnClose.TabIndex = 58;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(617, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 55);
            btnSave.TabIndex = 57;
            btnSave.Text = "Lưu";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(243, 299);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(244, 101);
            txtDescription.TabIndex = 59;
            txtDescription.Text = "";
            // 
            // fNewDrugCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 450);
            Controls.Add(txtDescription);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "fNewDrugCategory";
            Text = "fNewDrugCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private ToolTip toolTip1;
        private Button btnClose;
        private Button btnSave;
        private RichTextBox txtDescription;
    }
}