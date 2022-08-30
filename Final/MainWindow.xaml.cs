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
		int userChoiceInt;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void game()
		{
			string compChoice = aryChoices[random.Next(aryChoices.Length)];
			string userChoice = "";

			switch (userChoiceInt)
			{
				case 1:
					userChoice = "Rock";
					break;
				case 2:
					userChoice = "Paper";
					break;
				case 3:
					userChoice = "Scissors";
					break;
			}

			switch (compChoice)
			{
				case "Rock":

					//compImg.Source = "/Resources/rock.jpg";
					break;
				case "Paper":
					break;
				case "Scissors":
					break;
			}

			if ((userChoice == "Rock" && compChoice == "Scissors") || (userChoice == "Paper" && compChoice == "Rock") || (userChoice == "Scissors" && compChoice == "Paper"))
			{
				winner.Content = "User Wins!";
			}
			else if ((compChoice == "Rock" && userChoice == "Scissors") || (compChoice == "Paper" && userChoice == "Rock") || (compChoice == "Scissors" && userChoice == "Paper"))
			{
				winner.Content = "Computer Wins!";
			}
			else
			{
				winner.Content = "Tie Game!";
			}
		}

		private void rock_Click(object sender, RoutedEventArgs e)
		{
			userChoiceInt = 1;
			game();
		}

		private void paper_Click(object sender, RoutedEventArgs e)
		{
			userChoiceInt = 2;
			game();
		}

		private void scissors_Click(object sender, RoutedEventArgs e)
		{
			userChoiceInt = 3;
			game();
		}
	}
}
