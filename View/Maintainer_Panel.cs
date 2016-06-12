using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VendingMachine_SD.Model;

namespace VendingMachine_SD
{
    public partial class Maintainer_Panel : Form
    {
        public int Denonination { get; set; }
        public double Cents { get; set; }



        public Maintainer_Panel()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
            pnlMaintainerCashCollector.Enabled = false;
            grpbxProductsPanel.Enabled = false;
            cmbx_InsertProductPrice.Enabled = false;
            cmbxSelectCent.Enabled = false;
            btnSaveNewProductPrice.Enabled = false;
        }
        private void lbl_CoinCount_Click(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btn_Brand4_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// This event is fired upon clicking the buttorn beside Maintainer password textbox.
        /// This event is passing the textbox value to the model MaintainerCredentialModel.cs to 
        /// communicate with database and to fetch the right data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MaintainerPassword_Click(object sender, EventArgs e)
        {
            bool isPasswordExist = false;
            try
            {
                string password = txt_maintainer_Password.Text;
                MaintainerCredentialsModel maintainerCredentialsModel = new MaintainerCredentialsModel();
                isPasswordExist = maintainerCredentialsModel.getMaintainerPass(password);
                if (isPasswordExist)
                {
                    lbl_PasswordValidation.Text = "Unlocked";
                    groupBox1.Enabled = true;
                    grpbxProductsPanel.Enabled = true;
                    pnlMaintainerCashCollector.Enabled = true;
                    txt_maintainer_Password.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// This event is performing the validation for Maintainer password textbox.
        /// After executing this event the Click event will be fired.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_maintainer_Password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maintainer_Password.Text))
            {
                lbl_PasswordValidation.Text = "Password is required!";
                txt_maintainer_Password.Focus();
            }
            else if (!Regex.IsMatch(txt_maintainer_Password.Text, @"[A-Za-z][A-Za-z0-9]{2,7}"))
            {
                lbl_PasswordValidation.Text = "Password invalid!";
                txt_maintainer_Password.Focus();
            }

        }
        private void btn_10c_Click(object sender, EventArgs e)
        {
            string denomination = "10Cent";
            var coinsModel = new CoinsModel();
            int denominationResult = coinsModel.getDenominationCount(denomination);
            lbl_coinCount.Text = denominationResult.ToString();
        }

        private void btn_20c_Click(object sender, EventArgs e)
        {
            string denomination = "20Cent";
            var coinsModel = new CoinsModel();
            int denominationResult = coinsModel.getDenominationCount(denomination);
            lbl_coinCount.Text = denominationResult.ToString();
        }

        private void btn_50c_Click(object sender, EventArgs e)
        {
            string denomination = "50Cent";
            var coinsModel = new CoinsModel();
            int denominationResult = coinsModel.getDenominationCount(denomination);
            lbl_coinCount.Text = denominationResult.ToString();

        }

        private void lblTotalCash_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_coinCount_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTotalCash_Click(object sender, EventArgs e)
        {
            object TotalCashHeldByMachine;
            CoinsModel coinsModel = new CoinsModel();
            TotalCashHeldByMachine = coinsModel.GetTotalCashHeldByMachine();
            lblTotalCash.Text = "RM" + " " + TotalCashHeldByMachine.ToString();
        }

        private void btnCollectCash_Click(object sender, EventArgs e)
        {
            CoinsModel coinsModel = new CoinsModel();
            coinsModel.CollectTotalCashHeldByMachine();
            lblCollectAllCash.Text = "Collect Total Cash.";
        }

        private void cmbx_InsertProductPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            Denonination = Convert.ToInt32(cmbx_InsertProductPrice.SelectedItem);
        }

        private void cmbxSelectCent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cents = Convert.ToDouble(cmbxSelectCent.SelectedItem);
            lblDisplayPrice.Text = Denonination + "." + Cents;

        }

        private void rdbBrand1_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_InsertProductPrice.Enabled = true;
            cmbxSelectCent.Enabled = true;
            btnSaveNewProductPrice.Enabled = true;
        }

        private void rdbBrand2_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_InsertProductPrice.Enabled = true;
            cmbxSelectCent.Enabled = true;
            btnSaveNewProductPrice.Enabled = true;

        }

        private void rdbBrand3_Click(object sender, EventArgs e)
        {

        }

        private void rdbBrand3_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_InsertProductPrice.Enabled = true;
            cmbxSelectCent.Enabled = true;
            btnSaveNewProductPrice.Enabled = true;
        }

        private void rdbBrand4_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_InsertProductPrice.Enabled = true;
            cmbxSelectCent.Enabled = true;
            btnSaveNewProductPrice.Enabled = true;
        }

        private void rdbBrand5_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_InsertProductPrice.Enabled = true;
            cmbxSelectCent.Enabled = true;
            btnSaveNewProductPrice.Enabled = true;
        }

        private void btnSaveNewProductPrice_Click(object sender, EventArgs e)
        {
            CoinsModel coinsModel = new CoinsModel();

            if (rdbBrand1.Checked && lblDisplayPrice.Text != "")
            {
                coinsModel.UpdateProductPrice(1, lblDisplayPrice.Text);

            }
            else if (rdbBrand2.Checked && lblDisplayPrice.Text != "")
            {
                coinsModel.UpdateProductPrice(2, lblDisplayPrice.Text);
            }
            else if (rdbBrand3.Checked && lblDisplayPrice.Text != "")
            {
                coinsModel.UpdateProductPrice(3, lblDisplayPrice.Text);
            }
            else if (rdbBrand4.Checked && lblDisplayPrice.Text != "")
            {
                coinsModel.UpdateProductPrice(4, lblDisplayPrice.Text);
            }
            else if (rdbBrand5.Checked && lblDisplayPrice.Text != "")
            {
                coinsModel.UpdateProductPrice(5, lblDisplayPrice.Text);
            }
            else
            {
                lblDisplayPrice.Text = "Choose Product.";
            }
        }

        private void rdbFinishPanel_CheckedChanged(object sender, EventArgs e)
        {
            //Make the panels disabled
            pnlMaintainerCashCollector.Enabled = false;
            panel1.Enabled = false;
            groupBox1.Enabled = false;
            grpbxProductsPanel.Enabled = false;

            //Exit the panel
        }
    }
}
