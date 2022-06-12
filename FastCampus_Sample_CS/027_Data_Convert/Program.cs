using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Data_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141593";
            string strC = "3.1415926536897932384727433832";

            int convertA = Convert.ToInt32(strA);
            float convertB = Convert.ToSingle(strB);
            decimal convertC = Convert.ToDecimal(strC);

            Console.WriteLine("Convert.Toint32(strA) : {0}", convertA);
            Console.WriteLine("Convert.ToSingle(strB) : {0}", convertB);
            Console.WriteLine("Convert.ToDecimal(strC) : {0}", convertC);
        }
    }
}
