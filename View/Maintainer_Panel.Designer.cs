namespace VendingMachine_SD
{
    partial class Maintainer_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_PasswordValidation = new System.Windows.Forms.Label();
            this.btn_MaintainerPassword = new System.Windows.Forms.Button();
            this.txt_maintainer_Password = new System.Windows.Forms.TextBox();
            this.lbl_maintainerPassword = new System.Windows.Forms.Label();
            this.grb_maintainerPanel = new System.Windows.Forms.GroupBox();
            this.grpbxProductsPanel = new System.Windows.Forms.GroupBox();
            this.cmbxSelectCent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_InsertProductPrice = new System.Windows.Forms.ComboBox();
            this.btnSaveNewProductPrice = new System.Windows.Forms.Button();
            this.lblDisplayPrice = new System.Windows.Forms.Label();
            this.lblSelectedPrice = new System.Windows.Forms.Label();
            this.lblNewPriceSelection = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbBrand5 = new System.Windows.Forms.RadioButton();
            this.rdbBrand4 = new System.Windows.Forms.RadioButton();
            this.rdbBrand3 = new System.Windows.Forms.RadioButton();
            this.rdbBrand2 = new System.Windows.Forms.RadioButton();
            this.rdbBrand1 = new System.Windows.Forms.RadioButton();
            this.btn_Brand5 = new System.Windows.Forms.Button();
            this.btn_Brand1 = new System.Windows.Forms.Button();
            this.btn_Brand2 = new System.Windows.Forms.Button();
            this.btn_Brand4 = new System.Windows.Forms.Button();
            this.btn_Brand3 = new System.Windows.Forms.Button();
            this.pnlMaintainerCashCollector = new System.Windows.Forms.Panel();
            this.lblCollectAllCash = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.btnCollectCash = new System.Windows.Forms.Button();
            this.btnTotalCash = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_coinCount = new System.Windows.Forms.Label();
            this.btn_50c = new System.Windows.Forms.Button();
            this.btn_20c = new System.Windows.Forms.Button();
            this.btn_10c = new System.Windows.Forms.Button();
            this.lblFinish = new System.Windows.Forms.Label();
            this.rdbFinishPanel = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.grb_maintainerPanel.SuspendLayout();
            this.grpbxProductsPanel.SuspendLayout();
            this.pnlMaintainerCashCollector.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lbl_PasswordValidation);
            this.panel1.Controls.Add(this.btn_MaintainerPassword);
            this.panel1.Controls.Add(this.txt_maintainer_Password);
            this.panel1.Controls.Add(this.lbl_maintainerPassword);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 77);
            this.panel1.TabIndex = 0;
            // 
            // lbl_PasswordValidation
            // 
            this.lbl_PasswordValidation.BackColor = System.Drawing.Color.Black;
            this.lbl_PasswordValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PasswordValidation.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_PasswordValidation.Location = new System.Drawing.Point(14, 38);
            this.lbl_PasswordValidation.Name = "lbl_PasswordValidation";
            this.lbl_PasswordValidation.Size = new System.Drawing.Size(305, 32);
            this.lbl_PasswordValidation.TabIndex = 3;
            this.lbl_PasswordValidation.Text = "Locked";
            this.lbl_PasswordValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MaintainerPassword
            // 
            this.btn_MaintainerPassword.Location = new System.Drawing.Point(191, 8);
            this.btn_MaintainerPassword.Name = "btn_MaintainerPassword";
            this.btn_MaintainerPassword.Size = new System.Drawing.Size(100, 23);
            this.btn_MaintainerPassword.TabIndex = 2;
            this.btn_MaintainerPassword.Text = "OK";
            this.btn_MaintainerPassword.UseVisualStyleBackColor = true;
            this.btn_MaintainerPassword.Click += new System.EventHandler(this.btn_MaintainerPassword_Click);
            // 
            // txt_maintainer_Password
            // 
            this.txt_maintainer_Password.Location = new System.Drawing.Point(86, 9);
            this.txt_maintainer_Password.Name = "txt_maintainer_Password";
            this.txt_maintainer_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_maintainer_Password.TabIndex = 1;
            this.txt_maintainer_Password.UseSystemPasswordChar = true;
            this.txt_maintainer_Password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_maintainer_Password_Validating);
            // 
            // lbl_maintainerPassword
            // 
            this.lbl_maintainerPassword.AutoSize = true;
            this.lbl_maintainerPassword.Location = new System.Drawing.Point(11, 13);
            this.lbl_maintainerPassword.Name = "lbl_maintainerPassword";
            this.lbl_maintainerPassword.Size = new System.Drawing.Size(76, 13);
            this.lbl_maintainerPassword.TabIndex = 0;
            this.lbl_maintainerPassword.Text = "PASSWORD: ";
            // 
            // grb_maintainerPanel
            // 
            this.grb_maintainerPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.grb_maintainerPanel.Controls.Add(this.grpbxProductsPanel);
            this.grb_maintainerPanel.Controls.Add(this.pnlMaintainerCashCollector);
            this.grb_maintainerPanel.Controls.Add(this.groupBox1);
            this.grb_maintainerPanel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.grb_maintainerPanel.Location = new System.Drawing.Point(2, 95);
            this.grb_maintainerPanel.Name = "grb_maintainerPanel";
            this.grb_maintainerPanel.Size = new System.Drawing.Size(429, 608);
            this.grb_maintainerPanel.TabIndex = 1;
            this.grb_maintainerPanel.TabStop = false;
            this.grb_maintainerPanel.Text = "Maintainer Panel";
            // 
            // grpbxProductsPanel
            // 
            this.grpbxProductsPanel.Controls.Add(this.rdbFinishPanel);
            this.grpbxProductsPanel.Controls.Add(this.lblFinish);
            this.grpbxProductsPanel.Controls.Add(this.cmbxSelectCent);
            this.grpbxProductsPanel.Controls.Add(this.label1);
            this.grpbxProductsPanel.Controls.Add(this.cmbx_InsertProductPrice);
            this.grpbxProductsPanel.Controls.Add(this.btnSaveNewProductPrice);
            this.grpbxProductsPanel.Controls.Add(this.lblDisplayPrice);
            this.grpbxProductsPanel.Controls.Add(this.lblSelectedPrice);
            this.grpbxProductsPanel.Controls.Add(this.lblNewPriceSelection);
            this.grpbxProductsPanel.Controls.Add(this.label2);
            this.grpbxProductsPanel.Controls.Add(this.rdbBrand5);
            this.grpbxProductsPanel.Controls.Add(this.rdbBrand4);
            this.grpbxProductsPanel.Controls.Add(this.rdbBrand3);
            this.grpbxProductsPanel.Controls.Add(this.rdbBrand2);
            this.grpbxProductsPanel.Controls.Add(this.rdbBrand1);
            this.grpbxProductsPanel.Controls.Add(this.btn_Brand5);
            this.grpbxProductsPanel.Controls.Add(this.btn_Brand1);
            this.grpbxProductsPanel.Controls.Add(this.btn_Brand2);
            this.grpbxProductsPanel.Controls.Add(this.btn_Brand4);
            this.grpbxProductsPanel.Controls.Add(this.btn_Brand3);
            this.grpbxProductsPanel.Location = new System.Drawing.Point(6, 279);
            this.grpbxProductsPanel.Name = "grpbxProductsPanel";
            this.grpbxProductsPanel.Size = new System.Drawing.Size(346, 323);
            this.grpbxProductsPanel.TabIndex = 6;
            this.grpbxProductsPanel.TabStop = false;
            this.grpbxProductsPanel.Text = "Prducts Panel";
            // 
            // cmbxSelectCent
            // 
            this.cmbxSelectCent.Enabled = false;
            this.cmbxSelectCent.FormattingEnabled = true;
            this.cmbxSelectCent.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.cmbxSelectCent.Location = new System.Drawing.Point(265, 107);
            this.cmbxSelectCent.Name = "cmbxSelectCent";
            this.cmbxSelectCent.Size = new System.Drawing.Size(58, 21);
            this.cmbxSelectCent.TabIndex = 34;
            this.cmbxSelectCent.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectCent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = ".";
            // 
            // cmbx_InsertProductPrice
            // 
            this.cmbx_InsertProductPrice.Enabled = false;
            this.cmbx_InsertProductPrice.FormattingEnabled = true;
            this.cmbx_InsertProductPrice.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbx_InsertProductPrice.Location = new System.Drawing.Point(185, 106);
            this.cmbx_InsertProductPrice.Name = "cmbx_InsertProductPrice";
            this.cmbx_InsertProductPrice.Size = new System.Drawing.Size(58, 21);
            this.cmbx_InsertProductPrice.TabIndex = 32;
            this.cmbx_InsertProductPrice.SelectedIndexChanged += new System.EventHandler(this.cmbx_InsertProductPrice_SelectedIndexChanged);
            // 
            // btnSaveNewProductPrice
            // 
            this.btnSaveNewProductPrice.Location = new System.Drawing.Point(191, 218);
            this.btnSaveNewProductPrice.Name = "btnSaveNewProductPrice";
            this.btnSaveNewProductPrice.Size = new System.Drawing.Size(133, 33);
            this.btnSaveNewProductPrice.TabIndex = 31;
            this.btnSaveNewProductPrice.Text = "Save Price";
            this.btnSaveNewProductPrice.UseVisualStyleBackColor = true;
            this.btnSaveNewProductPrice.Click += new System.EventHandler(this.btnSaveNewProductPrice_Click);
            // 
            // lblDisplayPrice
            // 
            this.lblDisplayPrice.BackColor = System.Drawing.Color.Black;
            this.lblDisplayPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDisplayPrice.Location = new System.Drawing.Point(190, 164);
            this.lblDisplayPrice.Name = "lblDisplayPrice";
            this.lblDisplayPrice.Size = new System.Drawing.Size(136, 36);
            this.lblDisplayPrice.TabIndex = 13;
            this.lblDisplayPrice.Text = "0";
            this.lblDisplayPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectedPrice
            // 
            this.lblSelectedPrice.AutoSize = true;
            this.lblSelectedPrice.Location = new System.Drawing.Point(9, 177);
            this.lblSelectedPrice.Name = "lblSelectedPrice";
            this.lblSelectedPrice.Size = new System.Drawing.Size(96, 13);
            this.lblSelectedPrice.TabIndex = 11;
            this.lblSelectedPrice.Text = "Display New Price:";
            // 
            // lblNewPriceSelection
            // 
            this.lblNewPriceSelection.AutoSize = true;
            this.lblNewPriceSelection.Location = new System.Drawing.Point(8, 110);
            this.lblNewPriceSelection.Name = "lblNewPriceSelection";
            this.lblNewPriceSelection.Size = new System.Drawing.Size(86, 13);
            this.lblNewPriceSelection.TabIndex = 10;
            this.lblNewPriceSelection.Text = "Input New Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "RM";
            // 
            // rdbBrand5
            // 
            this.rdbBrand5.AutoSize = true;
            this.rdbBrand5.Location = new System.Drawing.Point(288, 72);
            this.rdbBrand5.Name = "rdbBrand5";
            this.rdbBrand5.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand5.TabIndex = 5;
            this.rdbBrand5.TabStop = true;
            this.rdbBrand5.UseVisualStyleBackColor = true;
            this.rdbBrand5.CheckedChanged += new System.EventHandler(this.rdbBrand5_CheckedChanged);
            // 
            // rdbBrand4
            // 
            this.rdbBrand4.AutoSize = true;
            this.rdbBrand4.Location = new System.Drawing.Point(223, 72);
            this.rdbBrand4.Name = "rdbBrand4";
            this.rdbBrand4.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand4.TabIndex = 4;
            this.rdbBrand4.TabStop = true;
            this.rdbBrand4.UseVisualStyleBackColor = true;
            this.rdbBrand4.CheckedChanged += new System.EventHandler(this.rdbBrand4_CheckedChanged);
            // 
            // rdbBrand3
            // 
            this.rdbBrand3.AutoSize = true;
            this.rdbBrand3.Location = new System.Drawing.Point(157, 72);
            this.rdbBrand3.Name = "rdbBrand3";
            this.rdbBrand3.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand3.TabIndex = 3;
            this.rdbBrand3.TabStop = true;
            this.rdbBrand3.UseVisualStyleBackColor = true;
            this.rdbBrand3.CheckedChanged += new System.EventHandler(this.rdbBrand3_CheckedChanged);
            this.rdbBrand3.Click += new System.EventHandler(this.rdbBrand3_Click);
            // 
            // rdbBrand2
            // 
            this.rdbBrand2.AutoSize = true;
            this.rdbBrand2.Location = new System.Drawing.Point(91, 72);
            this.rdbBrand2.Name = "rdbBrand2";
            this.rdbBrand2.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand2.TabIndex = 2;
            this.rdbBrand2.TabStop = true;
            this.rdbBrand2.UseVisualStyleBackColor = true;
            this.rdbBrand2.CheckedChanged += new System.EventHandler(this.rdbBrand2_CheckedChanged);
            // 
            // rdbBrand1
            // 
            this.rdbBrand1.AutoSize = true;
            this.rdbBrand1.BackColor = System.Drawing.Color.Transparent;
            this.rdbBrand1.Location = new System.Drawing.Point(27, 72);
            this.rdbBrand1.Name = "rdbBrand1";
            this.rdbBrand1.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand1.TabIndex = 0;
            this.rdbBrand1.TabStop = true;
            this.rdbBrand1.UseVisualStyleBackColor = false;
            this.rdbBrand1.CheckedChanged += new System.EventHandler(this.rdbBrand1_CheckedChanged);
            // 
            // btn_Brand5
            // 
            this.btn_Brand5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Brand5.Location = new System.Drawing.Point(270, 19);
            this.btn_Brand5.Name = "btn_Brand5";
            this.btn_Brand5.Size = new System.Drawing.Size(59, 53);
            this.btn_Brand5.TabIndex = 4;
            this.btn_Brand5.Text = "Brand 5";
            this.btn_Brand5.UseVisualStyleBackColor = false;
            // 
            // btn_Brand1
            // 
            this.btn_Brand1.BackColor = System.Drawing.Color.Orange;
            this.btn_Brand1.Location = new System.Drawing.Point(6, 19);
            this.btn_Brand1.Name = "btn_Brand1";
            this.btn_Brand1.Size = new System.Drawing.Size(60, 53);
            this.btn_Brand1.TabIndex = 0;
            this.btn_Brand1.Text = "Brand 1";
            this.btn_Brand1.UseVisualStyleBackColor = false;
            // 
            // btn_Brand2
            // 
            this.btn_Brand2.BackColor = System.Drawing.Color.Coral;
            this.btn_Brand2.Location = new System.Drawing.Point(72, 18);
            this.btn_Brand2.Name = "btn_Brand2";
            this.btn_Brand2.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand2.TabIndex = 1;
            this.btn_Brand2.Text = "Brand 2";
            this.btn_Brand2.UseVisualStyleBackColor = false;
            // 
            // btn_Brand4
            // 
            this.btn_Brand4.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Brand4.Location = new System.Drawing.Point(204, 19);
            this.btn_Brand4.Name = "btn_Brand4";
            this.btn_Brand4.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand4.TabIndex = 3;
            this.btn_Brand4.Text = "Brand 4";
            this.btn_Brand4.UseVisualStyleBackColor = false;
            this.btn_Brand4.Click += new System.EventHandler(this.btn_Brand4_Click);
            // 
            // btn_Brand3
            // 
            this.btn_Brand3.BackColor = System.Drawing.Color.Green;
            this.btn_Brand3.Location = new System.Drawing.Point(135, 18);
            this.btn_Brand3.Name = "btn_Brand3";
            this.btn_Brand3.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand3.TabIndex = 2;
            this.btn_Brand3.Text = "Brand 3";
            this.btn_Brand3.UseVisualStyleBackColor = false;
            // 
            // pnlMaintainerCashCollector
            // 
            this.pnlMaintainerCashCollector.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMaintainerCashCollector.Controls.Add(this.lblCollectAllCash);
            this.pnlMaintainerCashCollector.Controls.Add(this.lblTotalCash);
            this.pnlMaintainerCashCollector.Controls.Add(this.btnCollectCash);
            this.pnlMaintainerCashCollector.Controls.Add(this.btnTotalCash);
            this.pnlMaintainerCashCollector.Location = new System.Drawing.Point(6, 178);
            this.pnlMaintainerCashCollector.Name = "pnlMaintainerCashCollector";
            this.pnlMaintainerCashCollector.Size = new System.Drawing.Size(337, 84);
            this.pnlMaintainerCashCollector.TabIndex = 5;
            // 
            // lblCollectAllCash
            // 
            this.lblCollectAllCash.BackColor = System.Drawing.Color.Black;
            this.lblCollectAllCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectAllCash.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCollectAllCash.Location = new System.Drawing.Point(161, 47);
            this.lblCollectAllCash.Name = "lblCollectAllCash";
            this.lblCollectAllCash.Size = new System.Drawing.Size(103, 36);
            this.lblCollectAllCash.TabIndex = 5;
            this.lblCollectAllCash.Text = "0";
            this.lblCollectAllCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCollectAllCash.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.BackColor = System.Drawing.Color.Black;
            this.lblTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCash.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalCash.Location = new System.Drawing.Point(161, 3);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(103, 36);
            this.lblTotalCash.TabIndex = 5;
            this.lblTotalCash.Text = "0";
            this.lblTotalCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalCash.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCollectCash
            // 
            this.btnCollectCash.Location = new System.Drawing.Point(0, 51);
            this.btnCollectCash.Name = "btnCollectCash";
            this.btnCollectCash.Size = new System.Drawing.Size(150, 33);
            this.btnCollectCash.TabIndex = 3;
            this.btnCollectCash.Text = "Collect All Cash";
            this.btnCollectCash.UseVisualStyleBackColor = true;
            this.btnCollectCash.Click += new System.EventHandler(this.btnCollectCash_Click);
            // 
            // btnTotalCash
            // 
            this.btnTotalCash.Location = new System.Drawing.Point(0, 3);
            this.btnTotalCash.Name = "btnTotalCash";
            this.btnTotalCash.Size = new System.Drawing.Size(150, 36);
            this.btnTotalCash.TabIndex = 0;
            this.btnTotalCash.Text = "Total cash held by machine";
            this.btnTotalCash.UseVisualStyleBackColor = true;
            this.btnTotalCash.Click += new System.EventHandler(this.btnTotalCash_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lbl_coinCount);
            this.groupBox1.Controls.Add(this.btn_50c);
            this.groupBox1.Controls.Add(this.btn_20c);
            this.groupBox1.Controls.Add(this.btn_10c);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRESS BELOW TO DETERMINE NUMBER OF COINS IN SELECTED DENOMINATION";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(44, 69);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(106, 50);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "TOTAL NUMBER OF COINS IN SELECTED DENOMINATION";
            // 
            // lbl_coinCount
            // 
            this.lbl_coinCount.BackColor = System.Drawing.Color.Black;
            this.lbl_coinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coinCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_coinCount.Location = new System.Drawing.Point(154, 71);
            this.lbl_coinCount.Name = "lbl_coinCount";
            this.lbl_coinCount.Size = new System.Drawing.Size(110, 50);
            this.lbl_coinCount.TabIndex = 4;
            this.lbl_coinCount.Text = "0";
            this.lbl_coinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_coinCount.Click += new System.EventHandler(this.lbl_coinCount_Click_1);
            // 
            // btn_50c
            // 
            this.btn_50c.Location = new System.Drawing.Point(196, 40);
            this.btn_50c.Name = "btn_50c";
            this.btn_50c.Size = new System.Drawing.Size(75, 23);
            this.btn_50c.TabIndex = 2;
            this.btn_50c.Text = "RM 0.50";
            this.btn_50c.UseVisualStyleBackColor = true;
            this.btn_50c.Click += new System.EventHandler(this.btn_50c_Click);
            // 
            // btn_20c
            // 
            this.btn_20c.Location = new System.Drawing.Point(120, 40);
            this.btn_20c.Name = "btn_20c";
            this.btn_20c.Size = new System.Drawing.Size(75, 23);
            this.btn_20c.TabIndex = 1;
            this.btn_20c.Text = "RM 0.20";
            this.btn_20c.UseVisualStyleBackColor = true;
            this.btn_20c.Click += new System.EventHandler(this.btn_20c_Click);
            // 
            // btn_10c
            // 
            this.btn_10c.Location = new System.Drawing.Point(43, 40);
            this.btn_10c.Name = "btn_10c";
            this.btn_10c.Size = new System.Drawing.Size(75, 23);
            this.btn_10c.TabIndex = 0;
            this.btn_10c.Text = "RM 0.10";
            this.btn_10c.UseVisualStyleBackColor = true;
            this.btn_10c.Click += new System.EventHandler(this.btn_10c_Click);
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(9, 295);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(169, 13);
            this.lblFinish.TabIndex = 35;
            this.lblFinish.Text = "PRESS HERE WHEN FINISHED:";
            // 
            // rdbFinishPanel
            // 
            this.rdbFinishPanel.AutoSize = true;
            this.rdbFinishPanel.Location = new System.Drawing.Point(191, 295);
            this.rdbFinishPanel.Name = "rdbFinishPanel";
            this.rdbFinishPanel.Size = new System.Drawing.Size(14, 13);
            this.rdbFinishPanel.TabIndex = 36;
            this.rdbFinishPanel.TabStop = true;
            this.rdbFinishPanel.UseVisualStyleBackColor = true;
            this.rdbFinishPanel.CheckedChanged += new System.EventHandler(this.rdbFinishPanel_CheckedChanged);
            // 
            // Maintainer_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 703);
            this.Controls.Add(this.grb_maintainerPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Maintainer_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintainer_Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_maintainerPanel.ResumeLayout(false);
            this.grpbxProductsPanel.ResumeLayout(false);
            this.grpbxProductsPanel.PerformLayout();
            this.pnlMaintainerCashCollector.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PasswordValidation;
        private System.Windows.Forms.Button btn_MaintainerPassword;
        private System.Windows.Forms.TextBox txt_maintainer_Password;
        private System.Windows.Forms.Label lbl_maintainerPassword;
        private System.Windows.Forms.GroupBox grb_maintainerPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_coinCount;
        private System.Windows.Forms.Button btn_50c;
        private System.Windows.Forms.Button btn_20c;
        private System.Windows.Forms.Button btn_10c;
        private System.Windows.Forms.Button btn_Brand5;
        private System.Windows.Forms.Button btn_Brand4;
        private System.Windows.Forms.Button btn_Brand3;
        private System.Windows.Forms.Button btn_Brand2;
        private System.Windows.Forms.Button btn_Brand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMaintainerCashCollector;
        private System.Windows.Forms.Button btnCollectCash;
        private System.Windows.Forms.Button btnTotalCash;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblCollectAllCash;
        private System.Windows.Forms.GroupBox grpbxProductsPanel;
        private System.Windows.Forms.Label lblDisplayPrice;
        private System.Windows.Forms.Label lblSelectedPrice;
        private System.Windows.Forms.Label lblNewPriceSelection;
        private System.Windows.Forms.RadioButton rdbBrand5;
        private System.Windows.Forms.RadioButton rdbBrand4;
        private System.Windows.Forms.RadioButton rdbBrand3;
        private System.Windows.Forms.RadioButton rdbBrand2;
        private System.Windows.Forms.RadioButton rdbBrand1;
        private System.Windows.Forms.Button btnSaveNewProductPrice;
        private System.Windows.Forms.ComboBox cmbx_InsertProductPrice;
        private System.Windows.Forms.ComboBox cmbxSelectCent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFinishPanel;
        private System.Windows.Forms.Label lblFinish;
    }
}