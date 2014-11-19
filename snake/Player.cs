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
		public Player(int minLength, int maxLength, PictureBox imageHead, Point mapLocation, Item items, Control.ControlCollection control)
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

			this.imageHead = imageHead;
			this.items = items;
			this.direction = 0;
			this.mapLocation = mapLocation;
			this.control = control;
			ImageBodyParts = new List<PictureBox>();
			//this.CreatePlayer();

			this.addBodyPart(0, 0);
			this.addBodyPart(0, 50);
		}

		private List<PictureBox> ImageBodyParts;
		private int minLength;
		private int maxLength;
		private Point[] location;
		private PictureBox imageHead;
		private Item items;
		private Point mapLocation;
		private int positionX;
		private int positionY;
		private Point positionXY;
		private Byte direction;
		private Control.ControlCollection control;
		private void CreatePlayer()
		{
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
					//imageBody.Location = positionXY;
					//imageBody.Update();

					addBodyPart(100,100);
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

		public void addBodyPart(int x, int y)
		{
			PictureBox ImageBodyPart;
			ImageBodyPart = new PictureBox();

			ImageBodyPart.Location = new Point(x, y);
			ImageBodyPart.Size = new System.Drawing.Size(25, 25);
			ImageBodyPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			ImageBodyPart.Image = global::snake.Properties.Resources.SnakeBody;
			ImageBodyPart.Visible = true;

			ImageBodyParts.Add(ImageBodyPart);
			this.control.Add(ImageBodyParts[ImageBodyParts.Count - 1]);
			ImageBodyPart = null;

			MessageBox.Show("Ile = " + ImageBodyParts.Count);
		}
	}
}
