using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Converting
    {

        public static bool IsNumeric(string strNumber)
        {
            double dblIsNumber;
            return double.TryParse(strNumber, out dblIsNumber);
        }

        public static void DoIt()
        {
            //Implicit Conversion.  a long can hold any value an int can
            //built in numeric types, Implicit Conversion can be made when the value fits without being cut off
            int intNum = 34564321;
            long lngBigNum = intNum;
            var ch = 'C';
            Console.WriteLine("var type: {0}", ch.GetType());

            //Explicit Conversion
            double d = 12234.56;
            int i;
            i = (int)d;
            Console.WriteLine(i);

            //int intWasString = "5"; //doesn't work
            string strNum = "5";
            int intResults = 0;
            intResults = int.Parse(strNum);
            Console.WriteLine("Parse: {0} {1}", intResults, intResults.GetType());

            bool bSuccess = int.TryParse(strNum, out intResults);
            Console.WriteLine(strNum+ " converts to int? " + bSuccess);
        }
    }
}