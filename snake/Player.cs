using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{
	public class Player : Form
	{
		public Player(int minLength, int maxLength, PictureBox imageHead, PictureBox imageBody,Point mapLocation, Item items)
		{
			if (minLength < 3)
				this.minLength = 3;
			else if (minLength > 9)
				this.minLength = 9;
			else
				this.minLength = minLength;
			if (maxLength < 4)
				this.maxLength = 4;
			else if (maxLength > 324)
				this.maxLength = 324;
			else
				this.maxLength = maxLength;

			this.imageBody = imageBody;
			this.imageHead = imageHead;
			this.items = items;
			this.direction = 0;
			this.mapLocation = mapLocation;
			this.addBodyPart();

			this.CreatePlayer();
		}
		public PictureBox ImageBodyPart;
		private int minLength;
		private int maxLength;
		private Point[] location;
		private PictureBox imageHead;
		private PictureBox imageBody;
		private Item items;
		private Point mapLocation;
		private int positionX;
		private int positionY;
		private Point positionXY;
		private Byte direction;
		public void CreatePlayer()
		{
			MessageBox.Show("= " + this.mapLocation.X);
			location = new Point[maxLength];
			for (int i=0;i<minLength;i++)
			{
				location[i].X = 10;
				location[i].Y = 10 + i;
				if (i > 0)
				{
					positionX = location[i].X;
					positionY = location[i].Y;
					positionXY.X = positionX * 25 + this.mapLocation.X ;
					positionXY.Y = positionY * 25 + mapLocation.Y;
					imageBody.Location = positionXY;
					imageBody.Update();
				}
			}
			positionX = location[0].X;
			positionY = location[0].Y;
			positionXY.X = positionX * 25 + mapLocation.X;
			positionXY.Y = positionY * 25 + mapLocation.Y;
			imageHead.Location = positionXY;
			imageHead.Update();
			items.SetPosition();
		}

		private void addBodyPart()
		{
			ImageBodyPart = new PictureBox();
			ImageBodyPart.Location = new Point(0, 0);
			ImageBodyPart.Size = new System.Drawing.Size(25, 25);
			ImageBodyPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			ImageBodyPart.Image = global::snake.Properties.Resources.SnakeBody;
			ImageBodyPart.Visible = true;
			this.Controls.Add(ImageBodyPart);
		}
	}
}
