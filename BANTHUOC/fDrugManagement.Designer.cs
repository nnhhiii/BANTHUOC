﻿namespace BANTHUOC
{
    partial class fDrugManagement
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
            SuspendLayout();
            // 
            // cbDrugCategory
            // 
            cbDrugCategory.FormattingEnabled = true;
            cbDrugCategory.Location = new Point(1085, 193);
            cbDrugCategory.Name = "cbDrugCategory";
            cbDrugCategory.Size = new Size(179, 28);
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
            // fDrugManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 730);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbDrugCategory);
            Name = "fDrugManagement";
            Text = "fDrugManagement";
            WindowState = FormWindowState.Maximized;
            Activated += fDrugManagement_Activated;
            Load += fDrugManagement_Load;
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbDrugCategory;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}