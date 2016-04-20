using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedSodaMachine
{
    class UI
    {
        SodaMachine sodaMachine;
        Customer customer;
        public UI()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();

        }

        public void Run()
        {
            CustomerMenu();

        }

        private void CustomerMenu()
        {
            Console.WriteLine("Soda Machine");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please load your money");
                Console.WriteLine("");
                Console.WriteLine("Press (1) for a Meat flavored soda for 6 cents");
                Console.WriteLine("Press (2) for an Orange flavored soda for 35 cents");
                Console.WriteLine("Press (3) for a Grape flavored soda for 60 cents");
                Console.WriteLine("Press (4) to exit menu");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:


                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("You must enter 1,2,or 3");
                        CustomerMenu();

                        break;
                }

            }

        }
    }
}
