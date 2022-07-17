using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket // 완성
{
    public partial class LoginForm : Form
    {
        string id;
        DataBase db = RefDataBase.db;
        JoinForm join = new JoinForm();
        public LoginForm()
        {
            InitializeComponent();        
            db.Load();
            if (db.checkCountDic.ContainsKey("ok") == false)
            {
                Computer com = new Computer();
                com.MakeAI();
            }
        }
        public LoginForm(string check)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// 로그인폼 => 회원가입폼 전환
        {
            
            this.Visible = false;
            join.Show();
        }

        private void login_exit_Click(object sender, EventArgs e)// X 버튼
        {
            
            this.Close();
            
        }

        private void id_find_Click(object sender, EventArgs e)// 아이디 찾는 폼 열기
        {
            FindIDForm findid = new FindIDForm();
            this.Visible = false;
            findid.Show();

        }

        private void pw_find_Click(object sender, EventArgs e) // 비밀번호 찾는 폼 열기
        {
            FindPasswordForm findpw = new FindPasswordForm();
            this.Visible = false;
            findpw.Show();
        }

        private void login_button_Click(object sender, EventArgs e) // clientDb에 접근하여 등록된 회원일 때 mainstockmarket 폼전환 
        {
            if (db.Login(id_text.Text,pw_text.Text)==true)
            {
                AccountLogin accountlogin = new AccountLogin(id,db.GetName(id));
                this.Visible = false;
                accountlogin.Show();
                
            }
            else
            {
                MessageBox.Show("등록되어있지 않은 회원이거나 비밀번호가 잘못 입력되었습니다.");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            db.Save();
            this.Close();
        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {
            id = id_text.Text;
        }
    }
}
