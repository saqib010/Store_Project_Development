namespace Store
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernamelabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.text_password = new System.Windows.Forms.TextBox();
            this.text_username = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.pnl_change_pass = new System.Windows.Forms.Panel();
            this.btn_chng_pass_update = new System.Windows.Forms.Button();
            this.btn_chng_pass_back = new System.Windows.Forms.Button();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_change_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernamelabel.Location = new System.Drawing.Point(248, 157);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(79, 17);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "username";
            this.usernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Location = new System.Drawing.Point(248, 203);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(76, 17);
            this.password.TabIndex = 0;
            this.password.Text = "password";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(346, 200);
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '•';
            this.text_password.Size = new System.Drawing.Size(155, 20);
            this.text_password.TabIndex = 1;
            // 
            // text_username
            // 
            this.text_username.Location = new System.Drawing.Point(346, 157);
            this.text_username.Name = "text_username";
            this.text_username.Size = new System.Drawing.Size(155, 20);
            this.text_username.TabIndex = 1;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(251, 270);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(95, 33);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Clear";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(369, 270);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(95, 33);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Login";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(323, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 59);
            this.label1.TabIndex = 15;
            this.label1.Text = "LOGIN";
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_change_pass.Location = new System.Drawing.Point(488, 270);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(126, 33);
            this.btn_change_pass.TabIndex = 16;
            this.btn_change_pass.Text = "Change Password";
            this.btn_change_pass.UseVisualStyleBackColor = true;
            this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
            // 
            // pnl_change_pass
            // 
            this.pnl_change_pass.Controls.Add(this.btn_chng_pass_update);
            this.pnl_change_pass.Controls.Add(this.btn_chng_pass_back);
            this.pnl_change_pass.Controls.Add(this.txt_newpass);
            this.pnl_change_pass.Controls.Add(this.label5);
            this.pnl_change_pass.Controls.Add(this.label2);
            this.pnl_change_pass.Controls.Add(this.txt_user);
            this.pnl_change_pass.Controls.Add(this.txt_oldpass);
            this.pnl_change_pass.Controls.Add(this.label3);
            this.pnl_change_pass.Controls.Add(this.label4);
            this.pnl_change_pass.Location = new System.Drawing.Point(92, 23);
            this.pnl_change_pass.Name = "pnl_change_pass";
            this.pnl_change_pass.Size = new System.Drawing.Size(535, 354);
            this.pnl_change_pass.TabIndex = 17;
            // 
            // btn_chng_pass_update
            // 
            this.btn_chng_pass_update.Location = new System.Drawing.Point(205, 267);
            this.btn_chng_pass_update.Name = "btn_chng_pass_update";
            this.btn_chng_pass_update.Size = new System.Drawing.Size(95, 33);
            this.btn_chng_pass_update.TabIndex = 33;
            this.btn_chng_pass_update.Text = "Update";
            this.btn_chng_pass_update.UseVisualStyleBackColor = true;
            this.btn_chng_pass_update.Click += new System.EventHandler(this.btn_chng_pass_update_Click);
            // 
            // btn_chng_pass_back
            // 
            this.btn_chng_pass_back.Location = new System.Drawing.Point(323, 267);
            this.btn_chng_pass_back.Name = "btn_chng_pass_back";
            this.btn_chng_pass_back.Size = new System.Drawing.Size(95, 33);
            this.btn_chng_pass_back.TabIndex = 32;
            this.btn_chng_pass_back.Text = "Back";
            this.btn_chng_pass_back.UseVisualStyleBackColor = true;
            this.btn_chng_pass_back.Click += new System.EventHandler(this.btn_chng_pass_back_Click);
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(254, 205);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.PasswordChar = '•';
            this.txt_newpass.Size = new System.Drawing.Size(155, 20);
            this.txt_newpass.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(127, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "new password";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(76, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 59);
            this.label2.TabIndex = 29;
            this.label2.Text = "Change Password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(254, 117);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(155, 20);
            this.txt_user.TabIndex = 27;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(254, 160);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.PasswordChar = '•';
            this.txt_oldpass.Size = new System.Drawing.Size(155, 20);
            this.txt_oldpass.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(127, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "old password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(151, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_change_pass);
            this.Controls.Add(this.btn_change_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.text_username);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernamelabel);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnl_change_pass.ResumeLayout(false);
            this.pnl_change_pass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.TextBox text_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button btn_change_pass;
        private System.Windows.Forms.Panel pnl_change_pass;
        private System.Windows.Forms.Button btn_chng_pass_update;
        private System.Windows.Forms.Button btn_chng_pass_back;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

