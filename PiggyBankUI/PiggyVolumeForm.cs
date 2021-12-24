using PiggyBankData.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBankUI
{
    public partial class PiggyVolumeForm : Form
    {
        public PiggyVolumeForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double capacity = (double)nmuTotalVolume.Value;
            Moneybox moneybox = new Moneybox(capacity);
            PiggyMainForm piggyMain = new PiggyMainForm(moneybox);
            piggyMain.Show();
            Hide();

        }
    }
}
