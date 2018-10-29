using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num = Console.ReadLine();
            Console.WriteLine(num + " will be added to 10.");
            Console.WriteLine("Now press enter");
            Console.ReadLine();
            Console.WriteLine(num + 10 + " is your Result & I don't give a crap what you think!");
            Console.ReadLine();
        }
    }
}
