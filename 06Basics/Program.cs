using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07BaseDrink;
using HD;
using CD;
namespace _06Basics
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

   
}
