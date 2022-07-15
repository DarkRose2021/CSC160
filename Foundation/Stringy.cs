using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class Stringy
    {
        public static void DoIt()
        {
            //3 different ways to format strings
            //string strName = Console.ReadLine();
            //Console.WriteLine("V1 - Hello "+ strName +", glad to meet you!"); //string concatenation
            //Console.WriteLine("V2 - Hello {0}, glad to meet you!", strName); //string interpolation
            //Console.WriteLine($"V3 - Hello {strName}, glad to meet you!");    //string injection

            string strRandomString = "Neumont College of Computer Science";
            Console.WriteLine(strRandomString);

            Console.WriteLine("Length {0}", strRandomString.Length);
            Console.WriteLine("Contains 'of' {0}", strRandomString.Contains("of"));
            int intIndexOf = strRandomString.IndexOf("of");
            Console.WriteLine("IndexOf Contains: {0}", intIndexOf !=-1 ? intIndexOf.ToString(): "Not Found");

            Console.WriteLine("Remove {0}", strRandomString.Remove(intIndexOf, 3));

            StringBuilder sb = new StringBuilder();
            sb.Append("this is a really long string ");
            sb.Append(" it keeps going");
            sb.Append(" and going........");
            Console.WriteLine(strRandomString.ToString());


        }
    }
}
