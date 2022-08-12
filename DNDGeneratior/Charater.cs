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

		public List<string> lstNames = new List<string>
		{
			"Vland The Impaler",
			"Talsen Phla",
			"Oswald Copplepot"
		};

		public void Randomize()
		{
			this.Name = lstNames.ElementAt(random.Next(lstNames.Count));
			//this.cRace = lstRace.ElementAt(random.Next(lstRace.Count));
		}

		public Charater()
		{
			Randomize();
		}

		public Charater(string name, int age, string gender, string cclass, string race)
		{
			this.cName = name;
			//this.cAge = age;
			//this.cGender = gender;
			//this.cClass = cclass;
			//this.cRace = race;
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
