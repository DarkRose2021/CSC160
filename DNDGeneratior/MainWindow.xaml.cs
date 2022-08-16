using System.Windows;
using System.Windows.Data;

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
			Binding b = new Binding("Text");
			b.Source = txtValue;
			c = new Charater();
			this.DataContext = c;
		}

		private void btnRandom_Click(object sender, RoutedEventArgs e)
		{
			c.Randomize();
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}
