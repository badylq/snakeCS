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
		public int PositionX;
		public int PositionY;
		private PictureBox myPictureBox;
		private Point location;
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
		public int CollisinCheck(Point[] playerLocation)
		{
			if ((int)playerLocation[0].X == PositionX && (int)playerLocation[0].Y == PositionY)
			{
				this.SetPosition();
				return points;
			}
			else
				return 0;
		}
	}
}
