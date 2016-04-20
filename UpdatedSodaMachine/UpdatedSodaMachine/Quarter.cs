using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    class Quarter : Coin
    {
        public Quarter()
        {
            base.CoinValue = .25;
        }
    }
}
