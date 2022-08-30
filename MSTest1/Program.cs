namespace MSTest1
{
	internal class Program
	{
		public static double addIt(string str1, string str2)
		{
			double dblA, dblB;
			double.TryParse(str1, out dblA);
			double.TryParse(str2, out dblB);

			return dblA + dblB;
		}
	}
}
