using System;
using System.Collections.Generic;

namespace DNDGeneratior
{
	internal class Charater
	{
		private string cName;
		private int cAge;
		private string cGender;
		private string cClass;
		private string cRace;

		public List<string> lstNames = new List<string>
		{
			"Vland The Impaler",
			"Talsen Phla",
			"Oswald Copplepot"
		};

		public Charater(string cName, int cAge, string cGender, string cClass, string cRace)
		{
			this.cName = cName;
			this.cAge = cAge;
			this.cGender = cGender;
			this.cClass = cClass;
			this.cRace = cRace;
		}

		public string Name
		{
			get { return cName; }
			set { cName = value; }
		}

		public event EventHandler<string> PropertyChanged;

		private void PropertyHasChanged(string s)
		{
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
		}
	}
}
