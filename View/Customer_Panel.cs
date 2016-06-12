using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VendingMachine_SD.Controller;
using VendingMachine_SD.Model;

namespace VendingMachine_SD
{
    public partial class Customer_Panel : Form
    {
        DrinksSelector_Controller drinksSelector = new DrinksSelector_Controller();
        CoinSlot_Controller CoinSlot = new CoinSlot_Controller();
        DrinksModel drinks = new DrinksModel();
        public Customer_Panel()
        {
            InitializeComponent();
        }
        // When the customer panel's loaded, display the current price of each product
        private void Customer_Panel_Load(object sender, EventArgs e)
        {
            label_Display.Text = "SELECT DRINK";
            label_price_Brand1.Text = "RM " + string.Format("{0:0.00}", drinks.getDrinkPrice(1));
            label_price_Brand2.Text = "RM " + string.Format("{0:0.00}", drinks.getDrinkPrice(2));
            label_price_Brand3.Text = "RM " + string.Format("{0:0.00}", drinks.getDrinkPrice(3));
            label_price_Brand4.Text = "RM " + string.Format("{0:0.00}", drinks.getDrinkPrice(4));
            label_price_Brand5.Text = "RM " + string.Format("{0:0.00}", drinks.getDrinkPrice(5));
            rdbBrand1.Checked = false;
            rdbBrand2.Checked = false;
            rdbBrand3.Checked = false;
            rdbBrand4.Checked = false;
            rdbBrand5.Checked = false;



            /////

           
        }
        // When user push the cancel button, dispense all the inserted coins back to customer and reset everything
        private void button_cancel_Click(object sender, EventArgs e)
        {
            // we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            label_Display.Text = "INSERT COIN";

        }

         //When coin's inserted
        private void cmbx_insertCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //we check if the coin is valid
            CoinSlot.CoinDenomination = cmbx_insertCoin.SelectedItem.ToString();
            if (CoinSlot.IsCoinValid())
            {
                //If coin is valid we check if inserted money matches the drink's price
                //If match, return the balance if any, dispense the drink, update the coin storage and say thank you
                if (CoinSlot.isInsertedMoneyEnough(drinksSelector.DrinksBrand))
                {
                    label_Display.Text = "Thank you!";
                    
                    
                    lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
                    //DEBUG
                    //MessageBox.Show(CoinSlot.getCoinDenominationCount("50Cent").ToString());
                    //MessageBox.Show(CoinSlot.getCoinDenominationCount("20Cent").ToString());
                    //MessageBox.Show(CoinSlot.getCoinDenominationCount("10Cent").ToString());
                    CoinSlot.resetTotalInsertedCoins();
                    
                    //dispense drink
                    var drinksDispenser = new DrinksDispenser_Controller();
                    
                    pictureBox_dispensedDrink.Visible = true;
                    if (drinksSelector.DrinksBrand == 1)
                    {
                        pictureBox_dispensedDrink.BackColor = btn_Brand1.BackColor;
                        drinksDispenser.DrinksBrand = 1;
                        drinksDispenser.dispenseDrink();
                    }
                    else if(drinksSelector.DrinksBrand == 2)
                    {
                        pictureBox_dispensedDrink.BackColor = btn_Brand2.BackColor;
                        drinksDispenser.DrinksBrand = 2;
                        drinksDispenser.dispenseDrink();
                    }
                    else if (drinksSelector.DrinksBrand == 3)
                    {
                        pictureBox_dispensedDrink.BackColor = btn_Brand3.BackColor;
                        drinksDispenser.DrinksBrand = 3;
                        drinksDispenser.dispenseDrink();

                    }
                    else if (drinksSelector.DrinksBrand == 4)
                    {
                        pictureBox_dispensedDrink.BackColor = btn_Brand4.BackColor;
                        drinksDispenser.DrinksBrand = 4;
                        drinksDispenser.dispenseDrink();
                    }
                    else if (drinksSelector.DrinksBrand == 5)
                    {
                        pictureBox_dispensedDrink.BackColor = btn_Brand5.BackColor;
                        drinksDispenser.DrinksBrand = 5;
                        drinksDispenser.dispenseDrink();
                    }
                    else
                    {
                        pictureBox_dispensedDrink.Visible = false;
                    }
                    


                }
                //if not match, user need to insert more coin and display the inserted coin value everytime
                else
                {

                    label_Display.Text = "RM " + string.Format("{0:0.00}", CoinSlot.TotalInsertedCoin);

                }

            }
            // coin is not valid, return the coin back
            else
            {
                lbl_CoinDespenser.Text = cmbx_insertCoin.SelectedItem.ToString();
                label_Display.Text = "Invalid coin!";
            }
        }

