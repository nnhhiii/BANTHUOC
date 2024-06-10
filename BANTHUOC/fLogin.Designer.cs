namespace BANTHUOC
{
    partial class fLogin
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
            cbPass = new CheckBox();
            btLogin = new Button();
            lblUsername = new Label();
            lblPass = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbPass
            // 
            cbPass.AutoSize = true;
            cbPass.Location = new Point(127, 294);
            cbPass.Margin = new Padding(2);
            cbPass.Name = "cbPass";
            cbPass.Size = new Size(148, 24);
            cbPass.TabIndex = 0;
            cbPass.Text = "Hiển thị mật khẩu";
            cbPass.UseVisualStyleBackColor = true;
            cbPass.CheckedChanged += cbPass_CheckedChanged;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.SeaGreen;
            btLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(127, 354);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(295, 54);
            btLogin.TabIndex = 1;
            btLogin.Text = "Đăng Nhập";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(132, 107);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(129, 23);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Tên Đăng Nhập";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 10F);
            lblPass.ForeColor = Color.FromArgb(64, 64, 64);
            lblPass.Location = new Point(132, 198);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(82, 23);
            lblPass.TabIndex = 4;
            lblPass.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(132, 138);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(242, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(132, 229);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(106, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 42);
            label1.TabIndex = 7;
            label1.Text = "Pharmacity Store";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(562, 464);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(lblUsername);
            Controls.Add(btLogin);
            Controls.Add(cbPass);
            Margin = new Padding(2);
            Name = "fLogin";
            Text = "HIỆU THUỐC PHAMARCITY";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbPass;
        private Button btLogin;
        private Label lblUsername;
        private Label lblPass;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
    }
}