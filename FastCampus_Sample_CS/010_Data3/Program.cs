﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData;

            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbyte min {0} , sbyte max {1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("sbyteData2: " + sbyteData2);
        }
    }
}
