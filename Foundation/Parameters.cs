using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Parameters
    {
        public static void DoIt()
        {
            int intRef = 7;
            int[] ary = new int[] { 5, 6 };
            string strByValue = "Fred";
            RefTest clsRT = new RefTest();
            clsRT.x = 1;
            int intValue = 66;
            bool boolValue = false;

            ByValRefTest(ref intRef, strByValue, ary, clsRT, intValue, boolValue);
            Console.WriteLine("int ByRef: {0}", intRef);
            Console.WriteLine("String ByVal: {0}", strByValue);
            Console.WriteLine("ary[0]: {0}", ary[0]);
            Console.WriteLine("clsRT.x: {0}", clsRT.x);
            Console.WriteLine("int intValue: {0}", intValue);
            Console.WriteLine("bool boolValue: {0}", boolValue);

            //DefaultParam();
            //DefaultParam(40);

            namedFuction(10, 20);
            namedFuction(y: 10, x: 20);
        }

        static void namedFuction(int x, int y)
        {
            Console.WriteLine("Named param: {0}-{1}", x, y);
        }
        //creates default optional param
        static void DefaultParam(int n = 20)
        {
            Console.WriteLine("Default param: {0}", n);
        }

        public class RefTest
        {
            public int x;
        }

        public static void ByValRefTest(ref int xRef, string sVal, int[] ary, RefTest clsRefTest, int intValue, bool boolValue)
        {
            xRef = xRef * xRef;
            sVal = "Fanny";
            ary[0] = 10;
            clsRefTest.x = 88;
            intValue = 42;
            boolValue = true;
        }
    }
}
