using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankData.Concrete
{
    public class Coin : Money
    {
        private const double PI_NUMBER = 3.14;
        public double Height { get; set; }
        public double Diameter { get; set; }
        public override double GetVolume() => Height * Math.Pow(Diameter / 2, 2) * PI_NUMBER;
        public override string ToString() => $"{Name}";
    }
}
