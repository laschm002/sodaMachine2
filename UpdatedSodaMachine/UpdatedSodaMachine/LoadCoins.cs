using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    interface LoadCoins
    {
        List<Coin> loadPenny(int num);
        List<Coin> loadNickel(int num);
        List<Coin> loadDime(int num);
        List<Coin> loadQuarter(int num);


    }
}
