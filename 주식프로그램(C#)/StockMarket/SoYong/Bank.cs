using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket
{
    class Bank
    {
        DataBase db = RefDataBase.db;
        Random rannum = new Random();
        public string MakeAccount() // index 2 계좌번호
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] a = Directory.GetFiles(folder);        
            string account = rannum.Next(10000000, 100000000).ToString(); // 계좌번호 8자리
            if (a.Contains("너구리Dic1.txt"))
            {
                string[] hi = new string[8];
                int i = 0;
                bool Check = false;
                foreach (var id in db.clientDic.Keys)
                {
                    foreach (var values in db.clientDic[id])
                    {
                        hi[i] = values;
                        i++;
                    }
                    if (hi[2] == account)
                    {
                        Check = true;
                    }

                }
                if (Check == false)
                {
                    return account;
                }
                else
                {
                    MakeAccount();
                    return "0";
                }
            }else
            {
                return account;
            }
        }
    }
}