        // When customer selects drink...
        private void rdbBrand1_CheckedChanged(object sender, EventArgs e)
        {
            drinksSelector.DrinksBrand = 1;

            //first we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            pictureBox_dispensedDrink.Visible = false;
            rdbBrand1.Checked = true;

            if (drinksSelector.IsBrandAvailable())
            {
                label_Availability_Brand1.Enabled = false;
                cmbx_insertCoin.Enabled = true;
                label_Display.Text = "INSERT COIN";
            }
            else
            {
                label_Availability_Brand1.Enabled = true;
                cmbx_insertCoin.Enabled = false;
                label_Display.Text = "";
            }
        }

        private void rdbBrand2_CheckedChanged(object sender, EventArgs e)
        {
            drinksSelector.DrinksBrand = 2;

            //first we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            pictureBox_dispensedDrink.Visible = false;
            rdbBrand2.Checked = true;

            if (drinksSelector.IsBrandAvailable())
            {
                label_Availability_Brand2.Enabled = false;
                cmbx_insertCoin.Enabled = true;
                label_Display.Text = "INSERT COIN";
            }
            else
            {
                label_Availability_Brand2.Enabled = true;
                cmbx_insertCoin.Enabled = false;
                label_Display.Text = "";
            }
        }

        private void rdbBrand3_CheckedChanged(object sender, EventArgs e)
        {
            drinksSelector.DrinksBrand = 3;

            //first we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            pictureBox_dispensedDrink.Visible = false;
            rdbBrand3.Checked = true;

            if (drinksSelector.IsBrandAvailable())
            {
                label_Availability_Brand3.Enabled = false;
                cmbx_insertCoin.Enabled = true;
                label_Display.Text = "INSERT COIN";
            }
            else
            {
                label_Availability_Brand3.Enabled = true;
                cmbx_insertCoin.Enabled = false;
                label_Display.Text = "";
            }
        }

        private void rdbBrand4_CheckedChanged(object sender, EventArgs e)
        {
            drinksSelector.DrinksBrand = 4;

            //first we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            pictureBox_dispensedDrink.Visible = false;
            rdbBrand4.Checked = true;

            if (drinksSelector.IsBrandAvailable())
            {
                label_Availability_Brand4.Enabled = false;
                cmbx_insertCoin.Enabled = true;
                label_Display.Text = "INSERT COIN";
            }
            else
            {
                label_Availability_Brand4.Enabled = true;
                cmbx_insertCoin.Enabled = false;
                label_Display.Text = "";
            }
        }

        private void rdbBrand5_CheckedChanged(object sender, EventArgs e)
        {
            drinksSelector.DrinksBrand = 5;

            //first we reset everything. Return the money back from previous session
            lbl_CoinDespenser.Text = "RM " + string.Format("{0:0.00}", CoinSlot.getBalance(drinksSelector.DrinksBrand));
            CoinSlot.resetTotalInsertedCoins();
            pictureBox_dispensedDrink.Visible = false;
            rdbBrand5.Checked = true;

            if (drinksSelector.IsBrandAvailable())
            {
                label_Availability_Brand5.Enabled = false;
                cmbx_insertCoin.Enabled = true;
                label_Display.Text = "INSERT COIN";
            }
            else
            {
                label_Availability_Brand5.Enabled = true;
                cmbx_insertCoin.Enabled = false;
                label_Display.Text = "";
            }
        }
    }
}
