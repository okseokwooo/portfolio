using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class ResetPassword : Form
    {

        DataBase db = RefDataBase.db;
        string id;

        public ResetPassword(string id)
        {
            InitializeComponent();
            to_login.Enabled = false;
            this.id = id;
        }

        private void joinform_next_exit_Click(object sender, EventArgs e) // X버튼
        {
            this.Close();
        }

        private void to_login_Click(object sender, EventArgs e) // 로그인폼으로 폼전환하며 폼 정리
        {
            to_login.Enabled = false;
            if (reset_pw_redundancy.Text == "비밀번호가 같습니다.")
            {
                db.ResetPass(id, this.reset_pw_text.Text);
                LoginForm login = new LoginForm("a");
                login.Visible = true;
                this.Close();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (db.CheckPasswordRedundancy(reset_pw_text.Text, reset_pw_check_text.Text)) // 중복확인 매서드 사용
            {
                reset_pw_redundancy.Text = "비밀번호가 같습니다.";
                to_login.Enabled = true;
            }
            else
            {
                if (reset_pw_check_text.Text == "")
                {
                    reset_pw_redundancy.Text = "";
                    to_login.Enabled = false;
                }
                else
                {
                    reset_pw_redundancy.Text = "비밀번호가 다릅니다.";
                    to_login.Enabled = false;
                }

            }


        }

        private void reset_pw_text_TextChanged(object sender, EventArgs e)
        {
            if (reset_pw_text.Text == reset_pw_check_text.Text)
            {
                if (reset_pw_check_text.Text == "" && reset_pw_check_text.Text == "")
                {
                    reset_pw_redundancy.Text = "";
                    to_login.Enabled = false;
                }
                else
                {
                    reset_pw_redundancy.Text = "비밀번호가 같습니다.";
                    to_login.Enabled = true;
                }


            }
            else
            {
                to_login.Enabled = false;
                if (reset_pw_text.Text == "")
                {
                    reset_pw_redundancy.Text = "";
                }
                else
                {
                    reset_pw_redundancy.Text = "비밀번호가 다릅니다.";
                }
            }
        }
    }
}
