using System.Collections;
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
			lblmsg.Content = "";
			Hashtable ht = new Hashtable();
			string sql;
			long lngreturn;
			ht.Add("@Name", txtName.Text);
			ht.Add("@Username", txtUsername.Text);
			ht.Add("@Password", txtPass.Text);
			ht.Add("@Email", txtEmail.Text);

			sql = "select Username, Password from Users where Username = @Username and Password = @Password";
			lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);

			if (lngreturn != -1)
			{
				lblmsg.Content = "You've logged in";
			}
			else
			{
				sql = "insert into Users (Name, Username, Password, Email) values (@Name, @Username, @Password, @Email)";
				lngreturn = ExDB.ExecuteIt("AwesomeDB", sql, ht);
				lblmsg.Content = "Account Created";
			}
		}
	}
}
