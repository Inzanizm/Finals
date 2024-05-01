namespace Finals
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            timerslidebar = new System.Windows.Forms.Timer(components);
            panelngchildform = new Panel();
            iconlogout = new FontAwesome.Sharp.IconPictureBox();
            iconmusic = new FontAwesome.Sharp.IconPictureBox();
            iconarchive = new FontAwesome.Sharp.IconPictureBox();
            iconrecords = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            filesbutton = new FontAwesome.Sharp.IconButton();
            playerbutton = new FontAwesome.Sharp.IconButton();
            archivebutton = new FontAwesome.Sharp.IconButton();
            logoutbutton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelngchildform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconlogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconarchive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconrecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1116, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 106);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timerslidebar
            // 
            timerslidebar.Tick += timerslidebar_Tick;
            // 
            // panelngchildform
            // 
            panelngchildform.BackgroundImage = Properties.Resources.Untitled38_20240421112129;
            panelngchildform.BackgroundImageLayout = ImageLayout.Stretch;
            panelngchildform.Controls.Add(pictureBox1);
            panelngchildform.Dock = DockStyle.Fill;
            panelngchildform.Location = new Point(72, 0);
            panelngchildform.Name = "panelngchildform";
            panelngchildform.Size = new Size(1474, 716);
            panelngchildform.TabIndex = 2;
            panelngchildform.Paint += panel3_Paint;
            panelngchildform.MouseDown += panel3_MouseDown;
            // 
            // iconlogout
            // 
            iconlogout.BackColor = Color.Transparent;
            iconlogout.BackgroundImage = Properties.Resources.Untitled52_20240426180703;
            iconlogout.BackgroundImageLayout = ImageLayout.Stretch;
            iconlogout.ForeColor = SystemColors.ControlText;
            iconlogout.IconChar = FontAwesome.Sharp.IconChar.None;
            iconlogout.IconColor = SystemColors.ControlText;
            iconlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconlogout.IconSize = 66;
            iconlogout.Location = new Point(3, 637);
            iconlogout.Name = "iconlogout";
            iconlogout.Size = new Size(69, 66);
            iconlogout.TabIndex = 10;
            iconlogout.TabStop = false;
            iconlogout.Click += iconlogout_Click;
            iconlogout.MouseEnter += iconlogout_MouseEnter;
            iconlogout.MouseLeave += iconlogout_MouseLeave;
            // 
            // iconmusic
            // 
            iconmusic.BackColor = Color.Transparent;
            iconmusic.BackgroundImage = Properties.Resources.Untitled50_202404261758291;
            iconmusic.BackgroundImageLayout = ImageLayout.Stretch;
            iconmusic.ForeColor = SystemColors.ControlText;
            iconmusic.IconChar = FontAwesome.Sharp.IconChar.None;
            iconmusic.IconColor = SystemColors.ControlText;
            iconmusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconmusic.IconSize = 66;
            iconmusic.Location = new Point(3, 174);
            iconmusic.Name = "iconmusic";
            iconmusic.Size = new Size(69, 66);
            iconmusic.TabIndex = 8;
            iconmusic.TabStop = false;
            iconmusic.Click += iconmusic_Click;
            iconmusic.MouseEnter += iconmusic_MouseEnter;
            iconmusic.MouseLeave += iconmusic_MouseLeave;
            // 
            // iconarchive
            // 
            iconarchive.BackColor = Color.Transparent;
            iconarchive.BackgroundImage = Properties.Resources.Untitled51_20240426180250;
            iconarchive.BackgroundImageLayout = ImageLayout.Stretch;
            iconarchive.ForeColor = SystemColors.ControlText;
            iconarchive.IconChar = FontAwesome.Sharp.IconChar.None;
            iconarchive.IconColor = SystemColors.ControlText;
            iconarchive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconarchive.IconSize = 66;
            iconarchive.Location = new Point(3, 259);
            iconarchive.Name = "iconarchive";
            iconarchive.Size = new Size(69, 66);
            iconarchive.TabIndex = 9;
            iconarchive.TabStop = false;
            iconarchive.Click += iconarchive_Click;
            iconarchive.MouseEnter += iconarchive_MouseEnter;
            iconarchive.MouseLeave += iconarchive_MouseLeave;
            // 
            // iconrecords
            // 
            iconrecords.BackColor = Color.Transparent;
            iconrecords.BackgroundImage = Properties.Resources.Untitled46_20240426174043;
            iconrecords.BackgroundImageLayout = ImageLayout.Stretch;
            iconrecords.ForeColor = SystemColors.ControlText;
            iconrecords.IconChar = FontAwesome.Sharp.IconChar.None;
            iconrecords.IconColor = SystemColors.ControlText;
            iconrecords.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconrecords.IconSize = 66;
            iconrecords.Location = new Point(3, 87);
            iconrecords.Name = "iconrecords";
            iconrecords.Size = new Size(69, 66);
            iconrecords.TabIndex = 7;
            iconrecords.TabStop = false;
            iconrecords.Click += iconrecords_Click;
            iconrecords.MouseEnter += iconrecords_MouseEnter;
            iconrecords.MouseLeave += iconrecords_MouseLeave;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.Transparent;
            iconPictureBox5.BackgroundImage = Properties.Resources.Untitled45_20240426172914;
            iconPictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            iconPictureBox5.ForeColor = SystemColors.ControlText;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox5.IconColor = SystemColors.ControlText;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.IconSize = 51;
            iconPictureBox5.Location = new Point(3, 12);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(68, 51);
            iconPictureBox5.TabIndex = 11;
            iconPictureBox5.TabStop = false;
            iconPictureBox5.Click += iconPictureBox5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(iconPictureBox5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(72, 75);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint_1;
            panel3.MouseDown += panel3_MouseDown_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(iconarchive);
            panel1.Controls.Add(iconmusic);
            panel1.Controls.Add(iconlogout);
            panel1.Controls.Add(iconrecords);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(filesbutton);
            panel1.Controls.Add(playerbutton);
            panel1.Controls.Add(archivebutton);
            panel1.Controls.Add(logoutbutton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(72, 716);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // filesbutton
            // 
            filesbutton.BackColor = Color.Transparent;
            filesbutton.FlatAppearance.BorderColor = Color.Black;
            filesbutton.FlatStyle = FlatStyle.Flat;
            filesbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filesbutton.ForeColor = Color.White;
            filesbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            filesbutton.IconColor = Color.Black;
            filesbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            filesbutton.Location = new Point(12, 87);
            filesbutton.Name = "filesbutton";
            filesbutton.Size = new Size(200, 66);
            filesbutton.TabIndex = 14;
            filesbutton.Text = "FILES";
            filesbutton.UseVisualStyleBackColor = false;
            filesbutton.Click += filesbutton_Click;
            filesbutton.MouseEnter += filesbutton_MouseEnter;
            filesbutton.MouseLeave += filesbutton_MouseLeave;
            // 
            // playerbutton
            // 
            playerbutton.BackColor = Color.Transparent;
            playerbutton.FlatAppearance.BorderColor = Color.Black;
            playerbutton.FlatStyle = FlatStyle.Flat;
            playerbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerbutton.ForeColor = Color.White;
            playerbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            playerbutton.IconColor = Color.Black;
            playerbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playerbutton.Location = new Point(12, 174);
            playerbutton.Name = "playerbutton";
            playerbutton.Size = new Size(200, 66);
            playerbutton.TabIndex = 16;
            playerbutton.Text = "PLAYER";
            playerbutton.UseVisualStyleBackColor = false;
            playerbutton.Click += playerbutton_Click;
            playerbutton.MouseEnter += playerbutton_MouseEnter;
            playerbutton.MouseLeave += playerbutton_MouseLeave;
            // 
            // archivebutton
            // 
            archivebutton.BackColor = Color.Transparent;
            archivebutton.FlatAppearance.BorderColor = Color.Black;
            archivebutton.FlatStyle = FlatStyle.Flat;
            archivebutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            archivebutton.ForeColor = Color.White;
            archivebutton.IconChar = FontAwesome.Sharp.IconChar.None;
            archivebutton.IconColor = Color.Black;
            archivebutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            archivebutton.Location = new Point(12, 259);
            archivebutton.Name = "archivebutton";
            archivebutton.Size = new Size(200, 66);
            archivebutton.TabIndex = 17;
            archivebutton.Text = "ARCHIVE";
            archivebutton.UseVisualStyleBackColor = false;
            archivebutton.Click += archivebutton_Click;
            archivebutton.MouseEnter += archivebutton_MouseEnter;
            archivebutton.MouseLeave += archivebutton_MouseLeave;
            // 
            // logoutbutton
            // 
            logoutbutton.BackColor = Color.Transparent;
            logoutbutton.FlatAppearance.BorderColor = Color.Black;
            logoutbutton.FlatAppearance.BorderSize = 0;
            logoutbutton.FlatStyle = FlatStyle.Flat;
            logoutbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutbutton.ForeColor = Color.White;
            logoutbutton.IconChar = FontAwesome.Sharp.IconChar.None;
            logoutbutton.IconColor = Color.Black;
            logoutbutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logoutbutton.Location = new Point(12, 637);
            logoutbutton.Name = "logoutbutton";
            logoutbutton.Size = new Size(200, 66);
            logoutbutton.TabIndex = 18;
            logoutbutton.Text = "LOG OUT";
            logoutbutton.UseVisualStyleBackColor = false;
            logoutbutton.Click += logoutbutton_Click;
            logoutbutton.MouseEnter += logoutbutton_MouseEnter;
            logoutbutton.MouseLeave += logoutbutton_MouseLeave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1546, 716);
            Controls.Add(panelngchildform);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            MouseDown += Form2_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelngchildform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconlogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconarchive).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconrecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerslidebar;
        private Panel panelngchildform;
        private FontAwesome.Sharp.IconPictureBox iconlogout;
        private FontAwesome.Sharp.IconPictureBox iconmusic;
        private FontAwesome.Sharp.IconPictureBox iconarchive;
        private FontAwesome.Sharp.IconPictureBox iconrecords;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Panel panel3;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton filesbutton;
        private FontAwesome.Sharp.IconButton playerbutton;
        private FontAwesome.Sharp.IconButton archivebutton;
        private FontAwesome.Sharp.IconButton logoutbutton;
    }
}