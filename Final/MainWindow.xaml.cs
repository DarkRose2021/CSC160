using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Windows;

namespace Final
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Random random = new Random();
		int[] ary = new int[10];
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			for (int i = 0; i < ary.Length; i++)
			{
				ary[i] = random.Next();
				aryTxt.Text = ary[i].ToString();
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			if (stringTxt.Text == "")
			{
				stringTxt.Text = addTxt.Text;
			}
			else if (stringTxt.Text != "")
			{
				stringTxt.Text = sb.Append(addTxt.Text).ToString();
			}
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			string txt = stringTxt.Text;
			double dblNum;
			double.TryParse(txt, out dblNum);
			dblTxt.Text = dblNum.ToString();
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			Horse horse = new Horse("Shire", true);
			Mustang mustang = new Mustang("Buckskin", false, "Mustang", false);
			horse.write();
			mustang.write();
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			Hashtable ht = new Hashtable();
			DataTable dt;
			DataRow dr;
			string sql;
			long lngreturn;
			ht.Add("@Name", sqlName.Text);
			sql = "select * from Final where Name = @Name";
			lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
			dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

			if (dt.Rows.Count > 0)
			{

			}

		}
	}

	public class Horse
	{
		public string breed { get; set; }
		public bool isDraft { get; }

		public Horse() { }

		public Horse(string breed, bool isDraft = false)
		{
			this.breed = breed;
			this.isDraft = isDraft;
		}

		public void write()
		{
			Console.WriteLine(breed, isDraft);
		}
	}

	class Mustang : Horse
	{
		string coatColor { get; set; }
		bool isTamed { get; set; }

		public Mustang() { }

		public Mustang(string coatColor, bool isTamed, string breed, bool isDraft = false)
			: base(breed, isDraft)
		{
			this.coatColor = coatColor;
			this.isTamed = isTamed;
		}
		public void write()
		{
			Console.WriteLine(coatColor, isTamed);
		}
	}
}
