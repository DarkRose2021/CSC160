using System;
using System.Windows;

namespace Final
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Random random = new Random();
		string[] aryChoices = new string[] { "Rock", "Paper", "Scissors" };
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnUser_Click(object sender, RoutedEventArgs e)
		{
			string compChoice = aryChoices[random.Next(aryChoices.Length)];
			compInput.Text = compChoice;

			if ((userPick.ToString() == "Rock" && compChoice == "Scissors") || (userPick.ToString() == "Paper" && compChoice == "Rock") || (userPick.ToString() == "Scissors" && compChoice == "Paper"))
			{
				winner.Content = "User Wins!";
			}
			else if ((compChoice == "Rock" && userPick.ToString() == "Scissors") || (compChoice == "Paper" && userPick.ToString() == "Rock") || (compChoice == "Scissors" && userPick.ToString() == "Paper"))
			{
				winner.Content = "Computer Wins!";
			}
			else
			{
				winner.Content = "Tie Game!";
			}
		}
	}
}
