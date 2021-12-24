using PiggyBankData.Abstract;
using System;

namespace PiggyBankData.Concrete
{
    public class Banknote : Money, IFoldable
    {
        public Banknote()
        {
            Height = 0.25;
            IsFolded = false;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public bool IsFolded { get; set; }
        public void Fold()
        {
            Width /= 4;
            Height *= 4;
            IsFolded = true;
        }
        public override double GetVolume() => Width * Height * Length;
        public override string ToString() => $"{Name}";

    }
}
