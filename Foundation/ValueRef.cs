using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation
{
    internal class ValueRef
    {
        public static void Engage()
        {
            int v1 = 10;
            int v2 = v1;
            v1 = 5;
            Console.WriteLine("Value type v1: {0}", v1);
            Console.WriteLine("Value type v2: {0}", v2);

            int[] anyNum1 = new int[] {1,2,3};
            int[] anyNum2 = anyNum1;
            anyNum1[0] = 5;
            Console.WriteLine("Ref type 1: {0}", String.Join(",", anyNum1));
            Console.WriteLine("Ref type 2: {0}", String.Join(",", anyNum2));

            Point p1 = new Point(10, 20);
            Point p2 = p1;
            p1.Write();
            p2.Write();

            p1.x = 2000;
            p1.Write();
            p2.Write();
            //strut value type, class reference type
        }

        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x; 
                this.y = y;
            }

            public void Write()
            {
                Console.WriteLine("{0} - {1}", x, y);
            }
        }
    }
}