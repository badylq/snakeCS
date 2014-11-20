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
		public Point p;
		public Item Apple;
		public Random MyRandom;
		public Player PlayerSnake;
		public Snake()
		{
			InitializeComponent();
			
		}

		private void Snake_Load(object sender, EventArgs e)
		{
			p = ImageMap.Location;
			MyRandom = new Random();
			Apple = new Item(100, ImageItemApple, p, MyRandom);
			PlayerSnake = new Player(3, 10, ImageSnakeHead,p,Apple,Controls);
			this.Update();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			PlayerSnake.step(0);
			this.Update();
		}

		private void ImageMap_Click(object sender, EventArgs e)
		{

		}

	}
}
