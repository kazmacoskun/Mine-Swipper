using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace minesweeper
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.HelpProvider helpProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form3()
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.helpProvider1 = new System.Windows.Forms.HelpProvider();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(88, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "     Mines";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(88, 56);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(24, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 24);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form3
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(152, 94);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button2,
																		  this.button1,
																		  this.label1,
																		  this.textBox1});
			this.Name = "Form3";
			this.Text = "Special...";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				int t=Int32.Parse(textBox1.Text);
				if (textBox1.Text==" ")
				{
					errorProvider1.SetError(textBox1,"You Must Enter Number of Mines and Number of Buttons");
				}
				if(t<10)
					textBox1.Text="10";
				if(t>20)
					textBox1.Text="20";
				this.Close();
			}
			catch
			{
				MessageBox.Show("Only Integer !!!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				textBox1.Text=" ";
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
			textBox1.Text="";
		}

		private void Form3_Load(object sender, System.EventArgs e)
		{
			ToolTip show = new ToolTip();
			show.SetToolTip(this.textBox1," Enter and Integer Number to Set Numer of Mines and Button  ");
			helpProvider1.SetHelpString(textBox1," To Set Nomber of Mines and Number of Button Please Enter an Integer Between 10 and 20");
			Application.Idle+=new System.EventHandler (BoxEnabled);
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		private void BoxEnabled(object sender, EventArgs e)
		{
			if(textBox1.Text.Length>0)
			{
				button1.Enabled=true;
			}
			else 
			{
				button1.Enabled=false;
			}
		}
	}
}
