using System.Collections;
using System.Data;
using System.Windows;

namespace WPF
{
	/// <summary>
	/// Interaction logic for DB.xaml
	/// </summary>
	public partial class DB : Window
	{
		public DB()
		{
			InitializeComponent();
		}

		private void btnDoit_Click(object sender, RoutedEventArgs e)
		{
			DataTable dt;
			Hashtable ht = new Hashtable();
			string sql;
			long lngReturn;
			sql = "select * from names where ID=@ID";
			ht.Add("@ID", 3);
			dt = ExDB.GetDataTable("AwesomeDB", ht, sql);
			dg.ItemsSource = dt.DefaultView;
		}
	}
}
