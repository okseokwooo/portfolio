using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket // findpasswordform 완성
{
    public partial class FindPasswordForm : Form
    {
        DataBase db = RefDataBase.db;
        public FindPasswordForm()
        {
            InitializeComponent();
            JoinForm_Next joinformnext = new JoinForm_Next();
            
            combo_hint.Items.Add(joinformnext.getItem(0));
            combo_hint.Items.Add(joinformnext.getItem(1));
            combo_hint.Items.Add(joinformnext.getItem(2));
        }

        private void login_exit_Click(object sender, EventArgs e) //X버튼
        {
            this.Close();
        }

        private void to_login_Click(object sender, EventArgs e) // 비밀번호 리셋 폼으로
        {
            ResetPassword resetpw = new ResetPassword(this.user_id_text.Text);
            
            if(db.FindPass(this.user_id_text.Text, this.combo_hint.SelectedItem.ToString(), this.answer_text.Text))
            {
                resetpw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Information");
            }
            
        }
    }
}
