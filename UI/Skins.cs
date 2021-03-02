using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake.UI
{
    public partial class Skins : Form
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void Skins_Load(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Cursor = LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\music\GameDefault.wav";
            player.Play();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UI.LogIn.LabelofVAriables.SnakeID = 1;
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.LogIn.LabelofVAriables.SnakeID = 2;
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UI.LogIn.LabelofVAriables.SnakeID = 3;
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }
    }
}
