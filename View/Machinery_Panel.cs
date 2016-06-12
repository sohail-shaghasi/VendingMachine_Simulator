using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VendingMachine_SD.Model;

namespace VendingMachine_SD
{
    public partial class Machinery_Panel : Form
    {
        public Machinery_Panel()
        {
            InitializeComponent();
            GetNumberOfEachBrandDrinksCans();

        }
        public void GetNumberOfEachBrandDrinksCans()
        {
            var drinksModel = new DrinksModel();
            var coinsModel = new CoinsModel();
            drinksModel.GetNumberOfEachBrandDrinksCansFromdb();
            coinsModel.GetDenominationCount();

            txtBrand1Count.Text = drinksModel.NumberOfDrinksCansBrand1.ToString();
            txtBrand2Count.Text = drinksModel.NumberOfDrinksCansBrand2.ToString();
            txtBrand3Count.Text = drinksModel.NumberOfDrinksCansBrand3.ToString();
            txtBrand4Count.Text = drinksModel.NumberOfDrinksCansBrand4.ToString();
            txtBrand5Count.Text = drinksModel.NumberOfDrinksCansBrand5.ToString();
            txtNumberOf10cCoin.Text = coinsModel.NumberOf10cCoins.ToString();
            txtNumberOf20cCoin.Text = coinsModel.NumberOf20cCoins.ToString();
            txtNumberOf50cCoin.Text = coinsModel.NumberOf50cCoins.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBrand1Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBrand2Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }



        }

        private void txtBrand3Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBrand4Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBrand5Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOf10cCoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOf20cCoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtNumberOf50cCoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void lblDoorStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateMachineryPanelValues_Click(object sender, EventArgs e)
        {
            var drinksModel = new DrinksModel();
            var coinsModel = new CoinsModel();
            drinksModel.NumberOfDrinksCansBrand1 = Convert.ToDouble(txtBrand1Count.Text);
            drinksModel.NumberOfDrinksCansBrand2 = Convert.ToDouble(txtBrand2Count.Text);
            drinksModel.NumberOfDrinksCansBrand3 = Convert.ToDouble(txtBrand3Count.Text);
            drinksModel.NumberOfDrinksCansBrand4 = Convert.ToDouble(txtBrand4Count.Text);
            drinksModel.NumberOfDrinksCansBrand5 = Convert.ToDouble(txtBrand5Count.Text);
            coinsModel.NumberOf10cCoins = txtNumberOf10cCoin.Text;
            coinsModel.NumberOf20cCoins = txtNumberOf20cCoin.Text;
            coinsModel.NumberOf50cCoins = txtNumberOf50cCoin.Text;

            if (!string.IsNullOrEmpty(txtBrand1Count.Text) && !string.IsNullOrEmpty(txtBrand2Count.Text) && !string.IsNullOrEmpty(txtBrand3Count.Text) && !string.IsNullOrEmpty(txtBrand4Count.Text) && !string.IsNullOrEmpty(txtBrand5Count.Text) && !string.IsNullOrEmpty(coinsModel.NumberOf10cCoins) && !string.IsNullOrEmpty(coinsModel.NumberOf20cCoins) && !string.IsNullOrEmpty(coinsModel.NumberOf50cCoins)) ;
            {
                drinksModel.UpdateNumberOfEachBrandDrinksCans();
                coinsModel.updateCoinsCount();
                lblUpdateNotification.Text = "Records are updated.";
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            pnlDrinks.Enabled = false;
            pnlCoins.Enabled = false;
            pnlLocking.Enabled = false;
            lblDoorLocking.ForeColor = System.Drawing.Color.DarkRed;
            lblDoorLocking.BackColor = System.Drawing.Color.Black;
            lblDoorLocking.Text = "locked";
        }
    }
}
