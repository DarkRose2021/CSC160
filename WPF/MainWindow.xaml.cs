using System.Windows;

namespace WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			//overrides the window's default title
			Window.Title = "Neumont";
		}
	}
}
