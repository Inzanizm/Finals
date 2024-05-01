using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class MessageBoxYesNo : Form
    {
        public MessageBoxYesNo()
        {
            InitializeComponent();
        }

        public Image MessageIcon
        {
            get { return pictureBoxIcon.Image; }
            set
            {
                pictureBoxIcon.Image = value;
            }
        }

        public string Message
        {
            get { return labelMessage.Text; }
            set
            {
                labelMessage.Text = value;
            }
        }

        public string Title
        {
            get { return labelCaption.Text; }
            set { labelCaption.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnNO_Click(object sender, EventArgs e)
        {

        }
    }
}
