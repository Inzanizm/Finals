namespace Finals
{
    partial class MessageBoxYesNo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelButtons = new Panel();
            btnNO = new Button();
            btnYES = new Button();
            panelBody = new Panel();
            labelMessage = new Label();
            pictureBoxIcon = new PictureBox();
            panelTitleBar = new Panel();
            labelCaption = new Label();
            btnClose = new Button();
            panelButtons.SuspendLayout();
            panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(235, 235, 235);
            panelButtons.Controls.Add(btnNO);
            panelButtons.Controls.Add(btnYES);
            panelButtons.Location = new Point(12, 147);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(703, 54);
            panelButtons.TabIndex = 6;
            // 
            // btnNO
            // 
            btnNO.BackColor = Color.SeaGreen;
            btnNO.DialogResult = DialogResult.No;
            btnNO.FlatStyle = FlatStyle.Flat;
            btnNO.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNO.ForeColor = Color.WhiteSmoke;
            btnNO.Location = new Point(407, 2);
            btnNO.Margin = new Padding(4);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(160, 48);
            btnNO.TabIndex = 1;
            btnNO.Text = "&NO";
            btnNO.UseVisualStyleBackColor = false;
            btnNO.Click += btnNO_Click;
            // 
            // btnYES
            // 
            btnYES.BackColor = Color.SeaGreen;
            btnYES.DialogResult = DialogResult.Yes;
            btnYES.FlatStyle = FlatStyle.Flat;
            btnYES.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnYES.ForeColor = Color.WhiteSmoke;
            btnYES.Location = new Point(201, 2);
            btnYES.Margin = new Padding(4);
            btnYES.Name = "btnYES";
            btnYES.Size = new Size(160, 48);
            btnYES.TabIndex = 0;
            btnYES.Text = "&YES";
            btnYES.UseVisualStyleBackColor = false;
            btnYES.Click += button2_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.WhiteSmoke;
            panelBody.Controls.Add(labelMessage);
            panelBody.Controls.Add(pictureBoxIcon);
            panelBody.Location = new Point(12, 68);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(703, 86);
            panelBody.TabIndex = 5;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMessage.ForeColor = Color.FromArgb(85, 85, 85);
            labelMessage.Location = new Point(89, 15);
            labelMessage.Margin = new Padding(4, 0, 4, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new Padding(7, 6, 13, 14);
            labelMessage.Size = new Size(154, 45);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "labelMessage";
            labelMessage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.ErrorImage = null;
            pictureBoxIcon.Image = Properties.Resources.warning_595067;
            pictureBoxIcon.Location = new Point(4, 5);
            pictureBoxIcon.Margin = new Padding(4);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(77, 67);
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 2;
            pictureBoxIcon.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.IndianRed;
            panelTitleBar.Controls.Add(labelCaption);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Location = new Point(1, 6);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(726, 56);
            panelTitleBar.TabIndex = 4;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // labelCaption
            // 
            labelCaption.AutoSize = true;
            labelCaption.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCaption.ForeColor = Color.White;
            labelCaption.Location = new Point(15, 19);
            labelCaption.Margin = new Padding(4, 0, 4, 0);
            labelCaption.Name = "labelCaption";
            labelCaption.Size = new Size(121, 25);
            labelCaption.TabIndex = 2;
            labelCaption.Text = "labelCaption";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(669, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 55);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MessageBoxYesNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(729, 207);
            ControlBox = false;
            Controls.Add(panelButtons);
            Controls.Add(panelBody);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxYesNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MessageBoxYesNo";
            panelButtons.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Button btnYES;
        private Panel panelBody;
        private Label labelMessage;
        private PictureBox pictureBoxIcon;
        private Panel panelTitleBar;
        private Label labelCaption;
        private Button btnClose;
        private Button btnNO;
    }
}