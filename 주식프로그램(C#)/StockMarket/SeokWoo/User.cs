using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class User:Stock
    {
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
