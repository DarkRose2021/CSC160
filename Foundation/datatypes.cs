﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class datatypes
    {
        public static void excute()
        {
            short shortNum;
            int intNum;
            uint uintNUm;
            long longNum;
            float floatNum;
            double doubleNum;
            decimal decimalNum;

            Console.WriteLine("short min: {0}", short.MinValue);
            Console.WriteLine("short max: {0}", short.MaxValue);

            Console.WriteLine();

            Console.WriteLine("int min: {0}", int.MinValue);
            Console.WriteLine("int max: {0}", int.MaxValue);

            Console.WriteLine();

            Console.WriteLine("uint min: {0}", uint.MinValue);
            Console.WriteLine("uint max: {0}", uint.MaxValue);

            Console.WriteLine();

            Console.WriteLine("long min: {0}", long.MinValue);
            Console.WriteLine("long max: {0}", long.MaxValue);

            Console.WriteLine();

            Console.WriteLine("float min: {0}", float.MinValue);
            Console.WriteLine("float max: {0}", float.MaxValue);

            Console.WriteLine();

            Console.WriteLine("double min: {0}", double.MinValue);
            Console.WriteLine("double max: {0}", double.MaxValue);

            Console.WriteLine();

            Console.WriteLine("decimal min: {0}", decimal.MinValue);
            Console.WriteLine("decimal max: {0}", decimal.MaxValue);

            Console.WriteLine();

            char c = 'R';
            Console.WriteLine("char is {0}", c);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c));

            Console.WriteLine();
        }
    }
}
