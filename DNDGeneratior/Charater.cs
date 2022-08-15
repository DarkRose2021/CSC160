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

		public void Randomize()
		{
			this.cclass = lstClasses.ElementAt(random.Next(lstClasses.Count));
			//this.cRace = lstRace.ElementAt(random.Next(lstRace.Count));
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

		public string Name
		{
			get { return cName; }
			set
			{
				cName = value;
				PropertyHasChanged("Name");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void PropertyHasChanged(string s)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
		}
	}
}
