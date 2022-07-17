using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class MainStockMarket : Form
    {
        public string[] items = new string[5];

        public static string[] mystock = new string[3];
        public string[] buy_stock1 = new string[2];
        public string[] buy_stock2 = new string[2];
        public string[] buy_stock3 = new string[2];
        public string[] view_stock_array = new string[5];
        string[] stock_array = new string[5];
        DataBase db = RefDataBase.db;
        NotAttacker c_NotA;
        Normal c_Nor;
        Attacker c_A;
        User user;
        string[] stocks = new string[] { "호랑이", "너구리", "사자", "고양이", "매미", "강아지",
                "사슴", "고라니", "지렁이", "노루", "백호", "펭귄", "금붕어", "니모", "가오리", "매", "독수리", "참새",
                "까마귀", "비둘기", "닭", "병아리", "고슴도치", "상어", "하이에나", "기러기", "매기", "파이썬", "자바", "씨" };

        string id;
        public MainStockMarket(string id, string na)
        {
            c_NotA = new NotAttacker();
            c_Nor = new Normal();
            c_A = new Attacker();
            user = new User();
            this.id = id;
            InitializeComponent();
            name.Text = "" + na;

            // trade groupbox 내의 속성 조절
            show_price_label.Text = "" + view_stock_array[1];
            trade_stock_name.Text = "" + view_stock_array[0];
            user_money_label.Text = "" + db.GetClientMoney(id);// 유저 머니.
            trade_stock_total.Text = "0";

            stockview.View = View.Details;
            stockview.GridLines = true;
            stockview.FullRowSelect = true;
            stockview.Sorting = SortOrder.Ascending;


            items[2] = "-";
            items[3] = "-";
            items[4] = "-";


            for (int i = 0; i < 30; i++)
            {
                int count = 0;
                foreach (var a in db.stockDic1[stocks[i]])
                {
                    count++;
                }
                items[0] = stocks[i];
                items[1] = db.stockDic1[stocks[i]][count - 1].ToString();
                ListViewItem lvItem = new ListViewItem(items[0]);
                lvItem.SubItems.Add(items[1]);
                lvItem.SubItems.Add(items[2]);
                lvItem.SubItems.Add(items[3]);
                lvItem.SubItems.Add(items[4]);
                stockview.Items.Add(lvItem);
            }
        }
        public MainStockMarket()
        {
            InitializeComponent();
            // trade groupbox 내의 속성 조절
            show_price_label.Text = "" + view_stock_array[1];
            trade_stock_name.Text = "" + view_stock_array[0];
            user_money_label.Text = "" + db.GetClientMoney(id);// 유저 머니.
            trade_stock_total.Text = "" + (int.Parse(trade_stock_amount.Value.ToString()) * int.Parse(trade_text_price.Text)).ToString();//Convert.ToInt32(trade_stock_amount.Value)
        }

        private void joinform_next_exit_Click(object sender, EventArgs e) // X 버튼
        {
            this.Close();
        }

        private void MainStockMarket_Load(object sender, EventArgs e)
        {

        }

        private void stock_timer_Tick(object sender, EventArgs e) // 1초에 30분
        {
            db.ChangeTime();
            int[] time = new int[5];
            time = db.GetTime();
            label2.Text = "" + time[0];
            label4.Text = "" + time[1];
            label6.Text = "" + time[2];
            label8.Text = "" + time[3];
            label9.Text = "" + time[4];


            //쓰레드 -> 컴퓨터 유저 3명이 동시에 사게 하기 위해서
            Thread th1 = new Thread(ComputerBuy1);
            Thread th2 = new Thread(ComputerBuy2);
            Thread th3 = new Thread(ComputerBuy3);
            th1.Start();
            th2.Start();
            th3.Start();
            /*
            foreach(var items in stocks)
            {
                if(stockview.Columns.)
                {
                    int key_num = stockview.Items.IndexOfKey();
                }
            }
            */

            stockview.Update();
            mystockview.Update();
        }

        void ComputerBuy1()
        {
            buy_stock1 = c_A.Attack();
            if (buy_stock1[0] != "못삼")
            {
                Update1(buy_stock1[0], int.Parse(buy_stock1[1]));
            }
        }

        void ComputerBuy2()
        {
            buy_stock2 = c_Nor.Nor();
            if (buy_stock2[0] != "못삼")
                Update2(buy_stock2[0], int.Parse(buy_stock2[1]));
        }

        void ComputerBuy3()
        {
            buy_stock3 = c_NotA.NotA();
            if (buy_stock3[0] != "못삼")
                Update3(buy_stock3[0], int.Parse(buy_stock3[1]));
        }

        private void stockview_MouseClick(object sender, MouseEventArgs e) // substockmarket 폼 띄우기
        {
        }

        private void trade_stock_buy_Click(object sender, EventArgs e)
        {
            if (db.clientMoney[id] >= int.Parse(trade_stock_total.Text))
            {
                // 주식 사는 매서드        
                string[] info = new string[3];
                string n = name.Text.ToString();
                string tsn = trade_stock_name.Text.ToString();
                int tsa = int.Parse(Convert.ToInt32(trade_stock_amount.Value).ToString());
                int ttp = int.Parse(trade_text_price.Text);
                int um = int.Parse(user_money_label.Text.ToString());
                user.BuyStock(n, tsn, tsa, ttp, um);

                info[0] = trade_stock_name.Text;
                info[1] = trade_text_price.Text;
                info[2] = trade_stock_amount.Value.ToString();

                ListViewItem lvitem = new ListViewItem(info[0]);
                lvitem.SubItems.Add(info[1]);
                lvitem.SubItems.Add(info[2]);
                mystockview.Items.Add(lvitem);

                trade_stock_name.Text = "*";
                show_price_label.Text = "*";
                trade_text_price.Clear();
                user_money_label.Text = db.clientMoney[id].ToString();
                trade_stock_amount.Value = 0;
                trade_stock_total.Text = "*";
            }
            else MessageBox.Show("자산이 부족하여 거래를 할 수 없습니다.");

        }

        private void trade_stock_sele_Click(object sender, EventArgs e)
        {
            /*
            int sNum = 0;
            int sPrice = 0;

            trade_stock_amount.Maximum = trade_stock_amount.Value;//Convert.ToInt32(trade_stock_amount.Value)
            // 파는 이벤트
            string n = name.Text.ToString();
            string tsn = trade_stock_name.Text.ToString();
            int ttp = int.Parse(trade_text_price.Text);
            int tsa = int.Parse(Convert.ToInt32(trade_stock_amount.Value).ToString());
            user.SellStock(n, tsn, ttp, tsa);
            
            ListViewItem lvi = new ListViewItem(n);
            lvi.SubItems.Add(""+ttp);
            lvi.SubItems.Add(""+tsa);


            xforeach(var items in mystockview.Items)
            {
                string a = items.ToString();
                string b = lvi.ToString();
                if (a==b)
                {
                    int tempNum = int.Parse(a);
                    sNum = tempNum;
                    sNum -= tsa;
                }
            }

            lvi.SubItems.Add(tsn);
            lvi.SubItems.Add(sNum.ToString());

            mystockview.Items.Add(lvi);


            //mystock
            mystockview.SelectedItems[0].Remove();
            MessageBox.Show(trade_stock_name + "를 " + trade_stock_amount.Value.ToString() + "주 매도하여 " + trade_stock_total.Text + "원 버셨습니다.");//Convert.ToInt32(trade_stock_amount.Value)
            */
        }

        private void mystockview_MouseClick(object sender, MouseEventArgs e)
        {

        }
        void Update1(string sName, int money)
        {
            CheckForIllegalCrossThreadCalls = false;

            stock_array = db.GetStockInfo(sName, money);

            if (stock_array[4] == "2")
            {
                stock_array[4] = "▲";

            }
            else if (stock_array[4] == "0")
            {
                stock_array[4] = "▼";
            }
            else if (stock_array[4] == "1")
            {
                stock_array[4] = "-";
            }
            // ListView 생성
            this.stockview.View = View.Details;
            this.stockview.GridLines = true;
            this.stockview.FullRowSelect = true;
            this.stockview.Sorting = SortOrder.Ascending;

            ListViewItem lvitem = new ListViewItem(stock_array[0]);
            lvitem.SubItems.Add(stock_array[1]);
            lvitem.SubItems.Add(stock_array[2]);
            lvitem.SubItems.Add(stock_array[3]);
            lvitem.SubItems.Add(stock_array[4]);

            int[] counts = new int[30];
            int count = 0;
            int index = 100;
            bool check = false;
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(stock_array[0]);

            for (int i = 0; i < 30; i++)
            {
                string lviString = lvi.SubItems[0].ToString();
                string svString = this.stockview.Items[i].SubItems[0].ToString();
                if (svString == lviString)
                {
                    index = count;
                    break;
                }
                count++;
            }
            if (index != 100)
            {
                this.stockview.Items.RemoveAt(index);
            }
            this.stockview.Items.Add(lvitem);
        }

        void Update2(string sName, int money)
        {
            CheckForIllegalCrossThreadCalls = false;

            stock_array = db.GetStockInfo(sName, money);

            if (stock_array[4] == "2")
            {
                stock_array[4] = "▲";

            }
            else if (stock_array[4] == "0")
            {
                stock_array[4] = "▼";
            }
            else if (stock_array[4] == "1")
            {
                stock_array[4] = "-";
            }
            // ListView 생성
            this.stockview.View = View.Details;
            this.stockview.GridLines = true;
            this.stockview.FullRowSelect = true;
            this.stockview.Sorting = SortOrder.Ascending;

            ListViewItem lvitem = new ListViewItem(stock_array[0]);
            lvitem.SubItems.Add(stock_array[1]);
            lvitem.SubItems.Add(stock_array[2]);
            lvitem.SubItems.Add(stock_array[3]);
            lvitem.SubItems.Add(stock_array[4]);

            int[] counts = new int[30];
            int count = 0;
            int index = 0;
            bool check = false;
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(stock_array[0]);

            for (int i = 0; i < 30; i++)
            {
                string lviString = lvi.SubItems[0].ToString();
                string svString = this.stockview.Items[i].SubItems[0].ToString();
                if (svString == lviString)
                {
                    index = count;
                    break;
                }
                count++;
            }
            if (index != 100)
            {
                this.stockview.Items.RemoveAt(index);
            }
            this.stockview.Items.Add(lvitem);
        }

        void Update3(string sName, int money)
        {
            CheckForIllegalCrossThreadCalls = false;

            stock_array = db.GetStockInfo(sName, money);

            if (stock_array[4] == "2")
            {
                stock_array[4] = "▲";

            }
            else if (stock_array[4] == "0")
            {
                stock_array[4] = "▼";
            }
            else if (stock_array[4] == "1")
            {
                stock_array[4] = "-";
            }
            // ListView 생성
            this.stockview.View = View.Details;
            this.stockview.GridLines = true;
            this.stockview.FullRowSelect = true;
            this.stockview.Sorting = SortOrder.Ascending;

            ListViewItem lvitem = new ListViewItem(stock_array[0]);
            lvitem.SubItems.Add(stock_array[1]);
            lvitem.SubItems.Add(stock_array[2]);
            lvitem.SubItems.Add(stock_array[3]);
            lvitem.SubItems.Add(stock_array[4]);

            int[] counts = new int[30];
            int count = 0;
            int index = 0;
            bool check = false;
            ListViewItem lvi = new ListViewItem(stock_array[0]);
            lvi.SubItems.Add(stock_array[0]);

            for (int i = 0; i < 30; i++)
            {
                string lviString = lvi.SubItems[0].ToString();
                string svString = this.stockview.Items[i].SubItems[0].ToString();
                if (svString == lviString)
                {
                    index = count;
                    break;
                }
                count++;
            }
            if (index != 100)
            {
                this.stockview.Items.RemoveAt(index);
            }
            this.stockview.Items.Add(lvitem);
        }

        private void stockview_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a;

            trade_stock_name.Text = stockview.Items[stockview.FocusedItem.Index].SubItems[0].Text;
            show_price_label.Text = stockview.Items[stockview.FocusedItem.Index].SubItems[1].Text;
            user_money_label.Text = db.clientMoney[id].ToString();
            a = (int.Parse(trade_stock_amount.Value.ToString()) * int.Parse(stockview.Items[stockview.FocusedItem.Index].SubItems[1].Text)).ToString();//Convert.ToInt32(trade_stock_amount.Value)
            trade_stock_total.Text = a;

        }

        private void save_Click(object sender, EventArgs e)
        {
            db.Save();
            this.Close();
        }

        private void trade_stock_amount_ValueChanged(object sender, EventArgs e)
        {
            if (trade_text_price.Text == "")
            {
            }
            else
            {
                int price = int.Parse(trade_text_price.Text) * int.Parse(trade_stock_amount.Value.ToString());//Convert.ToInt32(trade_stock_amount.Value)
                trade_stock_total.Text = price.ToString();
            }

        }

        private void trade_text_price_TextChanged(object sender, EventArgs e)
        {
        }

        private void mystockview_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}