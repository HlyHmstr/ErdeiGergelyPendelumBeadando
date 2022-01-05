using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PendelumWinForm
{
    public partial class Form1 : Form
    {
        public static string connectionString { get; set; }
        public Form1()
        {
            connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = music; ";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFill();
            cbArtFill();
            cb_album.Enabled = false;
        }
        private void cbAlbFill()
        {
            using (var c = new SqlConnection(connectionString))
            {   
                c.Open();
                var r = new SqlCommand(
                    "Select Albums.title " +
                    "from Albums", c
                    ).ExecuteReader();
                while (r.Read())
                {
                    cb_album.Items.Add(r[0]);
                }  
            }
        }
        private void cbArtFill()
        {
            using (var c = new SqlConnection(connectionString))
            {
               
                c.Open();
                var r = new SqlCommand(
                    "Select Artist " +
                    "from Albums " +
                    "group by Artist;", c
                    ).ExecuteReader();
                while (r.Read())
                {
                    cb_artist.Items.Add(r[0]);
                }
            }
        }

        private void dgvFill()
        {
            using (var c = new SqlConnection(connectionString))
            {
                dgv.Rows.Clear();
                c.Open();
                var r = new SqlCommand(
                    "Select title, lenght " +
                    "from Tracks;", c
                    ).ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1]);
                }
            }
        }
        private void selAlbRTB()
        {
         

        }
        private void cb_artist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_album.Enabled = true;
            cbAlbFill();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cb_album_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cb_album.SelectedIndex;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (i)
            {
                case 0 :
                    pb.Image = Image.FromFile("..\\..\\res\\hold_your_colour.jpg");
                    using (var c = new SqlConnection(connectionString))
                    {
                        c.Open();
                        var r = new SqlCommand(
                            "select release " +
                            "from Albums " +
                            "where title = 'Hold Your Colour';", c).ExecuteReader();
                        while (r.Read())
                        {
                            DateTime dt = Convert.ToDateTime(r[0]);
                            rtb.Text = dt.ToString("yyyy. MM. dd.");
                        }
                        c.Close();
                        c.Open();
                        var r1 = new SqlCommand(
                           "select lenght " +
                           "from Tracks,Albums " +
                           "where Albums.title = 'Hold Your Colour';", c).ExecuteReader();
                        double hossz = 0;
                        while (r1.Read())
                        {
                            string hosszusag = Convert.ToString(r1[0]);
                            hossz = hosszusag.Select(x => TimeSpan.Parse(hosszusag).TotalHours).Sum();
                        }
                        rtb.AppendText($"\n{(double)hossz}");
                    }
                    break;
                case 1:
                    pb.Image = Image.FromFile("..\\..\\res\\immersion.jpg");
                    using (var c = new SqlConnection(connectionString))
                    {
                        c.Open();
                        var r = new SqlCommand(
                            "select release " +
                            "from Albums " +
                            "where title = 'In Silico';", c).ExecuteReader();
                        while (r.Read())
                        {
                            DateTime dt = Convert.ToDateTime(r[0]);
                            rtb.Text = dt.ToString("yyyy. MM. dd.");
                        }

                        c.Close();
                        c.Open();
                        var r1 = new SqlCommand(
                           "select lenght " +
                           "from Tracks,Albums " +
                           "where Albums.title = 'In Silico';", c).ExecuteReader();
                        double hossz = 0;
                        while (r1.Read())
                        {
                            string hosszusag = Convert.ToString(r1[0]);
                            hossz = hosszusag.Select(x => TimeSpan.Parse(hosszusag).TotalHours).Sum();
                        }
                        rtb.AppendText($"\n{(double)hossz}");
                    }
                    break;
                case 2:
                    pb.Image = Image.FromFile("..\\..\\res\\in_silico.jpg");
                    using (var c = new SqlConnection(connectionString))
                    {
                        c.Open();
                        var r = new SqlCommand(
                            "select release " +
                            "from Albums " +
                            "where title = 'Immersion';", c).ExecuteReader();
                        while (r.Read())
                        {
                            DateTime dt = Convert.ToDateTime(r[0]);
                            rtb.Text = dt.ToString("yyyy. MM. dd.");
                        }
                        c.Close();
                        c.Open();
                        var r1 = new SqlCommand(
                           "select lenght " +
                           "from Tracks,Albums " +
                           "where Albums.title = 'Immersion';", c).ExecuteReader();
                        double hossz = 0;
                        while (r1.Read())
                        {
                            string hosszusag = Convert.ToString(r1[0]);
                            hossz = hosszusag.Select(x => TimeSpan.Parse(hosszusag).TotalHours).Sum();
                        }
                        rtb.AppendText($"\n{(double)hossz}");
                    }
                        break;
            }
           
        }
    }
}
