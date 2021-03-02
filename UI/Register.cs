using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Snake.UI.LogIn;

namespace Snake.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string register;

            register = "insert into _User (Username, Password) values('" + this.textBox1.Text + "', '" + this.textBox2.Text + "'); ";

            try
            {
                SqlCommand insert = new SqlCommand(register, LabelofVAriables.conex);
                insert.ExecuteNonQuery();
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }

            catch (Exception ex)
            {
                LabelofVAriables.message = ex.GetType().ToString();
                Warn warn = new Warn();
                warn.ShowDialog();
            }
        }
    }
}
