namespace Foundation
{
	internal class Generics
	{
		public static void doit()
		{
			float fltHamburger = 4.5f;
			float fltCheeseburger = 3.5f;

			Swap<float>(ref fltHamburger, ref fltCheeseburger);
			Console.WriteLine("Ham: " + fltHamburger + " ches: " + fltCheeseburger);

			decimal decReturn = GetConsoleNum<decimal>("Enter a decimal", .001, 100.99);
		}

		static void Swap<G>(ref G first, ref G second)
		{
			G temp = first;
			first = second;
			second = temp;
		}

		public static T GetConsoleNum<T>(string msg, double min, double max)
		{
			bool success = false;
			double dblTypedValue;
			do
			{
				Console.WriteLine(msg);
				success = double.TryParse(Console.ReadLine(), out dblTypedValue);

				success = success & dblTypedValue >= min & dblTypedValue <= max;

				if (!success)
				{
					Console.WriteLine("You entered an invalid value");
				}
			} while (!success);

			return (T)Convert.ChangeType(dblTypedValue, typeof(T));
		}
	}
}
