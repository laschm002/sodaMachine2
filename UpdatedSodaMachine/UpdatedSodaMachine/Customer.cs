using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    class Customer : LoadCoins
    {
        public List<Coin> customerCoins;
        public Soda soda;

        public Customer()
        {
            customerCoins = new List<Coin>();
            soda = null;
        }

        public List<Coin> loadCoins(int numCoin)
        {
            {
                for (int i = 0; i < numCoin; i++)
                {
                    customerCoins.Add(new Penny());

                }
            }
            return customerCoins;

        }
        public List<Coin> loadPenny(int numPenny)
        {

            for (int i = 0; i < numPenny; i++)
            {
                customerCoins.Add(new Penny());

            }
            return customerCoins;
        }
        public List<Coin> loadNickel(int numNickel)
        {

            for (int i = 0; i < numNickel; i++)
            {
                customerCoins.Add(new Nickel());
            }
            return customerCoins;
        }

        public List<Coin> loadDime(int numDime)
        {
            for (int i = 0; i < numDime; i++)
            {
                customerCoins.Add(new Dime());

            }
            return customerCoins;
        }
        public List<Coin> loadQuarter(int numQuarter)
        {

            for (int i = 0; i < numQuarter; i++)
            {
                customerCoins.Add(new Quarter());

            }
            return customerCoins;

        }

    }
}
