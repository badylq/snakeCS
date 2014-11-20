using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
	public partial class Snake : Form
	{
		private Point p;
		private Item Apple;
		private Random MyRandom;
		private Player PlayerSnake;
		private bool keyLock;
		public Snake()
		{
			InitializeComponent();
			
		}

		private void Snake_Load(object sender, EventArgs e)
		{
			p = ImageMap.Location;
			MyRandom = new Random();
			Apple = new Item(100, ImageItemApple, p, MyRandom);
			PlayerSnake = new Player(90, 100, p,Apple,Controls);
			this.Update();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.PlayerSnake.Step();
			this.Update();
			this.keyLock = false;
		}

		private void ImageMap_Click(object sender, EventArgs e)
		{

		}

		private void Snake_KeyDown(object sender, KeyEventArgs e)
		{
			if (!this.keyLock)
			{
				this.PlayerSnake.ChangeDirection(e);
				this.keyLock = true;
			}
		}

	}
}
