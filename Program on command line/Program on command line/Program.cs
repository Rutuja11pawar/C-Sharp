using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_on_command_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Name is : " + args[0]);
            Console.WriteLine("Last Name is : " + args[1]);
            Console.ReadKey();
        }
    }
}
