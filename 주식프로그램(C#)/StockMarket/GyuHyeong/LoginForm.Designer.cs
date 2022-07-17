namespace StockMarket
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.join_button = new System.Windows.Forms.Button();
            this.stock_market = new System.Windows.Forms.Label();
            this.id_login = new System.Windows.Forms.Label();
            this.pw_login = new System.Windows.Forms.Label();
            this.login_exit = new System.Windows.Forms.Button();
            this.id_text = new System.Windows.Forms.TextBox();
            this.pw_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.pw_find = new System.Windows.Forms.Button();
            this.id_find = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // join_button
            // 
            this.join_button.Location = new System.Drawing.Point(113, 371);
            this.join_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_button.Name = "join_button";
            this.join_button.Size = new System.Drawing.Size(148, 18);
            this.join_button.TabIndex = 0;
            this.join_button.Text = "Join In!";
            this.join_button.UseVisualStyleBackColor = true;
            this.join_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // stock_market
            // 
            this.stock_market.AutoSize = true;
            this.stock_market.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stock_market.Location = new System.Drawing.Point(8, 14);
            this.stock_market.Name = "stock_market";
            this.stock_market.Size = new System.Drawing.Size(321, 48);
            this.stock_market.TabIndex = 1;
            this.stock_market.Text = "Stock Market";
            // 
            // id_login
            // 
            this.id_login.AutoSize = true;
            this.id_login.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_login.Location = new System.Drawing.Point(96, 122);
            this.id_login.Name = "id_login";
            this.id_login.Size = new System.Drawing.Size(33, 12);
            this.id_login.TabIndex = 2;
            this.id_login.Text = "ID : ";
            // 
            // pw_login
            // 
            this.pw_login.AutoSize = true;
            this.pw_login.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_login.Location = new System.Drawing.Point(28, 154);
            this.pw_login.Name = "pw_login";
            this.pw_login.Size = new System.Drawing.Size(95, 12);
            this.pw_login.TabIndex = 3;
            this.pw_login.Text = "PASSWORD : ";
            // 
            // login_exit
            // 
            this.login_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_exit.Location = new System.Drawing.Point(348, 6);
            this.login_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_exit.Name = "login_exit";
            this.login_exit.Size = new System.Drawing.Size(21, 19);
            this.login_exit.TabIndex = 4;
            this.login_exit.Text = "X";
            this.login_exit.UseVisualStyleBackColor = true;
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // id_text
            // 
            this.id_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_text.Location = new System.Drawing.Point(136, 120);
            this.id_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(124, 14);
            this.id_text.TabIndex = 5;
            this.id_text.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // pw_text
            // 
            this.pw_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_text.Location = new System.Drawing.Point(136, 152);
            this.pw_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_text.Name = "pw_text";
            this.pw_text.PasswordChar = '*';
            this.pw_text.Size = new System.Drawing.Size(124, 14);
            this.pw_text.TabIndex = 6;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(113, 246);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(148, 18);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pw_find
            // 
            this.pw_find.Location = new System.Drawing.Point(113, 328);
            this.pw_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pw_find.Name = "pw_find";
            this.pw_find.Size = new System.Drawing.Size(148, 18);
            this.pw_find.TabIndex = 8;
            this.pw_find.Text = "FIND PASSWORD";
            this.pw_find.UseVisualStyleBackColor = true;
            this.pw_find.Click += new System.EventHandler(this.pw_find_Click);
            // 
            // id_find
            // 
            this.id_find.Location = new System.Drawing.Point(113, 288);
            this.id_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.id_find.Name = "id_find";
            this.id_find.Size = new System.Drawing.Size(148, 18);
            this.id_find.TabIndex = 9;
            this.id_find.Text = "Find ID";
            this.id_find.UseVisualStyleBackColor = true;
            this.id_find.Click += new System.EventHandler(this.id_find_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(113, 409);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(148, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save and Close";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 464);
            this.Controls.Add(this.save);
            this.Controls.Add(this.id_find);
            this.Controls.Add(this.pw_find);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pw_text);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.login_exit);
            this.Controls.Add(this.pw_login);
            this.Controls.Add(this.id_login);
            this.Controls.Add(this.stock_market);
            this.Controls.Add(this.join_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button join_button;
        private System.Windows.Forms.Label stock_market;
        private System.Windows.Forms.Label id_login;
        private System.Windows.Forms.Label pw_login;
        private System.Windows.Forms.Button login_exit;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.TextBox pw_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button pw_find;
        private System.Windows.Forms.Button id_find;
        private System.Windows.Forms.Button save;
    }
}

