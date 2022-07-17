using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockMarket
{
    class MakeStockData
    {
        Random rannum = new Random();

        public void MakeData(string sName)
        {
            int sel = rannum.Next(0, 6);
            switch (sel)
            {
                case 0:
                    MakeDataU1(sName);
                    Thread.Sleep(300);
                    break;
                case 1:
                    MakeDataU2(sName);
                    Thread.Sleep(300);
                    break;
                case 2:
                    MakeDataD1(sName);
                    Thread.Sleep(300);
                    break;
                case 3:
                    MakeDataD2(sName);
                    Thread.Sleep(300);
                    break;
                case 4:
                    MakeDataD3(sName);
                    Thread.Sleep(300);
                    break;
                case 5:
                    MakeDataU3(sName);
                    Thread.Sleep(300);
                    break;
            }

        }

        void MakeDataU1(string sName)
        {
            int temp;
            int start = 100000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start += rannum.Next(7, 10);
                    start -= rannum.Next(12, 15);
                }
                else
                {
                    start += rannum.Next(10, 12);
                    start -= rannum.Next(8, 11);
                }
                sw1.WriteLine("" + start);
            }
            sw1.Close();
        }

        void MakeDataU2(string sName)
        {
            int temp;
            int k=0;
            int start = 1000000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start -= rannum.Next(49, 77);
                    start += rannum.Next(61, 92);
                }
                else
                {
                    start -= rannum.Next(60, 92);
                    start += rannum.Next(50, 78);
                }
                sw1.WriteLine("" + start);
                k = i;
            }
            sw1.Close();
        }

        void MakeDataU3(string sName)
        {
            int temp;
            int start = 5000000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start -= rannum.Next(34, 54);
                    start += rannum.Next(31, 47);
                }
                else
                {
                    start -= rannum.Next(30, 49);
                    start += rannum.Next(34, 54);
                }
                sw1.WriteLine("" + start);
            }
            sw1.Close();
        }

        void MakeDataD1(string sName)
        {
            int temp;
            int start = 100000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start -= rannum.Next(7, 10);
                    start += rannum.Next(12, 15);
                }
                else
                {
                    start -= rannum.Next(10, 12);
                    start += rannum.Next(8, 11);
                }
                sw1.WriteLine("" + start);
            }
            sw1.Close();
        }

        void MakeDataD2(string sName)
        {
            int temp;
            int start = 1000000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start += rannum.Next(49, 77);
                    start -= rannum.Next(61, 92);
                }
                else
                {
                    start += rannum.Next(60, 92);
                    start -= rannum.Next(50, 78);
                }
                sw1.WriteLine("" + start);
            }
            sw1.Close();
        }

        void MakeDataD3(string sName)
        {
            int temp;
            int start = 500000;
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw1 = new StreamWriter(folder + @"\" + sName + "StockDic1.txt");
            for (int i = 0; i < 9490; i++)
            {
                temp = i / 100;
                if (temp % 12 == 4)
                {
                    start -= rannum.Next(31, 47);
                    start += rannum.Next(34, 54);
                }
                else
                {
                    start -= rannum.Next(34, 54);
                    start += rannum.Next(30, 49);
                }
                sw1.WriteLine("" + start);
            }
            sw1.Close();
        }

    }
}
