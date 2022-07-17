namespace StockMarket
{
    partial class JoinForm
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
            this.next_join = new System.Windows.Forms.Button();
            this.join_in = new System.Windows.Forms.Label();
            this.join_id = new System.Windows.Forms.Label();
            this.pw_join = new System.Windows.Forms.Label();
            this.name_join = new System.Windows.Forms.Label();
            this.pw_check_join = new System.Windows.Forms.Label();
            this.pw_account_join = new System.Windows.Forms.Label();
            this.pw_account_check_join = new System.Windows.Forms.Label();
            this.join_exit = new System.Windows.Forms.Button();
            this.id_redundancy = new System.Windows.Forms.Button();
            this.name_text_join = new System.Windows.Forms.TextBox();
            this.id_text_join = new System.Windows.Forms.TextBox();
            this.pw_text_join = new System.Windows.Forms.TextBox();
            this.pw_check_text_join = new System.Windows.Forms.TextBox();
            this.pw_account_text_join = new System.Windows.Forms.TextBox();
            this.pw_account_check_text_join = new System.Windows.Forms.TextBox();
            this.pw_check_redundancy = new System.Windows.Forms.Label();
            this.pw_account_check_redundancy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next_join
            // 
            this.next_join.Location = new System.Drawing.Point(154, 366);
            this.next_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next_join.Name = "next_join";
            this.next_join.Size = new System.Drawing.Size(66, 18);
            this.next_join.TabIndex = 0;
            this.next_join.Text = "NEXT";
            this.next_join.UseVisualStyleBackColor = true;
            this.next_join.Click += new System.EventHandler(this.button1_Click);
            // 
            // join_in
            // 
            this.join_in.AutoSize = true;
            this.join_in.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_in.Location = new System.Drawing.Point(70, 14);
            this.join_in.Name = "join_in";
            this.join_in.Size = new System.Drawing.Size(198, 48);
            this.join_in.TabIndex = 1;
            this.join_in.Text = "JOIN IN";
            // 
            // join_id
            // 
            this.join_id.AutoSize = true;
            this.join_id.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_id.Location = new System.Drawing.Point(138, 151);
            this.join_id.Name = "join_id";
            this.join_id.Size = new System.Drawing.Size(33, 12);
            this.join_id.TabIndex = 2;
            this.join_id.Text = "ID : ";
            // 
            // pw_join
            // 
            this.pw_join.AutoSize = true;
            this.pw_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_join.Location = new System.Drawing.Point(70, 190);
            this.pw_join.Name = "pw_join";
            this.pw_join.Size = new System.Drawing.Size(95, 12);
            this.pw_join.TabIndex = 3;
            this.pw_join.Text = "PASSWORD : ";
            // 
            // name_join
            // 
            this.name_join.AutoSize = true;
            this.name_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_join.Location = new System.Drawing.Point(116, 120);
            this.name_join.Name = "name_join";
            this.name_join.Size = new System.Drawing.Size(60, 12);
            this.name_join.TabIndex = 4;
            this.name_join.Text = "NAME : ";
            // 
            // pw_check_join
            // 
            this.pw_check_join.AutoSize = true;
            this.pw_check_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_check_join.Location = new System.Drawing.Point(22, 229);
            this.pw_check_join.Name = "pw_check_join";
            this.pw_check_join.Size = new System.Drawing.Size(147, 12);
            this.pw_check_join.TabIndex = 5;
            this.pw_check_join.Text = "PASSWORD CHECK : ";
            // 
            // pw_account_join
            // 
            this.pw_account_join.AutoSize = true;
            this.pw_account_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_account_join.Location = new System.Drawing.Point(2, 266);
            this.pw_account_join.Name = "pw_account_join";
            this.pw_account_join.Size = new System.Drawing.Size(167, 12);
            this.pw_account_join.TabIndex = 6;
            this.pw_account_join.Text = "ACCOUNT PASSWORD : ";
            // 
            // pw_account_check_join
            // 
            this.pw_account_check_join.AutoSize = true;
            this.pw_account_check_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_account_check_join.Location = new System.Drawing.Point(7, 302);
            this.pw_account_check_join.Name = "pw_account_check_join";
            this.pw_account_check_join.Size = new System.Drawing.Size(164, 12);
            this.pw_account_check_join.TabIndex = 7;
            this.pw_account_check_join.Text = "ACCOUNT PW CHECK : ";
            // 
            // join_exit
            // 
            this.join_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_exit.Location = new System.Drawing.Point(348, 6);
            this.join_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_exit.Name = "join_exit";
            this.join_exit.Size = new System.Drawing.Size(21, 19);
            this.join_exit.TabIndex = 8;
            this.join_exit.Text = "X";
            this.join_exit.UseVisualStyleBackColor = true;
            this.join_exit.Click += new System.EventHandler(this.join_exit_Click);
            // 
            // id_redundancy
            // 
            this.id_redundancy.Location = new System.Drawing.Point(284, 148);
            this.id_redundancy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_redundancy.Name = "id_redundancy";
            this.id_redundancy.Size = new System.Drawing.Size(71, 18);
            this.id_redundancy.TabIndex = 9;
            this.id_redundancy.Text = "ID CHECK";
            this.id_redundancy.UseVisualStyleBackColor = true;
            this.id_redundancy.Click += new System.EventHandler(this.id_redundancy_Click);
            // 
            // name_text_join
            // 
            this.name_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_text_join.Location = new System.Drawing.Point(174, 120);
            this.name_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_text_join.Name = "name_text_join";
            this.name_text_join.Size = new System.Drawing.Size(88, 14);
            this.name_text_join.TabIndex = 10;
            this.name_text_join.TextChanged += new System.EventHandler(this.name_text_join_TextChanged);
            // 
            // id_text_join
            // 
            this.id_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_text_join.Location = new System.Drawing.Point(174, 151);
            this.id_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_text_join.Name = "id_text_join";
            this.id_text_join.Size = new System.Drawing.Size(88, 14);
            this.id_text_join.TabIndex = 11;
            this.id_text_join.TextChanged += new System.EventHandler(this.id_text_join_TextChanged_1);
            // 
            // pw_text_join
            // 
            this.pw_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_text_join.Location = new System.Drawing.Point(174, 190);
            this.pw_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_text_join.Name = "pw_text_join";
            this.pw_text_join.PasswordChar = '*';
            this.pw_text_join.Size = new System.Drawing.Size(88, 14);
            this.pw_text_join.TabIndex = 12;
            this.pw_text_join.TextChanged += new System.EventHandler(this.pw_text_join_TextChanged);
            // 
            // pw_check_text_join
            // 
            this.pw_check_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_check_text_join.Location = new System.Drawing.Point(174, 229);
            this.pw_check_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_check_text_join.Name = "pw_check_text_join";
            this.pw_check_text_join.PasswordChar = '*';
            this.pw_check_text_join.Size = new System.Drawing.Size(88, 14);
            this.pw_check_text_join.TabIndex = 13;
            this.pw_check_text_join.TextChanged += new System.EventHandler(this.pw_chek_text_join_TextChanged);
            // 
            // pw_account_text_join
            // 
            this.pw_account_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_account_text_join.Location = new System.Drawing.Point(174, 266);
            this.pw_account_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_account_text_join.Name = "pw_account_text_join";
            this.pw_account_text_join.PasswordChar = '*';
            this.pw_account_text_join.Size = new System.Drawing.Size(88, 14);
            this.pw_account_text_join.TabIndex = 14;
            this.pw_account_text_join.TextChanged += new System.EventHandler(this.pw_account_text_join_TextChanged);
            // 
            // pw_account_check_text_join
            // 
            this.pw_account_check_text_join.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_account_check_text_join.Location = new System.Drawing.Point(174, 302);
            this.pw_account_check_text_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_account_check_text_join.Name = "pw_account_check_text_join";
            this.pw_account_check_text_join.PasswordChar = '*';
            this.pw_account_check_text_join.Size = new System.Drawing.Size(88, 14);
            this.pw_account_check_text_join.TabIndex = 15;
            this.pw_account_check_text_join.TextChanged += new System.EventHandler(this.pw_account_check_text_join_TextChanged);
            // 
            // pw_check_redundancy
            // 
            this.pw_check_redundancy.AutoSize = true;
            this.pw_check_redundancy.Location = new System.Drawing.Point(172, 249);
            this.pw_check_redundancy.Name = "pw_check_redundancy";
            this.pw_check_redundancy.Size = new System.Drawing.Size(0, 12);
            this.pw_check_redundancy.TabIndex = 16;
            // 
            // pw_account_check_redundancy
            // 
            this.pw_account_check_redundancy.AutoSize = true;
            this.pw_account_check_redundancy.Location = new System.Drawing.Point(172, 322);
            this.pw_account_check_redundancy.Name = "pw_account_check_redundancy";
            this.pw_account_check_redundancy.Size = new System.Drawing.Size(0, 12);
            this.pw_account_check_redundancy.TabIndex = 17;
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 464);
            this.Controls.Add(this.pw_account_check_redundancy);
            this.Controls.Add(this.pw_check_redundancy);
            this.Controls.Add(this.pw_account_check_text_join);
            this.Controls.Add(this.pw_account_text_join);
            this.Controls.Add(this.pw_check_text_join);
            this.Controls.Add(this.pw_text_join);
            this.Controls.Add(this.id_text_join);
            this.Controls.Add(this.name_text_join);
            this.Controls.Add(this.id_redundancy);
            this.Controls.Add(this.join_exit);
            this.Controls.Add(this.pw_account_check_join);
            this.Controls.Add(this.pw_account_join);
            this.Controls.Add(this.pw_check_join);
            this.Controls.Add(this.name_join);
            this.Controls.Add(this.pw_join);
            this.Controls.Add(this.join_id);
            this.Controls.Add(this.join_in);
            this.Controls.Add(this.next_join);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinForm";
            this.Text = "Join In";
            this.Load += new System.EventHandler(this.JoinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next_join;
        private System.Windows.Forms.Label join_in;
        private System.Windows.Forms.Label join_id;
        private System.Windows.Forms.Label pw_join;
        private System.Windows.Forms.Label name_join;
        private System.Windows.Forms.Label pw_check_join;
        private System.Windows.Forms.Label pw_account_join;
        private System.Windows.Forms.Label pw_account_check_join;
        private System.Windows.Forms.Button join_exit;
        private System.Windows.Forms.Button id_redundancy;
        private System.Windows.Forms.TextBox name_text_join;
        private System.Windows.Forms.TextBox id_text_join;
        private System.Windows.Forms.TextBox pw_text_join;
        private System.Windows.Forms.TextBox pw_check_text_join;
        private System.Windows.Forms.TextBox pw_account_text_join;
        private System.Windows.Forms.TextBox pw_account_check_text_join;
        private System.Windows.Forms.Label pw_check_redundancy;
        private System.Windows.Forms.Label pw_account_check_redundancy;
    }
}