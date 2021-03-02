namespace Snake.Code
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };

    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 20;
            Height = 20;
            Score = 0;
            Points = 1;
            GameOver = false;
            direction = Direction.Down;
        }
    }


}
