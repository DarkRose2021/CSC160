using System.Windows;
using System.Windows.Media;

namespace WPF
{
	/// <summary>
	/// Interaction logic for Resources.xaml
	/// </summary>
	public partial class Resources : Window
	{
		public Resources()
		{
			InitializeComponent();
			btnResourceStatic.Content = FindResource("CompanyName");
			btnResourceStatic.Content = FindResource("AppString");

			//can create dynamic resources on the fly, no deceleration
			Resources["Boogers"] = "boogers";
			btnResourceDynamic.Content = FindResource("Boogers");

			btnResourceDynamic.Content = Properties.Settings.Default.AppID; //project/properties/settings

		}

		private void btnChangeColor_Click(object sender, RoutedEventArgs e)
		{
			//static resource updates will not auto update the controls using them, but dynamic resources will, like binding
			Resources["CompanyColor"] = new SolidColorBrush(Colors.Blue);

			//static will change if you explicitly update the field
			Resources["CompanyName"] = "CompanyName Resource Updated";
			btnResourceStatic.Content = FindResource("CompanyName");
		}
	}
}
