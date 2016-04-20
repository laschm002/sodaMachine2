using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    public class Coin
    {
        private double coinValue;

        public virtual double CoinValue
        {
            get
            {
                return coinValue;
            }

            set
            {
                coinValue = value;
            }
        }
    }
}
