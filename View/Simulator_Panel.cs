using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendingMachine_SD
{
    public partial class Simulator_Control_Panel : Form
    {
        public Simulator_Control_Panel()
        {
            InitializeComponent();
        }



        private void Simulator_Control_Panel_Load(object sender, EventArgs e)
        {

        }

        private void btn_CustomerPanel_Click(object sender, EventArgs e)
        {
            Customer_Panel customerpnl = new Customer_Panel();
            customerpnl.ShowDialog();
        }

        private void btn_MaintainerPanel_Click(object sender, EventArgs e)
        {
            Maintainer_Panel maintainerpnl = new Maintainer_Panel();
            maintainerpnl.ShowDialog();
        }

        private void btn_MachineryPanel_Click(object sender, EventArgs e)
        {
            Machinery_Panel machinerypnl = new Machinery_Panel();
            machinerypnl.ShowDialog();
        }

        private void rdb_ON_CheckedChanged(object sender, EventArgs e)
        {
            btn_CustomerPanel.Enabled = true;
            btn_MachineryPanel.Enabled = true;
            btn_MaintainerPanel.Enabled = true;
        }

        private void rdb_OFF_CheckedChanged(object sender, EventArgs e)
        {
            btn_CustomerPanel.Enabled = false;
            btn_MachineryPanel.Enabled = false;
            btn_MaintainerPanel.Enabled = false;
        }

        private void lbl_Simulation_Click(object sender, EventArgs e)
        {

        }
    }
}
