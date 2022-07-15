namespace Foundation
{
	internal class Classes
	{
		public static void Engage()
		{
			ExampleProps ep = new ExampleProps();

			ep.prop2 = "stuff";
			string s2 = ep.prop2;
			ep.GetProp3 = "prop3 stuff";
			string s3 = ep.GetProp3;

			float fltArea = Math.CalculateArea(2.0f);

			//Student milton = new Student();
			//milton.Name = "Milton";  //setter
			//Console.WriteLine("Student's name is: {0}", milton.Name); //getter

			//milton.GPA = 3.67843f;
			//Console.WriteLine("Milton's GPA: {0:0.0} ", milton.GPA);

			//Student tanner = new Student();
			//Student angelina = new Student("Angelina", 37, 3.99f, 19);

			Alumni a = new Alumni("Bob", 3.4f, 33, 1999);

		}

		class Student
		{
			protected string name;
			protected int cohort = 37;
			protected float gpa;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}
			public float GPA
			{
				get { return gpa; }
				set
				{
					if (value >= 0 && value <= 4.0)
					{
						gpa = value;
					}
				}
			}

			//auto implemented property
			public int Age { get; set; } = 20;
			static int numberOfStudents = 0;  // all studnets share this value

			public Student()
			{
				Age = 26;
				numberOfStudents++;
				Console.WriteLine("In Student constructor 0 params");
			}

			public Student(string name, int cohort, float gPA, int age)
			{

				this.cohort = cohort;
				Name = name;
				GPA = gPA;
				Age = age;
				numberOfStudents++;
			}
		}

		class Alumni : Student
		{
			public Alumni()
			{
				Console.WriteLine("Derived Alumni class constuctor 0 params");

			}

			public Alumni(string name, float gpa, int cohort, int yearGraduated) : base(name, cohort, gpa, 20)
			{
				Console.WriteLine("Derived Alumni class constructor called with 4 params");

			}
		}


		//static classes are optional, but force all methods in it to be static
		static class Math
		{
			public const float PI = 3.14159f;

			public static float CalculateArea(float radius)
			{
				return 2 * PI * radius;
			}
		}



		class ExampleProps
		{
			public string prop2;  //public quick and easy
			private string prop3; //private with get/set -> better security, validation

			public string GetProp3
			{
				get { return prop3; }
				set { prop3 = value; }
			}
		}

	}
}
