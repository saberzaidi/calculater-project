using System;
using System.Runtime.ExceptionServices;

namespace calculater_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my calculater");
            int a, b, c;
                Console.WriteLine("Please Enter First no");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Second no");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("YourAnswer =" +c);
            Console.ReadLine();
        }
    }
}
