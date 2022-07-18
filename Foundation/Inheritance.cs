namespace Foundation
{
	internal class Inheritance
	{
		public static void doIt()
		{
			//Animal animal = new Animal();
			//animal.Name = "Cat";

			//Animal animal1 = new Animal() {Name = "Cat"};

			Animal animal = new Animal(13, "Sabbath", false);
			// () = calling the constructor OR {} setting properties

			Mammal mammal = new Mammal(119, "Tanner", false, true);
			mammal.Speak();

			//creating an Animal instance of a mammal OR are we converting a Mammal to an Animal
			Animal animal1 = new Mammal(18, "Patchy", true, true, false);
			//Mammal mammal1 = new Animal();
		}

		class Animal
		{
			private int lifeSpan;
			public string Name { get; set; }
			public bool IsNoctunal { get; }

			public Animal() { }

			public Animal(int lifeSpan, string name, bool isNoctunal = false)
			{
				this.lifeSpan = lifeSpan;
				Name = name;
				IsNoctunal = isNoctunal;
			}
			public void Speak()
			{
				Console.WriteLine("Speak");
			}
		}

		class Mammal : Animal
		{
			public bool isCarnivore { get; set; }
			public bool livesOnLand { get; set; }

			public Mammal() { }

			public Mammal(int lifespan, string name, bool isCarnivore, bool livesOnLand, bool isNoctunal = false)
				: base(lifespan, name, isNoctunal)
			{
				this.isCarnivore = isCarnivore;
				this.livesOnLand = livesOnLand;
			}

			public void Speak()
			{
				Console.WriteLine("Speak");
			}

		}
	}
}
