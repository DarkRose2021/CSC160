namespace ConcoleLibrary
{
	public static class IO
	{
		public static void Print(string strStringToPrint)
		{
			Console.WriteLine(strStringToPrint);
		}

		/// <summary>
		/// Gets an integer from Console
		/// </summary>
		/// <param name="strMsg"></param> Message from user
		/// <param name="intMin"></param> Minimum integer value
		/// <param name="intMax"></param> Maximum integer value
		/// <returns>Returns integer if they entered a valid integer</returns>
		public static int GetConsoleInt(string strMsg, int intMin, int intMax)
		{
			bool bSuccess = false;
			int intTypedValue;

			do
			{
				Console.WriteLine(strMsg);

				//try to parse msg
				bSuccess = int.TryParse(Console.ReadLine(), out intTypedValue);
				bSuccess = bSuccess && intTypedValue >= intMin && intTypedValue <= intMax;

				if (!bSuccess)
				{
					Console.WriteLine("You enter an invalid value. Must be between {0} and {1} and a valid integer.", intMin, intMax);
				}
			} while (!bSuccess);

			return intTypedValue;
		}

		public static float GetConsoleFloat(string strMsg, float floatMin, float floatMax)
		{
			bool bSuccess = false;
			float floatTypedValue;

			do
			{
				Console.WriteLine(strMsg);

				//try to parse msg
				bSuccess = float.TryParse(Console.ReadLine(), out floatTypedValue);

				bSuccess = bSuccess && floatTypedValue >= floatMin && floatTypedValue <= floatMax;

				if (!bSuccess)
				{
					Console.WriteLine("You enter an invalid value. Must be between {0} and {1} and a valid integer.", floatMin, floatMax);
				}
			} while (!bSuccess);

			return floatTypedValue;
		}

		public static bool getConsoleBool(string strMsg)
		{
			bool bSuccess = false;
			bool boolTypedValue;

			do
			{
				Console.WriteLine(strMsg);
				bSuccess = bool.TryParse(Console.ReadLine(), out boolTypedValue);

				if (!bSuccess)
				{
					Console.WriteLine("Please enter true or false");
				}

			} while (!bSuccess);
			return boolTypedValue;
		}

		public static char getConsoleChar(string strMsg)
		{
			bool bSuccess = false;
			char charTypedValue;

			do
			{
				Console.WriteLine(strMsg);
				bSuccess = char.TryParse(Console.ReadLine(), out charTypedValue);

				if (!bSuccess)
				{
					Console.WriteLine("Please enter a valid char");
				}

			} while (!bSuccess);
			return charTypedValue;
		}

		public static string getConsoleString(string strMsg)
		{
			bool bSuccess = true;
			string strTypedValue;

			do
			{
				Console.WriteLine(strMsg);
				strTypedValue = Console.ReadLine();
				bSuccess = string.IsNullOrEmpty(strTypedValue);

				if (bSuccess)
				{
					Console.WriteLine("Please enter a valid string");
				}

			} while (bSuccess);
			return strTypedValue;
		}
		public static int getConsoleMenu(string[] items)
		{
			bool bSuccess = false;
			int numbered = 0;
			int intTypedValue;

			for (int i = 0; i < items.Length; i++)
			{
				numbered++;
				Console.WriteLine($"[{numbered}] {items[i]}");
			}

			do
			{
				Console.WriteLine("Please select what you would like to do");
				bSuccess = bSuccess = int.TryParse(Console.ReadLine(), out intTypedValue);
				bSuccess = bSuccess && intTypedValue != 0 && intTypedValue <= numbered;

				if (!bSuccess)
				{
					Console.WriteLine("Please enter a number from the list");
				}

			} while (!bSuccess);

			return intTypedValue;
		}
	}
}