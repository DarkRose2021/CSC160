namespace DNDGeneratior.UserControl
{
	/// <summary>
	/// Interaction logic for UserControl.xaml
	/// </summary>
	public partial class textBox : UserControl
	{
		public string Title { get; set; }
		public int MaxLength { get; set; }

		public string Message { get; set; }
		public string TitleWidth { get; set; } = "Auto";
		public textBox()
		{
			InitializeComponent();
			DataContext = this;
		}
	}
}
