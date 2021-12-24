using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBankData.Exceptions
{
   public  class PiggyBankException : Exception
    {
        public PiggyBankException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
