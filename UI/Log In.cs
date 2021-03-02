using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Snake.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        public class LabelofVAriables
        {
            public static int UserID;
            public static SqlConnection conex = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alex\Desktop\Organiser\Volatile\Applicative Programming\Visual C#\Snake\Data\snakedb.mdf;Integrated Security=True;Connect Timeout=30");
            public static string message;
            public static int MapID = 1;
            public static int SnakeID = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                LabelofVAriables.message = "All the fields must be clomplete!";
                Warn warn = new Warn();
                warn.ShowDialog();
            }

            else
            {
                SqlCommand check = new SqlCommand("select COUNT(UserID) from _User where Username = '" 
                    + this.textBox1.Text + "' and Password = '" 
                    + this.textBox2.Text + "'", LabelofVAriables.conex);

                int result = Convert.ToInt32(check.ExecuteScalar().ToString());

                if (result == 1)
                {

                    Menu menu = new Menu();
                    this.Hide();
                    SqlCommand GetId = new SqlCommand("select UserId from _User where Username = '"
                    + this.textBox1.Text +"'", LabelofVAriables.conex);
                    int id = Convert.ToInt32(GetId.ExecuteScalar().ToString());
                    LabelofVAriables.UserID = id;
                    menu.Show();

                }

                else
                {
                    LabelofVAriables.message = "Username or Password is invalid!";
                    Warn warn = new Warn();
                    warn.ShowDialog();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stop();
            if (LabelofVAriables.conex.State == ConnectionState.Closed)
                LabelofVAriables.conex.Open();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        public static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            bm.MakeTransparent();
            return new Cursor(bm.GetHicon());
        }
    }
}
