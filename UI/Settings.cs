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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.trackBar3.Value = NewGame.speed;
            LogIn lg = new LogIn();
            this.Cursor = LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseOver.wav";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            NewGame.speed = this.trackBar3.Value;
        }
    }
}
