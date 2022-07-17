using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Computer:Stock
    {
        public string[] AI = new string[100];

        public Computer()
        {
        }
        public void MakeAI()
        {
            for(int i = 0; i < 100; i++)
            {
                AI[i] = "ai" + i; 
            }
            for(int i = 0; i < 100; i++)
            {
                db.Join(AI[i], "null", "null", "null", "null", "null", "null", 0, "null");
                int rannum = random.Next(0, 30);
                int index = db.stockDic1[stock[rannum]].Length;
                int first = index - 20;
                int second = index - 5;
                int[] price = new int[index];
                if (price[first] > price[second])
                {
                    int temp = first;
                    first = second;
                    second = temp;
                }
                int randomPrice = random.Next(price[first], price[second]);

                db.SetStock(stock[rannum],db.stockDic2[stock[rannum]]);
                db.SetClientStock(AI[i],stock[rannum], "30");
                db.SetClientMoney(AI[i], 100000000);
                db.SetSellingName(AI[i]);
                db.SetSellingStock(AI[i], stock[rannum], random.Next(1, 10), randomPrice);
            }

            for(int i = 0; i < 30; i++)
            {
                db.Join(stock[i], "null", "null", "null", "null", "null", "null", 0, "null");
            }
        }
        public override string[] BuyStock(string id, string stockName, int buyCount, int price, int money)
        {
            return base.BuyStock(id, stockName, buyCount, price, money);
        }
        public override void SellStock(string id, string sName, int sPrice, int sNum)
        {
            base.SellStock(id, sName, sPrice, sNum);
        }
    }
}
