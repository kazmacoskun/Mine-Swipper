using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using Microsoft.Win32;

namespace minesweeper
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{   
		int count=0;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		int [,]random=new int[20,20];
		int [,]rightclick=new int[21,21];
		public Button[,]blist=new Button[20,20];
		public int index1=0;
		public int index2=0;
		public int a=0,b=0,c=0;
		public int basla=0;
		public int minenum=10;
		public int top=0;
		public int locked=0;
		public int locktime=0;
		public int locktimefinishing=0;
		public int gameover=0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			
			InitializeComponent();
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(64, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 203);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseHover += new System.EventHandler(this.Form1_Load);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem8,
            this.menuItem14,
            this.menuItem13,
            this.menuItem15,
            this.menuItem11,
            this.menuItem12,
            this.menuItem16,
            this.menuItem17,
            this.menuItem5});
            this.menuItem1.Text = "&Game";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "&New Game";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Checked = true;
            this.menuItem2.Index = 2;
            this.menuItem2.Text = "&Easy";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.Text = "&Medium";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 4;
            this.menuItem4.Text = "&Hard";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 5;
            this.menuItem8.Text = "&Special...";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 6;
            this.menuItem14.Text = "-";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 7;
            this.menuItem13.Text = "&Transparecy";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 8;
            this.menuItem15.Text = "-";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 9;
            this.menuItem11.Text = "&Alwaystop";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 10;
            this.menuItem12.Text = "-";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 11;
            this.menuItem16.Text = "locked";
            this.menuItem16.Click += new System.EventHandler(this.menuItem16_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 12;
            this.menuItem17.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 13;
            this.menuItem5.Text = "E&xit";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem7,
            this.menuItem20,
            this.menuItem19});
            this.menuItem6.Text = "&Help";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 0;
            this.menuItem7.Text = "&About";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 1;
            this.menuItem20.Text = "-";
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 2;
            this.menuItem19.Text = "&Set User";
            this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "10";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(230, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "0 : 0 : 0 ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(138, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 32);
            this.button1.TabIndex = 4;
            this.button1.Click += new System.EventHandler(this.oylebisi);
            this.button1.EnabledChanged += new System.EventHandler(this.panel1_EnabledChanged);
            // 
            // statusBar1
            // 
            this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.statusBar1.Location = new System.Drawing.Point(0, 371);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(344, 22);
            this.statusBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(344, 393);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "minesweeper";
            this.Click += new System.EventHandler(this.oylebisi);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
//			this.ShowInTaskbar=false;
			this.AutoScroll=true;
//			FormStartPosition.CenterParent;
//			this.MinimizeBox=false;
//			this.MaximizeBox=false;
//			this.ControlBox=false;
			ilk(minenum);
			ToolTip show=new ToolTip();
			show.SetToolTip(this.button1," New Game ");
			statusBar1.Panels.Add("oyun adý");
			statusBar1.Panels[0].Text="Mineswepeer";
			statusBar1.Panels[0].AutoSize=StatusBarPanelAutoSize.Spring;
			statusBar1.Panels[0].BorderStyle=StatusBarPanelBorderStyle.Sunken;

			statusBar1.Panels.Add("Oyunu Yapan");
			statusBar1.Panels[1].Text="Designed By Coþkun KAZMA";
			statusBar1.Panels[1].AutoSize=StatusBarPanelAutoSize.Spring;
			statusBar1.Panels[1].BorderStyle=StatusBarPanelBorderStyle.Sunken;

			DateTime date;
			date=new DateTime();
			statusBar1.Panels.Add("Tarih");
			statusBar1.Panels[2].Text="Today :  "+DateTime.Today.ToString(); 
			statusBar1.Panels[2].AutoSize=StatusBarPanelAutoSize.Spring;
			statusBar1.Panels[2].BorderStyle=StatusBarPanelBorderStyle.Sunken;

//			DateTime date1;
			date=new DateTime();
			statusBar1.Panels.Add("start time");
			statusBar1.Panels[3].Text="Game Start Time :  "+DateTime.Now.ToString(); 
			statusBar1.Panels[3].AutoSize=StatusBarPanelAutoSize.Spring;
			statusBar1.Panels[3].BorderStyle=StatusBarPanelBorderStyle.Sunken;






		}
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			button1.Location=new Point(138,8);
			minenum=10;
		    label3.Location=new Point(230,8);
			ilk(minenum);
			menuItem2.Checked=true;
			menuItem3.Checked=false;
			menuItem4.Checked=false;
			menuItem8.Checked=false;
			menuItem11.Checked=false;
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			
			button1.Location=new Point(184,8);
			minenum=15;
			label3.Location=new Point(326,8);
			ilk(minenum);
			menuItem2.Checked=false;
			menuItem3.Checked=true;
			menuItem4.Checked=false;
			menuItem8.Checked=false;
			menuItem11.Checked=false;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{  
			button1.Location=new Point(238,8);
			minenum=20;
		    label3.Location=new Point(430,8);
			ilk(minenum);
			menuItem2.Checked=false;
			menuItem3.Checked=false;
			menuItem4.Checked=true;
			menuItem8.Checked=false;
			menuItem11.Checked=false;
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void button1_Click(object sender, System.EventArgs e)
		{		
				locktime=1;
				Button p=new Button();
				p=(Button) sender;
				int x=p.Location.X/20;
				int y=p.Location.Y/20;
			if(rightclick[y,x]!=-1)
			{	
				if(basla==0)
					time();
				basla=1;	
				if(random[y,x]==-1)
				{
					locktimefinishing=1;
					p.BackColor=System.Drawing.Color.WhiteSmoke;
					p.Image=Image.FromFile("MISC01.ICO");
					button1.Image=Image.FromFile("FACE01.ICO");
					mayinbas();
					MessageBox.Show("Game is Over");
					gameover=1;
					panel1.Enabled=false;
				}
				else if(random[y,x]==0)
				{
					ac(y,x);
					p.FlatStyle = FlatStyle.Flat;
					p.BackColor=System.Drawing.Color.WhiteSmoke;
					random[y,x]=9;
				}
				else
				{
					if(random[y,x]!=9)
						p.Text=random[y,x].ToString();
					p.FlatStyle = FlatStyle.Flat;
					p.BackColor=System.Drawing.Color.WhiteSmoke;
					random[y,x]=9;
				}
				for(int c=0;c<20;c++)
					for(int l=0;l<20;l++)
					{
						if(random[c,l]==9)
							count++;
					}
			}
			if(count==(minenum*minenum-minenum))
			{
				timer1.Stop();
				button1.Image=Image.FromFile("FACE03.ICO");
				mayinbas();
				MessageBox.Show("You Win");
				panel1.Enabled=false;
			}
			count=0;
		}
		public void mayinbas()
		{
			label2.Text="0";
			basla=0;	
			timer1.Stop();
			a=0;
			b=0;
			for (int i=0;i<20;i++)
				for (int j=0;j<20;j++)
				{
					if(random[i,j]==-1)
					{
						blist[i,j].Image=Image.FromFile("MISC01.ICO");
						blist[i,j].FlatStyle=FlatStyle.Flat;
						blist[i,j].BackColor=System.Drawing.Color.WhiteSmoke;
					}
				}
					
		}
		private void mines(int mine1)
		{
            arrayclear();
			Random ran=new Random();
			int X,Y;
			for (int i=0;i<mine1;i++)
			{
				X=ran.Next()%mine1;
				Y=ran.Next()%mine1;
				if(random[X,Y]!=-1)
				{
					random[X,Y]=-1;
				}
				else
					i--;
			}	
			for(int c=0;c<mine1;c++)
				for(int l=0;l<mine1;l++)
				{
					if(random[c,l]==-1)
					{
							if(c>0&& l>0 && random[c-1,l-1]!=-1)random[c-1,l-1]++;
							if(l>0 &&random[c,l-1]!=-1)random[c,l-1]++;
							if(l>0 &&c<mine1-1&&random[c+1,l-1]!=-1)random[c+1,l-1]++;
							if(c>0&&random[c-1,l]!=-1)random[c-1,l]++;
							if(c<mine1-1&&random[c+1,l]!=-1)random[c+1,l]++;
							if(c>0&&l<mine1-1&&random[c-1,l+1]!=-1)random[c-1,l+1]++;
							if(l<mine1-1&&random[c,l+1]!=-1)random[c,l+1]++;
							if(c<mine1-1&&l<mine1-1&&random[c+1,l+1]!=-1)random[c+1,l+1]++;
					}
				}
		}
		public void ilk(int mnum)
		{
			button1.Image=Image.FromFile("FACE02.ICO");
			count=0;
			arrayclear();
			panel1.Controls.Clear();
			panel1.Size=new Size(mnum*20+3,mnum*20+3);
			panel1.BorderStyle=BorderStyle.Fixed3D;
			mines(mnum);


			saat(mnum);
			for (int i=0;i<mnum;i++)
				for (int j=0;j<mnum;j++)
				{
					Button b=new Button();
					b.Size=new Size(20,20);
					b.Location=new Point(20*i,20*j);
					b.BackColor=System.Drawing.Color.LightGray;
					
					panel1.Controls.Add(b);
					blist[j,i]=b;
					b.Click+=new EventHandler(button1_Click);
					b.MouseDown+=new System.Windows.Forms.MouseEventHandler(panel1_MouseDown);
					b.MouseUp+=new System.Windows.Forms.MouseEventHandler(Panel1_MouseUp);
				}
		}
		public void ac(int x,int y)
		{
				
				if(x>0&& y>0 && rightclick[x-1,y-1]!=-1&&(random[x-1,y-1]==0||(random[x-1,y-1]<=8&&random[x-1,y-1]>=1)))salla (blist[x-1,y-1],x-1,y-1);
				if(y>0 && rightclick[x,y-1]!=-1&&(random[x,y-1]==0||(random[x,y-1]<=8&&random[x,y-1]>=1)))salla (blist[x,y-1],x,y-1);
				if(y>0 && rightclick[x+1,y-1]!=-1&&x<minenum-1&&(random[x+1,y-1]==0||(random[x+1,y-1]<=8&&random[x+1,y-1]>=1)))salla (blist[x+1,y-1],x+1,y-1);
				if(x>0&& rightclick[x-1,y]!=-1&&(random[x-1,y]==0||(random[x-1,y]<=8&&random[x-1,y]>=1)))salla (blist[x-1,y],x-1,y);
				if(x<minenum-1&& rightclick[x+1,y]!=-1&&(random[x+1,y]==0||(random[x+1,y]<=8&&random[x+1,y]>=1)))salla (blist[x+1,y],x+1,y);
				if(x>0&&y<minenum-1&& rightclick[x-1,y+1]!=-1&&(random[x-1,y+1]==0||(random[x-1,y+1]<=8&&random[x-1,y+1]>=1)))salla (blist[x-1,y+1],x-1,y+1);
				if(y<minenum-1&& rightclick[x,y+1]!=-1&&(random[x,y+1]==0||(random[x,y+1]<=8&&random[x,y+1]>=1)))salla (blist[x,y+1],x,y+1);
				if(x<minenum-1&& rightclick[x+1,y+1]!=-1&&y<minenum-1&&(random[x+1,y+1]==0||(random[x+1,y+1]<=8&&random[x+1,y+1]>=1)))salla (blist[x+1,y+1],x+1,y+1);
		}
		private void salla(Button b,int x,int y)
		{
			b.FlatStyle=FlatStyle.Flat;
			b.BackColor=System.Drawing.Color.WhiteSmoke;
			if(random[x,y]!=0)
			{
				b.Text=random[x,y].ToString();
				random[x,y]=9;
			}
			if(random[x,y]==0)
			{
				random[x,y]=9;	
				ac(x,y);		
			}
		}
		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void label3_Click(object sender, System.EventArgs e)
		{
			
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			a++;
			label3.Text=c.ToString()+" : "+b.ToString()+" : "+a.ToString();
			if(a==60)
			{
				a=0;
				b++;
				label3.Text="0 : "+b.ToString()+" : 0";
			}
			if(b==60)
			{
				a=0;
				b=0;
				c++;
				label3.Text=c.ToString()+" "+" : 0 : "+" 0 ";
			}
			
		}
		public void time()
		{
			label3.Text="0 : 0 : 0 ";
			timer1.Enabled = true;
			a=0;
			b=0;
			c=0;
		}
		public void saat(int t)
		{
			panel1.Enabled=true;
			basla=0;
			label2.Text=t.ToString();
			timer1.Stop();
			a=0;
			label3.Text=" 0 : 0 : 0 ";
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
            //gameover=0;
            //panel1.Controls.Clear();
            //saat(minenum);
            //ilk(minenum);
            //button1.Image=Image.FromFile("FACE02.ICO");
		}

        private void oylebisi(object sender, System.EventArgs e)
        {
            gameover = 0;
            panel1.Controls.Clear();
            saat(minenum);
            ilk(minenum);
            button1.Image = Image.FromFile("FACE02.ICO");
        }

		private void button1_Click_1(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Form form2=new Form2();
			form2.ShowDialog();
		}
		private void panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Button p=new Button();
			p=(Button) sender;
			int x=p.Location.X/20;
			int y=p.Location.Y/20;
			switch(e.Button)
			{
				case MouseButtons.Right:
				{
					if(random[y,x]!=9)
					{
						if(rightclick[y,x]==0)
						{
							p.Image=Image.FromFile("FLGTURK.ICO");		
							rightclick[y,x]=-1;
							int w=Int32.Parse(label2.Text)-1;
							label2.Text=w.ToString();				
						}
						else if(rightclick[y,x]==-1)
						{
							p.Image=null;
							rightclick[y,x]=0;
							int w=Int32.Parse(label2.Text)+1;
							label2.Text=w.ToString();			
						}
					}
					break;
				}
				case MouseButtons.Left:
				{
					button1.Image=Image.FromFile("FACE03.ICO");
					break;
				}
				
			}
			
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			Form3 form3=new Form3();
			form3.ShowDialog();
			Control aControl;
			aControl = form3.Controls[3]; 
			TextBox t=new TextBox();
			t=(TextBox) aControl;
			try
			{
				minenum=Int32.Parse(t.Text);
				panandlabelloc(minenum);
				ilk(minenum);
				button1.Image=Image.FromFile("FACE02.ICO");
			}
			catch
			{
			}
			menuItem2.Checked=false;
			menuItem3.Checked=false;
			menuItem4.Checked=false;
			menuItem11.Checked=false;
			menuItem8.Checked=true;
		}
		private void panandlabelloc(int locnum)
		{
			button1.Location=new Point((locnum*10)+30,8);
			label3.Location=new Point((locnum*20)+30,8);
		}
		private void arrayclear()
		{
			for (int i=0;i<20;i++)
			{
				for (int j=0;j<20;j++)
				{
					random[i,j]=0;
					rightclick[i,j]=0;
				}
			}
		}

		private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			menuItem2.Checked=false;
			menuItem3.Checked=false;
			menuItem4.Checked=false;
			menuItem8.Checked=false;
			if(top==0)
			{
				this.TopMost=true;
				top++;
				menuItem11.Checked=true;
			}
			else
			{
				this.TopMost=false;
				top=0;
				menuItem11.Checked=false;
			}
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			Form4 form4=new Form4();
			form4.ShowDialog();
			Control ccontrol;
			ccontrol = form4.Controls[1];
			TextBox tex=new TextBox();
			tex=(TextBox) ccontrol;
			try
			{
				double trans=Convert.ToDouble(tex.Text);
				if(trans>1||trans<0)
				{
					MessageBox.Show(" Between 0 and 1( As 0,2 ) ","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				else
					this.Opacity=trans;					

			}
			catch{}
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer1.Enabled=false;
			DialogResult message;
			message=MessageBox.Show(this,"Are you Sure You Want to Exit?","Close",MessageBoxButtons.YesNo);
			if(message==DialogResult.No)
			{
				e.Cancel=true;
				if(locktimefinishing==0)
				{
					timer1.Enabled=true;
				}
			}
			else
			{
				MessageBox.Show("Good game with you");
			}		
		}

		private void menuItem16_Click(object sender, System.EventArgs e)
		{
			if(gameover==1)
			{
				DialogResult message2;
				message2=MessageBox.Show(this,"       You can't Lock the Game \n               New Game   ?","Warning",MessageBoxButtons.YesNo);
				if(message2==DialogResult.Yes)
				{
					gameover=0;
					panel1.Controls.Clear();
					saat(minenum);
					ilk(minenum);
					button1.Image=Image.FromFile("FACE02.ICO");
				}
				else if(message2==DialogResult.No) 
				{
					this.Close();
				}
			}



			else if(gameover==0)
			{
				if(locked==0)
				{
					menuItem16.Checked=true;
					button1.Enabled=false;
					panel1.Enabled=false;
					timer1.Enabled=false;
					menuItem2.Enabled=false;
					menuItem3.Enabled=false;
					menuItem4.Enabled=false;
					menuItem5.Enabled=false;
					menuItem8.Enabled=false;
					menuItem9.Enabled=false;
					menuItem11.Enabled=false;
					menuItem13.Enabled=false;
					locked=1;
				}
				else
				{
					menuItem16.Checked=false;
					button1.Enabled=true;
					panel1.Enabled=true;
					if(locktime==1)
					{
						timer1.Enabled=true;
					}
					menuItem2.Enabled=true;
					menuItem3.Enabled=true;
					menuItem4.Enabled=true;
					menuItem5.Enabled=true;
					menuItem8.Enabled=true;
					menuItem9.Enabled=true;
					menuItem11.Enabled=true;
					menuItem13.Enabled=true;
					locked=0;
				}
			}
		}

		private void panel1_EnabledChanged(object sender, System.EventArgs e)
		{
			if(locked==1)
			{
				MessageBox.Show("  Game start to contunue");
			}
			else
				MessageBox.Show("   Game is Locked");
		
		}

		private void Panel1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button==MouseButtons.Left)
			{
				button1.Image=Image.FromFile("FACE02.ICO");
			}
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			Form5 form5=new Form5();
			form5.ShowDialog();
			Control scontrol;
			scontrol = form5.Controls[1];
			TextBox tex=new TextBox();
			tex=(TextBox) scontrol;

		}

		private void panel1_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
		}

	}
}
