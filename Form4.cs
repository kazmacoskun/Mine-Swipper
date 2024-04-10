using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace minesweeper
{
	/// <summary>
	/// Summary description for Form4.
	/// </summary>
	public class Form4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.HelpProvider helpProvider1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form4()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new System.Drawing.Point(8, 72);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Cancel";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(112, 72);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(120, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(64, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "Transparency";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form4
			// 
			this.AcceptButton = this.button2;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button1;
			this.ClientSize = new System.Drawing.Size(200, 110);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.textBox1,
																		  this.button2,
																		  this.button1});
			this.Name = "Form4";
			this.Text = "Transparency";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				double tex=Convert.ToDouble(textBox1.Text);
				this.Close();
			}
			catch
			{
				MessageBox.Show("Only Reel Number !!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox1.Text=" ";
			}
		}
		private void label1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Form4_Load(object sender, System.EventArgs e)
		{
			ToolTip show = new ToolTip();
			show.SetToolTip(this.textBox1," Enter Real Nuber Between 0-1 (As 0,2) ");
			helpProvider1.SetHelpString(textBox1,"To Set Transparency of Form Please Enter a Number Between 0 and 1 (As 0,7) ");
			Application.Idle += new System.EventHandler(BoxEnabled); 
		}
		private void BoxEnabled(object sender, EventArgs e)
		{
			if(textBox1.Text.Length>0)
			{
				button2.Enabled=true;
			}
			else
			{
				button2.Enabled=false;
			}
		}
	}
}
