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
		private Random MyRandom;
		private Player PlayerSnake;
		private bool keyLock;
		private int baseSpeed;
		public Snake()
		{
			InitializeComponent();
			
		}

		private void Snake_Load(object sender, EventArgs e)
		{
			p = ImageMap.Location;
			MyRandom = new Random();
			baseSpeed = 10;
			timer1.Interval = 500 - baseSpeed * 17;
			prograssbarSpeed.Value = baseSpeed;
			PlayerSnake = new Player(90, 100, p,Controls, MyRandom, textScore, timer1, baseSpeed,prograssbarSpeed);
			this.Update();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.PlayerSnake.Step())
				this.timer1.Enabled = false;
			this.Update();
			this.keyLock = false;
		}

		private void ImageMap_Click(object sender, EventArgs e)
		{

		}

		private void Snake_KeyDown(object sender, KeyEventArgs e)
		{
			if (!this.keyLock && timer1.Enabled == true)
			{
				this.PlayerSnake.ChangeDirection(e);
				this.keyLock = true;
			}
		}

	}
}
