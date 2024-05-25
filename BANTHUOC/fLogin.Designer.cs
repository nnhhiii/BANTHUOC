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
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // cbPass
            // 
            cbPass.AutoSize = true;
            cbPass.Location = new Point(110, 488);
            cbPass.Name = "cbPass";
            cbPass.Size = new Size(208, 36);
            cbPass.TabIndex = 0;
            cbPass.Text = "Show Password";
            cbPass.UseVisualStyleBackColor = true;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(118, 562);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(174, 72);
            btLogin.TabIndex = 1;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(118, 150);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 32);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(118, 313);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(111, 32);
            lblPass.TabIndex = 4;
            lblPass.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(118, 224);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(391, 39);
            txtUsername.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(118, 399);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(391, 39);
            txtPass.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 743);
            Controls.Add(txtPass);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(lblUsername);
            Controls.Add(btLogin);
            Controls.Add(cbPass);
            Name = "Login";
            Text = "Hehe Pharmacy";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbPass;
        private Button btLogin;
        private Label lblUsername;
        private Label lblPass;
        private TextBox txtUsername;
        private TextBox txtPass;
    }
}