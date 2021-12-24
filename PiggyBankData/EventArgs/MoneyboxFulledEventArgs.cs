using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankData.EventArgs
{
    public class MoneyboxFulledEventArgs
    {
        public MoneyboxFulledEventArgs(double exceedValue)
        {
            ExceedValue = exceedValue;
        }
        public double ExceedValue { get; }
    }
}
