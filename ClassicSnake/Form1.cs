using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicSnake
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private List<Circle> Snake2 = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int numPlayers = 1;
        int score;
        int score2;
        int highScore;
        int highScore2;

        int lives = 3;
        int lives2 = 3;

        Random rand = new Random();

        bool goingLeft, goingRight, goingUp, goingDown; 
        bool goingLeft2, goingRight2, goingUp2, goingDown2;


        public Form1()
        {

            new Settings();
            InitializeComponent();
        }

     

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Player One Controls
            e.SuppressKeyPress = true;
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goingLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goingRight = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goingDown = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goingUp = true;
            }

            // Player Two Controls

            if (e.KeyCode == Keys.A && Settings.directions2 != "right")
            {
                goingLeft2 = true;
            }
            if (e.KeyCode == Keys.D && Settings.directions2 != "left")
            {
                goingRight2 = true;
            }
            if (e.KeyCode == Keys.S && Settings.directions2 != "up")
            {
                goingDown2 = true;
            }
            if (e.KeyCode == Keys.W && Settings.directions2 != "down")
            {
                goingUp2 = true;
            }




        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Player One Controls
            if (e.KeyCode == Keys.Left)
            {
                goingLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goingRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goingDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goingUp = false;
            }    

            //Player Two Controls
            if (e.KeyCode == Keys.A)
            {
                goingLeft2 = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goingRight2 = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goingDown2 = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goingUp2 = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            numPlayers = 1;
            lives = 3;
            lives2 = 3;
            RestartGame(numPlayers);
            
        }

   

        private void StartGameTwoPlayer(object sender, EventArgs e)
        {
            numPlayers = 2;
            lives = 3;
            lives2 = 3;
            RestartGame(2);
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (numPlayers == 1)
            {
                // set directions
                if (goingLeft)
                {
                    Settings.directions = "left";
                }
                if (goingRight)
                {
                    Settings.directions = "right";
                }
                if (goingDown)
                {
                    Settings.directions = "down";
                }
                if (goingUp)
                {
                    Settings.directions = "up";
                }
                // end of directions

                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (Settings.directions)
                        {
                            case "left":
                                Snake[i].x--;
                                break;

                            case "right":
                                Snake[i].x++;
                                break;

                            case "down":
                                Snake[i].y++;
                                break;

                            case "up":
                                Snake[i].y--;
                                break;

                            default:
                                break;
                        }

                        if (Snake[i].x < 0)
                        {
                            Snake[i].x = maxWidth;
                        }
                        if (Snake[i].x > maxWidth)
                        {
                            Snake[i].x = 0;
                        }
                        if (Snake[i].y < 0)
                        {
                            Snake[i].y = maxHeight;
                        }
                        if (Snake[i].y > maxHeight)
                        {
                            Snake[i].y = 0;
                        }

                        if (Snake[i].x == food.x && Snake[i].y == food.y)
                        {
                            EatFood(1);
                        }

                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                            {
                                GameOver();
                            }
                        }


                    }
                    else
                    {
                        Snake[i].x = Snake[i - 1].x;
                        Snake[i].y = Snake[i - 1].y;
                    }


                }

                canvas.Invalidate();
            }

            if (numPlayers == 2)
            {
                // set directions player 1
                if (goingLeft)
                {
                    Settings.directions = "left";
                }
                if (goingRight)
                {
                    Settings.directions = "right";
                }
                if (goingDown)
                {
                    Settings.directions = "down";
                }
                if (goingUp)
                {
                    Settings.directions = "up";
                }
                // end of directions player 1

                // set directions player 2
                if (goingLeft2)
                {
                    Settings.directions2 = "left";
                }
                if (goingRight2)
                {
                    Settings.directions2 = "right";
                }
                if (goingDown2)
                {
                    Settings.directions2 = "down";
                }
                if (goingUp2)
                {
                    Settings.directions2 = "up";
                }
                // end of directions player 2

                //player 1
                for (int i = Snake.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (Settings.directions)
                        {
                            case "left":
                                Snake[i].x--;
                                break;

                            case "right":
                                Snake[i].x++;
                                break;

                            case "down":
                                Snake[i].y++;
                                break;

                            case "up":
                                Snake[i].y--;
                                break;

                            default:
                                break;
                        }

                        if (Snake[i].x < 0)
                        {
                            Snake[i].x = maxWidth;
                        }
                        if (Snake[i].x > maxWidth)
                        {
                            Snake[i].x = 0;
                        }
                        if (Snake[i].y < 0)
                        {
                            Snake[i].y = maxHeight;
                        }
                        if (Snake[i].y > maxHeight)
                        {
                            Snake[i].y = 0;
                        }

                        if (Snake[i].x == food.x && Snake[i].y == food.y)
                        {
                            EatFood(1);
                        }

                        for (int j = 1; j < Snake.Count; j++)
                        {
                            if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                            {
                                GameOver();
                            }  
                        }

                        for (int k = 0; k < Snake2.Count; k++)
                        {
                            if (Snake[i].x == Snake2[k].x && Snake[i].y == Snake2[k].y)
                            {
                                LoseLife(1);
                            }
                        }


                    }
                    else
                    {
                        Snake[i].x = Snake[i - 1].x;
                        Snake[i].y = Snake[i - 1].y;
                    }


                }

                //player 2
                for (int i = Snake2.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (Settings.directions2)
                        {
                            case "left":
                                Snake2[i].x--;
                                break;

                            case "right":
                                Snake2[i].x++;
                                break;

                            case "down":
                                Snake2[i].y++;
                                break;

                            case "up":
                                Snake2[i].y--;
                                break;

                            default:
                                break;
                        }

                        if (Snake2[i].x < 0)
                        {
                            Snake2[i].x = maxWidth;
                        }
                        if (Snake2[i].x > maxWidth)
                        {
                            Snake2[i].x = 0;
                        }
                        if (Snake2[i].y < 0)
                        {
                            Snake2[i].y = maxHeight;
                        }
                        if (Snake2[i].y > maxHeight)
                        {
                            Snake2[i].y = 0;
                        }

                        if (Snake2[i].x == food.x && Snake2[i].y == food.y)
                        {
                            EatFood(2);
                        }

                        for (int j = 1; j < Snake2.Count; j++)
                        {
                            if (Snake2[i].x == Snake2[j].x && Snake2[i].y == Snake2[j].y)
                            {
                                GameOver();
                            }                        
                        }

                        for (int k = 0; k < Snake.Count; k++)
                        {
                            if (Snake2[i].x == Snake[k].x && Snake2[i].y == Snake[k].y)
                            {
                                LoseLife(2);
                            }
                        }
                    }
                    else
                    {
                        Snake2[i].x = Snake2[i - 1].x;
                        Snake2[i].y = Snake2[i - 1].y;
                    }


                }


                canvas.Invalidate();
            }

        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            Brush snakeColour2;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                } else
                {
                    snakeColour = Brushes.Blue;    
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].x * Settings.width,
                    Snake[i].y * Settings.width,
                    Settings.height, 
                    Settings.height

                    ));   
            }

            for (int i = 0; i < Snake2.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour2 = Brushes.White;
                }
                else
                {
                    snakeColour2 = Brushes.Red;
                }

                canvas.FillEllipse(snakeColour2, new Rectangle
                    (
                    Snake2[i].x * Settings.width,
                    Snake2[i].y * Settings.width,
                    Settings.height,
                    Settings.height

                    ));
            }

            canvas.FillEllipse(Brushes.Green, new Rectangle
                    (
                    food.x * Settings.width,
                    food.y * Settings.width,
                    Settings.height, 
                    Settings.height

                    ));
        }

        

        private void RestartGame(int numPlayers)
        {
            canvas.Invalidate();
            maxWidth = canvas.Width / Settings.width - 1;
            maxHeight = canvas.Height / Settings.height - 1;

            Settings.directions = "left";
            Settings.directions2 = "right";

            

            Snake.Clear();
            Snake2.Clear();

            startButtonOnePlayer.Enabled = false;
            startButtonTwoPlayer.Enabled = false;

            score = 0;
            score2 = 0;
            txtScore.Text = $"P1 Score: {score}";
            txtScore2.Text = $"P2 Score: {score2}";

            txtLives.Text = $"P1 Lives: {lives}";
            txtLives2.Text = $"P2 Lives: {lives2}";

            txtScore.ForeColor = Color.Blue;
            txtScore2.ForeColor = Color.Red;


            textHighScore.ForeColor = Color.Blue;
            textHighScore2.ForeColor = Color.Red;

            if (numPlayers == 1)
            {
            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head); // Adds snake head

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle {x = rand.Next(2, maxWidth), y = rand.Next(2, maxWidth) };

            gameTimer.Start();

            }

            if (numPlayers == 2)
            {

                Circle head = new Circle { x = maxWidth / 2, y = (maxHeight / 2) + 5 };
                Snake.Add(head); // Adds snake head

                for (int i = 0; i < 10; i++)
                {
                    Circle body = new Circle();
                    Snake.Add(body);
                }

                Circle head2 = new Circle { x = maxWidth / 2, y = (maxHeight / 2) - 5 };
                Snake2.Add(head2); // Adds snake head

                for (int i = 0; i < 10; i++)
                {
                    Circle body2 = new Circle();
                    Snake2.Add(body2);
                }

                food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxWidth) };

                gameTimer.Start();
            }

        }
       


        private void EatFood(int player)
        {
            if (player == 1)
            {
                score++;
                txtScore.Text = $"Score: {score}";
                Circle body = new Circle
                {
                    x = Snake[Snake.Count - 1].x,
                    y = Snake[Snake.Count - 1].y,

                };

                Snake.Add(body);

                food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxWidth) };
            }

            if (player == 2)
            {
                score2++;
                txtScore2.Text = $"P2 Score: {score2}";
                Circle body = new Circle
                {
                    x = Snake2[Snake2.Count - 1].x,
                    y = Snake2[Snake2.Count - 1].y,

                };

                Snake2.Add(body);

                food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxWidth) };
            }

        }

        private void LoseLife (int player)
        {
            if (player == 1)
            {
                lives--;
                txtLives.Text = $"P1 Lives: {lives}";
               

                Snake[0].x = maxWidth / 2;
                Snake[0].y = (maxHeight / 2) + 5;
                
                if (lives <= 0)
                {
                    WinGame(2);
                }
            }

            if (player == 2)
            {
                lives2--;
                txtLives2.Text = $"P2 Lives: {lives2}";

                Snake2[0].x = maxWidth / 2;
                Snake2[0].y = (maxHeight / 2) - 5;


                if (lives2 <= 0)
                {
                    WinGame(1);
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButtonOnePlayer.Enabled = true;
            startButtonTwoPlayer.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                textHighScore.Text = $"High Score: {highScore}";
                textHighScore.ForeColor = Color.Green;
                textHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }

            if (score2 > highScore2)
            {
                highScore2 = score2;

                textHighScore2.Text = $"High Score: {highScore2}";
                textHighScore2.ForeColor = Color.Green;
                textHighScore2.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void WinGame(int player)
        {
            gameTimer.Stop();
            startButtonOnePlayer.Enabled = true;
            startButtonTwoPlayer.Enabled = true;

            MessageBox.Show($"Player {player} wins!");

            if (score > highScore)
            {
                highScore = score;

                textHighScore.Text = $"High Score: {highScore}";
                textHighScore.ForeColor = Color.Green;
                textHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }

            if (score2 > highScore2)
            {
                highScore2 = score2;

                textHighScore2.Text = $"High Score: {highScore2}";
                textHighScore2.ForeColor = Color.Green;
                textHighScore2.TextAlign = ContentAlignment.MiddleCenter;
            }

            
        }



    }
}
