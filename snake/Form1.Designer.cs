
namespace snake
{
	partial class Snake
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ImageMap = new System.Windows.Forms.PictureBox();
			this.ImageItemApple = new System.Windows.Forms.PictureBox();
			this.ImageSnakeBody = new System.Windows.Forms.PictureBox();
			this.ImageSnakeHead = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageItemApple)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageSnakeBody)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageSnakeHead)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageMap
			// 
			this.ImageMap.Image = global::snake.Properties.Resources.Background;
			this.ImageMap.Location = new System.Drawing.Point(43, 32);
			this.ImageMap.Name = "ImageMap";
			this.ImageMap.Size = new System.Drawing.Size(500, 500);
			this.ImageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageMap.TabIndex = 0;
			this.ImageMap.TabStop = false;
			this.ImageMap.Click += new System.EventHandler(this.ImageMap_Click);
			// 
			// ImageItemApple
			// 
			this.ImageItemApple.Image = global::snake.Properties.Resources.ItemApple;
			this.ImageItemApple.Location = new System.Drawing.Point(13, 13);
			this.ImageItemApple.Name = "ImageItemApple";
			this.ImageItemApple.Size = new System.Drawing.Size(25, 25);
			this.ImageItemApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageItemApple.TabIndex = 1;
			this.ImageItemApple.TabStop = false;
			// 
			// ImageSnakeBody
			// 
			this.ImageSnakeBody.Image = global::snake.Properties.Resources.SnakeBody;
			this.ImageSnakeBody.Location = new System.Drawing.Point(13, 70);
			this.ImageSnakeBody.Name = "ImageSnakeBody";
			this.ImageSnakeBody.Size = new System.Drawing.Size(25, 25);
			this.ImageSnakeBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageSnakeBody.TabIndex = 2;
			this.ImageSnakeBody.TabStop = false;
			// 
			// ImageSnakeHead
			// 
			this.ImageSnakeHead.Image = global::snake.Properties.Resources.SnakeHead;
			this.ImageSnakeHead.Location = new System.Drawing.Point(13, 127);
			this.ImageSnakeHead.Name = "ImageSnakeHead";
			this.ImageSnakeHead.Size = new System.Drawing.Size(25, 25);
			this.ImageSnakeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageSnakeHead.TabIndex = 3;
			this.ImageSnakeHead.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Snake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.ImageSnakeHead);
			this.Controls.Add(this.ImageSnakeBody);
			this.Controls.Add(this.ImageItemApple);
			this.Controls.Add(this.ImageMap);
			this.Name = "Snake";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Snake_Load);
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageItemApple)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageSnakeBody)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageSnakeHead)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageMap;
		private System.Windows.Forms.PictureBox ImageItemApple;
		private System.Windows.Forms.PictureBox ImageSnakeBody;
		private System.Windows.Forms.PictureBox ImageSnakeHead;
		private System.Windows.Forms.Timer timer1;

	}
}

