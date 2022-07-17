using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockMarket
{
    class Normal : Computer
    {
        public string[] Nor()
        {
            bool check = false;
            int num = random.Next(5, 35);
            int per = random.Next(1, 101);
            int count = random.Next(10, 31);
            int money = db.clientMoney["ai" + num];
            string stockName = "0";
            while (stockName == "0")
            {
                stockName = db.GetClientRandomStockName("ai" + num);
            }
            string randomStockName = stock[random.Next(0, 30)];
            string[] info = new string[2];
            int index = db.stockDic1[randomStockName].Count();
            int[] price = db.stockDic1[randomStockName];
            int first = index - 20;
            int second = index - 5;
            int sellNum = random.Next(0, db.GetClientStockNum("ai" + num, stockName));
            //price = new int[index];
            if (price[first] > price[second])
            {
                int temp = price[first];
                price[first] = price[second];
                price[second] = temp;
            }

            int randomPrice = random.Next(price[first], price[second]);
            //int randomPrice = random.Next(15000, 200000);

            while (true)
            {
                if (money >= randomPrice * count)
                {
                    break;
                }
                randomPrice = random.Next(price[first], price[second]);
                count = random.Next(20, 101);
            }

            if (per > 65)
            {
                info = BuyStock("ai" + num, randomStockName, count, randomPrice, db.GetClientMoney("ai" + num)); // 주식 그래프 이상할경우 사는 가격 알고리즘 추가
                if (info[0] != "못삼")
                    check = true;
            }
            if (per > 60 && stockName != "0")
            {
                if (sellNum != 0 && sellNum <= db.GetClientStockNum("ai" + num, stockName))
                    SellStock("ai" + num, stockName, randomPrice, sellNum);
            }
            Thread.Sleep(50);
            if (check == true)
                return info;
            else
                return new string[] { "못삼", "0" };
        }
    }
}
