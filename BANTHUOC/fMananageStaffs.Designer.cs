using System;
using System.Drawing; // Thêm namespace này để giải quyết sự mơ hồ của Font
using System.Windows.Forms;

namespace BANTHUOC
{
    public partial class fManageStaffs : Form
    {
        private System.ComponentModel.IContainer components = null;

        public fManageStaffs()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnContact = new Button();
            this.btnSales = new Button();
            this.btnManage = new Button();
            this.panelButtons = new Panel();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContact
            // 
            this.btnContact.FlatStyle = FlatStyle.Flat;
            this.btnContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnContact.Location = new Point(385, 0);
            this.btnContact.Margin = new Padding(4);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new Size(200, 50);
            this.btnContact.TabIndex = 2;
            this.btnContact.Text = "Liên hệ";
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.FlatStyle = FlatStyle.Flat;
            this.btnSales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnSales.Location = new Point(185, 0);
            this.btnSales.Margin = new Padding(4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new Size(200, 50);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Bán hàng";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.FlatStyle = FlatStyle.Flat;
            this.btnManage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.btnManage.Location = new Point(0, 0);
            this.btnManage.Margin = new Padding(4);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new Size(200, 50);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Quản lý";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.panelButtons.BackColor = Color.LightGray;
            this.panelButtons.Controls.Add(this.btnContact);
            this.panelButtons.Controls.Add(this.btnSales);
            this.panelButtons.Controls.Add(this.btnManage);
            this.panelButtons.Location = new Point(50, 335);
            this.panelButtons.Margin = new Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new Size(1000, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // fManageStaffs
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1100, 700);
            this.Controls.Add(this.panelButtons);
            this.Name = "fManageStaffs";
            this.Text = "Quản lý nhân viên";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Button btnContact;
        private Button btnSales;
        private Button btnManage;
        private Panel panelButtons;
    }
}
