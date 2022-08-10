using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NumberGuess
{
	public partial class NumberGuess : Form
	{
		Random random = new Random();
		List<Label> lblResults = new List<Label>();
		List<PictureBox> picResults = new List<PictureBox>();
		int answer = 0;
		int numGuess = 0;
		int intRandomMax = 0;

		public NumberGuess()
		{
			InitializeComponent();
			InitializeGame();
			ResetGame();
		}

		private void InitializeGame()
		{
			lblResults.Add(label1);
			lblResults.Add(label2);
			lblResults.Add(label3);
			lblResults.Add(label4);
			lblResults.Add(label5);

			picResults.Add(pictureBox1);
			picResults.Add(pictureBox2);
			picResults.Add(pictureBox3);
			picResults.Add(pictureBox4);
			picResults.Add(pictureBox5);
		}

		private void ResetGame()
		{
			foreach (Label label in lblResults)
			{
				label.Text = "";
			}

			foreach (PictureBox pictureBox in picResults)
			{
				pictureBox.Image = null;
			}

			txtGuess.Enabled = false;
			btnStart.Enabled = true;
			btnStart.Text = "Start";
			numGuess = 0;
			feedback.Text = "";
			txtGuess.Text = "00";
		}

		private void StartGame()
		{
			answer = random.Next(1, intRandomMax + 1);
			txtGuess.Enabled = true;
			btnStart.Text = "Reset";
			feedback.Text = "Enter a number between 1 and " + intRandomMax;
		}

		private void GameWon()
		{
			txtGuess.Enabled = false;
			feedback.Text = "Game Won!";

		}

		private void GameLost()
		{
			txtGuess.Enabled = false;
			feedback.Text = "Game Lost! Try Again!";
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (btnStart.Text == "Start")
			{
				StartGame();
			}
			else
			{
				ResetGame();
			}
		}

		private void rbEasy_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbEasy = (RadioButton)sender;
			if (rbEasy.Checked)
			{
				intRandomMax = 10;
			}

		}

		private void rbMed_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbMed = (RadioButton)sender;
			if (rbMed.Checked)
			{
				intRandomMax = 15;
			}
		}

		private void rbHard_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rbHard = (RadioButton)sender;
			if (rbHard.Checked)
			{
				intRandomMax = 20;
			}
		}

		private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtGuess_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				string txt = txtGuess.Text;
				int guess = int.Parse(txt);
				numGuess++;
				if (guess == answer)
				{
					lblResults[numGuess - 1].Text = txt + " correct!";
					lblResults[numGuess - 1].ForeColor = Color.Green;
					//picResults[guess].Image = Properties.Resources.correct_icon;
					GameWon();
				}
				else if (guess != answer)
				{
					string highlow = "Too ";
					lblResults[numGuess - 1].Text = highlow + (guess > answer ? "high" : "low");
					lblResults[numGuess - 1].ForeColor = Color.Red;
					//picResults[guess].Image = Properties.Resources.incorrect_icon;

					if (numGuess == 5)
					{
						GameLost();
					}
				}
			}
		}
	}
}
