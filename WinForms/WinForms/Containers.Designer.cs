namespace WinForms
{
	partial class Containers
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
			this.pnlMain = new System.Windows.Forms.Panel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.MyGroupbox = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlMain.Location = new System.Drawing.Point(12, 12);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(63, 41);
			this.pnlMain.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(139, 341);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(141, 29);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "radioButton1";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(671, 318);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 25;
			this.listBox1.Location = new System.Drawing.Point(550, 51);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(180, 129);
			this.listBox1.TabIndex = 2;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(426, 359);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(121, 29);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(518, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MyGroupbox
			// 
			this.MyGroupbox.Location = new System.Drawing.Point(112, 79);
			this.MyGroupbox.Name = "MyGroupbox";
			this.MyGroupbox.Size = new System.Drawing.Size(300, 150);
			this.MyGroupbox.TabIndex = 5;
			this.MyGroupbox.TabStop = false;
			this.MyGroupbox.Text = "groupBox1";
			this.MyGroupbox.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// Containers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.MyGroupbox);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Containers";
			this.Text = "Containers";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Panel pnlMain;
		private Button button1;
		private RadioButton radioButton1;
		private Label label1;
		private ListBox listBox1;
		private CheckBox checkBox1;
		private GroupBox MyGroupbox;
	}
}