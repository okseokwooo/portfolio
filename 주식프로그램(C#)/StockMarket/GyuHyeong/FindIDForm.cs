using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket // findidform 완성
{
    public partial class FindIDForm : Form
    {
        DataBase db = RefDataBase.db;
        public FindIDForm()
        {
            InitializeComponent();
        }

        private void to_login_Click(object sender, EventArgs e) // 로그인 화면으로
        {
            LoginForm login = new LoginForm("a");
            login.Visible = true;
            this.Close();
        }

        private void login_exit_Click(object sender, EventArgs e) // X 버튼
        {
            this.Close();
        }

        private void search_id_Click(object sender, EventArgs e) // 버튼을 눌렀을때 아이디를 찾기위한 조건이 충족되었으면 라벨에 띄운다.
        {
            id_found.Text = db.FindID(username_text.Text, schoolname_text.Text, int.Parse(studentnum_text.Text));
        }






        /*
        private void schoolname_id_find_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
