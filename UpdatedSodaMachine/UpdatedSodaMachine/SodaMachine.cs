using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    public class SodaMachine : LoadCoins
    {
        List<Coin> register;
        List<Soda> sodas;
        Customer customer = new Customer();

        public SodaMachine()
        {
            register = new List<Coin>();
            sodas = new List<Soda>();

        }

        public List<Coin> insertCoins(List<Coin> coins)
        {
            register.AddRange(coins);
            return register;
        }

        public List<Soda> vend(Soda soda, List<Coin> coins)
        {

            register.AddRange(coins);

            double sum = coins.Sum(coin => coin.CoinValue);
            double changeTotal = sum - soda.Price;

            if (sum >= soda.Price) //&& sodas.Contains(soda))
            {
                sodas.Remove(soda);
                customer.soda = soda;
            }

            return sodas;
        }

        public List<Coin> insufficentFunds(Soda soda, List<Coin> coins)
        {

            double sum = coins.Sum(coin => coin.CoinValue);
            Console.WriteLine(sum);

            register.AddRange(coins);
            if (soda.Price > sum)
            {
                Console.WriteLine("Insufficent Funds");

            }

            return register;
        }

        public List<Coin> ReturnChange(Soda soda, List<Coin> coins)
        {
            register.AddRange(coins);
            double sum = coins.Sum(coin => coin.CoinValue);
            double change = sum - soda.Price;
            double registerTotal = register.Sum(coin => coin.CoinValue);
            if ((sodas.Contains(soda)) && (sum > soda.Price))
            {
                registerTotal -= change;
            }

            return register;
        }

        public List<Coin> loadPenny(int numPenny)
        {

            for (int i = 0; i < numPenny; i++)
            {
                register.Add(new Penny());

            }
            return register;
        }
        public List<Coin> loadNickel(int numNickel)
        {

            for (int i = 0; i < numNickel; i++)
            {
                register.Add(new Nickel());
            }
            return register;
        }

        public List<Coin> loadDime(int numDime)
        {
            for (int i = 0; i < numDime; i++)
            {
                register.Add(new Dime());

            }
            return register;
        }
        public List<Coin> loadQuarter(int numQuarter)
        {

            for (int i = 0; i < numQuarter; i++)
            {
                register.Add(new Quarter());

            }
            return register;

        }
        public List<Soda> loadMeatSoda(int numMeatSoda)
        {
            for (int i = 0; i < numMeatSoda; i++)
            {
                sodas.Add(new MeatSoda());

            }
            return sodas;
        }

        public List<Soda> loadOrangeSoda(int numOrangeSoda)
        {
            for (int i = 0; i < numOrangeSoda; i++)
            {
                sodas.Add(new OrangeSoda());

            }
            return sodas;
        }

        public List<Soda> loadGrapeSoda(int numGrapeSoda)
        {
            for (int i = 0; i < numGrapeSoda; i++)
            {
                sodas.Add(new GrapeSoda());

            }
            return sodas;
        }
    }
}
