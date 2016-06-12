using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using VendingMachine_SD.Model;

namespace VendingMachine_SD.Controller
{


    class CoinSlot_Controller
    {
        DrinksModel drinksModel = new DrinksModel();
        CoinsModel coinsModel = new CoinsModel();
        

        public string CoinDenomination { get; set; }
       private int Coin50cDenominationCount = 0;
        private int Coin20cDenominationCount = 0;
        private int Coin10cDenominationCount = 0;
        public double InsertedCoin { get; set; }
        public double TotalInsertedCoin { get; set; }

        public bool IsCoinValid()
        {
            
            string valid_coin_pattern = @"^RM\s+0\.(1|2|5)0";
            Regex rgx1 = new Regex(valid_coin_pattern);
            Match match_10c_20c_50c = rgx1.Match(CoinDenomination);

            if (match_10c_20c_50c.Success)
            {
                

                return true;
            }
            else
            {
                return false;
            }
                //Mockup return value START
               

            //Mockup return value END

        }
        public void resetTotalInsertedCoins()
        {
            TotalInsertedCoin = 0;
        }
        public double getTotalInsertedCoins()
        {
            
            int numbercoin_10c_to_update = Convert.ToInt32(coinsModel.NumberOf10cCoins);
            int numbercoin_20c_to_update = Convert.ToInt32(coinsModel.NumberOf20cCoins);
            int numbercoin_50c_to_update = Convert.ToInt32(coinsModel.NumberOf50cCoins);

            string valid_10c_coin_pattern = @"^RM\s+0\.10";
            string valid_20c_coin_pattern = @"^RM\s+0\.20";
            string valid_50c_coin_pattern = @"^RM\s+0\.50";
            Regex rgx2 = new Regex(valid_10c_coin_pattern);
            Regex rgx3 = new Regex(valid_20c_coin_pattern);
            Regex rgx4 = new Regex(valid_50c_coin_pattern);
            Match match_10c = rgx2.Match(CoinDenomination);
            Match match_20c = rgx3.Match(CoinDenomination);
            Match match_50c = rgx4.Match(CoinDenomination);
            if (match_10c.Success)
            {
                TotalInsertedCoin = TotalInsertedCoin + 0.1;
                numbercoin_10c_to_update = Convert.ToInt32(coinsModel.NumberOf10cCoins) + 1;
            }
            if (match_20c.Success)
            {
                TotalInsertedCoin = TotalInsertedCoin + 0.2;
                numbercoin_20c_to_update = Convert.ToInt32(coinsModel.NumberOf20cCoins) + 1;
            }
            if (match_50c.Success)
            {
                TotalInsertedCoin = TotalInsertedCoin + 0.5;
                numbercoin_50c_to_update = Convert.ToInt32(coinsModel.NumberOf50cCoins) + 1;
            }

            coinsModel.NumberOf10cCoins = numbercoin_10c_to_update.ToString();
            coinsModel.NumberOf20cCoins = numbercoin_20c_to_update.ToString();
            coinsModel.NumberOf50cCoins = numbercoin_50c_to_update.ToString();

            coinsModel.updateCoinsCount();

            return TotalInsertedCoin;
        }
        public bool isInsertedMoneyEnough(int brands)
        {
            double selectedDrinkPrice = drinksModel.getDrinkPrice(brands);
            getBalance(brands);
            if (getTotalInsertedCoins() >= selectedDrinkPrice)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public double getBalance(int brands)
        {
            double selectedDrinkPrice = drinksModel.getDrinkPrice(brands);
            coinsModel.GetDenominationCount();
            if (TotalInsertedCoin > selectedDrinkPrice)
            {
                //int FiftyCentCount = coinsModel.getCoinsCount(0.5);
                //int TwentyCentCount = coinsModel.getCoinsCount(0.2);
                //int TenCentCount = coinsModel.getCoinsCount(0.1);
                   ////LOGIC FOR COINS COUNT/UPDATE////START////
                double totalBalance = TotalInsertedCoin - drinksModel.getDrinkPrice(brands);

                int numbercoin_20c_to_return = 0;
                int numbercoin_10c_to_return = 0;
                int numbercoin_50c_to_return = 0;

                int numbercoin_20c_to_update = 0;
                int numbercoin_10c_to_update = 0;
                int numbercoin_50c_to_update = 0;


                int numbercoin_10c_in_storage = 0;
                int numbercoin_20c_in_storage = 0;
                int numbercoin_50c_in_storage = 0;

                int numbercoin_10c_on_shortage = 0;
                int numbercoin_20c_on_shortage = 0;
                int numbercoin_50c_on_shortage = 0;
                //check number of coins in storage for each denomination
                
                numbercoin_10c_in_storage = coinsModel.getDenominationCount("10Cent");
                numbercoin_20c_in_storage = coinsModel.getDenominationCount("20Cent");
                numbercoin_50c_in_storage = coinsModel.getDenominationCount("50Cent");

                //count number of coins to return for each denomination
                numbercoin_50c_to_return = Convert.ToInt32(Math.Truncate(Convert.ToDouble(totalBalance / 0.50)));
                //if number of coin 50c in storage not enough, we return whatever we have
                if (numbercoin_50c_to_return > numbercoin_50c_in_storage)
                {
                    numbercoin_50c_on_shortage = numbercoin_50c_to_return - numbercoin_50c_in_storage;
                    numbercoin_50c_to_return = numbercoin_50c_in_storage;
                }
                if ((totalBalance % 0.50) + (numbercoin_50c_on_shortage * 0.5) >= 0.2)
                {
                    if (numbercoin_50c_on_shortage > 0)
                    {
                        numbercoin_20c_to_return = Convert.ToInt32(Math.Truncate(Math.Round((totalBalance % 0.50) + ((numbercoin_50c_on_shortage * 0.5)) / 0.20)));
                    }
                    else
                    {
                        numbercoin_20c_to_return = Convert.ToInt32(Math.Truncate(Math.Round((totalBalance % 0.50) / 0.20)));
                    }
                    //if number of coin 20c in storage not enough, we return whatever we have
                    if (numbercoin_20c_to_return > numbercoin_20c_in_storage)
                    {
                        numbercoin_20c_on_shortage = numbercoin_20c_to_return - numbercoin_20c_in_storage;
                        numbercoin_20c_to_return = numbercoin_20c_in_storage;
                    }
                }
                if ((totalBalance % 0.50 % 0.20) + (numbercoin_20c_on_shortage * 0.20) > 0 && (totalBalance % 0.50 % 0.20) + (numbercoin_20c_on_shortage * 0.20) <= 0.1)
                {
                    if (numbercoin_20c_on_shortage > 0)
                    {
                        numbercoin_10c_to_return = Convert.ToInt32(Math.Truncate(Math.Round((totalBalance % 0.50 % 0.20) + (numbercoin_20c_on_shortage * 0.20) / 0.10)));
                    }
                    else
                    {
                        numbercoin_10c_to_return = Convert.ToInt32(Math.Truncate(Math.Round(totalBalance % 0.50 % 0.20 / 0.10)));
                    }
                    //if number of coin 10c in storage not enough, we return whatever we have
                    if (numbercoin_10c_to_return > numbercoin_10c_in_storage)
                    {
                        numbercoin_10c_on_shortage = numbercoin_10c_to_return - numbercoin_10c_in_storage;
                        numbercoin_10c_to_return = numbercoin_10c_in_storage;
                    }
                }

                //DEBUG
                // MessageBox.Show(numbercoin_50c_to_return.ToString());
                // MessageBox.Show(numbercoin_20c_to_return.ToString());
                //MessageBox.Show(numbercoin_10c_to_return.ToString());
                //now we have the update the coins database
                
                numbercoin_10c_to_update = Convert.ToInt32(coinsModel.NumberOf10cCoins) - numbercoin_10c_to_return;
                numbercoin_20c_to_update = Convert.ToInt32(coinsModel.NumberOf20cCoins) - numbercoin_20c_to_return;
                numbercoin_50c_to_update = Convert.ToInt32(coinsModel.NumberOf50cCoins) - numbercoin_50c_to_return;

                coinsModel.NumberOf10cCoins = numbercoin_10c_to_update.ToString();
                coinsModel.NumberOf20cCoins = numbercoin_20c_to_update.ToString();
                coinsModel.NumberOf50cCoins = numbercoin_50c_to_update.ToString();

                coinsModel.updateCoinsCount();

                ////LOGIC FOR COINS COUNT/UPDATE////END////
                return totalBalance;
            }
            else if (TotalInsertedCoin == selectedDrinkPrice)
            {
                return 0;
            }
            else
            {
                coinsModel.NumberOf10cCoins = Convert.ToInt32(coinsModel.NumberOf10cCoins).ToString();
                coinsModel.NumberOf20cCoins = Convert.ToInt32(coinsModel.NumberOf20cCoins).ToString();
                coinsModel.NumberOf50cCoins = Convert.ToInt32(coinsModel.NumberOf50cCoins).ToString();
                return TotalInsertedCoin;
            }
            
        }
        public int getCoinDenominationCount(String CoinDenomination) {

            if (CoinDenomination == "50Cent") { return coinsModel.getDenominationCount("50Cent"); }
            else if (CoinDenomination == "20Cent") { return coinsModel.getDenominationCount("20Cent"); }
            else if (CoinDenomination == "10Cent") { return coinsModel.getDenominationCount("10Cent"); }
            else
            {
                return 0;
            }
        }
    
    }


}
