using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Stock
    {
        public DataBase db = RefDataBase.db;
        public static Random random = new Random();
        
        
        public string[] stock = new string[] {"호랑이","너구리","사자","고양이","매미","강아지","사슴","고라니","지렁이",
            "노루","백호","펭귄","금붕어","니모","가오리","매","독수리","참새","까마귀","비둘기","닭","병아리","고슴도치","상어",
            "하이에나","기러기","매기","파이썬","자바","씨" };

        public virtual string[] BuyStock(string id, string stockName, int buyCount, int price, int money)
        //매수  >>>>>> 매개변수:아이디, 사는 주식이름, 사는 주식개수, 사용자가 정한가격, 재산 / 사는 주식 이름이랑 주식가격 반환
        {
            bool checkBuy = true;
            bool checkCom = false; // 컴퓨터가 사야하나?
            int a = buyCount;
            int sNum = 0;
            int sPrice = 0;
            foreach (var ids in db.GetSellingName())
            {
                checkBuy = true;
                checkCom = true;
                if (db.sellingStockTimeDic2.ContainsKey(new string[] { ids, stockName }) && a != 0 && money >= (a * price))
                {
                    if (db.sellingStockTimeDic3[new string[] { ids, stockName }] == price)
                    {
                        checkCom = false;
                        sNum = db.sellingStockTimeDic2[new string[] { ids, stockName }];
                        sPrice = db.sellingStockTimeDic3[new string[] { ids, stockName }];
                        if (sNum < a)
                        {
                            a -= sNum;
                            db.SetClientMoney(id, money-(price * sNum));
                            db.SetClientStock(id, stockName, ""+a);
                            db.SetStock(stockName,price);
                            db.sellingStockTimeDic2.Remove(new string[] { ids, stockName });
                            db.sellingStockTimeDic3.Remove(new string[] { ids, stockName });
                        }
                        else if (sNum == a)
                        {
                            a = 0;
                            db.SetClientMoney(id, money - (price * a));
                            db.SetClientStock(id, stockName, ""+a);
                            db.SetStock(stockName, price);
                            db.sellingStockTimeDic2.Remove(new string[] { ids, stockName });
                            db.sellingStockTimeDic3.Remove(new string[] { ids, stockName });
                        }
                        else
                        {
                            sNum -= a;
                            a = 0;
                            db.SetClientMoney(id, money - (price * a));
                            db.SetClientStock(id, stockName, ""+a);
                            db.SetStock(stockName, price);
                            db.sellingStockTimeDic3.Remove(new string[] { ids, stockName });
                            db.sellingStockTimeDic2.Add(new string[] { ids, stockName }, sNum);
                        }
                        if (a == 0) // 팔 사람 있고 더이상 주식 안사도 될때
                            checkCom = false;
                    }
                }
            }
            if (checkCom == true)
            {
                checkBuy = true;
                if(money<(price*a))
                db.SetClientStock(id, stockName, ""+a);
                db.SetClientMoney(id, money-(a * price));
                db.SetStock(stockName, price);

                a = 0;
            }

            if (checkBuy == true)
            {
                return new string[] { stockName, price.ToString() };
            }else
            {
                return new string[] { "못삼", "0" };
            }
        }

        public virtual void SellStock(string id, string sName, int sPrice, int sNum)
        {
            db.SetSellingName(id);
            db.SetSellingStock(id, sName, sPrice, sNum);
        }
        
    }  
}
