using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankData.Concrete
{
    public abstract class Money
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public abstract double GetVolume();
        public Bitmap Image { get; set; }
        public double GetExcessArea()
        {
            Random rnd = new Random();
            double excessRnd = rnd.Next(25, 76);
            double excessVolume = (excessRnd * GetVolume()) / 100;
            return excessVolume;
        }
    }
}
