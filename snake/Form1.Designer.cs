
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
			this.ImageMap = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.prograssbarSpeed = new System.Windows.Forms.ToolStripProgressBar();
			this.textScore = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// ImageMap
			// 
			this.ImageMap.Image = global::snake.Properties.Resources.Background;
			this.ImageMap.Location = new System.Drawing.Point(0, 24);
			this.ImageMap.Name = "ImageMap";
			this.ImageMap.Size = new System.Drawing.Size(500, 500);
			this.ImageMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ImageMap.TabIndex = 10;
			this.ImageMap.TabStop = false;
			this.ImageMap.Click += new System.EventHandler(this.ImageMap_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.prograssbarSpeed,
            this.textScore});
			this.statusStrip1.Location = new System.Drawing.Point(0, 524);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(500, 22);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel1.Text = "Speed";
			// 
			// prograssbarSpeed
			// 
			this.prograssbarSpeed.Maximum = 25;
			this.prograssbarSpeed.Minimum = 1;
			this.prograssbarSpeed.Name = "prograssbarSpeed";
			this.prograssbarSpeed.Size = new System.Drawing.Size(100, 16);
			this.prograssbarSpeed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prograssbarSpeed.Value = 1;
			// 
			// textScore
			// 
			this.textScore.Name = "textScore";
			this.textScore.Size = new System.Drawing.Size(344, 17);
			this.textScore.Spring = true;
			this.textScore.Text = "Score : 0";
			this.textScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(500, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
			this.toolStripMenuItem1.Text = "SnakeCS";
			// 
			// aaaToolStripMenuItem
			// 
			this.aaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lolToolStripMenuItem});
			this.aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
			this.aaaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aaaToolStripMenuItem.Text = "aaa";
			// 
			// lolToolStripMenuItem
			// 
			this.lolToolStripMenuItem.Name = "lolToolStripMenuItem";
			this.lolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.lolToolStripMenuItem.Text = "lol";
			// 
			// Snake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 546);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.ImageMap);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(516, 585);
			this.MinimumSize = new System.Drawing.Size(516, 585);
			this.Name = "Snake";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SnakeCS";
			this.Load += new System.EventHandler(this.Snake_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.ImageMap)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ImageMap;
		public System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aaaToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripProgressBar prograssbarSpeed;
		private System.Windows.Forms.ToolStripStatusLabel textScore;
		private System.Windows.Forms.ToolStripMenuItem lolToolStripMenuItem;

	}
}

