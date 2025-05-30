using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace display_value_using_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            int argument1 = Convert.ToInt31(args[0]);
            Console.WriteLine("Argument in interger is : " + argument1);

            double argument2 = Convert.ToDouble(args[1]);
            Console.WriteLine("Argument in double is : " + argument2);
            Console.ReadKey();
        }
    }
}
