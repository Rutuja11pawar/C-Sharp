using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 11;
            if (num % 2 == 0)
            {
                Console.WriteLine("It is Even Number");
            }
            else
            {
                Console.WriteLine("It is Odd Number");
            }
            Console.ReadLine();
        }
    }
}
