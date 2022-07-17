namespace StockMarket
{
    partial class FindPasswordForm
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
            this.login_exit = new System.Windows.Forms.Button();
            this.find_pw = new System.Windows.Forms.Label();
            this.to_login = new System.Windows.Forms.Button();
            this.hint_check = new System.Windows.Forms.Label();
            this.hint_name = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.user_id_text = new System.Windows.Forms.TextBox();
            this.answer_text = new System.Windows.Forms.TextBox();
            this.combo_hint = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // login_exit
            // 
            this.login_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_exit.Location = new System.Drawing.Point(398, 7);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(24, 24);
            this.login_exit.TabIndex = 5;
            this.login_exit.Text = "X";
            this.login_exit.UseVisualStyleBackColor = true;
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // find_pw
            // 
            this.find_pw.AutoSize = true;
            this.find_pw.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.find_pw.Location = new System.Drawing.Point(2, 48);
            this.find_pw.Name = "find_pw";
            this.find_pw.Size = new System.Drawing.Size(429, 48);
            this.find_pw.TabIndex = 6;
            this.find_pw.Text = "FIND PASSWORD";
            // 
            // to_login
            // 
            this.to_login.Location = new System.Drawing.Point(187, 407);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(75, 23);
            this.to_login.TabIndex = 7;
            this.to_login.Text = "OK";
            this.to_login.UseVisualStyleBackColor = true;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // hint_check
            // 
            this.hint_check.AutoSize = true;
            this.hint_check.Location = new System.Drawing.Point(43, 277);
            this.hint_check.Name = "hint_check";
            this.hint_check.Size = new System.Drawing.Size(83, 15);
            this.hint_check.TabIndex = 8;
            this.hint_check.Text = "ANSWER : ";
            // 
            // hint_name
            // 
            this.hint_name.AutoSize = true;
            this.hint_name.Location = new System.Drawing.Point(74, 235);
            this.hint_name.Name = "hint_name";
            this.hint_name.Size = new System.Drawing.Size(52, 15);
            this.hint_name.TabIndex = 9;
            this.hint_name.Text = "HINT : ";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(47, 191);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(79, 15);
            this.user_id.TabIndex = 10;
            this.user_id.Text = "USER ID : ";
            // 
            // user_id_text
            // 
            this.user_id_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_id_text.Location = new System.Drawing.Point(132, 191);
            this.user_id_text.Name = "user_id_text";
            this.user_id_text.Size = new System.Drawing.Size(250, 18);
            this.user_id_text.TabIndex = 11;
            // 
            // answer_text
            // 
            this.answer_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answer_text.Location = new System.Drawing.Point(132, 277);
            this.answer_text.Name = "answer_text";
            this.answer_text.Size = new System.Drawing.Size(250, 18);
            this.answer_text.TabIndex = 12;
            // 
            // combo_hint
            // 
            this.combo_hint.FormattingEnabled = true;
            this.combo_hint.Location = new System.Drawing.Point(132, 232);
            this.combo_hint.Name = "combo_hint";
            this.combo_hint.Size = new System.Drawing.Size(250, 23);
            this.combo_hint.TabIndex = 13;
            this.combo_hint.Text = "SELECT THE HINT";
            // 
            // FindPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 580);
            this.Controls.Add(this.combo_hint);
            this.Controls.Add(this.answer_text);
            this.Controls.Add(this.user_id_text);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.hint_name);
            this.Controls.Add(this.hint_check);
            this.Controls.Add(this.to_login);
            this.Controls.Add(this.find_pw);
            this.Controls.Add(this.login_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindPasswordForm";
            this.Text = "FindPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_exit;
        private System.Windows.Forms.Label find_pw;
        private System.Windows.Forms.Button to_login;
        private System.Windows.Forms.Label hint_check;
        private System.Windows.Forms.Label hint_name;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.TextBox user_id_text;
        private System.Windows.Forms.TextBox answer_text;
        private System.Windows.Forms.ComboBox combo_hint;
    }
}