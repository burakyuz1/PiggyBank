namespace PiggyBankUI
{
    partial class PiggyMainForm
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
            this.components = new System.ComponentModel.Container();
            this.cmbCoins = new System.Windows.Forms.ComboBox();
            this.cmbBanknotes = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.lblOccupancyRate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnFold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbMoney = new System.Windows.Forms.PictureBox();
            this.lblOccupancyInfo = new System.Windows.Forms.Label();
            this.lblTotalInfo = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lbLWarning = new System.Windows.Forms.Label();
            this.tmrShake = new System.Windows.Forms.Timer(this.components);
            this.btnRepair = new System.Windows.Forms.Button();
            this.btnAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCoins
            // 
            this.cmbCoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCoins.FormattingEnabled = true;
            this.cmbCoins.Items.AddRange(new object[] {
            "1 KURUŞ",
            "5 KURUŞ",
            "10 KURUŞ",
            "25 KURUŞ",
            "50 KURUŞ",
            "1 LİRA"});
            this.cmbCoins.Location = new System.Drawing.Point(12, 52);
            this.cmbCoins.Name = "cmbCoins";
            this.cmbCoins.Size = new System.Drawing.Size(121, 32);
            this.cmbCoins.TabIndex = 0;
            this.cmbCoins.SelectedIndexChanged += new System.EventHandler(this.cmbCoins_SelectedIndexChanged);
            // 
            // cmbBanknotes
            // 
            this.cmbBanknotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanknotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBanknotes.FormattingEnabled = true;
            this.cmbBanknotes.Location = new System.Drawing.Point(215, 52);
            this.cmbBanknotes.Name = "cmbBanknotes";
            this.cmbBanknotes.Size = new System.Drawing.Size(121, 32);
            this.cmbBanknotes.TabIndex = 1;
            this.cmbBanknotes.SelectedIndexChanged += new System.EventHandler(this.cmbBanknotes_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(520, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShake
            // 
            this.btnShake.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShake.Location = new System.Drawing.Point(403, 74);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(111, 40);
            this.btnShake.TabIndex = 3;
            this.btnShake.Text = "SHAKE";
            this.btnShake.UseVisualStyleBackColor = false;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBreak.Location = new System.Drawing.Point(520, 74);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(111, 40);
            this.btnBreak.TabIndex = 4;
            this.btnBreak.Text = "BREAK (1)";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // lblOccupancyRate
            // 
            this.lblOccupancyRate.AutoSize = true;
            this.lblOccupancyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOccupancyRate.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblOccupancyRate.Location = new System.Drawing.Point(495, 169);
            this.lblOccupancyRate.Name = "lblOccupancyRate";
            this.lblOccupancyRate.Size = new System.Drawing.Size(64, 20);
            this.lblOccupancyRate.TabIndex = 5;
            this.lblOccupancyRate.Text = "% 0.00";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTotalAmount.Location = new System.Drawing.Point(491, 258);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 20);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Visible = false;
            // 
            // btnFold
            // 
            this.btnFold.BackColor = System.Drawing.Color.IndianRed;
            this.btnFold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFold.Location = new System.Drawing.Point(403, 17);
            this.btnFold.Name = "btnFold";
            this.btnFold.Size = new System.Drawing.Size(111, 40);
            this.btnFold.TabIndex = 7;
            this.btnFold.Text = "FOLD";
            this.btnFold.UseVisualStyleBackColor = false;
            this.btnFold.Click += new System.EventHandler(this.btnFold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "COINS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(211, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "BANKNOTES";
            // 
            // pcbMoney
            // 
            this.pcbMoney.Location = new System.Drawing.Point(54, 119);
            this.pcbMoney.Name = "pcbMoney";
            this.pcbMoney.Size = new System.Drawing.Size(261, 108);
            this.pcbMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMoney.TabIndex = 10;
            this.pcbMoney.TabStop = false;
            // 
            // lblOccupancyInfo
            // 
            this.lblOccupancyInfo.AutoSize = true;
            this.lblOccupancyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOccupancyInfo.Location = new System.Drawing.Point(431, 140);
            this.lblOccupancyInfo.Name = "lblOccupancyInfo";
            this.lblOccupancyInfo.Size = new System.Drawing.Size(184, 24);
            this.lblOccupancyInfo.TabIndex = 11;
            this.lblOccupancyInfo.Text = "OCCUPANCY RATE";
            // 
            // lblTotalInfo
            // 
            this.lblTotalInfo.AutoSize = true;
            this.lblTotalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalInfo.Location = new System.Drawing.Point(445, 222);
            this.lblTotalInfo.Name = "lblTotalInfo";
            this.lblTotalInfo.Size = new System.Drawing.Size(160, 24);
            this.lblTotalInfo.TabIndex = 12;
            this.lblTotalInfo.Text = "TOTAL AMOUNT";
            this.lblTotalInfo.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 288);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 13;
            // 
            // lbLWarning
            // 
            this.lbLWarning.AutoSize = true;
            this.lbLWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbLWarning.ForeColor = System.Drawing.Color.Orange;
            this.lbLWarning.Location = new System.Drawing.Point(9, 262);
            this.lbLWarning.Name = "lbLWarning";
            this.lbLWarning.Size = new System.Drawing.Size(85, 17);
            this.lbLWarning.TabIndex = 14;
            this.lbLWarning.Text = "WARNING!";
            this.lbLWarning.Visible = false;
            // 
            // tmrShake
            // 
            this.tmrShake.Interval = 1;
            this.tmrShake.Tick += new System.EventHandler(this.tmrShake_Tick);
            // 
            // btnRepair
            // 
            this.btnRepair.BackColor = System.Drawing.Color.Orange;
            this.btnRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepair.Location = new System.Drawing.Point(520, 74);
            this.btnRepair.Name = "btnRepair";
            this.btnRepair.Size = new System.Drawing.Size(111, 40);
            this.btnRepair.TabIndex = 15;
            this.btnRepair.Text = "REPAIR";
            this.btnRepair.UseVisualStyleBackColor = false;
            this.btnRepair.Visible = false;
            this.btnRepair.Click += new System.EventHandler(this.btnRepair_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAgain.Location = new System.Drawing.Point(403, 185);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(228, 40);
            this.btnAgain.TabIndex = 16;
            this.btnAgain.Text = "NEW PIGGYBANK";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // PiggyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 335);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.btnRepair);
            this.Controls.Add(this.lbLWarning);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTotalInfo);
            this.Controls.Add(this.lblOccupancyInfo);
            this.Controls.Add(this.pcbMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFold);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOccupancyRate);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbBanknotes);
            this.Controls.Add(this.cmbCoins);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PiggyMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIGGY BANK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PiggyMainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoins;
        private System.Windows.Forms.ComboBox cmbBanknotes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Label lblOccupancyRate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnFold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbMoney;
        private System.Windows.Forms.Label lblOccupancyInfo;
        private System.Windows.Forms.Label lblTotalInfo;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbLWarning;
        private System.Windows.Forms.Timer tmrShake;
        private System.Windows.Forms.Button btnRepair;
        private System.Windows.Forms.Button btnAgain;
    }
}

