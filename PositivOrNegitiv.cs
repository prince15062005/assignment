using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class PositivOrNegitiv
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number: ");
            n = Int32.Parse(Console.ReadLine());

            if(n>0)
            {
                Console.WriteLine(n + "is positive");
                
            }
        }
    }
}
