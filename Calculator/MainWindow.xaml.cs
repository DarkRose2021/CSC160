using System.Windows;

namespace Calculator
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

		float num1 = 0;
		float num2 = 0;

		float total;


		private void Divide_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "/";
			Number.Content = 0;
			posNeg.Content = " ";
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			Number.Content = 0;
			num1 = 0;
			num2 = 0;
		}

		private void Neg_Click(object sender, RoutedEventArgs e)
		{
			if (posNeg.Content.ToString().Contains('-'))
			{
				posNeg.Content = " ";
			}
			else
			{
				posNeg.Content = "-";
			}
		}

		private void Precent_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "%";
			Number.Content = 0;
			posNeg.Content = " ";
		}

		private void Multi_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "*";
			Number.Content = 0;
			posNeg.Content = " ";
		}

		private void Sub_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "-";
			Number.Content = 0;
			posNeg.Content = " ";
		}

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "+";
			Number.Content = 0;
			posNeg.Content = " ";
		}

		private void exp_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num1);
			if (posNeg.Content == "-")
			{
				float temp = num1;
				num1 = -temp;
			}
			operation.Content = "^2";
			total = num1 * num1;
			Number.Content = total;
			posNeg.Content = " ";
		}

		private void Equals_Click(object sender, RoutedEventArgs e)
		{
			float.TryParse(Number.Content.ToString(), out num2);
			switch (operation.Content)
			{
				case "+":
					total = num1 + num2;
					break;
				case "-":
					total = num1 - num2;
					break;
				case "*":
					total = num1 * num2;
					break;
				case "/":
					total = num1 / num2;
					break;
				case "%":
					total = num1 % num2;
					break;
			}
			Number.Content = total.ToString();
			operation.Content = "";
		}

		private void Dec_Click(object sender, RoutedEventArgs e)
		{
			Number.Content += ".";
		}

		private void Num0_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "0";
			}
			else
			{
				Number.Content += "0";
			}
		}
		private void Num1_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "1";
			}
			else
			{
				Number.Content += "1";
			}
		}
		private void Num2_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "2";
			}
			else
			{
				Number.Content += "2";
			}
		}

		private void Num3_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "3";
			}
			else
			{
				Number.Content += "3";
			}
		}
		private void Num4_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "4";
			}
			else
			{
				Number.Content += "4";
			}
		}
		private void Num5_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "5";
			}
			else
			{
				Number.Content += "5";
			}
		}
		private void Num6_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "6";
			}
			else
			{
				Number.Content += "6";
			}
		}
		private void Num7_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "7";
			}
			else
			{
				Number.Content += "7";
			}
		}
		private void Num8_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "8";
			}
			else
			{
				Number.Content += "8";
			}
		}

		private void Num9_Click(object sender, RoutedEventArgs e)
		{
			if (Number.Content.ToString() == "0")
			{
				Number.Content = "9";
			}
			else
			{
				Number.Content += "9";
			}
		}
	}
}
