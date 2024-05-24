using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANTHUOC
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btlienhe = new Button();
            btbanhang = new Button();
            btquanly = new Button();
            pnpanel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btlienhe);
            panel1.Controls.Add(btbanhang);
            panel1.Controls.Add(btquanly);
            panel1.Location = new Point(-2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 27);
            panel1.TabIndex = 0;
            // 
            // btlienhe
            // 
            btlienhe.FlatStyle = FlatStyle.Flat;
            btlienhe.Location = new Point(175, 0);
            btlienhe.Margin = new Padding(2, 2, 2, 2);
            btlienhe.Name = "btlienhe";
            btlienhe.Size = new Size(90, 27);
            btlienhe.TabIndex = 2;
            btlienhe.Text = "Liên hệ";
            btlienhe.UseVisualStyleBackColor = true;
            btlienhe.Click += btlienhe_Click;
            // 
            // btbanhang
            // 
            btbanhang.FlatStyle = FlatStyle.Flat;
            btbanhang.Location = new Point(90, 0);
            btbanhang.Margin = new Padding(2, 2, 2, 2);
            btbanhang.Name = "btbanhang";
            btbanhang.Size = new Size(90, 27);
            btbanhang.TabIndex = 1;
            btbanhang.Text = "Bán hàng";
            btbanhang.UseVisualStyleBackColor = true;
            btbanhang.Click += btbanhang_Click;
            // 
            // btquanly
            // 
            btquanly.FlatStyle = FlatStyle.Flat;
            btquanly.Location = new Point(2, 0);
            btquanly.Margin = new Padding(2, 2, 2, 2);
            btquanly.Name = "btquanly";
            btquanly.Size = new Size(90, 27);
            btquanly.TabIndex = 0;
            btquanly.Text = "Quản lý";
            btquanly.UseVisualStyleBackColor = true;
            btquanly.Click += btquanly_Click;
            // 
            // pnpanel2
            // 
            pnpanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnpanel2.BackColor = SystemColors.ControlLight;
            pnpanel2.Location = new Point(1, 29);
            pnpanel2.Margin = new Padding(2, 2, 2, 2);
            pnpanel2.Name = "pnpanel2";
            pnpanel2.Size = new Size(639, 139);
            pnpanel2.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(pnpanel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "fMain";
            Text = "Quản lý hiệu thuốc";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btlienhe;
        private Button btbanhang;
        private Button btquanly;
        private Panel pnpanel2;
    }
}
