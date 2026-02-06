using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer positive number");
            UInt64.TryParse(Console.ReadLine(), out ulong ulNumber);
            if (ulNumber % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");
            Console.ReadLine();
        }
    }
}
