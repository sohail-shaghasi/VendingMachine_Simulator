namespace VendingMachine_SD
{
    partial class Simulator_Control_Panel
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
            this.btn_CustomerPanel = new System.Windows.Forms.Button();
            this.btn_MaintainerPanel = new System.Windows.Forms.Button();
            this.btn_MachineryPanel = new System.Windows.Forms.Button();
            this.rdb_ON = new System.Windows.Forms.RadioButton();
            this.rdb_OFF = new System.Windows.Forms.RadioButton();
            this.lbl_Simulation = new System.Windows.Forms.Label();
            this.pnl_MainSimulator = new System.Windows.Forms.Panel();
            this.pnl_MainSimulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CustomerPanel
            // 
            this.btn_CustomerPanel.Enabled = false;
            this.btn_CustomerPanel.Location = new System.Drawing.Point(30, 125);
            this.btn_CustomerPanel.Name = "btn_CustomerPanel";
            this.btn_CustomerPanel.Size = new System.Drawing.Size(170, 58);
            this.btn_CustomerPanel.TabIndex = 0;
            this.btn_CustomerPanel.Text = "Customer Panel";
            this.btn_CustomerPanel.UseVisualStyleBackColor = true;
            this.btn_CustomerPanel.Click += new System.EventHandler(this.btn_CustomerPanel_Click);
            // 
            // btn_MaintainerPanel
            // 
            this.btn_MaintainerPanel.Enabled = false;
            this.btn_MaintainerPanel.Location = new System.Drawing.Point(30, 189);
            this.btn_MaintainerPanel.Name = "btn_MaintainerPanel";
            this.btn_MaintainerPanel.Size = new System.Drawing.Size(170, 52);
            this.btn_MaintainerPanel.TabIndex = 1;
            this.btn_MaintainerPanel.Text = "Maintainer Panel";
            this.btn_MaintainerPanel.UseVisualStyleBackColor = true;
            this.btn_MaintainerPanel.Click += new System.EventHandler(this.btn_MaintainerPanel_Click);
            // 
            // btn_MachineryPanel
            // 
            this.btn_MachineryPanel.Enabled = false;
            this.btn_MachineryPanel.Location = new System.Drawing.Point(30, 247);
            this.btn_MachineryPanel.Name = "btn_MachineryPanel";
            this.btn_MachineryPanel.Size = new System.Drawing.Size(170, 55);
            this.btn_MachineryPanel.TabIndex = 2;
            this.btn_MachineryPanel.Text = "Machinery Panel";
            this.btn_MachineryPanel.UseVisualStyleBackColor = true;
            this.btn_MachineryPanel.Click += new System.EventHandler(this.btn_MachineryPanel_Click);
            // 
            // rdb_ON
            // 
            this.rdb_ON.AutoSize = true;
            this.rdb_ON.Location = new System.Drawing.Point(30, 80);
            this.rdb_ON.Name = "rdb_ON";
            this.rdb_ON.Size = new System.Drawing.Size(41, 17);
            this.rdb_ON.TabIndex = 3;
            this.rdb_ON.Text = "ON";
            this.rdb_ON.UseVisualStyleBackColor = true;
            this.rdb_ON.CheckedChanged += new System.EventHandler(this.rdb_ON_CheckedChanged);
            // 
            // rdb_OFF
            // 
            this.rdb_OFF.AutoSize = true;
            this.rdb_OFF.Checked = true;
            this.rdb_OFF.Location = new System.Drawing.Point(155, 80);
            this.rdb_OFF.Name = "rdb_OFF";
            this.rdb_OFF.Size = new System.Drawing.Size(45, 17);
            this.rdb_OFF.TabIndex = 4;
            this.rdb_OFF.Text = "OFF";
            this.rdb_OFF.UseVisualStyleBackColor = true;
            this.rdb_OFF.CheckedChanged += new System.EventHandler(this.rdb_OFF_CheckedChanged);
            // 
            // lbl_Simulation
            // 
            this.lbl_Simulation.AutoSize = true;
            this.lbl_Simulation.Location = new System.Drawing.Point(87, 48);
            this.lbl_Simulation.Name = "lbl_Simulation";
            this.lbl_Simulation.Size = new System.Drawing.Size(55, 13);
            this.lbl_Simulation.TabIndex = 5;
            this.lbl_Simulation.Text = "Simulation";
            this.lbl_Simulation.Click += new System.EventHandler(this.lbl_Simulation_Click);
            // 
            // pnl_MainSimulator
            // 
            this.pnl_MainSimulator.Controls.Add(this.btn_MachineryPanel);
            this.pnl_MainSimulator.Controls.Add(this.lbl_Simulation);
            this.pnl_MainSimulator.Controls.Add(this.btn_MaintainerPanel);
            this.pnl_MainSimulator.Controls.Add(this.rdb_OFF);
            this.pnl_MainSimulator.Controls.Add(this.btn_CustomerPanel);
            this.pnl_MainSimulator.Controls.Add(this.rdb_ON);
            this.pnl_MainSimulator.Location = new System.Drawing.Point(12, 12);
            this.pnl_MainSimulator.Name = "pnl_MainSimulator";
            this.pnl_MainSimulator.Size = new System.Drawing.Size(238, 323);
            this.pnl_MainSimulator.TabIndex = 6;
            // 
            // Simulator_Control_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 355);
            this.Controls.Add(this.pnl_MainSimulator);
            this.Name = "Simulator_Control_Panel";
            this.Text = "Simulator Control Panel";
            this.Load += new System.EventHandler(this.Simulator_Control_Panel_Load);
            this.pnl_MainSimulator.ResumeLayout(false);
            this.pnl_MainSimulator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CustomerPanel;
        private System.Windows.Forms.Button btn_MaintainerPanel;
        private System.Windows.Forms.Button btn_MachineryPanel;
        private System.Windows.Forms.RadioButton rdb_ON;
        private System.Windows.Forms.RadioButton rdb_OFF;
        private System.Windows.Forms.Label lbl_Simulation;
        private System.Windows.Forms.Panel pnl_MainSimulator;
    }
}

