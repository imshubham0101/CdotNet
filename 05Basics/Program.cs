using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Env Kaisa hai?");
            Console.WriteLine("1: Cold");
            Console.WriteLine("2: Hot");

            int choice = Convert.ToInt32(Console.ReadLine());
            DrinkFactory factory = new DrinkFactory();
            IDrink myDrink = factory.GetDrink(choice);
            string result = myDrink.Drink();
            Console.WriteLine("Have a " + result);
            Console.ReadLine();

        }
    }

    public class DrinkFactory
    {
        public IDrink GetDrink(int choice)
        {
            if (choice == 1)
            {
                return new HotDrink();
            }
            else
            {
                return new ColdDrink();
            }
        }
    }

    public interface IDrink
    {
        string Drink();
    }

    public class HotDrink:IDrink
    {
        public string Drink()
        {
            return "Tea";
        }
    }

    public class ColdDrink:IDrink
    {
        public string Drink()
        {
            return "Coke";
        }
    }
}


