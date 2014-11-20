using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace snake
{
	public class Player
	{
		public Player(int minLength, int maxLength, Point mapLocation, Item items, Control.ControlCollection control)
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

			this.items = items;
			this.direction = 0;
			this.mapLocation = mapLocation;
			this.control = control;
			ImageBodyParts = new List<PictureBox>();

			//imageHead.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
			
			this.CreatePlayer();

		}

		private List<PictureBox> ImageBodyParts;
		private int minLength;
		private int maxLength;
		private Point[] location;
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
				if (i==0)
				{
					positionX = location[0].X;
					positionY = location[0].Y;
					positionXY.X = positionX * 25 + mapLocation.X;
					positionXY.Y = positionY * 25 + mapLocation.Y;

					addBodyPart(positionXY, global::snake.Properties.Resources.SnakeHead);
					
				}
				if (i > 0)
				{
					positionX = location[i].X;
					positionY = location[i].Y;
					positionXY.X = positionX * 25 + this.mapLocation.X ;
					positionXY.Y = positionY * 25 + mapLocation.Y;
					addBodyPart(positionXY, global::snake.Properties.Resources.SnakeBody);
				}
			}
			items.SetPosition();

		}

		public void addBodyPart(Point location, Image img)
		{
			PictureBox ImageBodyPart;
			ImageBodyPart = new PictureBox();

			ImageBodyPart.Location = location;
			ImageBodyPart.Size = new System.Drawing.Size(25, 25);
			ImageBodyPart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			ImageBodyPart.Image = img;

			ImageBodyParts.Add(ImageBodyPart);
			control.Add(ImageBodyParts[ImageBodyParts.Count - 1]);
			ImageBodyParts[ImageBodyParts.Count - 1].BringToFront();
			ImageBodyPart = null;
		}

		public void Step()
		{
			Point tempLocation1;
			Point tempLocation2 = new Point(0,0);

			for (int i = 0; i <= location.Length-1; i++)
			{
				if(i==0)
				{
					tempLocation2 = location[i];
					switch (this.direction)
					{
						case 0:
							location[0].Y -= 1;
							break;
						case 1:
							location[i].X += 1;
							ImageBodyParts[i].Update();
							break;
						case 2:
							location[i].Y += 1;
							break;
						case 3:
							location[i].X -= 1;
							break;
						default:
							MessageBox.Show("Błędny kierunek");
							break;
					}
				}
				else
				{
					tempLocation1 = tempLocation2; ;
					tempLocation2 = location[i];
					location[i] = tempLocation1;
				}
			}
			this.DrawPlayer();
		}
		private void DrawPlayer()
		{
			for (int i = 0; i < ImageBodyParts.Count; i++)
			{
				positionX = location[i].X;
				positionY = location[i].Y;
				positionXY.X = positionX * 25 + this.mapLocation.X;
				positionXY.Y = positionY * 25 + mapLocation.Y;
				ImageBodyParts[i].Location = positionXY;
				ImageBodyParts[i].Update();
			}
		}

		public void ChangeDirection(KeyEventArgs Key)
		{
			switch (Key.KeyCode){
				case Keys.Left:
					if (this.direction != 1 && this.direction != 3)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 270);
						this.direction = 3;
						//this.Step();
					}
					break;
				case Keys.Up:
					if (this.direction != 2 && this.direction != 0)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 0);
						this.direction = 0;
						//this.Step();
					}
					break;
				case Keys.Right:
					if (this.direction != 1 && this.direction != 3)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 90);
						this.direction = 1;
						//this.Step();
					}
					break;
				case Keys.Down:
					if (this.direction != 2 && this.direction != 0)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 180);
						this.direction = 2;
						//this.Step();
					}
					break;
				default:
					MessageBox.Show("Zły klawisz");
					break;
			}

		}

		public Image RotateImage(Image img, float rotationAngle)
		{
			if (rotationAngle == 90) 
				img.RotateFlip(RotateFlipType.Rotate90FlipNone);
			else if (rotationAngle == 180)
				img.RotateFlip(RotateFlipType.Rotate180FlipNone);
			else if (rotationAngle == 270)
				img.RotateFlip(RotateFlipType.Rotate270FlipNone);
			else if (rotationAngle == 0)
				img.RotateFlip(RotateFlipType.RotateNoneFlipNone);

			return img;
		}
	}
}
