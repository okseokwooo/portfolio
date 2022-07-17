namespace StockMarket
{
    partial class FindIDForm
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
            this.schoolnum_id_find = new System.Windows.Forms.Label();
            this.studentname_id_find = new System.Windows.Forms.Label();
            this.username_id_find = new System.Windows.Forms.Label();
            this.studentnum_text = new System.Windows.Forms.TextBox();
            this.schoolname_text = new System.Windows.Forms.TextBox();
            this.username_text = new System.Windows.Forms.TextBox();
            this.id_found = new System.Windows.Forms.Label();
            this.login_exit = new System.Windows.Forms.Button();
            this.to_login = new System.Windows.Forms.Button();
            this.find_id = new System.Windows.Forms.Label();
            this.search_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // schoolnum_id_find
            // 
            this.schoolnum_id_find.AutoSize = true;
            this.schoolnum_id_find.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.schoolnum_id_find.Location = new System.Drawing.Point(39, 150);
            this.schoolnum_id_find.Name = "schoolnum_id_find";
            this.schoolnum_id_find.Size = new System.Drawing.Size(168, 15);
            this.schoolnum_id_find.TabIndex = 0;
            this.schoolnum_id_find.Text = "STUDENT NUMBER : ";
            // 
            // studentname_id_find
            // 
            this.studentname_id_find.AutoSize = true;
            this.studentname_id_find.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentname_id_find.Location = new System.Drawing.Point(64, 205);
            this.studentname_id_find.Name = "studentname_id_find";
            this.studentname_id_find.Size = new System.Drawing.Size(142, 15);
            this.studentname_id_find.TabIndex = 1;
            this.studentname_id_find.Text = "SCHOOL NAME : ";
            // 
            // username_id_find
            // 
            this.username_id_find.AutoSize = true;
            this.username_id_find.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.username_id_find.Location = new System.Drawing.Point(87, 258);
            this.username_id_find.Name = "username_id_find";
            this.username_id_find.Size = new System.Drawing.Size(117, 15);
            this.username_id_find.TabIndex = 2;
            this.username_id_find.Text = "USER NAME : ";
            // 
            // studentnum_text
            // 
            this.studentnum_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentnum_text.Location = new System.Drawing.Point(198, 150);
            this.studentnum_text.Name = "studentnum_text";
            this.studentnum_text.Size = new System.Drawing.Size(100, 18);
            this.studentnum_text.TabIndex = 3;
            // 
            // schoolname_text
            // 
            this.schoolname_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schoolname_text.Location = new System.Drawing.Point(198, 202);
            this.schoolname_text.Name = "schoolname_text";
            this.schoolname_text.Size = new System.Drawing.Size(100, 18);
            this.schoolname_text.TabIndex = 4;
            // 
            // username_text
            // 
            this.username_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_text.Location = new System.Drawing.Point(198, 258);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 18);
            this.username_text.TabIndex = 5;
            // 
            // id_found
            // 
            this.id_found.AutoSize = true;
            this.id_found.Location = new System.Drawing.Point(195, 345);
            this.id_found.Name = "id_found";
            this.id_found.Size = new System.Drawing.Size(14, 15);
            this.id_found.TabIndex = 6;
            this.id_found.Text = "*";
            // 
            // login_exit
            // 
            this.login_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_exit.Location = new System.Drawing.Point(398, 7);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(24, 24);
            this.login_exit.TabIndex = 7;
            this.login_exit.Text = "X";
            this.login_exit.UseVisualStyleBackColor = true;
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // to_login
            // 
            this.to_login.Location = new System.Drawing.Point(168, 384);
            this.to_login.Name = "to_login";
            this.to_login.Size = new System.Drawing.Size(75, 23);
            this.to_login.TabIndex = 8;
            this.to_login.Text = "OK";
            this.to_login.UseVisualStyleBackColor = true;
            this.to_login.Click += new System.EventHandler(this.to_login_Click);
            // 
            // find_id
            // 
            this.find_id.AutoSize = true;
            this.find_id.Font = new System.Drawing.Font("굴림", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.find_id.Location = new System.Drawing.Point(105, 47);
            this.find_id.Name = "find_id";
            this.find_id.Size = new System.Drawing.Size(202, 48);
            this.find_id.TabIndex = 9;
            this.find_id.Text = "FIND ID";
            // 
            // search_id
            // 
            this.search_id.Location = new System.Drawing.Point(168, 306);
            this.search_id.Name = "search_id";
            this.search_id.Size = new System.Drawing.Size(75, 23);
            this.search_id.TabIndex = 10;
            this.search_id.Text = "SEARCH";
            this.search_id.UseVisualStyleBackColor = true;
            this.search_id.Click += new System.EventHandler(this.search_id_Click);
            // 
            // FindIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 580);
            this.Controls.Add(this.search_id);
            this.Controls.Add(this.find_id);
            this.Controls.Add(this.to_login);
            this.Controls.Add(this.login_exit);
            this.Controls.Add(this.id_found);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.schoolname_text);
            this.Controls.Add(this.studentnum_text);
            this.Controls.Add(this.username_id_find);
            this.Controls.Add(this.studentname_id_find);
            this.Controls.Add(this.schoolnum_id_find);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindIDForm";
            this.Text = "FindIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schoolnum_id_find;
        private System.Windows.Forms.Label studentname_id_find;
        private System.Windows.Forms.Label username_id_find;
        private System.Windows.Forms.TextBox studentnum_text;
        private System.Windows.Forms.TextBox schoolname_text;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label id_found;
        private System.Windows.Forms.Button login_exit;
        private System.Windows.Forms.Button to_login;
        private System.Windows.Forms.Label find_id;
        private System.Windows.Forms.Button search_id;
    }
}