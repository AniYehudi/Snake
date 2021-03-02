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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Cursor = LogIn.CreateCursor((Bitmap)lg.imageList1.Images[0], new Size(25, 25));
            dataGridView1.RowHeadersVisible = false;

            string Query = "select top 10 Username, s.Name as Snake, Score, Level, m.Name as Map, g.Data as Date from Game g inner join _User u on g.UserId = u.UserId inner join Snake s on g.SnakeId = s.SnakeId inner join Map m on m.MapId = g.MapID order by Score desc; ";

            SqlCommand prt = new SqlCommand(Query, UI.LogIn.LabelofVAriables.conex);
            SqlDataAdapter da = new SqlDataAdapter(prt);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns["Username"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns["Map"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns["Snake"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns["Date"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns["Level"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dataGridView1.Columns["Score"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = Environment.CurrentDirectory + @"\sfx\MouseClick.wav";
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
