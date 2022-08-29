namespace MauiTest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async void CounterBtn_Clicked(object sender, EventArgs e)
		{
			string result = await DisplayPromptAsync("Question 2", "What's 5 + 5?", maxLength: 2);
			if (result == "10")
			{
				await DisplayAlert("Correct?", "Correct!", "Close");
			}
			else
			{
				await DisplayAlert("Correct?", "Incorrect!", "Close");
			}
		}
	}

}