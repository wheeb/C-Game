namespace WindowsFormsApp1
{
	partial class Form1
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
			this.pokTreat1 = new System.Windows.Forms.PictureBox();
			this.spawnTreat = new System.Windows.Forms.Button();
			this.Character = new System.Windows.Forms.PictureBox();
			this.happinessTimer = new System.Windows.Forms.Timer(this.components);
			this.happinessBar = new System.Windows.Forms.ProgressBar();
			this.tmrMoving = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pokTreat1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
			this.SuspendLayout();
			// 
			// pokTreat1
			// 
			this.pokTreat1.Location = new System.Drawing.Point(344, 130);
			this.pokTreat1.Name = "pokTreat1";
			this.pokTreat1.Size = new System.Drawing.Size(100, 50);
			this.pokTreat1.TabIndex = 0;
			this.pokTreat1.TabStop = false;
			this.pokTreat1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// spawnTreat
			// 
			this.spawnTreat.Location = new System.Drawing.Point(12, 207);
			this.spawnTreat.Name = "spawnTreat";
			this.spawnTreat.Size = new System.Drawing.Size(84, 23);
			this.spawnTreat.TabIndex = 1;
			this.spawnTreat.Text = "Spawn Treat";
			this.spawnTreat.UseVisualStyleBackColor = true;
			this.spawnTreat.Click += new System.EventHandler(this.spawnTreat_Click_1);
			// 
			// Character
			// 
			this.Character.Location = new System.Drawing.Point(165, 180);
			this.Character.Name = "Character";
			this.Character.Size = new System.Drawing.Size(100, 50);
			this.Character.TabIndex = 2;
			this.Character.TabStop = false;
			// 
			// happinessTimer
			// 
			this.happinessTimer.Enabled = true;
			this.happinessTimer.Tick += new System.EventHandler(this.happinessTimer_Tick_1);
			// 
			// happinessBar
			// 
			this.happinessBar.Location = new System.Drawing.Point(282, 33);
			this.happinessBar.Name = "happinessBar";
			this.happinessBar.Size = new System.Drawing.Size(156, 23);
			this.happinessBar.TabIndex = 3;
			this.happinessBar.Click += new System.EventHandler(this.happinessBar_Click);
			// 
			// tmrMoving
			// 
			this.tmrMoving.Enabled = true;
			this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(402, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 4;
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(303, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Happiness meter";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(258, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Drag fruit to the thing to feed the thing";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(450, 272);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.happinessBar);
			this.Controls.Add(this.Character);
			this.Controls.Add(this.spawnTreat);
			this.Controls.Add(this.pokTreat1);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.pokTreat1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pokTreat1;
		private System.Windows.Forms.Button spawnTreat;
		private System.Windows.Forms.PictureBox Character;
		private System.Windows.Forms.Timer happinessTimer;
		private System.Windows.Forms.ProgressBar happinessBar;
		private System.Windows.Forms.Timer tmrMoving;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

