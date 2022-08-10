using System.Collections.ObjectModel;
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
		//List<Student> students = new List<Student>();
		ObservableCollection<Student> students = new ObservableCollection<Student>();

		public DataBinding()
		{
			InitializeComponent();

			DataContext = this;

			Binding b = new Binding("Text");
			b.Source = txtValue;

			students.Add(new Student() { Id = 1, Name = "Rob1" });
			students.Add(new Student() { Id = 2, Name = "Rob2" });
			students.Add(new Student() { Id = 3, Name = "Rob3" });
			lstStudents.ItemsSource = students;


		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			BindingExpression bindingExpression = txtTitle.GetBindingExpression(TextBox.TextProperty);
			bindingExpression.UpdateSource();
		}

		private void btnRemove_Click(object sender, RoutedEventArgs e)
		{
			if (lstStudents.SelectedItem != null)
			{
				students.Remove((Student)lstStudents.SelectedItem);
			}
		}

		private void btnChange_Click(object sender, RoutedEventArgs e)
		{
			((Student)lstStudents.SelectedItem).Name = "Lob";
			//lstStudents.ItemsSource = students;
		}

		class Student
		{
			public int Id { get; set; }
			private string name;
			public string Name { get { return name; } set { name = value; } }
		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			int newId = students[students.Count - 1].Id + 1;
			students.Add(new Student() { Id = newId, Name = "Hob" + newId });
		}
	}
}
