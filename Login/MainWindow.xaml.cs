using System.Collections;
using System.Data;
using System.Windows;


namespace Login
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{


		public MainWindow()
		{
			InitializeComponent();

		}

		private void btnSubmit_Click(object sender, RoutedEventArgs e)
		{
			Hashtable ht = new Hashtable();
			DataTable dt;
			DataRow dr;
			string sql;
			long lngreturn;
			lblmsg.Content = "";
			ht.Add("@Username", txtUsername.Text);
			ht.Add("@Email", txtEmail.Text);

			sql = "select * from Users where Username = @Username or Email = @Email";
			lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
			dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

			if (dt.Rows.Count > 0)
			{
				dr = dt.Rows[0];
				lblmsg.Content = "Username or Email is Already in use";
			}
			else
			{
				ht.Add("@Name", txtName.Text);
				ht.Add("@Password", txtPass.Text);

				sql = "insert into Users (Name, Username, Password, Email) values (@Name, @Username, @Password, @Email)";
				lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
				lblmsg.Content = "Account Created";
			}

			txtUsername.Clear();
			txtPass.Clear();
			txtEmail.Clear();
			txtName.Clear();
		}

		private void btnlogin_Click(object sender, RoutedEventArgs e)
		{
			Hashtable ht = new Hashtable();
			DataTable dt;
			DataRow dr;
			string sql;
			long lngreturn;
			lblmsg.Content = "";
			ht.Add("@Username", logUser.Text);
			ht.Add("@Password", logPass.Text);

			sql = "select * from Users where Username = @Username and Password = @Password";
			lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
			dt = ExDB.GetDataTable("AwesomeDB", ht, sql);

			if (dt.Rows.Count > 0)
			{
				dr = dt.Rows[0];
				lblmsg.Content = "Logged in";
			}
			else
			{
				lblmsg.Content = "Account Not Found";
			}

			logUser.Clear();
			logPass.Clear();
		}
	}
}
