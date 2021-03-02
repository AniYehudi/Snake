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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Cursor = LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + @"\music\GameDefault.wav";
            player.PlayLooping();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            NewGame ng = new NewGame();
            this.Hide();
            ng.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Settings settings = new Settings();
            this.Hide();
            settings.Show();
        }

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Maps maps = new Maps();
            this.Hide();
            maps.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Skins skins = new Skins();
            this.Hide();
            skins.Show();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Records rec = new Records();
            this.Hide();
            rec.Show();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayerSfx.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }
    }
}
