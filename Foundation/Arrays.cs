namespace Foundation
{
    public class Arrays
    {
        public static void DoIt()
        {
            int[] ary1 = new int[3];
            ary1[0] = 55;
            ary1[1] = 145;
            ary1.SetValue(23, 2); //same as ary1[2] = 23;
            //int arys default to 0 otherwise it defaults to null

            int[] ary2 = { 1, 4, 7, 11 };
            int[] ary3 = new int[] { 1, 3, 7, 11 };


            //test 
            for (int i = 0; i < ary1.Length; i++)
            {
                Console.WriteLine("{0} ", ary1[i]);
            }

            Console.WriteLine();

            //iterate without worrying about the index
            foreach (int intEach in ary2)
            {
                Console.WriteLine("{0} ", intEach);
            }

            Console.WriteLine();

            //arrays that allow different types
            object[] aryMultiStuff = new object[] { 10, "bob", 10.4f };

            string[,] aryMultiDim = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int row = 0; row < aryMultiDim.GetLength(0); row++)
            {
                for (int col = 0; col < aryMultiDim.GetLength(1); col++)
                {
                    Console.Write("{0} ", aryMultiDim[row, col]);
                }
                Console.WriteLine();
            }

            int[] aryNums = { 1, 2, 3, 4, 5, 6, 7 };

            WriteArray(aryNums);

            WriteArray(aryNums[..3]);
            WriteArray(aryNums[1..4]);
            WriteArray(aryNums[4..]);

            //arry obj has many funts
            Array.Reverse(aryNums);
            WriteArray(aryNums);

            Array.Sort(aryNums);
            WriteArray(aryNums);

            Console.WriteLine("Find Index {0}", Array.IndexOf(aryNums, 2));
            Console.WriteLine("All Nums <4");
            WriteArray(Array.FindAll(aryNums, LessThanFour));

            //jagged arrays
            //rows and cols of varying sizes
            int[][] aryJagged = new int[3][];

            aryJagged[0] = new int[] { 1, 2, 3, 4 };
            aryJagged[1] = new int[] { 5, 6, 7 };
            aryJagged[2] = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };


        }

        public static bool LessThanFour(int value)
        {
            return value < 4;
        }

        static void WriteArray(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("{0} ", values[i]);
            }
            Console.WriteLine();
        }
    }
}
