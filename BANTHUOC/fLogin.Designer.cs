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
            SuspendLayout();
            // 
            // cbPass
            // 
            cbPass.AutoSize = true;
            cbPass.Location = new Point(68, 305);
            cbPass.Margin = new Padding(2);
            cbPass.Name = "cbPass";
            cbPass.Size = new Size(132, 24);
            cbPass.TabIndex = 0;
            cbPass.Text = "Show Password";
            cbPass.UseVisualStyleBackColor = true;
            cbPass.CheckedChanged += cbPass_CheckedChanged;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(73, 351);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(107, 45);
            btLogin.TabIndex = 1;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(73, 94);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(73, 196);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(70, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(73, 140);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(242, 27);
            txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 249);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(242, 27);
            txtPassword.TabIndex = 6;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 464);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(lblUsername);
            Controls.Add(btLogin);
            Controls.Add(cbPass);
            Margin = new Padding(2);
            Name = "fLogin";
            Text = "Hehe Pharmacy";
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
    }
}