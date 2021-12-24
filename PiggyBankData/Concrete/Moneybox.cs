using PiggyBankData.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankData.Concrete
{
    public class Moneybox
    {
        public event EventHandler<MoneyboxFulledEventArgs> MoneyboxFulled;
        private double TotalVolume;
        public Moneybox(double capacity)
        {
            Capacity = capacity;
            Money = new List<Money>();
            BreakRemaining = 1;
        }
        private List<Money> Money { get; set; }
        public double Capacity { get; set; } 
        public byte BreakRemaining { get; private set; }
        public double OccupancyRate { get; set; }
        public List<Money> Break()
        {
            BreakRemaining--;
            return Money;
        }
        public void AddMoney(Money money)
        {
            double totalVolumeOfMoney = money.GetVolume() + money.GetExcessArea();
            double overspill = TotalVolume + totalVolumeOfMoney;

            if (overspill > Capacity)
            {
                if (MoneyboxFulled != null)
                    MoneyboxFulled(this, new MoneyboxFulledEventArgs(overspill - Capacity));
            }
            else
            {
                Money.Add(money);
                UpdateOccupancyRate(money.GetVolume(), money.GetExcessArea());
            }

        }
        public void Shake()
        {
            TotalVolume = 0;
            foreach (Money money in Money)
            {
                double defaultExcess = (money.GetVolume() * 25) / 100;
                UpdateOccupancyRate(money.GetVolume(), defaultExcess);
            }
        }
        private void UpdateOccupancyRate(double volume, double excessArea)
        {
            TotalVolume += volume + excessArea;
            OccupancyRate = (TotalVolume / Capacity) * 100;
        }
    }
}
