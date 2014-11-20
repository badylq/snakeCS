
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.ImageItemApple = new System.Windows.Forms.PictureBox();
			this.ImageMap = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ImageItemApple)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 250;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			// ImageMap
			// 
			this.ImageMap.Image = global::snake.Properties.Resources.Background;
			this.ImageMap.Location = new System.Drawing.Point(43, 32);
			this.ImageMap.Name = "ImageMap";
			this.ImageMap.Size = new System.Drawing.Size(500, 500);
			this.ImageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageMap.TabIndex = 10;
			this.ImageMap.TabStop = false;
			this.ImageMap.Click += new System.EventHandler(this.ImageMap_Click);
			// 
			// Snake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.ImageItemApple);
			this.Controls.Add(this.ImageMap);
			this.Name = "Snake";
			this.Text = "SnakeCS";
			this.Load += new System.EventHandler(this.Snake_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ImageItemApple)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageMap;
		private System.Windows.Forms.PictureBox ImageItemApple;
		private System.Windows.Forms.Timer timer1;

	}
}

