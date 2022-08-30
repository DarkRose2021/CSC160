using System;
using System.Windows;
using System.Windows.Media.Imaging;

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
					temp.Content = "Computer Chose: Rock";
					//compImg.Source = new BitmapImage(new Uri(@"/Resources/rock.jpg", UriKind.Relative));
					Uri urir = new Uri("C:\\aNeumont\\Year 1\\Q4\\App Dev\\CSC160\\Final\\Resources\\rock.jpg");
					compImg.Source = new BitmapImage(urir);
					break;
				case "Paper":
					temp.Content = "Computer Chose: Paper";
					compImg.Source = new BitmapImage(new Uri(@"/Resources/paper.png", UriKind.Relative));
					//Uri urip = new Uri("C:\\aNeumont\\Year 1\\Q4\\App Dev\\CSC160\\Final\\Resources\\paper.png");
					//compImg.Source = new BitmapImage(urip);
					break;
				case "Scissors":
					temp.Content = "Computer Chose: Scissors";
					compImg.Source = new BitmapImage(new Uri(@"/Resources/scissors.png", UriKind.Relative));
					//Uri uris = new Uri("C:\\aNeumont\\Year 1\\Q4\\App Dev\\CSC160\\Final\\Resources\\scissors.png");
					//compImg.Source = new BitmapImage(uris);
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
