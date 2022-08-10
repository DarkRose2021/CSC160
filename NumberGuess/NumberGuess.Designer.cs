namespace NumberGuess
{
	partial class NumberGuess
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbHard = new System.Windows.Forms.RadioButton();
			this.rbMed = new System.Windows.Forms.RadioButton();
			this.rbEasy = new System.Windows.Forms.RadioButton();
			this.btnStart = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.txtGuess = new System.Windows.Forms.TextBox();
			this.feedback = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbHard);
			this.groupBox1.Controls.Add(this.rbMed);
			this.groupBox1.Controls.Add(this.rbEasy);
			this.groupBox1.Location = new System.Drawing.Point(28, 33);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(129, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Difficulty";
			// 
			// rbHard
			// 
			this.rbHard.AutoSize = true;
			this.rbHard.Location = new System.Drawing.Point(22, 85);
			this.rbHard.Name = "rbHard";
			this.rbHard.Size = new System.Drawing.Size(69, 24);
			this.rbHard.TabIndex = 2;
			this.rbHard.TabStop = true;
			this.rbHard.Text = "Hard";
			this.rbHard.UseVisualStyleBackColor = true;
			this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
			// 
			// rbMed
			// 
			this.rbMed.AutoSize = true;
			this.rbMed.Location = new System.Drawing.Point(22, 55);
			this.rbMed.Name = "rbMed";
			this.rbMed.Size = new System.Drawing.Size(90, 24);
			this.rbMed.TabIndex = 1;
			this.rbMed.TabStop = true;
			this.rbMed.Text = "Medium";
			this.rbMed.UseVisualStyleBackColor = true;
			this.rbMed.CheckedChanged += new System.EventHandler(this.rbMed_CheckedChanged);
			// 
			// rbEasy
			// 
			this.rbEasy.AutoSize = true;
			this.rbEasy.Location = new System.Drawing.Point(22, 25);
			this.rbEasy.Name = "rbEasy";
			this.rbEasy.Size = new System.Drawing.Size(69, 24);
			this.rbEasy.TabIndex = 0;
			this.rbEasy.TabStop = true;
			this.rbEasy.Text = "Easy";
			this.rbEasy.UseVisualStyleBackColor = true;
			this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
			// 
			// btnStart
			// 
			this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnStart.Location = new System.Drawing.Point(0, 416);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(450, 29);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.36025F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.63976F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 174);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 194);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 31);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(4, 42);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(39, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(4, 80);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(39, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(101, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "label5";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(4, 156);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(39, 34);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 7;
			this.pictureBox5.TabStop = false;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(101, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "label4";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(101, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(101, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(4, 118);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(39, 31);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// txtGuess
			// 
			this.txtGuess.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGuess.Location = new System.Drawing.Point(274, 174);
			this.txtGuess.Name = "txtGuess";
			this.txtGuess.Size = new System.Drawing.Size(154, 116);
			this.txtGuess.TabIndex = 3;
			this.txtGuess.Text = "00";
			this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
			this.txtGuess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyUp);
			// 
			// feedback
			// 
			this.feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.feedback.Location = new System.Drawing.Point(180, 88);
			this.feedback.Name = "feedback";
			this.feedback.Size = new System.Drawing.Size(226, 54);
			this.feedback.TabIndex = 4;
			this.feedback.Text = "Enter a number Between";
			this.feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NumberGuess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(450, 445);
			this.Controls.Add(this.feedback);
			this.Controls.Add(this.txtGuess);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.groupBox1);
			this.Name = "NumberGuess";
			this.Text = "Number Guess";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbHard;
		private System.Windows.Forms.RadioButton rbMed;
		private System.Windows.Forms.RadioButton rbEasy;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.TextBox txtGuess;
		private System.Windows.Forms.Label feedback;
	}
}