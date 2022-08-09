using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPF
{
	/// <summary>
	/// Interaction logic for DataBinding.xaml
	/// </summary>
	public partial class DataBinding : Window
	{
		public DataBinding()
		{
			InitializeComponent();

			DataContext = this;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			BindingExpression bindingExpression = txtTitle.GetBindingExpression(TextBox.TextProperty);
			bindingExpression.UpdateSource();
		}
	}
}
