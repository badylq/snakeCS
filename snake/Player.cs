﻿using System;
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
		public Player(int minLength, int maxLength, Point mapLocation, Control.ControlCollection control, Random myRandom,
			ToolStripStatusLabel textScore, Timer timer)
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

			extend = false;
			this.textScore = textScore;
			this.direction = 0;
			this.mapLocation = mapLocation;
			this.control = control;
			ImageBodyParts = new List<PictureBox>();
			this.myRandom = myRandom;
			score = 0;
			points = 10;
			this.speedUps = 0;
			this.timer = timer;
			this.eatCounter = 0;
			this.CreatePlayer();

		}

		private int eatCounter;
		private ToolStripStatusLabel textScore;
		private Random myRandom;
		private List<PictureBox> ImageBodyParts;
		private int minLength;
		private int maxLength;
		private Point[] location;
		private Point mapLocation;
		private int positionX;
		private int positionY;
		private Point positionXY;
		private Byte direction;
		private Control.ControlCollection control;
		private Item apple;
		private PictureBox itemApple;
		private int score;
		private int points;
		private bool extend;
		private Timer timer;
		private int speedUps;
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
			itemApple = new PictureBox();
			itemApple.Size = new System.Drawing.Size(25, 25);
			itemApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			itemApple.Image = global::snake.Properties.Resources.ItemApple;;
			apple = new Item(this.points, this.itemApple, this.mapLocation, this.myRandom);
			control.Add(itemApple);
			itemApple.BringToFront();
			apple.SetPosition();
		}

		private void addBodyPart(Point location, Image img)
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

		private void extendSnake(Point newPartLocation)
		{
			positionX = newPartLocation.X;
			positionY = newPartLocation.Y;
			positionXY.X = positionX * 25 + this.mapLocation.X ;
			positionXY.Y = positionY * 25 + this.mapLocation.Y;
			addBodyPart(positionXY, global::snake.Properties.Resources.SnakeBody);
			extend = false;
		}
		public bool Step()
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
			if (this.extend)
				this.extendSnake(tempLocation2);
			this.DrawPlayer();
			if(this.apple.CollisinCheck(this.location[0]))
			{
				this.score += this.points;
				this.extend = true;
				this.eatCounter += 1;
				this.textScore.Text = "Score : " + this.score;
				if(eatCounter>1 && timer.Interval>25)
				{
					timer.Interval -= 50/speedUps;
					this.speedUps += 1;
				}
			}
			if (this.Colision())
				return true;
			else
				return false;
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
					}
					break;
				case Keys.Up:
					if (this.direction != 2 && this.direction != 0)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 0);
						this.direction = 0;
					}
					break;
				case Keys.Right:
					if (this.direction != 1 && this.direction != 3)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 90);
						this.direction = 1;
					}
					break;
				case Keys.Down:
					if (this.direction != 2 && this.direction != 0)
					{
						this.ImageBodyParts[0].Image = this.RotateImage(global::snake.Properties.Resources.SnakeHead, 180);
						this.direction = 2;
					}
					break;
				default:
					MessageBox.Show("Zły klawisz");
					break;
			}

		}

		private Image RotateImage(Image img, float rotationAngle)
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

		private bool Colision()
		{
			if(this.location[0].X < 1)
			{
				this.ImageBodyParts[0].Image = global::snake.Properties.Resources.WaterDead;
				return true;
			}
			else if (this.location[0].X > 18)
			{
				this.ImageBodyParts[0].Image = global::snake.Properties.Resources.WaterDead;
				return true;
			}
			else if (this.location[0].Y < 1)
			{
				this.ImageBodyParts[0].Image = global::snake.Properties.Resources.WaterDead;
				return true;
			}
			else if (this.location[0].Y > 18)
			{
				this.ImageBodyParts[0].Image = global::snake.Properties.Resources.WaterDead;
				return true;
			}
			else
				return false;
		}
	}
}
