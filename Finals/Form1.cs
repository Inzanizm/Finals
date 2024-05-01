using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Finals
{
    public partial class Form1 : Form
    {
        private string username = "", password = "";
        private int limit = 3;
        public Form1()
        {
            InitializeComponent();
            panel1.Location = new Point(720, 0);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_NCHITTEST = 0x0084;
            const int HTCLIENT = 0x0001;
            const int HTCAPTION = 0x0002;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            switch (m.Msg)
            {
                case WM_NCCALCSIZE:
                    if (m.WParam.ToInt32() == 1)
                    {
                        return;
                    }
                    break;
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (m.Result.ToInt32() == HTCLIENT)
                    {
                        Point pos = new Point(m.LParam.ToInt32() & 0xFFFF, m.LParam.ToInt32() >> 16);
                        pos = PointToClient(pos);
                        if (pos.X <= 7)
                        {
                            if (pos.Y <= 7)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (pos.Y >= ClientSize.Height - 7)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else
                                m.Result = (IntPtr)HTLEFT;
                        }
                        else if (pos.X >= ClientSize.Width - 7)
                        {
                            if (pos.Y <= 7)
                                m.Result = (IntPtr)HTTOPRIGHT;
                            else if (pos.Y >= ClientSize.Height - 7)
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                            else
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else if (pos.Y <= 7)
                        {
                            m.Result = (IntPtr)HTTOP;
                        }
                        else if (pos.Y >= ClientSize.Height - 7)
                        {
                            m.Result = (IntPtr)HTBOTTOM;
                        }
                        else
                        {
                            m.Result = (IntPtr)HTCAPTION;
                        }
                        return;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        private void CheckCredentials()
        {
            username = textBox1.Text;
            password = textBox2.Text;

            string connString = "server=localhost;user=root;password=;database=db_spookify";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string sql = "SELECT * FROM tb_login";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        bool found = false;
                        string fullName = "", userType = "";

                        while (reader.Read())
                        {
                            if (username == reader["username"].ToString() && password == reader["password"].ToString())
                            {
                                found = true;
                                string? fullNameLocal = reader["FullName"].ToString();
                                if (fullNameLocal != null)
                                {
                                    fullName = fullNameLocal;
                                }
                                string? userTypeLocal = reader["UserType"].ToString();
                                if (userTypeLocal != null)
                                {
                                    userType = userTypeLocal;
                                }
                                break;
                            }
                        }
                        if (found)
                        {
                            MyMessageBox.ShowMessage($"Welcome! {fullName} {userType}", "LOGGED IN..!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (fullName != null)
                            {
                                Form2 form2 = new Form2();
                                form2.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            limit--;
                            string tr = (limit == 1) ? "y" : "ies";

                            if (limit > 0)
                            {
                                DialogResult ds = MyMessageBox.ShowMessage($"Invalid / No Record Found! ({limit} tr{tr} left)\nYou can try again or cancel.", "LOG-IN ERROR.!!!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                                if (ds == DialogResult.Retry)
                                {
                                    textBox1.Text = "";
                                    textBox2.Text = "";
                                    textBox1.Focus();
                                }
                                else if (ds == DialogResult.Cancel)
                                {
                                    Form1 frmMain = new Form1();
                                    frmMain.Show();
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                MyMessageBox.ShowMessage("System Blocked", "NOT TODAY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                        }
                    }
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Para magpunta sa next textbox after mag enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                CheckCredentials();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}