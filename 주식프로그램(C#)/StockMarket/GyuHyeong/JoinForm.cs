using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket // joiinform 완성
{
    public partial class JoinForm : Form
    {
        DataBase db = RefDataBase.db;
        Bank bank = new Bank();

        //필드
        bool idCheck = false, pwCheck = false, accPwCheck = false; // 겹치면 true 안겹치면 false


        public JoinForm()
        {
            InitializeComponent();
            next_join.Enabled = false;

        }

        void Update_join() // next버튼 활성화. 비활성화
        {
            if (pwCheck && accPwCheck && idCheck)
            {
                next_join.Enabled = true;
            }
            else
            {
                next_join.Enabled = false;
            }
        }

        private void JoinForm_Load(object sender, EventArgs e) //쓸데없는 이벤트
        {

        }

        private void button1_Click(object sender, EventArgs e)// 회원가입폼 => 로그인폼 전환
        {
            //account = Stock.bank.MakeAccount();

            JoinForm_Next joinformnext = new JoinForm_Next(id_text_join.Text, name_text_join.Text, pw_text_join.Text, "", pw_account_text_join.Text);

            joinformnext.Show();
            this.Close();
        }

        private void pw_chek_text_join_TextChanged(object sender, EventArgs e) // 비밀번호 중복체크 이벤트
        {
            if (pw_text_join.Text == pw_check_text_join.Text)
            {
                pwCheck = true;
                pw_check_redundancy.Text = "비밀번호가 같습니다.";
            }
            else
            {
                pwCheck = false;
                if (pw_check_text_join.Text == "")
                {
                    pw_check_redundancy.Text = "";
                }
                else
                {
                    pw_check_redundancy.Text = "비밀번호가 다릅니다.";
                }
            }
            Update_join();
        }

        private void pw_account_check_text_join_TextChanged(object sender, EventArgs e) // 계좌 비밀번호 중복체크 이벤트
        {
            if (pw_account_text_join.Text == pw_account_check_text_join.Text)
            {
                pw_account_check_redundancy.Text = "비밀번호가 같습니다.";
                accPwCheck = true;
            }
            else
            {
                accPwCheck = false;
                if (pw_account_check_text_join.Text == "")
                {
                    pw_account_check_redundancy.Text = "";
                }
                else
                {
                    pw_account_check_redundancy.Text = "비밀번호가 다릅니다.";
                }
            }
            Update_join();
        }

        private void id_text_join_TextChanged_1(object sender, EventArgs e)
        {
            if (id_text_join.Text == "")
            {
                idCheck = false;
                id_redundancy.Enabled = true;
            }
            else if (idCheck == true)
            {
                idCheck = false;
                id_redundancy.Enabled = true;
            }
            Update_join();
        }

        private void name_text_join_TextChanged(object sender, EventArgs e)
        {
        }

        private void pw_text_join_TextChanged(object sender, EventArgs e)
        {
            if (pw_text_join.Text == pw_check_text_join.Text)
            {
                pw_check_redundancy.Text = "비밀번호가 같습니다.";
                pwCheck = true;
            }
            else
            {
                pwCheck = false;
                if (pw_check_text_join.Text == "")
                {
                    pw_check_redundancy.Text = "";
                }
                else
                {
                    pw_check_redundancy.Text = "비밀번호가 다릅니다.";
                }
            }
            Update_join();
        }

        private void pw_account_text_join_TextChanged(object sender, EventArgs e)
        {
            if (pw_account_text_join.Text == pw_account_check_text_join.Text)
            {
                pw_account_check_redundancy.Text = "비밀번호가 같습니다.";
                accPwCheck = true;
            }
            else
            {
                accPwCheck = false;
                if (pw_account_text_join.Text == "")
                {
                    pw_account_check_redundancy.Text = "";
                }
                else
                {
                    pw_account_check_redundancy.Text = "비밀번호가 다릅니다.";
                }
            }
            Update_join();
        }

        private void id_text_join_TextChanged(object sender, EventArgs e)
        {
        }

        private void join_exit_Click(object sender, EventArgs e) // X버튼
        {

            this.Close();

        }

        private void id_redundancy_Click(object sender, EventArgs e) // 아이디 중복체크 이벤트
        {
            if (db.CheckIdRedundancy(id_text_join.Text) == false)
            {
                MessageBox.Show("중복확인 되었습니다.");
                idCheck = true;
                id_redundancy.Enabled = false;
                Update_join();
            }
            else
            {
                MessageBox.Show("중복확인 실패하였습니다 다른 아이디를 입력하여주세요.");
                idCheck = false;
                Update_join();
            }
            Update_join();
        }
    }

}
