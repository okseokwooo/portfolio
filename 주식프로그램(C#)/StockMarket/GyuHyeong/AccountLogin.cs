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
    public partial class AccountLogin : Form
    {
        DataBase db = RefDataBase.db;
        int count = 0;
        string id;
        string name;
        

        public AccountLogin(string id, string name)
        {
            InitializeComponent();
            myaccount.Text = db.GetAccount(id);
            this.id = id;
            this.name = name;
        }
        

        private void joinform_next_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_account_Click(object sender, EventArgs e)
        {
            count++;
            if(account_password.Text == db.GetAccountPass(this.id))
            {
                count = 0;
                MessageBox.Show("환영합니다." + name);
                this.Visible = false;
                MainStockMarket mainstockmarket = new MainStockMarket(id,name);
                mainstockmarket.Show();
                
            }
            else
            {
                MessageBox.Show("계좌 비밀번호가 틀립니다.");
                if(count == 5)
                {
                    MessageBox.Show("5회 접근실패로 프로그램이 종료되었습니다.");
                    this.Close();
                }
            }
        }
    }
}
