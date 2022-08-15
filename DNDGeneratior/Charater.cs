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
			this.cClass = lstClasses.ElementAt(random.Next(lstClasses.Count));
			this.cRace = lstRaces.ElementAt(random.Next(lstRaces.Count));
			this.cGender = lstGenders.ElementAt(random.Next(lstGenders.Count));
			this.cAge = random.Next(20, 30);
		}

		public Charater()
		{
			Randomize();
		}

		public Charater(string name, int age, string gender, string cclass, string race)
		{
			this.cName = name;
			this.cAge = age;
			this.cGender = gender;
			this.cClass = cclass;
			this.cRace = race;
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

		public event PropertyChangedEventHandler PropertyChanged;

		private void PropertyHasChanged(string s)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
		}
	}
}
