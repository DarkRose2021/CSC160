namespace WinForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnHello = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.ListBox();
			this.cb = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// BtnHello
			// 
			this.BtnHello.BackColor = System.Drawing.Color.Cyan;
			this.BtnHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnHello.Location = new System.Drawing.Point(335, 245);
			this.BtnHello.Name = "BtnHello";
			this.BtnHello.Size = new System.Drawing.Size(112, 34);
			this.BtnHello.TabIndex = 0;
			this.BtnHello.Text = "Hello";
			this.BtnHello.UseVisualStyleBackColor = false;
			this.BtnHello.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(335, 165);
			this.label1.Margin = new System.Windows.Forms.Padding(100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Label Msg";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// lb
			// 
			this.lb.FormattingEnabled = true;
			this.lb.ItemHeight = 25;
			this.lb.Location = new System.Drawing.Point(100, 87);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(180, 129);
			this.lb.TabIndex = 2;
			this.lb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// cb
			// 
			this.cb.FormattingEnabled = true;
			this.cb.Location = new System.Drawing.Point(514, 93);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(182, 33);
			this.cb.TabIndex = 3;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cb);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnHello);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button BtnHello;
		private Label label1;
		private ListBox lb;
		private ComboBox cb;
	}
}