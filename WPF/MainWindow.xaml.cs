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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(sender.ToString());
		}

		private void FavFood_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
		{
			//ComboBox cb = (ComboBoxd)sender;
			//ComboBoxItem cbi = (ComboBoxItem)cb.SelectedItem;
			//MessageBox.Show(cbi.SelecetedValue.ToString());
			MessageBox.Show(cbi.Content.ToString());
		}
	}
}