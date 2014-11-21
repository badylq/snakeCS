using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace snake
{
	public class Item
	{
		public Item(int points, PictureBox myPictureBox, Point mapLocation, Random myRandom)
		{
			this.points = points;
			this.myPictureBox = myPictureBox;
			this.mapLocation = mapLocation;
			this.myRandom = myRandom;
		}
		private int points;
		private int PositionX;
		private int PositionY;
		private PictureBox myPictureBox;
		public Point location;
		private Point mapLocation;
		private Random myRandom;
		public void SetPosition()
		{
			PositionX = myRandom.Next(1, 18);
			PositionY = myRandom.Next(1, 18);
			location.X = PositionX * 25 + mapLocation.X;
			location.Y = PositionY * 25 + mapLocation.Y;
			myPictureBox.Location = location;
			myPictureBox.Update();
		}
		public bool CollisinCheck(Point playerLocation)
		{
			if ((int)playerLocation.X == PositionX && (int)playerLocation.Y == PositionY)
			{
				this.SetPosition();
				return true;
			}
			else
				return false;
		}
	}
}
