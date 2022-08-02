namespace WinForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Button btnGoodbye = new Button();
			btnGoodbye.Location = new Point(30, 30);
			btnGoodbye.Text = "Goodbye";
			btnGoodbye.Size = new Size(200, 100);

			btnGoodbye.Click += new System.EventHandler(this.Goodbye_Click);

			Controls.Add(btnGoodbye);
		}

		private void Goodbye_Click(object sender, EventArgs e)
		{
			label1.Text = "Goodbye, the button was clicked";
			Button btnSender = (Button)sender;
			btnSender.Size = new Size(btnSender.Width + 10, btnSender.Height + 10);
			//label1.Text = btnSender.Text;
			lb.Items.Add("Pixels");
			//label1.Text = lb.SelectedItem.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			GlobalThings.gContainersWindow.Show();
			this.Hide();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			lb.Items.Add("Grown Ups");
		}

		private void cb_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}