namespace StockMarket
{
    partial class JoinForm_Next
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
            this.join_in = new System.Windows.Forms.Label();
            this.student_number_join = new System.Windows.Forms.Label();
            this.student_name_join = new System.Windows.Forms.Label();
            this.pw_hint = new System.Windows.Forms.Label();
            this.hint_combo = new System.Windows.Forms.ComboBox();
            this.school_name = new System.Windows.Forms.TextBox();
            this.student_number = new System.Windows.Forms.TextBox();
            this.hint_ans = new System.Windows.Forms.TextBox();
            this.hint_ans_join = new System.Windows.Forms.Label();
            this.join_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joinform_next_exit
            // 
            this.joinform_next_exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinform_next_exit.Location = new System.Drawing.Point(398, 7);
            this.joinform_next_exit.Name = "joinform_next_exit";
            this.joinform_next_exit.Size = new System.Drawing.Size(24, 24);
            this.joinform_next_exit.TabIndex = 5;
            this.joinform_next_exit.Text = "X";
            this.joinform_next_exit.UseVisualStyleBackColor = true;
            this.joinform_next_exit.Click += new System.EventHandler(this.joinform_next_exit_Click);
            // 
            // join_in
            // 
            this.join_in.AutoSize = true;
            this.join_in.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_in.Location = new System.Drawing.Point(80, 18);
            this.join_in.Name = "join_in";
            this.join_in.Size = new System.Drawing.Size(241, 60);
            this.join_in.TabIndex = 6;
            this.join_in.Text = "JOIN IN";
            // 
            // student_number_join
            // 
            this.student_number_join.AutoSize = true;
            this.student_number_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.student_number_join.Location = new System.Drawing.Point(33, 214);
            this.student_number_join.Name = "student_number_join";
            this.student_number_join.Size = new System.Drawing.Size(168, 15);
            this.student_number_join.TabIndex = 7;
            this.student_number_join.Text = "STUDENT NUMBER : ";
            // 
            // student_name_join
            // 
            this.student_name_join.AutoSize = true;
            this.student_name_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.student_name_join.Location = new System.Drawing.Point(56, 157);
            this.student_name_join.Name = "student_name_join";
            this.student_name_join.Size = new System.Drawing.Size(142, 15);
            this.student_name_join.TabIndex = 8;
            this.student_name_join.Text = "SCHOOL NAME : ";
            // 
            // pw_hint
            // 
            this.pw_hint.AutoSize = true;
            this.pw_hint.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw_hint.Location = new System.Drawing.Point(40, 271);
            this.pw_hint.Name = "pw_hint";
            this.pw_hint.Size = new System.Drawing.Size(158, 15);
            this.pw_hint.TabIndex = 9;
            this.pw_hint.Text = "PASSWORD HINT : ";
            // 
            // hint_combo
            // 
            this.hint_combo.FormattingEnabled = true;
            this.hint_combo.Location = new System.Drawing.Point(200, 268);
            this.hint_combo.Name = "hint_combo";
            this.hint_combo.Size = new System.Drawing.Size(190, 23);
            this.hint_combo.TabIndex = 10;
            this.hint_combo.Text = "SELECT THE HINT";
            this.hint_combo.SelectedIndexChanged += new System.EventHandler(this.hint_combo_SelectedIndexChanged);
            // 
            // school_name
            // 
            this.school_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.school_name.Location = new System.Drawing.Point(200, 154);
            this.school_name.Name = "school_name";
            this.school_name.Size = new System.Drawing.Size(190, 18);
            this.school_name.TabIndex = 11;
            // 
            // student_number
            // 
            this.student_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.student_number.Location = new System.Drawing.Point(200, 211);
            this.student_number.Name = "student_number";
            this.student_number.Size = new System.Drawing.Size(190, 18);
            this.student_number.TabIndex = 12;
            // 
            // hint_ans
            // 
            this.hint_ans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hint_ans.Location = new System.Drawing.Point(200, 319);
            this.hint_ans.Name = "hint_ans";
            this.hint_ans.Size = new System.Drawing.Size(190, 18);
            this.hint_ans.TabIndex = 13;
            // 
            // hint_ans_join
            // 
            this.hint_ans_join.AutoSize = true;
            this.hint_ans_join.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hint_ans_join.Location = new System.Drawing.Point(56, 322);
            this.hint_ans_join.Name = "hint_ans_join";
            this.hint_ans_join.Size = new System.Drawing.Size(132, 15);
            this.hint_ans_join.TabIndex = 14;
            this.hint_ans_join.Text = "HINT ANSWER : ";
            // 
            // join_create
            // 
            this.join_create.Location = new System.Drawing.Point(186, 458);
            this.join_create.Name = "join_create";
            this.join_create.Size = new System.Drawing.Size(75, 23);
            this.join_create.TabIndex = 15;
            this.join_create.Text = "CREATE!";
            this.join_create.UseVisualStyleBackColor = true;
            this.join_create.Click += new System.EventHandler(this.join_create_Click);
            // 
            // JoinForm_Next
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 580);
            this.Controls.Add(this.join_create);
            this.Controls.Add(this.hint_ans_join);
            this.Controls.Add(this.hint_ans);
            this.Controls.Add(this.student_number);
            this.Controls.Add(this.school_name);
            this.Controls.Add(this.hint_combo);
            this.Controls.Add(this.pw_hint);
            this.Controls.Add(this.student_name_join);
            this.Controls.Add(this.student_number_join);
            this.Controls.Add(this.join_in);
            this.Controls.Add(this.joinform_next_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JoinForm_Next";
            this.Text = "JoinForm_Next";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinform_next_exit;
        private System.Windows.Forms.Label join_in;
        private System.Windows.Forms.Label student_number_join;
        private System.Windows.Forms.Label student_name_join;
        private System.Windows.Forms.Label pw_hint;
        private System.Windows.Forms.ComboBox hint_combo;
        private System.Windows.Forms.TextBox school_name;
        private System.Windows.Forms.TextBox student_number;
        private System.Windows.Forms.TextBox hint_ans;
        private System.Windows.Forms.Label hint_ans_join;
        private System.Windows.Forms.Button join_create;
    }
}