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
    public partial class JoinForm_Next : Form
    {
        DataBase db = RefDataBase.db;
        Bank bank = new Bank();
        string id;
        string name;
        string password;
        string account;
        string accountPassword;
        string hint;

        public JoinForm_Next(string id, string name, string password, string account, string accountPassword)
        {


            InitializeComponent();
            hint_combo.Items.Add("회원가입시 당신이 살던곳은 어딘가요?");
            hint_combo.Items.Add("당신의 혈핵형은 무엇인가요?");
            hint_combo.Items.Add("왕교수님 사랑하나요?");
            this.id = id;
            this.name = name;
            this.password = password;
            this.account = account;
            this.accountPassword = accountPassword;
        }
        public JoinForm_Next() // 오버로딩
        {
            InitializeComponent();
            hint_combo.Items.Add("회원가입시 당신이 살던곳은 어딘가요?");
            hint_combo.Items.Add("당신의 혈핵형은 무엇인가요?");
            hint_combo.Items.Add("왕교수님 사랑하나요?");
        }

        private void hint_combo_SelectedIndexChanged(object sender, EventArgs e) // 콤보박스 비밀번호 힌트 목록
        {
        }

        public string getItem(int index) // 콤보박스 아이템에 대한 겟터함수
        {
            return hint_combo.Items[index].ToString();
        }


        private void joinform_next_exit_Click(object sender, EventArgs e) // X 버튼
        {
            
            this.Close();
        }

        private void join_create_Click(object sender, EventArgs e) // joinform 폼 전환
        {
            db.Join(id, name, password, bank.MakeAccount(), accountPassword, hint_combo.SelectedItem.ToString(), hint_ans.Text, int.Parse(student_number.Text), school_name.Text);
            LoginForm login = new LoginForm("a");
            login.Visible = true;
            this.Close();
        }
    }
}
