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
    public partial class Archive : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        int i = 0;

        Dbconnection dbconn = new Dbconnection();

        public Archive(Form2 form2)
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            LoadRecord();
            dataGridView1.RowTemplate.Height = 25;
        }

        public void LoadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT `MusicID`, `Title`, `Artist`, `Album`, `Writtenby`, `filename`, `filepath` FROM `tb_archieve`", conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["Title"].ToString(), dr["Artist"].ToString(), dr["Album"].ToString(), dr["Writtenby"].ToString(), dr["filename"].ToString(), dr["filepath"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("INSERT INTO tb_records (MusicID, Title, Artist, Album, Writtenby, filename, filepath) SELECT MusicID, Title, Artist, Album, Writtenby, filename, filepath FROM tb_archieve WHERE `Title`=@Title", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Title", txbTitle.Text);
            int rowsInserted = cmd.ExecuteNonQuery();

            if (rowsInserted > 0)
            {
                cmd = new MySqlCommand("Delete From `tb_archieve` WHERE `Title`=@Title", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Title", txbTitle.Text);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MyMessageBox.ShowMessage("Record restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MyMessageBox.ShowMessage("Record not restored", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
            LoadRecord();
            txbTitle.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MyMessageBox.ShowMessage("Are you sure you want to delete this record forever?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand("Delete From `tb_archieve` WHERE `Title`=@Title", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Title", txbTitle.Text);
                    
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MyMessageBox.ShowMessage("Record deleted forever.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MyMessageBox.ShowMessage("Record not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                LoadRecord();
                txbTitle.Clear();
            }
        }
    }
}
