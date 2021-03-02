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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            NewGame.option = "Again";
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            UI.Menu menu = new UI.Menu();
            this.Close();
            menu.Show();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Cursor = LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\music\GameOver.wav";
            player.Play();
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
