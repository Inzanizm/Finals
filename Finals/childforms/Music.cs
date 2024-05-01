using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;
using MySql.Data.MySqlClient;
using System.Reflection.PortableExecutable;

namespace Finals.childforms
{
    public partial class Music : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        Dbconnection dbconn = new Dbconnection();
        public Music(Form2 form2)
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
            player.uiMode = "none";
        }

        //string[] files;
        List<string> paths = new List<string>();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Music_Load(object sender, EventArgs e)
        {

        }

        private void lbl_track_start_Click(object sender, EventArgs e)
        {

        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT `Title`, `Artist`, `filename`, `filepath` FROM `tb_records`", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string title = dr.GetString(0);
                string artist = dr.GetString(1);
                string fileName = dr.GetString(2);
                string filePath = dr.GetString(3);
                track_list.Items.Add($"{title} - {artist}"); // Add file name to the list
                paths.Add(filePath); // Add file path to the paths list
            }
            dr.Close();
            conn.Close();
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && track_list.SelectedIndex < paths.Count)
            {
                player.URL = paths[track_list.SelectedIndex];

                if (player.playState != WMPPlayState.wmppsPlaying)
                {
                    btn_play.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled59_20240427172010.png");
                    player.Ctlcontrols.play();
                }
                else
                {
                    btn_play.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled56_20240427155003.png");
                    player.Ctlcontrols.pause();
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)

            {

                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;

                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;



            }

            lbl_track_start.Text = player.Ctlcontrols.currentPositionString;

            if (player.Ctlcontrols.currentItem != null)
            {
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString;
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (player.Ctlcontrols.currentItem != null)
            {
                if (player.playState != WMPPlayState.wmppsPlaying)
                {
                    btn_play.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled59_20240427172010.png");
                    player.Ctlcontrols.play();
                    timer1.Start();
                }
                else
                {
                    btn_play.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled56_20240427155003.png");
                    player.Ctlcontrols.pause();
                }
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)

            {

                track_list.SelectedIndex = track_list.SelectedIndex + 1;

            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)

            {

                track_list.SelectedIndex = track_list.SelectedIndex - 1;

            }
        }

        private void btn_play_MouseEnter(object sender, EventArgs e)
        {
            btn_play.BackColor = Color.OrangeRed;
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.BackColor = Color.Transparent;
        }

        private void btn_prev_MouseEnter(object sender, EventArgs e)
        {
            btn_prev.BackColor = Color.OrangeRed;
        }

        private void btn_prev_MouseLeave(object sender, EventArgs e)
        {
            btn_prev.BackColor = Color.Transparent;
        }

        private void btn_next_MouseEnter(object sender, EventArgs e)
        {
            btn_next.BackColor = Color.OrangeRed;
        }

        private void btn_next_MouseLeave(object sender, EventArgs e)
        {
            btn_next.BackColor = Color.Transparent;
        }

        private void btn_open_MouseEnter(object sender, EventArgs e)
        {
            btn_open.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled46_20240426173708.png");
            btn_open.BackColor = Color.OrangeRed;
        }

        private void btn_open_MouseLeave(object sender, EventArgs e)
        {
            btn_open.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled46_20240427154248.png");
            btn_open.BackColor = Color.Transparent;
        }
    }
}
