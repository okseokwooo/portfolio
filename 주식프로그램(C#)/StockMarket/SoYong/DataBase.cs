using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockMarket
{
    class DataBase
    {
        private int year = 2018, month = 6, day = 12, hour = 2, min = 30;
        public Dictionary<string, string[]> ClientKeys = new Dictionary<string, string[]>();
        public Dictionary<string, string[]> clientDic = new Dictionary<string, string[]>(); // key : 아이디 / value : 이름, 패스워드, 계좌번호, 계좌 비밀번호, 힌트, 힌트정답, 학번, 학교이름 -> 학번 저장 문자열 불러올때 정수
        public Dictionary<string, int> clientMoney = new Dictionary<string, int>(); // key : 아이디 / value : 돈
        public Dictionary<string, string[]> buyerName = new Dictionary<string, string[]>(); // 주식파는사람 이름들 / key : buyer(고정) / value : 아이디
        public Dictionary<string, string[]> sellerName = new Dictionary<string, string[]>(); // 주식사는사람 이름들 / key : seller(고정) / value : 아이디
        public Dictionary<string, int[]> stockDic1 = new Dictionary<string, int[]>(); // key : 주식이름 / value : 주식가격 (30분 단위) -> 프로그램 켜지기 이전의 주식 변동 값
        public Dictionary<string, int> stockDic2 = new Dictionary<string, int>(); // key : 주식이름 / value : 주식 총 개수(일정)      
        public Dictionary<string[], int> sellingStockTimeDic2 = new Dictionary<string[], int>(); // key : 아이디, 파는 주식 이름 / value : 파는 주식 개수
        public Dictionary<string[], int> sellingStockTimeDic3 = new Dictionary<string[], int>(); // key : 아이디, 파는 주식 이름 / value : 파는 주식 가격        
        public Dictionary<string, int[]> tempStock = new Dictionary<string, int[]>(); // key : 주식 이름 / value : 주식 변동 가격 -> 프로그램 켜진 이후의 주식 변동 값
        public Dictionary<string, string[]> clientStockDic1 = new Dictionary<string, string[]>(); // key : 아이디 / value : 주식 이름
        public Dictionary<string[], string> clientStockDic2 = new Dictionary<string[], string>(); // key : 아이디, 주식이름 / value : (string)주식 개수 -> 주식개수 정수지만 저장할때는 문자열 불러올떄는 정수로 형변환 
        public Dictionary<string, string[]> timeDic = new Dictionary<string, string[]>(); // key : Time(고정) / value : 년도, 월, 일, 시, 분
        public Dictionary<string, int> checkCountDic = new Dictionary<string, int>();
        public Dictionary<string, int[]> myStockInfo = new Dictionary<string, int[]>(); // key : 주식이름 / value : 주식개수, 가격

        private MakeStockData msd = new MakeStockData();
        public static Bank bank = new Bank();


        string[] stock = new string[] { "호랑이", "너구리", "사자", "고양이", "매미", "강아지",
                "사슴", "고라니", "지렁이", "노루", "백호", "펭귄", "금붕어", "니모", "가오리", "매", "독수리", "참새",
                "까마귀", "비둘기", "닭", "병아리", "고슴도치", "상어", "하이에나", "기러기", "매기", "파이썬", "자바", "씨" };

        public void SetStockNum(string sName, int count)
        {
            stockDic2.Remove(sName);
            stockDic2.Add(sName, stockDic2[sName] - count);
        }

        public int GetStockNum(string sName)
        {
            return stockDic2[sName];
        }

        public int SetClientMoney(string id, int money)
        {
            if (clientMoney.ContainsKey(id))
            {
                clientMoney.Remove(id);
                clientMoney.Add(id, money);
            }
            return money;
        }


        public void SetSellingName(string id)
        {
            if (sellerName["key"].Contains(id) == false)
            {
                int count = 0;
                string[] tempNames = new string[1000];
                foreach (var name in sellerName["key"])
                {
                    tempNames[count] = name;
                    count++;
                }
                tempNames[count] = id;
                string[] names = new string[count+1];
                for (int i = 0; i < count+1; i++)
                {
                    names[i] = tempNames[i];
                }
                sellerName.Remove("key");
                sellerName.Add("key", names);
            }
        }

        public void SetBuyingingName(string id)
        {
            if (buyerName.ContainsKey(id) == false)
            {
                int count = 0;
                string[] names = new string[1000];
                foreach (var name in buyerName.Keys)
                {
                    names[count] = name;
                    count++;
                }
                names[count] = id;
                Array.Resize<string>(ref names, count + 1);
                buyerName.Add("key", names);
            }
            else
            {
                sellerName.Add("key", new string[] { id });
            }
        }

        public string[] GetSellingName()
        {
            string[] name = new string[1000];
            int count = 0;
            if (sellerName.Count != 1)
            {
                foreach (var values in sellerName["key"])
                {
                    name[count] = values;
                    count++;
                }
                Array.Resize<string>(ref name, count);
                return name;
            }
            else
            {
                return new string[] { "davxvva" };
            }
        }

        public string[] GetBuyingName()
        {
            string[] name = new string[1000];
            int count = 0;
            if (buyerName.Count != 1)
            {
                foreach (var values in buyerName["key"])
                {
                    name[count] = values;
                    count++;
                }
                Array.Resize<string>(ref name, count);
                return name;
            }
            else
            {
                return new string[] { "dasdfsva" };
            }
        }

        void SetClientKeys(string id)
        {
            string[] tempKeys = new string[150];
            int count = 0;
            if (ClientKeys.ContainsKey(id))
            {
                foreach (var values in clientDic.Keys)
                {
                    tempKeys[count] = values;
                    count++;
                }
                tempKeys[count] = id;
                string[] keys = new string[count + 1];
                for (int i = 0; i < count + 1; i++)
                {
                    keys[i] = tempKeys[i];
                }
                ClientKeys.Remove("key");
                ClientKeys.Add("key", keys);
            }else
            {
                ClientKeys.Add("key", new string[] { id });
            }
        }

        public void SetStock(string sName, int stockPrice) // tempStock에 프로그램이 켜진 뒤의 주식 이름과 그에 해당하는 주식 가격 저장 / 매개변수 : 주식이름, 주식가격
        {

            if (tempStock.ContainsKey(sName) == true)
            {
                int[] t_tempStock = new int[100000000];
                int count = 0;
                foreach(var values in tempStock[sName])
                {
                    t_tempStock[count] = values;
                    count++;
                }
                t_tempStock[count] = stockPrice;
                int[] tempArray = new int[count + 1];
                tempStock.Remove(sName);
                tempStock.Add(sName, tempArray);
            }
            else
            {
                int[] stock = new int[1];
                stock[0] = stockPrice;
                tempStock.Add(sName, stock);
            }
            
        }

        public void SetSellingStock(string id, string sellingSName, int sNum, int price) // sellingStockDic123에 판매할 주식의 개수와 이름 저장 / 매개변수 : 파는 사용자 아이디, 판매할 주식 이름, 판매할 주식 개수, 판매한 시간, 판매가격
        {
            if (sellingStockTimeDic2.ContainsKey(new string[] { id, sellingSName }))
            {
                sellingStockTimeDic2.Remove(new string[] { id, sellingSName });
                sellingStockTimeDic3.Remove(new string[] { id, sellingSName });
                sellingStockTimeDic2.Add(new string[] { id, sellingSName }, sNum);
                sellingStockTimeDic3.Add(new string[] { id, sellingSName }, price);
            }
            else
            {
                sellingStockTimeDic2.Add(new string[] { id, sellingSName }, sNum);
                sellingStockTimeDic3.Add(new string[] { id, sellingSName }, price);
            }
        }

        /*public void SetBuyingStock(string id, string buyingSName, int sNum, int price) // buyingStockDic123에 구매할 주식의 개수와 이름 저장 / 매개변수 : 구매하는 사용자 아이디, 구매할 주식 이름, 구매할 주식 개수, 구매한 시간, 구매가격
        {
            if (buyingStockTimeDic2.ContainsKey(new string[] { id, buyingSName }))
            {
                int[] stockNum = new int[10000];
                int[] stockPrice = new int[10000];
                int count2 = 0;
                int count3 = 0;

                foreach (var values in buyingStockTimeDic2[new string[] { id, buyingSName }])
                {
                    stockNum[count2] = values;
                    count2++;
                }

                foreach (var values in buyingStockTimeDic3[new string[] { id, buyingSName }])
                {
                    stockPrice[count3] = values;
                    count3++;
                }

                stockNum[count2] = sNum;
                stockPrice[count3] = price;

                Array.Resize<int>(ref stockNum, count2 + 1);
                Array.Resize<int>(ref stockPrice, count3 + 1);

                buyingStockTimeDic2.Remove(new string[] { id, buyingSName });
                buyingStockTimeDic3.Remove(new string[] { id, buyingSName });

                buyingStockTimeDic2.Add(new string[] { id, buyingSName }, stockNum);
                buyingStockTimeDic3.Add(new string[] { id, buyingSName }, stockPrice);

            }
            else
            {
                buyingStockTimeDic2.Add(new string[] { id, buyingSName }, new int[] { sNum });
            }
        }*/

        public void SetClientStock(string id, string sName, string sNum) // 유저의 주식 정보(보유 주식 이름, 보유 주식 개수)를 clientStockDic12에 저장 // 매개변수 : 유저 아이디, 주식 이름, 주식 개수
        {
            SetClientStock1(id, sName);
            SetClientStock2(id, sName, sNum);
        }

        private void SetClientStock1(string id, string sName) // clientDic1에 저장
        {
            if (clientStockDic1.ContainsKey(id)) // 에러 ========================================================================================== ERROR
            {
                int count = 0;
                string[] tempArray = new string[1000000];

                foreach (var values in clientStockDic1[id])
                {
                    tempArray[count] = values;
                    count++;
                }
                tempArray[count] = sName;

                string[] array = new string[count+1];
                for(int i = 0; i < count+1; i++)
                {
                    array[i] = tempArray[i];
                }
                clientStockDic1.Remove(id);
                clientStockDic1.Add(id, array);
            }
            else
            {
                clientStockDic1.Add(id, new string[] { sName });
            }
        }

        private void SetClientStock2(string id, string sName, string sNum) // clientDic2에 저장
        {
                clientStockDic2.Remove(new string[] { id, sName });
                clientStockDic2.Add(new string[] { id, sName }, sNum);            
        }

        public string GetName(string id)
        {
            string[] array = new string[8];
            string name = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                name = array[0];
                return name;
            }
            else
            {
                return "NULL";
            }
        }

        public string GetPass(string id)
        {
            string[] array = new string[8];
            string password = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                password = array[1];
                return password;
            }
            else
                return "NULL";
        }

        public string GetAccount(string id)
        {
            string[] array = new string[8];
            string account = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                account = array[2];
                return account;
            }
            else
            {
                return "NULL";
            }
        }

        public string GetAccountPass(string id)
        {
            string[] array = new string[8];
            string accountPass = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                accountPass = array[3];
                return accountPass;
            }
            else
            {
                return "NULL";
            }
        }

        public string GetHint(string id)
        {
            string[] array = new string[8];
            string hint = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                hint = array[4];
                return hint;
            }
            else
            {
                return "NULL";
            }
        }

        public string GetHintAnswer(string id)
        {
            string[] array = new string[8];
            string hintAnswer = "";

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                hintAnswer = array[8];
                return hintAnswer;
            }
            else
            {
                return "NULL";
            }
        }

        public int GetStudentNum(string id)
        {
            string[] array = new string[8];
            int num = 0;

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                num = int.Parse(array[5]);
                return num;
            }
            else
            {
                return 0;
            }
        }

        public int[] GetOldStocksPrice(string sName) // 주식 가격 폼으로 반환
        {
            if (stockDic1.ContainsKey(sName))
            {
                int count = 0;
                int[] money = new int[10000];

                for (int i = 0; i < 10000; i++)
                    money[i] = 0;

                foreach (var values in stockDic1[sName])
                {
                    money[count] = values;
                    count++;
                }
                return money;
            }
            else
            {
                return null;
            }
        }

        public string[] GetClientStockName(string id) // 아이디 넣으면 사용자가 가지고 있는 주식 이름 반환
        {
            if (clientStockDic1.ContainsKey(id))
            {
                int count = 0;
                string[] sName = new string[100];
                for (int i = 0; i < 100; i++)
                    sName[i] = "";

                foreach (var values in clientStockDic1[id])
                {
                    sName[count] = values;
                    count++;
                }
                return sName;
            }
            else
            {
                return null;
            }
        }

        public string GetClientRandomStockName(string id)
        {
            Random random = new Random();
            int ran_num = 0;
            if (clientStockDic1.ContainsKey(id) == true)
            {
                string[] names = clientStockDic1[id];
                ran_num = random.Next(0, clientStockDic1[id].Length);
                return names[ran_num];
            }
            else
            {
                return "0";
            }
        }

        public int GetClientStockNum(string id, string sName) // 아이디 넣으면 사용자가 가지고 있는 주식 개수 반환
        {
            string[] val = new string[] { id, sName };
            int count = 0;
            if (clientStockDic2.ContainsKey(val))      
            {
                int[] sNum = new int[10000];
                for (int i = 0; i < 10000; i++)
                    sNum[i] = 0;

                foreach (var values in clientStockDic2[val])
                {
                    count++;
                }
                return sNum[count - 1];
            }
            else
            {
                return 0;
            }

        }

        public int GetSellingStockNum(string id, string sName) // 판매하는 주식의 개수 반환 / value : 판매자 아이디, 판매할 주식 이름
        {
            if (sellingStockTimeDic2.ContainsKey(new string[] { id, sName }))
            {
                int stockNum = sellingStockTimeDic2[new string[] { id, sName }];
                return stockNum;
            }
            else
            {
                return 0;
            }
        }

        public int GetSellingStockPrice(string id, string sName) // 판매하는 주식 가격 반환 / value : 판매자 아이디, 판매할 주식 이름
        {
            if (sellingStockTimeDic3.ContainsKey(new string[] { id, sName }))
            {
                return sellingStockTimeDic3[new string[] { id, sName }];
            }
            else
            {
                return 0;
            }
        }

        /*public int[] GetBuyingStockNum(string id, string sName)
        {
            if (buyingStockTimeDic2.ContainsKey(new string[] { id, sName }))
            {
                int count = 0;
                int[] stockNum = new int[10000];
                for (int i = 0; i < 10000; i++)
                    stockNum[i] = 0;

                foreach (var values in buyingStockTimeDic2[new string[] { id, sName }])
                {
                    stockNum[count] = values;
                    count++;
                }

                return stockNum;
            }
            else
            {
                return null;
            }
        }

        public int[] GetBuyingStockPrice(string id, string sName)
        {
            if (buyingStockTimeDic3.ContainsKey(new string[] { id, sName }))
            {
                return buyingStockTimeDic3[new string[] { id, sName }];
            }
            else
            {
                return null;
            }
        }*/

        public int GetClientMoney(string id)
        {
            int money = 0;
            if (clientMoney.ContainsKey(id))
            {
                money = clientMoney[id];
            }
            return money;
        }

        public string[] GetStockInfo(string sName, int money) // 종목 이름, 종목 시세, 등락값, 등락율, 등락
        {
            string[] returnValue = new string[5];
            int[] t_tempStock = new int[10000];
            int[] t_oldStock = new int[1000000];

            int count1 = 0;
            int count2 = 0;
            bool check = false; // 해당 주식의 거래 횟수가 2번 이상?

            returnValue[0] = sName;
            returnValue[1] = "0";
            returnValue[2] = "0";
            returnValue[3] = "0%";
            returnValue[4] = "1";

            if (tempStock.ContainsKey(sName))
            {
                foreach (var items in tempStock[sName])
                {
                    if (items != 0)
                    {
                        t_tempStock[count1] = items;
                        count1++;
                    }
                }
            }

            foreach (var items in stockDic1[sName])
            {
                t_oldStock[count2] = items;
                count2++;
            }       

            int[] tempStocks = new int[count1];
            int[] oldStock = new int[count2];

            for (int i = 0; i < count1; i++)
            {
                tempStocks[i] = t_tempStock[i];
            }

            for (int i = 0; i < count2; i++)
            {
                oldStock[i] = t_oldStock[i];
            }

            if (count1 >= 2)
                check = true;

            if (check == true)
            {
                if (tempStocks[count1 - 1] > tempStocks[count1 - 2]) // 최신 가격 상승 (2)
                {
                    returnValue[1] = tempStocks[count1 - 1].ToString();
                    returnValue[2] = (tempStocks[count1 - 1] - tempStocks[count1 - 2]).ToString();
                    returnValue[3] = ((tempStocks[count1 - 1] - tempStocks[count1 - 2]) / tempStocks[count1 - 2]).ToString();
                    returnValue[4] = "2";
                }
                else if (tempStocks[count1 - 1] == tempStocks[count1 - 2]) // 최신 가격 그대로 (1)
                {
                    returnValue[1] = tempStocks[count1 - 2].ToString();
                    returnValue[2] = "0";
                    returnValue[3] = "0";
                    returnValue[4] = "1";
                }
                else // 최신 가격 하락 (0)
                {
                    returnValue[1] = tempStocks[count1 - 1].ToString();
                    returnValue[2] = (tempStocks[count1 - 1] - tempStocks[count1 - 2]).ToString();
                    returnValue[3] = ((tempStocks[count1 - 2] - tempStocks[count1 - 1]) / tempStocks[count1 - 2]).ToString();
                    returnValue[4] = "0";
                }
            }
            else
            {
                if (count1 == 1)
                {
                    if (tempStocks[count1 - 1] > oldStock[count2 - 1])
                    {
                        returnValue[1] = tempStocks[count1 - 1].ToString();
                        returnValue[2] = (tempStocks[count1 - 1] - oldStock[count2 - 1]).ToString();
                        returnValue[3] = ((tempStocks[count1 - 1] - oldStock[count2 - 1]) / oldStock[count2 - 1]).ToString();
                        returnValue[4] = "2";
                    }
                    else if (tempStocks[count1 - 1] == oldStock[count2 - 1])
                    {
                        returnValue[1] = oldStock[count2-1].ToString();
                        returnValue[2] = "0";
                        returnValue[3] = "0";
                        returnValue[4] = "1";
                    }
                    else
                    {
                        returnValue[1] = tempStocks[count1 - 1].ToString();
                        returnValue[2] = (tempStocks[count1 - 1] - oldStock[count2 - 1]).ToString();
                        returnValue[3] = ((tempStocks[count1 - 1] - oldStock[count2 - 1]) / oldStock[count2 - 1]).ToString();
                        returnValue[4] = "0";
                    }
                }
                else
                {
                    if (oldStock[count2 - 1] > oldStock[count2 - 2])
                    {
                        returnValue[1] = oldStock[count2 - 1].ToString();
                        returnValue[2] = (oldStock[count2 - 1] - oldStock[count2 - 2]).ToString();
                        returnValue[3] = ((oldStock[count2 - 1] - oldStock[count2 - 2]) / oldStock[count2 - 2]).ToString();
                        returnValue[4] = "2";
                    }
                    else if (oldStock[count2 - 1] == oldStock[count2 - 2])
                    {
                        returnValue[1] = oldStock[count2 - 2].ToString();
                        returnValue[2] = "0";
                        returnValue[3] = "0";
                        returnValue[4] = "1";
                    }
                    else
                    {
                        returnValue[1] = oldStock[count2 - 1].ToString();
                        returnValue[2] = (oldStock[count2 - 1] - oldStock[count2 - 2]).ToString();
                        returnValue[3] = ((oldStock[count2 - 1] - oldStock[count2 - 2]) / oldStock[count2 - 2]).ToString();
                        returnValue[4] = "0";
                    }
                }
            }
            return returnValue;
        }

        //====================================================================================================================================================


        public void ChangeTime() // 시간 1초에 30분
        {
            min += 30;

            int tempdays = 0;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    tempdays = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    tempdays = 30;
                    break;

                case 2:
                    tempdays = 28;
                    break;
            }

            if (min == 60)
            {
                if (hour == 23)
                {
                    if (day == tempdays)
                    {
                        if (month == 12)
                        {
                            year++;
                            month = 1;
                            day = 1;
                            hour = 0;
                            min = 0;
                        }
                        else
                        {
                            month++;
                            day = 1;
                            hour = 0;
                            min = 0;
                        }
                    }
                    else
                    {
                        day++;
                        hour = 0;
                        min = 0;
                    }
                }
                else
                {
                    hour++;
                    min = 0;
                }
            }
            else
            {

            }
        }

        public int[] GetTime() // 시간 반환
        {
            int[] time = new int[5]; // 년도, 월, 일, 시, 분
            time[0] = year;
            time[1] = month;
            time[2] = day;
            time[3] = hour;
            time[4] = min;

            return time;
        }

        public bool Login(string id, string password) // 일치 true반환, 불일치 false반환
        {
            bool checkUser = false;

            if (clientDic.ContainsKey(id)==true) {
                if (clientDic[id].Contains(password)==true){
                    checkUser = true;
                }
            }

            return checkUser;
        }

        public void Join(string id, string name, string password, string account, string accountPassword, string hint, string hintAnswer, int studentNum, string schoolName)
        {
            if (clientDic.ContainsKey(id) == false)
            {
                clientDic.Add(id, new string[] { name, password, bank.MakeAccount(), accountPassword, hint, hintAnswer, studentNum.ToString(), schoolName });
                clientMoney.Add(id, 100000000);
            }
        }

        public string FindID(string name, string schoolName, int studentNum)
        {
            string id = "해당유저의 아이디가 존재하지 않습니다.";

            foreach (var key in clientDic.Keys)
            {
                if (clientDic[key].Contains(name) && clientDic[key].Contains(schoolName) && clientDic[key].Contains(studentNum.ToString()))
                {
                    id = key;
                }
            }

            return id;
        }

        public bool FindPass(string id, string hint, string hintAnswer) // 먼저 자신 확인
                                                                        // 이름, 패스워드, 계좌번호, 계좌 비밀번호, 힌트, 힌트정답, 학번, 학교이름
        {
            bool checkUser = false;
            string[] array = new string[8];

            if (clientDic.ContainsKey(id))
            {
                array = clientDic[id];
                if (hint == array[4] && hintAnswer == array[5])
                    checkUser = true;
            }
            return checkUser;
        }

        public void ResetPass(string id, string password) // 그후 패스워드 변경
        {
            string[] array = new string[8];

            array = clientDic[id];
            array[1] = password;

            clientDic.Remove(id);
            clientDic.Add(id, array);
        }

        public bool CheckIdRedundancy(string id) // id 중복확인 - 겹치면 true 안겹치면 false
        {
            bool checkSame = false;
            foreach (var key in clientDic.Keys)
            {
                if (id == key)
                {
                    checkSame = true;
                }
            }
            return checkSame;
        }

        public bool CheckPasswordRedundancy(string first, string second) // 계좌비번, 유저비번 password 중복확인 - 겹치면 true 안겹치면 false
        {
            bool checkSame = false;
            if (first == second)
            {
                checkSame = true;
            }
            return checkSame;

        }


        //====================================================================================================================================================

        private void SaveTime()
        {
            string[] time = new string[5];
            int[] temp = new int[5];
            temp[0] = year;
            temp[1] = month;
            temp[2] = day;
            temp[3] = hour;
            temp[4] = min;

            for (int i = 0; i < 5; i++)
                time[i] = temp[i].ToString();

            timeDic.Add("Time", time);

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw = new StreamWriter(folder + @"\TimeDic.txt");
            foreach (var values in time)
            {
                sw.WriteLine(values.ToString());
            }
            sw.Close();
        }

        void SaveClientStockDic()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            foreach (var name in clientStockDic2.Keys)
            {
                string[] array = new string[2];
                array = name;
                StreamWriter sw2 = new StreamWriter(folder + @"\" + array[0] + array[1] + "ClientDic2.txt");
                string tempLine = clientStockDic2[name];
                sw2.WriteLine(tempLine);
                sw2.Close();
            }
            foreach (var name in clientStockDic1.Keys)
            {
                File.Delete(folder + @"\" + name + "ClientDic1.txt");
                //FileStream WriteData = new FileStream(folder + @"\" + name + "ClientDic1.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
                StreamWriter sw1 = new StreamWriter(folder + @"\" + name + "ClientDic1.txt");
                foreach (var values in clientStockDic1[name]) //key: 아이디 / value : 주식 이름
                {
                    if (values != "" && values != null)
                        sw1.WriteLine(values);
                }
                sw1.Close();
                //WriteData.Close();
            }
        }

        void LoadClientStockDic1()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] check = Directory.GetFiles(folder);

            int count = 0;
            foreach (var name in ClientKeys["key"])
            {
                if (check.Contains(folder + @"\" + name + "ClientDic1.txt"))
                {
                    string[] tempLine1 = new string[1000000];
                    StreamReader sr = new StreamReader(folder + @"\" + name + "ClientDic1.txt");
                    while (!sr.EndOfStream)
                    {
                        tempLine1[count] = sr.ReadLine();
                        count++;
                    }
                    string[] array = new string[count];
                    for (int i = 0; i < count; i++)
                    {

                        array[i] = tempLine1[i];
                    }
                    clientStockDic1.Add(name, array);
                    sr.Close();
                }
            }
        }

        void LoadClientStockDic2()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] check = Directory.GetFiles(folder);
            foreach (var name in clientStockDic1.Keys)
            {
                foreach (var values in stock)
                {
                    if (check.Contains(folder + @"\" + name + values + "ClientDic2.txt"))
                    {
                        StreamReader sr = new StreamReader(folder + @"\" + name + values + "ClientDic2.txt");
                        string tempLine = sr.ReadLine();
                        clientStockDic2.Add(new string[] { name, values }, tempLine);
                        sr.Close();
                    }
                }
            }
        }

        private void LoadTime() // 시간 딕셔너리에서 동기화
        {
            if (checkCountDic.ContainsKey("ok") == true)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamReader sr = new StreamReader(folder + @"\TimeDic.txt");
                int[] time = new int[5];
                string[] temp = new string[5];

                for (int i = 0; i < 5; i++)
                {
                    time[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();
                year = time[0];
                month = time[1];
                day = time[2];
                hour = time[3];
                min = time[4];
            }

        }

        void SaveSellingStockTimeDic()
        {
            foreach (var values in sellerName["key"])
            {
                foreach (var sName in stock)
                {
                    if (sellingStockTimeDic2.ContainsKey(new string[] { values, sName }))
                    {
                        string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        StreamWriter sw1 = new StreamWriter(folder + @"\" + values + sName + "SellingStockTimeDic2.txt");
                        StreamWriter sw2 = new StreamWriter(folder + @"\+" + values + sName + "SellingStockTimeDic3.txt");
                        sw1.WriteLine("" + sellingStockTimeDic2[new string[] { values, sName }]);
                        sw2.WriteLine("" + sellingStockTimeDic3[new string[] { values, sName }]);
                        sw1.Close();
                        sw2.Close();
                    }
                }
            }
        }

        void LoadSellingStockTimeDic()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] check = Directory.GetFiles(folder);
            foreach (var values in sellerName["key"])
            {
                foreach (var sName in stock)
                {
                    if (check.Contains(folder + @"\" + values + sName + "SellingStockTimeDic2.txt") == true)
                    {
                        StreamReader sr1 = new StreamReader(folder + @"\" + values + sName + "SellingStockTimeDic2.txt");
                        StreamReader sr2 = new StreamReader(folder + @"\" + values + sName + "SellingStockTimeDic3.txt");
                        string tempLine1, tempLine2;
                        tempLine1 = sr1.ReadLine();
                        tempLine2 = sr2.ReadLine();
                        sellingStockTimeDic2.Add(new string[] { values, sName }, int.Parse(tempLine1));
                        sellingStockTimeDic3.Add(new string[] { values, sName }, int.Parse(tempLine2));
                        sr1.Close();
                        sr2.Close();
                    }
                }
            }
        }

        void SaveSellerName()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw = new StreamWriter(folder + @"\SellerName.txt");
            foreach (var names in sellerName["key"])
            {
                sw.WriteLine("" + names);
            }
            sw.Close();
        }

        void LoadSellerName()
        {
            string[] tempArray = new string[10000];
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int count = 0;
            StreamReader sr = new StreamReader(folder + @"\SellerName.txt");
            while (!sr.EndOfStream)
            {
                tempArray[count] = sr.ReadLine();
                count++;
            }
            string[] Array = new string[count];
            for (int i = 0; i < count; i++)
            {
                Array[i] = tempArray[i];
            }
            sellerName.Add("key", Array);
            sr.Close();
        }

        void SaveBuyerName()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw = new StreamWriter(folder + @"\BuyerName.txt");
            foreach (var names in buyerName["key"])
            {
                sw.WriteLine("" + names);
            }
            sw.Close();
        }

        void LoadBuyerName()
        {
            string[] tempArray = new string[10000];
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int count = 0;
            StreamReader sr = new StreamReader(folder + @"\BuyerName.txt");
            while (!sr.EndOfStream)
            {
                tempArray[count] = sr.ReadLine();
                count++;
            }
            string[] Array = new string[count];
            for (int i = 0; i < count; i++)
            {
                Array[i] = tempArray[i];
            }
            buyerName.Add("key", Array);
            sr.Close();
        }

        public void SaveClientMoney()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            foreach (var names in clientMoney.Keys)
            {
                StreamWriter sw = new StreamWriter(folder + @"\" + names + "ClientMoney.txt");
                sw.WriteLine("" + clientMoney[names]);
                sw.Close();
            }
        }

        void LoadClientMoney()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int money;

            foreach (var names in ClientKeys["key"])
            {
                StreamReader sr = new StreamReader(folder + @"\" + names + "ClientMoney.txt");
                money = int.Parse(sr.ReadLine());
                sr.Close();
                clientMoney[names] = money;
            }
        }

        void SaveStock()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            for (int k = 0; k < 30; k++)
            {
                string key;
                if (tempStock.ContainsKey(stock[k]) == true)
                {
                    key = stock[k];
                    FileStream ReadData = new FileStream(folder + @"\" + key + "StockDic1.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    FileStream WriteData = new FileStream(folder + @"\" + key + "StockDic1.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw1 = new StreamWriter(WriteData);
                    StreamReader sr1 = new StreamReader(ReadData);
                    int[] tempOldValues = new int[10000000];
                    int[] tempValues = new int[10000000];
                    int count1 = 0;
                    int count2 = 0;

                    foreach(var values in tempStock[key])
                    {
                        tempValues[count1] = values;
                        count1++;
                    }

                    foreach(var values in stockDic1[key])
                    {
                        tempOldValues[count2] = values;
                        count2++;
                    }

                    int[] oldValues = new int[count1 + count2];
                    for (int i = 0; i < count2; i++)
                    {
                        oldValues[i] = tempOldValues[i];
                    }

                    for (int i = 0; i < count1; i++)
                    {
                        oldValues[count2 + i] = tempValues[i];
                    }

                    for (int i = 0; i < count1 + count2; i++)
                    {
                        string tempLine = sr1.ReadLine();
                        if (tempLine != "" && tempLine != null)
                            sw1.WriteLine(tempLine);
                    }
                    sw1.Close();
                    sr1.Close();
                    ReadData.Close();
                    WriteData.Close();
                    Thread.Sleep(100);
                }
            }
            for (int k = 0; k < 30; k++)
            {
                string key;
                if (tempStock.ContainsKey(stock[k]) == false)
                {
                    key = stock[k];
                    FileStream WriteData11 = new FileStream(folder + @"\" + key + "StockDic1.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
                    StreamWriter sw1 = new StreamWriter(WriteData11);
                    foreach (var values in stockDic1[key])
                    {
                        sw1.WriteLine("" + values);
                    }
                    sw1.Close();
                    WriteData11.Close();
                    Thread.Sleep(100);
                }
            }
        }

        private void LoadStock()
        {


            if (checkCountDic.ContainsKey("ok") == false)
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                int i = 0;
                foreach (var values in stock)
                    msd.MakeData(values);

                foreach (var values in stock)
                {
                    i = 0;
                    int[] temp = new int[1000000];
                    StreamReader sr = new StreamReader(folder + @"\" + values + "StockDic1.txt");
                    while (!sr.EndOfStream)
                    {
                        temp[i] = int.Parse(sr.ReadLine());
                        i++;
                    }
                    sr.Close();
                    int[] array = new int[i];
                    for (int count = 0; count < 9490; count++)
                    {
                        array[count] = temp[count];
                    }
                    stockDic1.Add(values, array);
                }
            }
            else
            {
                foreach (var key in stock)
                {
                    string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    FileStream ReadData = new FileStream(folder + @"\" + key + "StockDic1.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    FileStream WriteData = new FileStream(folder + @"\" + key + "StockDic1.txt", FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                    StreamWriter sw1 = new StreamWriter(WriteData);
                    StreamReader sr1 = new StreamReader(ReadData);
                    int[] tempArray = new int[100000000];
                    string tempLine;
                    int i = 0;

                    while (!sr1.EndOfStream)
                    {
                        tempLine = sr1.ReadLine();
                        sw1.WriteLine(tempLine);
                        if (tempLine != "")
                        {
                            tempArray[i] = int.Parse(tempLine);
                            i++;
                        }
                    }
                    //Array.Resize<int>(ref tempArray, i);
                    int[] array = new int[i];
                    for (int count = 0; count < i; count++)
                    {
                        array[count] = tempArray[count];
                    }
                    stockDic1.Add(key, array);
                    stockDic2.Add(key, 1000000);
                    sw1.Close();
                    sr1.Close();
                    ReadData.Close();
                    WriteData.Close();

                }
            }
        }

        public void SaveKeys()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sw = new StreamWriter(folder + @"\KeysDic.txt");
            foreach (var key in clientDic.Keys)
            {
                sw.WriteLine("" + key);
            }
            sw.Close();
        }

        void LoadKeys()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamReader sr = new StreamReader(folder + @"\KeysDic.txt");
            int count = 0;
            string[] tempKeys = new string[1000];
            while (!sr.EndOfStream)
            {
                tempKeys[count] = sr.ReadLine();
                count++;
            }
            string[] keys = new string[count];
            for (int i = 0; i < count; i++)
            {
                keys[i] = tempKeys[i];
            }
            //Array.Resize<string>(ref keys, count);
            sr.Close();
            ClientKeys.Add("key", keys);
        }

        void LoadClient()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] temp = new string[8];
            if (ClientKeys.ContainsKey("key"))
            {
                foreach (var key in ClientKeys["key"])
                {
                    int count = 0;
                    StreamReader sr = new StreamReader(folder + @"\" + key + "ClientDic.txt");
                    while (count != 8)
                    {
                        temp[count] = sr.ReadLine();
                        count++;
                    }
                    clientDic.Add(key, temp);
                    sr.Close();
                }
            }
        }

        public void SaveClient()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            foreach (var key in clientDic.Keys)
            {
                string tempLine;
                StreamWriter sw = new StreamWriter(folder + @"\" + key + "ClientDic.txt");
                foreach (var values in clientDic[key])
                {
                    tempLine = values;
                    sw.WriteLine(tempLine);
                }
                sw.Close();
            }
        }

        void LoadSellingStock1()
        {
        }
        void SaveSellingStock2()
        {
            string[] name;
            foreach (var key in clientDic.Keys)
            {
                foreach (var sName in stock)
                {
                    int count = 0;
                    name = new string[100];
                    if (sellingStockTimeDic2.ContainsKey(new string[] { key, sName }))
                    {
                        name[count] = sName;
                        count++;
                    }
                }

            }
        }

        /*void SaveMyStockInfo()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            for (int i = 0; i < 30; i++)
            {
                FileStream WriteData = new FileStream(folder + @"\" + key + "ClientMyStock.txt", FileMode.Open, FileAccess.Write, FileShare.Write);
                FileStream ReadData = new FileStream(folder + @"\" + key + "ClientMyStock.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamWriter sw = new StreamWriter(WriteData);
                StreamReader sr = new StreamReader(ReadData);
                foreach (var key in myStockInfo[stock[i]])
                {
                    
                    
                }
            }
        }*/

        void LoadMyStockInfo()
        {

        }

        public void Save()
        {
            SaveTime();
            SaveClientStockDic();
            SaveStock();
            SaveKeys();
            SaveClient();
            SaveClientMoney();
            //SaveBuyerName();
            SaveSellerName();
            SaveSellingStockTimeDic();

        }

        public void Load()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] check = Directory.GetFiles(folder);
            if (check.Contains(folder + @"\너구리StockDic1.txt"))
            {
                checkCountDic.Add("ok", 1);
                LoadTime();
                LoadKeys();
                LoadStock();
                LoadClient();
                LoadClientMoney();
                //LoadBuyerName();
                LoadSellerName();
                LoadSellingStockTimeDic();
                LoadClientStockDic1();
                LoadClientStockDic2();

            }
            else
            {
                foreach (var items in stock)
                {
                    stockDic2.Add(items, 1000000);
                }
                LoadTime();
                LoadStock();

                //ClientKeys.Add("key", new string[] { "0" });
                //clientDic.Add("0", new string[] { "0" });
                //clientMoney.Add("0", 0);
                //buyerName.Add("key", new string[] { "0" });
                sellerName.Add("key", new string[] { "0" });
                //stockDic1.Add("0", new int[] { 0 });
                //stockDic2.Add("0", 0);
                //sellingStockTimeDic2.Add(new string[] { "0", "0" }, 0);
                //sellingStockTimeDic3.Add(new string[] { "0", "0" }, 0);                
                //foreach (var keys in stock)
                //{
                //   tempStock.Add(keys, new int[] { 0 });
                //}
                //clientStockDic1.Add("0", new string[] { "0" });
                //clientStockDic2.Add(new string[] { "0","0" }, "0");

            }
        }
    }
}
