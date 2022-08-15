using System.Windows.Controls;

namespace WPF.UserControls
{
	/// <summary>
	/// Interaction logic for TextBoxLimiter.xaml
	/// </summary>
	public partial class TextBoxLimiter : UserControl
	{

		public string Title { get; set; }
		public int MaxLength { get; set; }

		public string Message { get; set; }
		public string TitleWidth { get; set; } = "Auto";
		public TextBoxLimiter()
		{
			InitializeComponent();
			DataContext = this;
		}
	}
}
