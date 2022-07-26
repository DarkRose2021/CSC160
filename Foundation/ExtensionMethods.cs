namespace Foundation
{
	internal class ExtensionMethods
	{
		public static void Engage()
		{
			string strmsg = "Havarti Cheese";
			Console.WriteLine("Is [{0}] first letter capitalized? {1}", strmsg, strmsg.IsFirstCap());
			Console.WriteLine(strmsg.AppendToEnd(" is the best cheese in the world."));
		}
	}
	//Extension must be in a static class
	public static class StringHelper
	{
		public static bool IsFirstCap(this string strIncoming)
		{
			return char.IsUpper(strIncoming[0]);

		}

		public static string AppendToEnd(this string incoming, string append)
		{
			return incoming + append;
		}
	}
}
