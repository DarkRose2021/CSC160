namespace Foundation
{
	internal class DebugIt
	{
		public static void doIt()
		{
			double x = 42;
			int y = 78549307;
			int[] ary = { 4, 5, 6, 7 };

			for (int row = 1; row < 10; row++)
			{
				for (int col = 1; col < 10; col++)
				{
					y = y * col;
					x = x * (row * .04) / 5.3;
					InnerFunt(ref x);
				}
			}
		}

		public static void InnerFunt(ref double r)
		{
			string s = "taco";
			r = r * r;

		}
	}
}