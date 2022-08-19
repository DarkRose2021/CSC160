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
		Names3 ds = new Names3();
		WPF.Names3TableAdapters.namesTableAdapter ad = new WPF.Names3TableAdapters.namesTableAdapter();
		public DB()
		{
			InitializeComponent();
		}

		private void btnDoit_Click(object sender, RoutedEventArgs e)
		{
			DataTable dt;
			Hashtable ht = new Hashtable();
			DataRow dr;
			string sql;
			long lngReturn;
			int intID;
			sql = "select ID from Users where Username=@username and password=@Password";
			ht.Add("@ID", 3);
			dt = ExDB.GetDataTable("AwesomeDB", ht, sql);
			//dg.ItemsSource = dt.DefaultView;

			if (dt.Rows.Count > 0)
			{
				dr = dt.Rows[0];
				intID = (int)dr["ID"];
				lblMsg.Content = intID;
			}

			ht.Clear();
			sql = "Insert into names (Name, Age) values('Grace', 19)";
			//lngReturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
			//lblMsg.Content = lngReturn + " records affected";

			//ad.Insert("Katie", 19);
			ad.Fill(ds.names);
			lblMsg.Content = ds.names.Rows.Count;

			var s = (from names in ds.names
					 where names.ID == 3
					 select names.Name);
			lblMsg.Content = s.First().ToString();
		}
	}
}
