using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DNDGeneratior
{
	internal class Charater : INotifyPropertyChanged
	{
		private string cName;
		private int cAge;
		private string cGender;
		private string cClass;
		private string cRace;
		private int cStrength;
		private int cDex;
		private int cChar;
		private int cInteg;
		private int cWis;
		private int cCon;
		private Random random = new Random();

		public List<string> lstClasses = new List<string>
		{
			"Barbarian",
			"Bard",
			"Cleric",
			"Druid",
			"Fighter",
			"Monk",
			"Paladin",
			"Ranger",
			"Rogue",
			"Sorcerer",
			"Warlock",
			"Wizard"
		};

		public List<string> lstRaces = new List<string>
		{
			"Dragonborn",
			"Dwarf",
			"Elf",
			"Gnome",
			"Half-Elf",
			"Halfling",
			"Half-Orc",
			"Human",
			"Tiefling"
		};

		public List<string> lstGenders = new List<string>
		{
			"Male",
			"Female",
			"Non-Binary"
		};

		public void Randomize()
		{
			this.CClass = lstClasses.ElementAt(random.Next(lstClasses.Count));
			this.Race = lstRaces.ElementAt(random.Next(lstRaces.Count));
			this.Gender = lstGenders.ElementAt(random.Next(lstGenders.Count));
			this.Age = random.Next(18, 100);
			this.Strength = random.Next(20);
			this.Dex = random.Next(20);
			this.CChar = random.Next(20);
			this.Integ = random.Next(20);
			this.Wis = random.Next(20);
			this.Con = random.Next(20);
		}

		public Charater()
		{
			Randomize();
		}

		public Charater(string name, int age, string gender, string cclass, string race, int strength, int dex, int integ, int wis, int cchar, int con)
		{
			this.cName = name;
			this.cAge = age;
			this.cGender = gender;
			this.cClass = cclass;
			this.cRace = race;
			this.cStrength = strength;
			this.cDex = dex;
			this.cInteg = integ;
			this.cWis = wis;
			this.cChar = cchar;
			this.cCon = con;
		}

		//public string Name
		//{
		//	get { return cName; }
		//	set
		//	{
		//		cName = value;
		//		PropertyHasChanged("Name");
		//	}
		//}

		public int Age
		{
			get { return cAge; }
			set
			{
				cAge = value;
				PropertyHasChanged("Age");
			}
		}

		public string Gender
		{
			get { return cGender; }
			set
			{
				cGender = value;
				PropertyHasChanged("Gender");
			}
		}

		public string Race
		{
			get { return cRace; }
			set
			{
				cRace = value;
				PropertyHasChanged("Race");
			}
		}

		public string CClass
		{
			get { return cClass; }
			set
			{
				cClass = value;
				PropertyHasChanged("CClass");
			}
		}

		public int Strength
		{
			get { return cStrength; }
			set
			{
				cStrength = value;
				PropertyHasChanged("Strength");
			}
		}

		public int Dex
		{
			get { return cDex; }
			set
			{
				cDex = value;
				PropertyHasChanged("Dex");
			}
		}
		public int CChar
		{
			get { return cChar; }
			set
			{
				cChar = value;
				PropertyHasChanged("CChar");
			}
		}

		public int Con
		{
			get { return cCon; }
			set
			{
				cCon = value;
				PropertyHasChanged("Con");
			}
		}
		public int Wis
		{
			get { return cWis; }
			set
			{
				cWis = value;
				PropertyHasChanged("Wis");
			}
		}

		public int Integ
		{
			get { return cInteg; }
			set
			{
				cInteg = value;
				PropertyHasChanged("Integ");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void PropertyHasChanged(string s)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
		}
	}
}
