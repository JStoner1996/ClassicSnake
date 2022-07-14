namespace ClassicSnake
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
            this.startButtonOnePlayer = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.textHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startButtonTwoPlayer = new System.Windows.Forms.Button();
            this.txtScore2 = new System.Windows.Forms.Label();
            this.textHighScore2 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.txtLives2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // startButtonOnePlayer
            // 
            this.startButtonOnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButtonOnePlayer.Location = new System.Drawing.Point(584, 12);
            this.startButtonOnePlayer.Name = "startButtonOnePlayer";
            this.startButtonOnePlayer.Size = new System.Drawing.Size(161, 52);
            this.startButtonOnePlayer.TabIndex = 0;
            this.startButtonOnePlayer.Text = "Start One Player";
            this.startButtonOnePlayer.UseVisualStyleBackColor = true;
            this.startButtonOnePlayer.Click += new System.EventHandler(this.StartGame);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(580, 680);
            this.canvas.TabIndex = 1;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(586, 160);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(102, 20);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "P1 Score: 0";
            // 
            // textHighScore
            // 
            this.textHighScore.AutoSize = true;
            this.textHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHighScore.Location = new System.Drawing.Point(586, 189);
            this.textHighScore.Name = "textHighScore";
            this.textHighScore.Size = new System.Drawing.Size(144, 20);
            this.textHighScore.TabIndex = 2;
            this.textHighScore.Text = "P1 High Score: 0";
            this.textHighScore.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 80;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // startButtonTwoPlayer
            // 
            this.startButtonTwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButtonTwoPlayer.Location = new System.Drawing.Point(586, 70);
            this.startButtonTwoPlayer.Name = "startButtonTwoPlayer";
            this.startButtonTwoPlayer.Size = new System.Drawing.Size(161, 52);
            this.startButtonTwoPlayer.TabIndex = 0;
            this.startButtonTwoPlayer.Text = "Start Two Player";
            this.startButtonTwoPlayer.UseVisualStyleBackColor = true;
            this.startButtonTwoPlayer.Click += new System.EventHandler(this.StartGameTwoPlayer);
            // 
            // txtScore2
            // 
            this.txtScore2.AutoSize = true;
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(586, 269);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(102, 20);
            this.txtScore2.TabIndex = 2;
            this.txtScore2.Text = "P2 Score: 0";
            // 
            // textHighScore2
            // 
            this.textHighScore2.AutoSize = true;
            this.textHighScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHighScore2.Location = new System.Drawing.Point(586, 298);
            this.textHighScore2.Name = "textHighScore2";
            this.textHighScore2.Size = new System.Drawing.Size(144, 20);
            this.textHighScore2.TabIndex = 2;
            this.textHighScore2.Text = "P2 High Score: 0";
            this.textHighScore2.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.Location = new System.Drawing.Point(586, 219);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(96, 20);
            this.txtLives.TabIndex = 2;
            this.txtLives.Text = "P1 Lives: 3";
            this.txtLives.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // txtLives2
            // 
            this.txtLives2.AutoSize = true;
            this.txtLives2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives2.Location = new System.Drawing.Point(586, 328);
            this.txtLives2.Name = "txtLives2";
            this.txtLives2.Size = new System.Drawing.Size(96, 20);
            this.txtLives2.TabIndex = 2;
            this.txtLives2.Text = "P2 Lives: 3";
            this.txtLives2.Click += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.txtLives2);
            this.Controls.Add(this.textHighScore2);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.textHighScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.startButtonTwoPlayer);
            this.Controls.Add(this.startButtonOnePlayer);
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButtonOnePlayer;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label textHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButtonTwoPlayer;
        private System.Windows.Forms.Label txtScore2;
        private System.Windows.Forms.Label textHighScore2;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.Label txtLives2;
    }
}

