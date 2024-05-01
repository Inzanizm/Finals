using Finals.childforms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            openChildFormInPanel(new Record(this));
            
            iconrecords.BackColor = Color.Blue;
            filesbutton.BackColor = Color.Yellow;
            filesbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filesbutton.ForeColor = Color.Black;
            filesbuttonclicked = true;

        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }


        bool sidebarexpand = false;
        private const int SlideIncrement = 10;

        private void timerslidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarexpand)
            {
                if (panel1.Width > 72)
                {
                    SuspendLayout();
                    int newWidth = Math.Max(panel1.Width - SlideIncrement, 72);
                    panel1.Width = newWidth;
                    archivebutton.Width = newWidth;
                    playerbutton.Width = newWidth;
                    filesbutton.Width = newWidth;
                    logoutbutton.Width = newWidth;
                    ResumeLayout();

                }
                else
                {
                    sidebarexpand = false;
                    timerslidebar.Stop();
                }
            }
            else
            {
                if (panel1.Width < 215)
                {
                    SuspendLayout();
                    int newWidth = Math.Min(panel1.Width + 10, 215);
                    panel1.Width = newWidth;
                    archivebutton.Width = newWidth;
                    playerbutton.Width = newWidth;
                    filesbutton.Width = newWidth;
                    logoutbutton.Width = newWidth;
                    ResumeLayout();

                }
                else
                {
                    sidebarexpand = true;
                    timerslidebar.Stop();
                }
            }
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            timerslidebar.Start();
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Form? activeForm = null, musicForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (childForm is not Music)
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                if (musicForm != null)
                {
                    musicForm.Hide();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelngchildform.Controls.Add(childForm);
                panelngchildform.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();

            }
            else
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                if (musicForm == null)
                {
                    musicForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    panelngchildform.Controls.Add(childForm);
                    panelngchildform.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();

                }
                else
                {
                    musicForm.Show();
                }
            }
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {

        }

        private void btnplaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnmusic_Click(object sender, EventArgs e)
        {

        }

        private void btnarchive_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #region button highlight and openchildform


        private bool filesbuttonclicked = false;
        private bool playerbuttonclicked = false;
        private bool archivebuttonclicked = false;
        private void iconrecords_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Record(this));
            ResetButtonStates();
            iconrecords.BackColor = Color.Blue;
            filesbutton.BackColor = Color.Yellow;
            filesbutton.ForeColor = Color.Black;
            filesbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filesbuttonclicked = true;
        }

        private void iconmusic_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Music(this));
            ResetButtonStates();
            iconmusic.BackColor = Color.Blue;
            playerbutton.BackColor = Color.Yellow;
            playerbutton.ForeColor = Color.Black;
            playerbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerbuttonclicked = true;
        }

        private void iconarchive_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Archive(this));
            ResetButtonStates();
            iconarchive.BackColor = Color.Blue;
            archivebutton.BackColor = Color.Yellow;
            archivebutton.ForeColor = Color.Black;
            archivebutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivebuttonclicked = true;
        }

        private void filesbutton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Record(this));
            ResetButtonStates();
            iconrecords.BackColor = Color.Blue;
            filesbutton.BackColor = Color.Yellow;
            filesbutton.ForeColor = Color.Black;
            filesbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filesbuttonclicked = true;
        }

      

        private void playerbutton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Music(this));
            ResetButtonStates();
            iconmusic.BackColor = Color.Blue;
            playerbutton.BackColor = Color.Yellow;
            playerbutton.ForeColor = Color.Black;
            playerbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerbuttonclicked = true;
        }

        private void archivebutton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Archive(this));
            ResetButtonStates();
            iconarchive.BackColor = Color.Blue;
            archivebutton.BackColor = Color.Yellow;
            archivebutton.ForeColor = Color.Black;
            archivebutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivebuttonclicked = true;
        }
        #endregion


        #region button highlight
        private void filesbutton_MouseEnter(object sender, EventArgs e)
        {
            if (!filesbuttonclicked)
            {
                iconrecords.BackColor = Color.Blue;
                filesbutton.BackColor = Color.Yellow;
                filesbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }

        }

        private void filesbutton_MouseLeave(object sender, EventArgs e)
        {
            if (!filesbuttonclicked)
            {
                iconrecords.BackColor = Color.Transparent;
                filesbutton.BackColor = Color.Transparent;
                filesbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void playerbutton_MouseEnter(object sender, EventArgs e)
        {
            if (!playerbuttonclicked)
            {
                iconmusic.BackColor = Color.Blue;
                playerbutton.BackColor = Color.Yellow;
                playerbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void playerbutton_MouseLeave(object sender, EventArgs e)
        {
            if (!playerbuttonclicked)
            {
                iconmusic.BackColor = Color.Transparent;
                playerbutton.BackColor = Color.Transparent;
                playerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void archivebutton_MouseEnter(object sender, EventArgs e)
        {
            if (!archivebuttonclicked)
            {
                iconarchive.BackColor = Color.Blue;
                archivebutton.BackColor = Color.Yellow;
                archivebutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void archivebutton_MouseLeave(object sender, EventArgs e)
        {
            if (!archivebuttonclicked)
            {
                iconarchive.BackColor = Color.Transparent;
                archivebutton.BackColor = Color.Transparent;
                archivebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void logoutbutton_MouseEnter(object sender, EventArgs e)
        {
            
                iconlogout.BackColor = Color.Blue;
                logoutbutton.BackColor = Color.Yellow;
                logoutbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            
        }

        private void logoutbutton_MouseLeave(object sender, EventArgs e)
        {            
                iconlogout.BackColor = Color.Transparent;
                logoutbutton.BackColor = Color.Transparent;
                logoutbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);           
        }
        private void iconrecords_MouseEnter(object sender, EventArgs e)
        {
            if (!filesbuttonclicked)
            {
                iconrecords.BackColor = Color.Blue;
                filesbutton.BackColor = Color.Yellow;
                filesbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }
        private void iconrecords_MouseLeave(object sender, EventArgs e)
        {
            if (!filesbuttonclicked)
            {
                iconrecords.BackColor = Color.Transparent;
                filesbutton.BackColor = Color.Transparent;
                filesbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void iconmusic_MouseEnter(object sender, EventArgs e)
        {
            if (!playerbuttonclicked)
            {
                iconmusic.BackColor = Color.Blue;
                playerbutton.BackColor = Color.Yellow;
                playerbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void iconmusic_MouseLeave(object sender, EventArgs e)
        {
            if (!playerbuttonclicked)
            {
                iconmusic.BackColor = Color.Transparent;
                playerbutton.BackColor = Color.Transparent;
                playerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }

        private void iconarchive_MouseEnter(object sender, EventArgs e)
        {
            if (!archivebuttonclicked)
            {
                iconarchive.BackColor = Color.Blue;
                archivebutton.BackColor = Color.Yellow;
                archivebutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);

            }
        }

        private void iconarchive_MouseLeave(object sender, EventArgs e)
        {
            if (!archivebuttonclicked)
            {
                iconarchive.BackColor = Color.Transparent;
                archivebutton.BackColor = Color.Transparent;
                archivebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }
        private void iconlogout_MouseEnter(object sender, EventArgs e)
        {          
                iconlogout.BackColor = Color.Blue;
                logoutbutton.BackColor = Color.Yellow;
                logoutbutton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);            
        }

        private void iconlogout_MouseLeave(object sender, EventArgs e)
        {
                iconlogout.BackColor = Color.Transparent;
                logoutbutton.BackColor = Color.Transparent;
                logoutbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);            
        }
        private void ResetButtonStates()
        {
            // Reset all button and icon states here
            iconrecords.BackColor = Color.Transparent;
            filesbutton.BackColor = Color.Transparent;
            iconmusic.BackColor = Color.Transparent;
            playerbutton.BackColor = Color.Transparent;
            iconarchive.BackColor = Color.Transparent;
            archivebutton.BackColor = Color.Transparent;
            iconlogout.BackColor = Color.Transparent;
            logoutbutton.BackColor = Color.Transparent;
           
            // reset all fonts
            archivebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filesbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);

            // reset forecolor
            archivebutton.ForeColor = Color.White;
            filesbutton.ForeColor = Color.White;
            playerbutton.ForeColor = Color.White;

            // Reset the iconbuttonclicked variable
            filesbuttonclicked = false;
            playerbuttonclicked = false;
            archivebuttonclicked = false;
        }
        #endregion
        

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MyMessageBox.ShowMessage("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 frmLogin = new Form1();
                frmLogin.Show();
                this.Dispose();
            }
        }

        private void iconlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MyMessageBox.ShowMessage("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 frmLogin = new Form1();
                frmLogin.Show();
                this.Dispose();
            }
        }

        private void panel3_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
