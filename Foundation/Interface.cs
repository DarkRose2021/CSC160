namespace Foundation
{
	internal class Interface
	{
		public static void doit()
		{

		}

		interface ISleep
		{
			public void sleep()
			{
				Console.WriteLine("interface");
			}
		}

		class Bird : Inheritance.Animal, ISleep
		{
			public void sleep()
			{
				Console.WriteLine("sleeps");
			}
		}

		class car
		{
			public virtual void Model()
			{
				Console.WriteLine("Fiesta");
			}
		}

		class Ford : car
		{
			public override void Model()
			{
				Console.WriteLine("Mustang");
			}
		}
	}
}
