using System;
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
	}
}
