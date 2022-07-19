namespace Foundation
{
	internal class Ploymorphism
	{
		public static void doit()
		{
			Animal myAnimal = new Animal();
			Animal myPig = new Pig();
			Animal myDog = new Dog();

			myAnimal.animalSound(); //outputs the base response
			myPig.animalSound(); //outputs the response from the Pig child class
			myDog.animalSound(); //outputs the response from the Dog child class
		}

		//adding the virtual keyword to the method inside the base class, and by using the override keyword for each derived class methods

		class Animal  // Base class (parent) 
		{
			public virtual void animalSound()
			{
				Console.WriteLine("The animal makes a sound");
			}
		}

		class Pig : Animal  // Derived class (child) 
		{
			public override void animalSound()
			{
				Console.WriteLine("The pig says: oink oink");
			}
		}

		class Dog : Animal  // Derived class (child) 
		{
			public override void animalSound()
			{
				Console.WriteLine("The dog says: bark bark");
			}
		}
	}
}
