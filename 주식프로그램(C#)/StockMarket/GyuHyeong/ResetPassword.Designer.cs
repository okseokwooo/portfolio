namespace StockMarket
{
    partial class ResetPassword
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
            this.to_login = new System.Windows.Forms.Button();
            this.reset_pw = new System.Windows.Forms.Label();
            this.reset_new_pw = new System.Windows.Forms.Label();
            this.reset_pw_check = new System.Windows.Forms.Label();
            this.reset_pw_text = new System.Windows.Forms.TextBox();
            this.reset_pw_check_text = new System.Windows.Forms.TextBox();
            this.reset_pw_redundancy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joinform_next_exit
            // 
            this.joinform_next_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinform_next_exit.Location = new System.Drawing.Point(305, 12);
            this.joinform_next_exit.Name = "joinform_next_exit";
            this.joinform_next_exit.Size = new System.Drawing.Size(24, 24);
            this.joinform_next_exit.TabIndex = 6;
            this.joinform_next_exit.Text = "X";
            this.joinform_next_exit.UseVisualStyleBackColor = true;
            this.joinform_next_exit.Click += new System.EventHandler(this.joinform_next_exit_Click);
            // 
            // to_login
            // 
            this.to_login.Location = new System.Drawing.Point(132, 209);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(75, 23);
            this.to_login.TabIndex = 7;
            this.to_login.Text = "OK";
            this.to_login.UseVisualStyleBackColor = true;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // reset_pw
            // 
            this.reset_pw.AutoSize = true;
            this.reset_pw.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.reset_pw.Location = new System.Drawing.Point(20, 47);
            this.reset_pw.Name = "reset_pw";
            this.reset_pw.Size = new System.Drawing.Size(299, 30);
            this.reset_pw.TabIndex = 8;
            this.reset_pw.Text = "RESET PASSWORD";
            // 
            // reset_new_pw
            // 
            this.reset_new_pw.AutoSize = true;
            this.reset_new_pw.Location = new System.Drawing.Point(74, 104);
            this.reset_new_pw.Name = "reset_new_pw";
            this.reset_new_pw.Size = new System.Drawing.Size(97, 15);
            this.reset_new_pw.TabIndex = 9;
            this.reset_new_pw.Text = "RESET PW : ";
            // 
            // reset_pw_check
            // 
            this.reset_pw_check.AutoSize = true;
            this.reset_pw_check.Location = new System.Drawing.Point(22, 144);
            this.reset_pw_check.Name = "reset_pw_check";
            this.reset_pw_check.Size = new System.Drawing.Size(149, 15);
            this.reset_pw_check.TabIndex = 10;
            this.reset_pw_check.Text = "RESET PW CHECK : ";
            // 
            // reset_pw_text
            // 
            this.reset_pw_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reset_pw_text.Location = new System.Drawing.Point(167, 101);
            this.reset_pw_text.Name = "reset_pw_text";
            this.reset_pw_text.Size = new System.Drawing.Size(100, 18);
            this.reset_pw_text.TabIndex = 11;
            this.reset_pw_text.UseSystemPasswordChar = true;
            // 
            // reset_pw_check_text
            // 
            this.reset_pw_check_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reset_pw_check_text.Location = new System.Drawing.Point(167, 144);
            this.reset_pw_check_text.Name = "reset_pw_check_text";
            this.reset_pw_check_text.Size = new System.Drawing.Size(100, 18);
            this.reset_pw_check_text.TabIndex = 12;
            this.reset_pw_check_text.UseSystemPasswordChar = true;
            this.reset_pw_check_text.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // reset_pw_redundancy
            // 
            this.reset_pw_redundancy.AutoSize = true;
            this.reset_pw_redundancy.Location = new System.Drawing.Point(164, 180);
            this.reset_pw_redundancy.Name = "reset_pw_redundancy";
            this.reset_pw_redundancy.Size = new System.Drawing.Size(0, 15);
            this.reset_pw_redundancy.TabIndex = 13;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 256);
            this.Controls.Add(this.reset_pw_redundancy);
            this.Controls.Add(this.reset_pw_check_text);
            this.Controls.Add(this.reset_pw_text);
            this.Controls.Add(this.reset_pw_check);
            this.Controls.Add(this.reset_new_pw);
            this.Controls.Add(this.reset_pw);
            this.Controls.Add(this.to_login);
            this.Controls.Add(this.joinform_next_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinform_next_exit;
        private System.Windows.Forms.Button to_login;
        private System.Windows.Forms.Label reset_pw;
        private System.Windows.Forms.Label reset_new_pw;
        private System.Windows.Forms.Label reset_pw_check;
        private System.Windows.Forms.TextBox reset_pw_text;
        private System.Windows.Forms.TextBox reset_pw_check_text;
        private System.Windows.Forms.Label reset_pw_redundancy;
    }
}