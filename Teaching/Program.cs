using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                float rubInWallet;
                float dolInWallet;
                int exchangeCurrencyCount;
                float rubToUsd = 90.25f, usdToRub = 90.70f;
                string desiredOperation;

                Console.WriteLine($"Welcome to exchange currency!");
                Console.Write($"Enter number of rubles on wallet: ");
                rubInWallet = Convert.ToSingle(Console.ReadLine());
                if (rubInWallet <= 0)
                {
                    Console.WriteLine($"Entered incorrect balance, exchange is not possible.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write($"Enter number of dollars on wallet: ");
                dolInWallet = Convert.ToSingle(Console.ReadLine());
                if(dolInWallet <= 0)
                {
                    Console.WriteLine($"Entered incorrect balance, exchange is not possible.");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine($"Enter desired operation: ");
                Console.WriteLine($"1 - exchange rubles to dollars.");
                Console.WriteLine($"2 - exchange dollars to rubles.");
                Console.Write($"Your choice is: ");
                desiredOperation = Console.ReadLine();

                switch (desiredOperation)
                {
                    case "1":
                        Console.Write($"Now many rubles you want to exchange: ");
                        exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());
                        if (rubInWallet >= exchangeCurrencyCount)
                        {
                            rubInWallet -= exchangeCurrencyCount;
                            dolInWallet += exchangeCurrencyCount / rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine($"Not enouth rubles in the wallet.");
                        }
                        break;
                    case "2":
                        Console.Write($"How many dollars you want to exchange: ");
                        exchangeCurrencyCount = Convert.ToInt32(Console.ReadLine());
                        if (dolInWallet >= exchangeCurrencyCount)
                        {
                            dolInWallet -= exchangeCurrencyCount;
                            rubInWallet += exchangeCurrencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine($"Not enouth dollars in the wallet.");
                        }
                        break;
                    default:
                        Console.WriteLine($"Entered incorrect operation.");
                        break;
                }
                Console.WriteLine($"On your wallet {rubInWallet} rubles, " + $"{dolInWallet} dollars.");
                Console.ReadKey();
            }
        }

         
    }
}
