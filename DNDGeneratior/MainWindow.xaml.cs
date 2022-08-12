using System.Windows;

namespace DNDGeneratior
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Charater c;
		public MainWindow()
		{
			InitializeComponent();
			c = new Charater();
			this.DataContext = c;
		}

		private void btnRandom_Click(object sender, RoutedEventArgs e)
		{
			c.Randomize();
		}
	}
}
