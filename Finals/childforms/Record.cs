using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals.childforms
{
    public partial class Record : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        int i = 0;

        Dbconnection dbconn = new Dbconnection();

        public Record(Form2 form2)
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void Record_Load(object sender, EventArgs e)
        {
            LoadRecord();
            dataGridView1.RowTemplate.Height = 25;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT `MusicID`, `Title`, `Artist`, `Album`, `Writtenby`, `filename`, `filepath` FROM `tb_records`", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Title"].ToString(), dr["Artist"].ToString(), dr["Album"].ToString(), dr["Writtenby"].ToString(), dr["filename"].ToString(), dr["filepath"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        public void clear()
        {
            txbTitle.Clear();
            txbArtist.Clear();
            txbAlbum.Clear();
            txbWrittenBy.Clear();
            txbfilename.Clear();
            txbfilepath.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txbTitle.Text == string.Empty) || (txbArtist.Text == string.Empty) || (txbAlbum.Text == string.Empty) || (txbWrittenBy.Text == string.Empty) || (txbfilename.Text == string.Empty) || (txbfilepath.Text == string.Empty))
            {
                MyMessageBox.ShowMessage("Required to fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tb_records`(`Title`, `Artist`, `Album`, `Writtenby`, `filename`, `filepath`) VALUES (@Title,@Artist,@Album,@Writtenby,@filename,@filepath)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Title", txbTitle.Text);
                cmd.Parameters.AddWithValue("@Artist", txbArtist.Text);
                cmd.Parameters.AddWithValue("@Album", txbAlbum.Text);
                cmd.Parameters.AddWithValue("@Writtenby", txbWrittenBy.Text);
                cmd.Parameters.AddWithValue("@filename", txbfilename.Text);
                cmd.Parameters.AddWithValue("@filepath", txbfilepath.Text);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MyMessageBox.ShowMessage("Record Saved Successfullly", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MyMessageBox.ShowMessage("Record Not Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                LoadRecord();
                clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MyMessageBox.ShowMessage("Are you sure you want to delete this record and transfer it to archive?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO tb_archieve (MusicID, Title, Artist, Album, Writtenby, filename, filepath) SELECT MusicID, Title, Artist, Album, Writtenby, filename, filepath FROM tb_records WHERE `Title`=@Title", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Title", txbTitle.Text);
                int rowsInserted = cmd.ExecuteNonQuery();

                if (rowsInserted > 0)
                {
                    cmd = new MySqlCommand("Delete From `tb_records` WHERE `Title`=@Title", conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Title", txbTitle.Text);

                    i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MyMessageBox.ShowMessage("Record archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MyMessageBox.ShowMessage("Record not archived", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
                LoadRecord();
                clear();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE `tb_records` SET `Artist`=@Artist,`Album`=@Album,`Writtenby`=@Writtenby,`filename`=@filename,`filepath`=@filepath WHERE `Title`=@Title", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Artist", txbArtist.Text);
            cmd.Parameters.AddWithValue("@Album", txbAlbum.Text);
            cmd.Parameters.AddWithValue("@Writtenby", txbWrittenBy.Text);
            cmd.Parameters.AddWithValue("@Title", txbTitle.Text);
            cmd.Parameters.AddWithValue("@filename", txbfilename.Text);
            cmd.Parameters.AddWithValue("@filepath", txbfilepath.Text);

            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MyMessageBox.ShowMessage("Record Update Successfullly", "CONFIRMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MyMessageBox.ShowMessage("Record Not Updated", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
            LoadRecord();
            clear();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT `Title`, `Artist`, `Album`, `Writtenby`, `filename`, `filepath` FROM `tb_records` WHERE Title like '%" + txbSearch.Text + "%' or Artist like '%" + txbSearch.Text + "%' or Album like '%" + txbSearch.Text + "%' or Writtenby like '%" + txbSearch.Text + "%' or filename like '%" + txbSearch.Text + "%' or filepath like '%" + txbSearch.Text + "%'", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Title"].ToString(), dr["Artist"].ToString(), dr["Album"].ToString(), dr["Writtenby"].ToString(), dr["filename"].ToString(), dr["filepath"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file name and path
                txbfilename.Text = openFileDialog.SafeFileName;
                txbfilepath.Text = openFileDialog.FileName;
            }
        }

        private void btn_open_MouseEnter(object sender, EventArgs e)
        {
            btn_open.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled46_20240426174043.png");
            btn_open.BackColor = Color.OrangeRed;
        }

        private void btn_open_MouseLeave(object sender, EventArgs e)
        {
            btn_open.BackgroundImage = Image.FromFile("C:\\Users\\ACER\\Downloads\\Untitled46_20240427154248.png");
            btn_open.BackColor = Color.Transparent;

        }
    }
}
