using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _044_Operator_Branch3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isA = false;
            bool isB = true;
            bool isC = true;
            bool isD = false;

            if (isA && isB)
            {
                Console.WriteLine("flase && true => false");
            }
            
            if (isB && isC)
            {
                Console.WriteLine("true && ture => ture");
            }

            if (isC || isD)
            {
                Console.WriteLine("ture || false => ture");
            }

            if (2 > 1 && 3 < 4 || 1 > 2)
            {
                Console.WriteLine("true && ture || false => ture");
            }

        }
    }
}
