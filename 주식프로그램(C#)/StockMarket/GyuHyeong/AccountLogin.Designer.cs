namespace StockMarket
{
    partial class AccountLogin
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
            this.joinform_next_exit = new System.Windows.Forms.Button();
            this.account_login = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.account_pw = new System.Windows.Forms.Label();
            this.myaccount = new System.Windows.Forms.Label();
            this.account_password = new System.Windows.Forms.TextBox();
            this.login_account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joinform_next_exit
            // 
            this.joinform_next_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinform_next_exit.Location = new System.Drawing.Point(437, 12);
            this.joinform_next_exit.Name = "joinform_next_exit";
            this.joinform_next_exit.Size = new System.Drawing.Size(24, 24);
            this.joinform_next_exit.TabIndex = 6;
            this.joinform_next_exit.Text = "X";
            this.joinform_next_exit.UseVisualStyleBackColor = true;
            this.joinform_next_exit.Click += new System.EventHandler(this.joinform_next_exit_Click);
            // 
            // account_login
            // 
            this.account_login.AutoSize = true;
            this.account_login.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.account_login.Location = new System.Drawing.Point(21, 49);
            this.account_login.Name = "account_login";
            this.account_login.Size = new System.Drawing.Size(428, 48);
            this.account_login.TabIndex = 7;
            this.account_login.Text = "ACCOUNT LOGIN";
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.account.Location = new System.Drawing.Point(85, 181);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(150, 15);
            this.account.TabIndex = 8;
            this.account.Text = "YOUR ACCOUNT : ";
            // 
            // account_pw
            // 
            this.account_pw.AutoSize = true;
            this.account_pw.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.account_pw.Location = new System.Drawing.Point(36, 227);
            this.account_pw.Name = "account_pw";
            this.account_pw.Size = new System.Drawing.Size(199, 15);
            this.account_pw.TabIndex = 9;
            this.account_pw.Text = "ACCOUNT PASSWORD : ";
            // 
            // myaccount
            // 
            this.myaccount.AutoSize = true;
            this.myaccount.Location = new System.Drawing.Point(238, 181);
            this.myaccount.Name = "myaccount";
            this.myaccount.Size = new System.Drawing.Size(14, 15);
            this.myaccount.TabIndex = 10;
            this.myaccount.Text = "*";
            // 
            // account_password
            // 
            this.account_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.account_password.Location = new System.Drawing.Point(241, 224);
            this.account_password.Name = "account_password";
            this.account_password.PasswordChar = '*';
            this.account_password.Size = new System.Drawing.Size(100, 18);
            this.account_password.TabIndex = 11;
            // 
            // login_account
            // 
            this.login_account.Location = new System.Drawing.Point(201, 274);
            this.login_account.Name = "login_account";
            this.login_account.Size = new System.Drawing.Size(75, 23);
            this.login_account.TabIndex = 12;
            this.login_account.Text = "LOGIN";
            this.login_account.UseVisualStyleBackColor = true;
            this.login_account.Click += new System.EventHandler(this.login_account_Click);
            // 
            // AccountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.login_account);
            this.Controls.Add(this.account_password);
            this.Controls.Add(this.myaccount);
            this.Controls.Add(this.account_pw);
            this.Controls.Add(this.account);
            this.Controls.Add(this.account_login);
            this.Controls.Add(this.joinform_next_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountLogin";
            this.Text = "AccountLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinform_next_exit;
        private System.Windows.Forms.Label account_login;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label account_pw;
        private System.Windows.Forms.Label myaccount;
        private System.Windows.Forms.TextBox account_password;
        private System.Windows.Forms.Button login_account;
    }
}