using PiggyBankData.Concrete;
using PiggyBankUI.Properties;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using PiggyBankData.Exceptions;

namespace PiggyBankUI
{
    public partial class PiggyMainForm : Form
    {
        PiggyVolumeForm piggyVolume = new PiggyVolumeForm();
        Money selectedMoney;
        private readonly Moneybox moneybox;
        PiggyBankException bankException;
        public PiggyMainForm(Moneybox moneybox)
        {
            moneybox.MoneyboxFulled += Moneybox_MoneyboxFulled;
            InitializeComponent();
            FillComboboxes();
            ClearPicturebox();
            this.moneybox = moneybox;
            Text = $"PiggyBank - Capacity : {moneybox.Capacity:#,###,###} mm³";
        }
        private void ClearPicturebox()
        {
            pcbMoney.Image = null;
        }
        private void Moneybox_MoneyboxFulled(object sender, PiggyBankData.EventArgs.MoneyboxFulledEventArgs e)
        {
            string errorMessage = $"The piggy bank overflowed with a volume of {e.ExceedValue:#,###,###} mm³. Please enter a lower amount or try to shake.";
            try
            {
                throw new PiggyBankException(errorMessage);
            }
            catch (Exception ex)
            {
                ThrowError(ex);
            }
        }
        private void ThrowError(Exception error)
        {
            lbLWarning.Show();
            lblError.Text = error.Message;
            Refresh();
            Thread.Sleep(2000);
            lblError.Text = "";
            lbLWarning.Hide();
        }
        private void FillComboboxes()
        {
            cmbBanknotes.DataSource = new List<Banknote>()
            {
                new Banknote()
                {
                    Name = "5 Lira",
                    Value = 5,
                    Length = 64,
                    Width = 130,
                    Image = Resources.banknote5
                },
                new Banknote()
                {
                    Name = "10 Lira",
                    Value = 10,
                    Length = 64,
                    Width = 136,
                    Image = Resources.banknote10

                },
                new Banknote()
                {
                    Name = "20 Lira",
                    Value = 20,
                    Length = 68,
                    Width = 142,
                    Image = Resources.banknote20

                },
                new Banknote()
                {
                    Name = "50 Lira",
                    Value = 50,
                    Length = 68,
                    Width = 148,
                    Image = Resources.banknote50
                },
                new Banknote()
                {
                    Name = "100 Lira",
                    Value = 100,
                    Length = 72,
                    Width = 154,
                    Image = Resources.banknote100
                },
                    new Banknote()
                {
                    Name = "200 Lira",
                    Value = 200,
                    Length = 72,
                    Width = 160,
                    Image = Resources.banknote200
                }
            };
            cmbCoins.DataSource = new List<Coin>()
            {
                new Coin()
                {
                    Name = "1 Kuruş",
                    Value = 0.01m,
                    Diameter = 16.5,
                    Height = 1.35,
                    Image = Resources.kurus1

                },
                new Coin()
                {
                    Name = "5 Kuruş",
                    Value = 0.05m,
                    Diameter = 17.5,
                    Height = 2.9,
                    Image = Resources.kurus5
                },
                new Coin()
                {
                    Name = "10 Kuruş",
                    Value = 0.10m,
                    Diameter = 18.5,
                    Height = 3.15,
                    Image = Resources.kurus10
                },
                new Coin()
                {
                    Name = "25 Kuruş",
                    Value = 0.25m,
                    Diameter = 20.5,
                    Height = 4,
                    Image = Resources.kurus25
                },
                new Coin()
                {
                     Name = "50 Kuruş",
                    Value = 0.50m,
                    Diameter = 23.85,
                    Height = 6.8,
                    Image = Resources.kurus50
                },
                    new Coin()
                {
                    Name = "1 Lira",
                    Value = 1.00m,
                    Diameter = 26.15,
                    Height = 8.2,
                    Image = Resources.lira1
                }
            };
            ClearComboboxes();
        }
        private void ClearComboboxes()
        {
            cmbBanknotes.SelectedIndex = -1;
            cmbCoins.SelectedIndex = -1;
        }
        private void btnFold_Click(object sender, EventArgs e)
        {
            Banknote banknote = (Banknote)selectedMoney;
            if (banknote != null)
            {
                banknote.Fold();
                btnFold.Text = "FOLDED";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var banknote = selectedMoney as Banknote;
            if (selectedMoney == null)
            {
                string errorMessage = "Please choose either coin or banknote for your piggybank !";
                bankException = new PiggyBankException(errorMessage);
                ThrowError(bankException);
                return;
            }
            if (banknote != null && banknote.IsFolded == false)
            {
                string errorMessage = "You should fold the banknote before throw in your piggybank !";
                bankException = new PiggyBankException(errorMessage);
                ThrowError(bankException);
                return;
            }
            moneybox.AddMoney(selectedMoney);
            UpdateOccupancyRate();
            if (banknote != null)
                banknote.IsFolded = false;
            ClearComboboxes();
            ClearPicturebox();
            btnFold.Text = "FOLD";

        }
        private void btnShake_Click(object sender, EventArgs e)
        {
            tmrShake.Start();
            moneybox.Shake();
            UpdateOccupancyRate();
        }
        private void UpdateOccupancyRate()
        {
            lblOccupancyRate.Text = "%" + moneybox.OccupancyRate.ToString("N"); //metot
        }
        private void cmbCoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoins.SelectedItem == null) return;
            btnFold.Enabled = false;
            selectedMoney = (Coin)cmbCoins.SelectedItem;
            pcbMoney.Image = selectedMoney.Image;
            cmbBanknotes.SelectedIndex = -1;
        }
        private void cmbBanknotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBanknotes.SelectedItem == null) return;
            btnFold.Enabled = true;
            selectedMoney = (Banknote)cmbBanknotes.SelectedItem;
            pcbMoney.Image = selectedMoney.Image;
            cmbCoins.SelectedIndex = -1;
        }
        private void btnBreak_Click(object sender, EventArgs e)
        {
            byte breakRemaining = moneybox.BreakRemaining;
            if (breakRemaining == 1)
            {
                DialogResult dr = MessageBox.Show($"You can repair only one time after break your piggybank. Are you sure that you would like to break it?", "PiggyBank", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var moneyList = moneybox.Break();
                    decimal total = moneyList.Sum(x => x.Value);

                    lblTotalAmount.Text = total.ToString("C2", CultureInfo.GetCultureInfo("tr-tr"));
                    lblTotalInfo.Show();
                    lblTotalAmount.Show();
                    btnAdd.Enabled = false;
                    btnFold.Enabled = false;
                    btnShake.Enabled = false;
                    btnBreak.Text = "BREAK";
                    btnRepair.Show();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show("You can not repair again ! Are you sure to contiune?", "PiggyBank", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    var moneyList = moneybox.Break();
                    decimal total = moneyList.Sum(x => x.Value);
                    dr = MessageBox.Show($"You save {total}₺, no more break. Would you like to create a new piggybank?", "PiggyBank", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        piggyVolume.Show();
                    }
                    else
                    {
                        btnBreak.Enabled = false;
                        btnAdd.Enabled = false;
                        btnFold.Enabled = false;
                        btnShake.Enabled = false;
                        btnBreak.Enabled = false;
                        cmbBanknotes.Enabled = false;
                        cmbCoins.Enabled = false;
                        lblOccupancyInfo.Hide();
                        lblOccupancyRate.Hide();
                        btnAgain.Show();
                    }

                }

            }
        }
        private void tmrShake_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int shaker = 0;
            Point firstPosition = this.Location;
            while (shaker < 5)
            {
                int x = rnd.Next(1, 20);
                int y = rnd.Next(1, 20);
                this.Location = new Point(firstPosition.X + x, firstPosition.Y + y);
                Thread.Sleep(20);
                shaker++;
            }
            this.Location = firstPosition;
            tmrShake.Stop();
        }
        private void btnRepair_Click(object sender, EventArgs e)
        {
            lblTotalAmount.Hide();
            lblTotalInfo.Hide();
            btnShake.Enabled = true;
            btnAdd.Enabled = true;
            btnFold.Enabled = true;
            btnRepair.Hide();
        }
        private void PiggyMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnAgain_Click(object sender, EventArgs e)
        {
            piggyVolume.Show();
        }
    }
}
