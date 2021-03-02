using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Snake.UI.LogIn;

namespace Snake.UI
{
    public partial class Warn : Form
    {
        public Warn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Warn_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Error : " + LabelofVAriables.message;
        }
    }
}
