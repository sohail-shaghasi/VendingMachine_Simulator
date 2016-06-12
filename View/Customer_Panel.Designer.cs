namespace VendingMachine_SD
{
    partial class Customer_Panel
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
            this.grb_CoinDespenser = new System.Windows.Forms.GroupBox();
            this.lbl_CoinDespenser = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.grb_ProductDespenser = new System.Windows.Forms.GroupBox();
            this.pictureBox_dispensedDrink = new System.Windows.Forms.PictureBox();
            this.pnl_Products = new System.Windows.Forms.Panel();
            this.label_price_Brand5 = new System.Windows.Forms.Label();
            this.label_price_Brand4 = new System.Windows.Forms.Label();
            this.label_price_Brand3 = new System.Windows.Forms.Label();
            this.label_price_Brand2 = new System.Windows.Forms.Label();
            this.label_price_Brand1 = new System.Windows.Forms.Label();
            this.label_Availability_Brand5 = new System.Windows.Forms.Label();
            this.label_Availability_Brand4 = new System.Windows.Forms.Label();
            this.label_Availability_Brand3 = new System.Windows.Forms.Label();
            this.label_Availability_Brand2 = new System.Windows.Forms.Label();
            this.label_Availability_Brand1 = new System.Windows.Forms.Label();
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
            this.pnl_Display = new System.Windows.Forms.Panel();
            this.label_Display = new System.Windows.Forms.Label();
            this.pnl_InsertCoin = new System.Windows.Forms.Panel();
            this.cmbx_insertCoin = new System.Windows.Forms.ComboBox();
            this.lbl_InsertCoin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grb_CoinDespenser.SuspendLayout();
            this.grb_ProductDespenser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dispensedDrink)).BeginInit();
            this.pnl_Products.SuspendLayout();
            this.pnl_Display.SuspendLayout();
            this.pnl_InsertCoin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.grb_CoinDespenser);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.grb_ProductDespenser);
            this.panel1.Controls.Add(this.pnl_Products);
            this.panel1.Controls.Add(this.pnl_Display);
            this.panel1.Controls.Add(this.pnl_InsertCoin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 440);
            this.panel1.TabIndex = 0;
            // 
            // grb_CoinDespenser
            // 
            this.grb_CoinDespenser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grb_CoinDespenser.Controls.Add(this.lbl_CoinDespenser);
            this.grb_CoinDespenser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb_CoinDespenser.Location = new System.Drawing.Point(207, 232);
            this.grb_CoinDespenser.Name = "grb_CoinDespenser";
            this.grb_CoinDespenser.Size = new System.Drawing.Size(123, 55);
            this.grb_CoinDespenser.TabIndex = 7;
            this.grb_CoinDespenser.TabStop = false;
            this.grb_CoinDespenser.Text = "Your Balance";
            // 
            // lbl_CoinDespenser
            // 
            this.lbl_CoinDespenser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoinDespenser.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CoinDespenser.Location = new System.Drawing.Point(7, 14);
            this.lbl_CoinDespenser.Name = "lbl_CoinDespenser";
            this.lbl_CoinDespenser.Size = new System.Drawing.Size(111, 30);
            this.lbl_CoinDespenser.TabIndex = 0;
            this.lbl_CoinDespenser.Text = "RM 0.00";
            this.lbl_CoinDespenser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cancel.Location = new System.Drawing.Point(206, 204);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 25);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // grb_ProductDespenser
            // 
            this.grb_ProductDespenser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grb_ProductDespenser.Controls.Add(this.pictureBox_dispensedDrink);
            this.grb_ProductDespenser.ForeColor = System.Drawing.Color.White;
            this.grb_ProductDespenser.Location = new System.Drawing.Point(3, 204);
            this.grb_ProductDespenser.Name = "grb_ProductDespenser";
            this.grb_ProductDespenser.Size = new System.Drawing.Size(200, 83);
            this.grb_ProductDespenser.TabIndex = 5;
            this.grb_ProductDespenser.TabStop = false;
            this.grb_ProductDespenser.Text = "Pick Here";
            // 
            // pictureBox_dispensedDrink
            // 
            this.pictureBox_dispensedDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_dispensedDrink.Location = new System.Drawing.Point(64, 20);
            this.pictureBox_dispensedDrink.Name = "pictureBox_dispensedDrink";
            this.pictureBox_dispensedDrink.Size = new System.Drawing.Size(58, 50);
            this.pictureBox_dispensedDrink.TabIndex = 20;
            this.pictureBox_dispensedDrink.TabStop = false;
            this.pictureBox_dispensedDrink.Visible = false;
            // 
            // pnl_Products
            // 
            this.pnl_Products.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Products.Controls.Add(this.label_price_Brand5);
            this.pnl_Products.Controls.Add(this.label_price_Brand4);
            this.pnl_Products.Controls.Add(this.label_price_Brand3);
            this.pnl_Products.Controls.Add(this.label_price_Brand2);
            this.pnl_Products.Controls.Add(this.label_price_Brand1);
            this.pnl_Products.Controls.Add(this.label_Availability_Brand5);
            this.pnl_Products.Controls.Add(this.label_Availability_Brand4);
            this.pnl_Products.Controls.Add(this.label_Availability_Brand3);
            this.pnl_Products.Controls.Add(this.label_Availability_Brand2);
            this.pnl_Products.Controls.Add(this.label_Availability_Brand1);
            this.pnl_Products.Controls.Add(this.rdbBrand5);
            this.pnl_Products.Controls.Add(this.rdbBrand4);
            this.pnl_Products.Controls.Add(this.rdbBrand3);
            this.pnl_Products.Controls.Add(this.rdbBrand2);
            this.pnl_Products.Controls.Add(this.rdbBrand1);
            this.pnl_Products.Controls.Add(this.btn_Brand5);
            this.pnl_Products.Controls.Add(this.btn_Brand1);
            this.pnl_Products.Controls.Add(this.btn_Brand2);
            this.pnl_Products.Controls.Add(this.btn_Brand4);
            this.pnl_Products.Controls.Add(this.btn_Brand3);
            this.pnl_Products.Location = new System.Drawing.Point(3, 64);
            this.pnl_Products.Name = "pnl_Products";
            this.pnl_Products.Size = new System.Drawing.Size(332, 134);
            this.pnl_Products.TabIndex = 3;
            // 
            // label_price_Brand5
            // 
            this.label_price_Brand5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_price_Brand5.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price_Brand5.ForeColor = System.Drawing.Color.White;
            this.label_price_Brand5.Location = new System.Drawing.Point(266, 77);
            this.label_price_Brand5.Name = "label_price_Brand5";
            this.label_price_Brand5.Size = new System.Drawing.Size(66, 10);
            this.label_price_Brand5.TabIndex = 24;
            this.label_price_Brand5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price_Brand4
            // 
            this.label_price_Brand4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_price_Brand4.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price_Brand4.ForeColor = System.Drawing.Color.White;
            this.label_price_Brand4.Location = new System.Drawing.Point(199, 77);
            this.label_price_Brand4.Name = "label_price_Brand4";
            this.label_price_Brand4.Size = new System.Drawing.Size(66, 10);
            this.label_price_Brand4.TabIndex = 23;
            this.label_price_Brand4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price_Brand3
            // 
            this.label_price_Brand3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_price_Brand3.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price_Brand3.ForeColor = System.Drawing.Color.White;
            this.label_price_Brand3.Location = new System.Drawing.Point(132, 77);
            this.label_price_Brand3.Name = "label_price_Brand3";
            this.label_price_Brand3.Size = new System.Drawing.Size(66, 10);
            this.label_price_Brand3.TabIndex = 22;
            this.label_price_Brand3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price_Brand2
            // 
            this.label_price_Brand2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_price_Brand2.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price_Brand2.ForeColor = System.Drawing.Color.White;
            this.label_price_Brand2.Location = new System.Drawing.Point(65, 77);
            this.label_price_Brand2.Name = "label_price_Brand2";
            this.label_price_Brand2.Size = new System.Drawing.Size(66, 10);
            this.label_price_Brand2.TabIndex = 21;
            this.label_price_Brand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_price_Brand1
            // 
            this.label_price_Brand1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_price_Brand1.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price_Brand1.ForeColor = System.Drawing.Color.White;
            this.label_price_Brand1.Location = new System.Drawing.Point(-2, 77);
            this.label_price_Brand1.Name = "label_price_Brand1";
            this.label_price_Brand1.Size = new System.Drawing.Size(66, 10);
            this.label_price_Brand1.TabIndex = 20;
            this.label_price_Brand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Availability_Brand5
            // 
            this.label_Availability_Brand5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Availability_Brand5.Enabled = false;
            this.label_Availability_Brand5.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Availability_Brand5.ForeColor = System.Drawing.Color.Red;
            this.label_Availability_Brand5.Location = new System.Drawing.Point(266, 66);
            this.label_Availability_Brand5.Name = "label_Availability_Brand5";
            this.label_Availability_Brand5.Size = new System.Drawing.Size(66, 10);
            this.label_Availability_Brand5.TabIndex = 19;
            this.label_Availability_Brand5.Text = "Not Available";
            this.label_Availability_Brand5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Availability_Brand4
            // 
            this.label_Availability_Brand4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Availability_Brand4.Enabled = false;
            this.label_Availability_Brand4.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Availability_Brand4.ForeColor = System.Drawing.Color.Red;
            this.label_Availability_Brand4.Location = new System.Drawing.Point(199, 66);
            this.label_Availability_Brand4.Name = "label_Availability_Brand4";
            this.label_Availability_Brand4.Size = new System.Drawing.Size(66, 10);
            this.label_Availability_Brand4.TabIndex = 18;
            this.label_Availability_Brand4.Text = "Not Available";
            this.label_Availability_Brand4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Availability_Brand3
            // 
            this.label_Availability_Brand3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Availability_Brand3.Enabled = false;
            this.label_Availability_Brand3.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Availability_Brand3.ForeColor = System.Drawing.Color.Red;
            this.label_Availability_Brand3.Location = new System.Drawing.Point(132, 66);
            this.label_Availability_Brand3.Name = "label_Availability_Brand3";
            this.label_Availability_Brand3.Size = new System.Drawing.Size(66, 10);
            this.label_Availability_Brand3.TabIndex = 17;
            this.label_Availability_Brand3.Text = "Not Available";
            this.label_Availability_Brand3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Availability_Brand2
            // 
            this.label_Availability_Brand2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Availability_Brand2.Enabled = false;
            this.label_Availability_Brand2.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Availability_Brand2.ForeColor = System.Drawing.Color.Red;
            this.label_Availability_Brand2.Location = new System.Drawing.Point(65, 66);
            this.label_Availability_Brand2.Name = "label_Availability_Brand2";
            this.label_Availability_Brand2.Size = new System.Drawing.Size(66, 10);
            this.label_Availability_Brand2.TabIndex = 16;
            this.label_Availability_Brand2.Text = "Not Available";
            this.label_Availability_Brand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Availability_Brand1
            // 
            this.label_Availability_Brand1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Availability_Brand1.Enabled = false;
            this.label_Availability_Brand1.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Availability_Brand1.ForeColor = System.Drawing.Color.Red;
            this.label_Availability_Brand1.Location = new System.Drawing.Point(-2, 66);
            this.label_Availability_Brand1.Name = "label_Availability_Brand1";
            this.label_Availability_Brand1.Size = new System.Drawing.Size(66, 10);
            this.label_Availability_Brand1.TabIndex = 8;
            this.label_Availability_Brand1.Text = "Not Available";
            this.label_Availability_Brand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbBrand5
            // 
            this.rdbBrand5.AutoSize = true;
            this.rdbBrand5.Location = new System.Drawing.Point(287, 88);
            this.rdbBrand5.Name = "rdbBrand5";
            this.rdbBrand5.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand5.TabIndex = 15;
            this.rdbBrand5.UseVisualStyleBackColor = true;
            this.rdbBrand5.Click += new System.EventHandler(this.rdbBrand5_CheckedChanged);
            // 
            // rdbBrand4
            // 
            this.rdbBrand4.AutoSize = true;
            this.rdbBrand4.Location = new System.Drawing.Point(222, 88);
            this.rdbBrand4.Name = "rdbBrand4";
            this.rdbBrand4.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand4.TabIndex = 13;
            this.rdbBrand4.UseVisualStyleBackColor = true;
            this.rdbBrand4.Click += new System.EventHandler(this.rdbBrand4_CheckedChanged);
            // 
            // rdbBrand3
            // 
            this.rdbBrand3.AutoSize = true;
            this.rdbBrand3.Location = new System.Drawing.Point(156, 88);
            this.rdbBrand3.Name = "rdbBrand3";
            this.rdbBrand3.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand3.TabIndex = 11;
            this.rdbBrand3.UseVisualStyleBackColor = true;
            this.rdbBrand3.Click += new System.EventHandler(this.rdbBrand3_CheckedChanged);
            // 
            // rdbBrand2
            // 
            this.rdbBrand2.AutoSize = true;
            this.rdbBrand2.Location = new System.Drawing.Point(90, 88);
            this.rdbBrand2.Name = "rdbBrand2";
            this.rdbBrand2.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand2.TabIndex = 9;
            this.rdbBrand2.UseVisualStyleBackColor = true;
            this.rdbBrand2.Click += new System.EventHandler(this.rdbBrand2_CheckedChanged);
            // 
            // rdbBrand1
            // 
            this.rdbBrand1.AutoSize = true;
            this.rdbBrand1.BackColor = System.Drawing.Color.Transparent;
            this.rdbBrand1.Location = new System.Drawing.Point(26, 88);
            this.rdbBrand1.Name = "rdbBrand1";
            this.rdbBrand1.Size = new System.Drawing.Size(14, 13);
            this.rdbBrand1.TabIndex = 6;
            this.rdbBrand1.UseVisualStyleBackColor = false;
            this.rdbBrand1.Click += new System.EventHandler(this.rdbBrand1_CheckedChanged);
            // 
            // btn_Brand5
            // 
            this.btn_Brand5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Brand5.Location = new System.Drawing.Point(269, 10);
            this.btn_Brand5.Name = "btn_Brand5";
            this.btn_Brand5.Size = new System.Drawing.Size(59, 53);
            this.btn_Brand5.TabIndex = 14;
            this.btn_Brand5.Text = "Brand 5";
            this.btn_Brand5.UseVisualStyleBackColor = false;
            this.btn_Brand5.Click += new System.EventHandler(this.rdbBrand5_CheckedChanged);
            // 
            // btn_Brand1
            // 
            this.btn_Brand1.BackColor = System.Drawing.Color.Orange;
            this.btn_Brand1.Location = new System.Drawing.Point(5, 10);
            this.btn_Brand1.Name = "btn_Brand1";
            this.btn_Brand1.Size = new System.Drawing.Size(60, 53);
            this.btn_Brand1.TabIndex = 7;
            this.btn_Brand1.Text = "Brand 1";
            this.btn_Brand1.UseVisualStyleBackColor = false;
            this.btn_Brand1.Click += new System.EventHandler(this.rdbBrand1_CheckedChanged);
            // 
            // btn_Brand2
            // 
            this.btn_Brand2.BackColor = System.Drawing.Color.Coral;
            this.btn_Brand2.Location = new System.Drawing.Point(71, 9);
            this.btn_Brand2.Name = "btn_Brand2";
            this.btn_Brand2.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand2.TabIndex = 8;
            this.btn_Brand2.Text = "Brand 2";
            this.btn_Brand2.UseVisualStyleBackColor = false;
            this.btn_Brand2.Click += new System.EventHandler(this.rdbBrand2_CheckedChanged);
            // 
            // btn_Brand4
            // 
            this.btn_Brand4.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_Brand4.Location = new System.Drawing.Point(203, 10);
            this.btn_Brand4.Name = "btn_Brand4";
            this.btn_Brand4.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand4.TabIndex = 12;
            this.btn_Brand4.Text = "Brand 4";
            this.btn_Brand4.UseVisualStyleBackColor = false;
            this.btn_Brand4.Click += new System.EventHandler(this.rdbBrand4_CheckedChanged);
            // 
            // btn_Brand3
            // 
            this.btn_Brand3.BackColor = System.Drawing.Color.Green;
            this.btn_Brand3.Location = new System.Drawing.Point(137, 9);
            this.btn_Brand3.Name = "btn_Brand3";
            this.btn_Brand3.Size = new System.Drawing.Size(60, 54);
            this.btn_Brand3.TabIndex = 10;
            this.btn_Brand3.Text = "Brand 3";
            this.btn_Brand3.UseVisualStyleBackColor = false;
            this.btn_Brand3.Click += new System.EventHandler(this.rdbBrand3_CheckedChanged);
            // 
            // pnl_Display
            // 
            this.pnl_Display.BackColor = System.Drawing.Color.Black;
            this.pnl_Display.Controls.Add(this.label_Display);
            this.pnl_Display.Location = new System.Drawing.Point(176, 3);
            this.pnl_Display.Name = "pnl_Display";
            this.pnl_Display.Size = new System.Drawing.Size(159, 55);
            this.pnl_Display.TabIndex = 2;
            // 
            // label_Display
            // 
            this.label_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Display.ForeColor = System.Drawing.Color.Red;
            this.label_Display.Location = new System.Drawing.Point(4, 0);
            this.label_Display.Name = "label_Display";
            this.label_Display.Size = new System.Drawing.Size(152, 55);
            this.label_Display.TabIndex = 0;
            this.label_Display.Text = "Display";
            this.label_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_InsertCoin
            // 
            this.pnl_InsertCoin.Controls.Add(this.cmbx_insertCoin);
            this.pnl_InsertCoin.Controls.Add(this.lbl_InsertCoin);
            this.pnl_InsertCoin.Location = new System.Drawing.Point(3, 3);
            this.pnl_InsertCoin.Name = "pnl_InsertCoin";
            this.pnl_InsertCoin.Size = new System.Drawing.Size(167, 55);
            this.pnl_InsertCoin.TabIndex = 1;
            // 
            // cmbx_insertCoin
            // 
            this.cmbx_insertCoin.Enabled = false;
            this.cmbx_insertCoin.FormattingEnabled = true;
            this.cmbx_insertCoin.Items.AddRange(new object[] {
            "RM 0.01",
            "RM 0.05",
            "RM 0.10",
            "RM 0.20",
            "RM 0.50",
            "AFG 10.0",
            "USD 0.25"});
            this.cmbx_insertCoin.Location = new System.Drawing.Point(66, 17);
            this.cmbx_insertCoin.Name = "cmbx_insertCoin";
            this.cmbx_insertCoin.Size = new System.Drawing.Size(92, 21);
            this.cmbx_insertCoin.TabIndex = 0;
            this.cmbx_insertCoin.SelectedIndexChanged += new System.EventHandler(this.cmbx_insertCoin_SelectedIndexChanged);
            // 
            // lbl_InsertCoin
            // 
            this.lbl_InsertCoin.AutoSize = true;
            this.lbl_InsertCoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_InsertCoin.Location = new System.Drawing.Point(3, 20);
            this.lbl_InsertCoin.Name = "lbl_InsertCoin";
            this.lbl_InsertCoin.Size = new System.Drawing.Size(60, 13);
            this.lbl_InsertCoin.TabIndex = 0;
            this.lbl_InsertCoin.Text = "Insert Coin:";
            // 
            // Customer_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 463);
            this.Controls.Add(this.panel1);
            this.Name = "Customer_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer_Panel";
            this.Load += new System.EventHandler(this.Customer_Panel_Load);
            this.panel1.ResumeLayout(false);
            this.grb_CoinDespenser.ResumeLayout(false);
            this.grb_ProductDespenser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dispensedDrink)).EndInit();
            this.pnl_Products.ResumeLayout(false);
            this.pnl_Products.PerformLayout();
            this.pnl_Display.ResumeLayout(false);
            this.pnl_InsertCoin.ResumeLayout(false);
            this.pnl_InsertCoin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_InsertCoin;
        private System.Windows.Forms.ComboBox cmbx_insertCoin;
        private System.Windows.Forms.Label lbl_InsertCoin;
        private System.Windows.Forms.GroupBox grb_CoinDespenser;
        private System.Windows.Forms.Label lbl_CoinDespenser;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.GroupBox grb_ProductDespenser;
        private System.Windows.Forms.Panel pnl_Products;

        private System.Windows.Forms.Panel pnl_Display;
        private System.Windows.Forms.Label label_Display;

        private System.Windows.Forms.Label label_Availability_Brand5;
        private System.Windows.Forms.Label label_Availability_Brand4;
        private System.Windows.Forms.Label label_Availability_Brand3;
        private System.Windows.Forms.Label label_Availability_Brand2;
        private System.Windows.Forms.Label label_Availability_Brand1;
        private System.Windows.Forms.RadioButton rdbBrand5;
        private System.Windows.Forms.RadioButton rdbBrand4;
        private System.Windows.Forms.RadioButton rdbBrand3;
        private System.Windows.Forms.RadioButton rdbBrand2;
        private System.Windows.Forms.RadioButton rdbBrand1;
        private System.Windows.Forms.Button btn_Brand5;
        private System.Windows.Forms.Button btn_Brand1;
        private System.Windows.Forms.Button btn_Brand2;
        private System.Windows.Forms.Button btn_Brand4;
        private System.Windows.Forms.Button btn_Brand3;
        private System.Windows.Forms.Label label_price_Brand5;
        private System.Windows.Forms.Label label_price_Brand4;
        private System.Windows.Forms.Label label_price_Brand3;
        private System.Windows.Forms.Label label_price_Brand2;
        private System.Windows.Forms.Label label_price_Brand1;
        private System.Windows.Forms.PictureBox pictureBox_dispensedDrink;
    }
}