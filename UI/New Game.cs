using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Snake.Code;
using System.Media;
using System.Data.SqlClient;

namespace Snake
{
    public partial class NewGame : Form
    {
        public static int speed = 10;
        public static string option = "";
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public NewGame()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            //Set game speed and start timer
            gameTimer.Interval = 1000 / speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Start New game
            StartGame();
        }

        private void StartGame()
        {
            //Set settings to default
            new Settings();


            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\music\GamePlay.wav";
            player.PlayLooping();

            //Create new player object
            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

        }

        //Place random food object
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle {X = random.Next(1, maxXPos - 1), Y = random.Next(1, maxYPos - 1)};
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check for Game Over
            if (Settings.GameOver)
            {
                gameTimer.Stop();
                option = "";
                UI.Dialog dialog = new UI.Dialog();
                string gameOver = "         Game over! \nYour final score is: " + Settings.Score;
                dialog.lblGameOver.Text = gameOver;
                dialog.ShowDialog();
                gameTimer.Start();

                if (option == "Again")
                {
                    StartGame();
                }

                else
                {
                    this.Hide();
                    gameTimer.Stop();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                //Set colour of snake

                //Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour = Brushes.Black;
                    if (i == 0)
                        snakeColour = Brushes.Black;     //Draw head
                    else
                        //Rest of body
                        if (UI.LogIn.LabelofVAriables.SnakeID == 1)
                            snakeColour = Brushes.DarkViolet;

                        else if (UI.LogIn.LabelofVAriables.SnakeID == 2)
                            snakeColour = Brushes.Blue;

                        else if (UI.LogIn.LabelofVAriables.SnakeID == 3)
                            snakeColour = Brushes.DimGray;

                    //Draw snake
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height));


                    //Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
        }


        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Move head
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    //Get maximum X and Y Pos
                    int minYPosUp = pictureBoxUp.Location.Y / Settings.Height;
                    int maxYPosD = (pictureBoxD.Location.Y + pictureBoxD.Size.Height) / Settings.Height;
                    int minXPosR = pictureBoxR.Location.X / Settings.Height;
                    int maxXPosL = (pictureBoxL.Location.X + pictureBoxL.Size.Width) / Settings.Height;

                    //Detect collission with game borders.
                    if (Snake[i].Y > minYPosUp)
                    {
                        Die();
                    }

                    if (Snake[i].Y < maxYPosD)
                    {
                        Die();
                    }

                    if (Snake[i].X > minXPosR - 1)
                    {
                        Die();
                    }

                    if (Snake[i].X < maxXPosL)
                    {
                        Die();
                    }

                    //Detect collission with body
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Move body
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

        private void Eat()
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\Eat.wav";
            this.axWindowsMediaPlayer1.Ctlcontrols.play();

            //Add circle to body
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {

            string Insert = "insert into Game values('" +
             UI.LogIn.LabelofVAriables.UserID + "', '" +
             UI.LogIn.LabelofVAriables.SnakeID + "', '" +
             UI.LogIn.LabelofVAriables.MapID + "', '" +
             ((speed / 5) - 1) + "', '" +
             Settings.Score + "', " + 
             "getdate());";

             SqlCommand insert = new SqlCommand(Insert, UI.LogIn.LabelofVAriables.conex);
             insert.ExecuteNonQuery();

            SoundPlayer sound = new SoundPlayer();
            sound.Stop();
            Settings.GameOver = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UI.LogIn lg = new UI.LogIn();
            this.Cursor = UI.LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
            pbCanvas.BackgroundImage = imageList1.Images[UI.LogIn.LabelofVAriables.MapID - 1];
        }
    }
}
