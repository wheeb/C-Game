using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Resources;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			Init();
			createCharacter(xSize, ySize);
			createTreat();

		}



		private int X;
		private int Y;
		public int counter = 0;
		public int happiness = 100;
		private int maxHappiness = 100;
		public Bitmap MyImage;
		public Bitmap MyTreat;
		private int xSize = 100;
		private int ySize = 100;
		private Point firstPoint1 = new Point();

		public void Init() 
		{
 
			pokTreat1.MouseDown += (ss, ee) => {
				if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint1 = Control.MousePosition; }
			};
			pokTreat1.MouseMove += (ss, ee) =>
			{
				if (ee.Button == System.Windows.Forms.MouseButtons.Left)
				{
					Point temp = Control.MousePosition;
					Point res = new Point(firstPoint1.X - temp.X, firstPoint1.Y - temp.Y);
					pokTreat1.Location = new Point(pokTreat1.Location.X - res.X, pokTreat1.Location.Y - res.Y);
					firstPoint1 = temp;
				}
			};
		}

		

		private void createTreat()
		{
			if (MyTreat != null)
			{
				MyImage.Dispose();
			}

			pokTreat1.SizeMode = PictureBoxSizeMode.StretchImage;
			MyTreat = new Bitmap(Resource1.Razz_Berry);
			pokTreat1.ClientSize = new Size(50, 50);
			pokTreat1.Image = (Image)MyTreat;




		}

		private void Form1_KeyDown(object sender, KeyEventArgs key) 
		{
			if (key.KeyCode == Keys.W)
			{
				Y -= 10;

			}
			if (key.KeyCode == Keys.S)
			{
				Y += 10;
			}
			if (key.KeyCode == Keys.A)
			{
				X -= 10;
			}
			if (key.KeyCode == Keys.D)
			{
				X += 10;
			}
		}
		 
		public void Collision()
		{
			if (Character.Bounds.IntersectsWith(pokTreat1.Bounds ))
			{
				counter ++;
				pokTreat1.Top = 2000;
				happiness = happiness + 50;
				hahmoTarisee();
				
				if (happiness > 100) {
					happiness = maxHappiness;
				}


			}

		}
		public void pokTreatSpawn()
		{
			if (pokTreat1.Top > 200)
			{
				pokTreat1.Top = 100;
			}
		}
		public static System.Timers.Timer tarinaTimer;
		private void hahmoTarisee()
		{

			int count = 0;
			while (count < 50)
			{

				Character.Top = Character.Top - 10;
				Character.Left = Character.Left + 5;

				Character.Top = Character.Top + 10;
				Character.Left = Character.Left - 5;
				count++;

			}
		} 


		private void createCharacter( int xSize, int ySize)
		{
				if (MyImage != null)
			{
				MyImage.Dispose();
			}

			Character.SizeMode = PictureBoxSizeMode.StretchImage;
			MyImage = new Bitmap(Resource1.unnamed);
			Character.ClientSize = new Size(xSize, ySize);
			Character.Image = (Image) MyImage;




		}


		private void Form1_Load_1(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void happinessBar_Click(object sender, EventArgs e)
		{

		}

		private void spawnTreat_Click_1(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;
			pokTreatSpawn();
			counter = counter + 1;
		}

		private void tmrMoving_Tick_1(object sender, EventArgs e)
		{
			Collision();
			Invalidate();
		}

		private void happinessTimer_Tick_1(object sender, EventArgs e)
		{
			label1.Text = counter.ToString();
			happiness = happiness - 1;
			if (happiness < 1)
			{
				this.Close();
			}
			happinessBar.Value = happiness;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
