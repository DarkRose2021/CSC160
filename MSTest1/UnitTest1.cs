namespace MSTest1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestPositive()
		{
			//Positive check
			Assert.AreEqual(Program.addIt("3", "4"), 7);

			//if (Program.addIt("5", "6") != 7)
			//{
			//	Assert.Fail();
			//}

			Assert.AreEqual(Foundation.Arrays.LessThanFour(3), true);
		}

		[TestMethod]
		public void TestNegitive()
		{
			//Positive check
			Assert.AreEqual(Program.addIt("string", "string"), DBNull.Value);
		}
	}
}