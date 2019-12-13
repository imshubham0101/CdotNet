using System;
using System.Data.SqlClient;
using _02MathsLib;
namespace _00Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection obj = new SqlConnection();
            //SqlCommand cmd = new SqlCommand();

            Console.WriteLine(".net is best!");


            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Sub");
            string choice = Console.ReadLine();

            int ch = Convert.ToInt32(choice);

            Maths obj1 = new Maths();

            if (ch == 1)
            {
                int result = obj1.Add(10, 20);
                Console.WriteLine(result);
            }
            else if (ch == 2)
            {
                int result = obj1.Sub(10, 20);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("Press Enter to terminate");



            Console.ReadLine();
        }
    }
}
