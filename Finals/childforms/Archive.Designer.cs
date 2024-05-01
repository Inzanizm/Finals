namespace Finals.childforms
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            dataGridView1 = new DataGridView();
            txtMusicID = new DataGridViewTextBoxColumn();
            txtTitle = new DataGridViewTextBoxColumn();
            txtArtist = new DataGridViewTextBoxColumn();
            txtAlbum = new DataGridViewTextBoxColumn();
            txtWrittenby = new DataGridViewTextBoxColumn();
            pictureBox3 = new PictureBox();
            txbTitle = new TextBox();
            btnRestore = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtMusicID, txtTitle, txtArtist, txtAlbum, txtWrittenby });
            dataGridView1.Location = new Point(399, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(910, 555);
            dataGridView1.TabIndex = 2;
            // 
            // txtMusicID
            // 
            txtMusicID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            txtMusicID.DataPropertyName = "MusicID";
            txtMusicID.HeaderText = "Music ID";
            txtMusicID.MinimumWidth = 6;
            txtMusicID.Name = "txtMusicID";
            txtMusicID.ReadOnly = true;
            txtMusicID.Width = 95;
            // 
            // txtTitle
            // 
            txtTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            txtTitle.DataPropertyName = "Title";
            txtTitle.HeaderText = "Title";
            txtTitle.MinimumWidth = 6;
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            // 
            // txtArtist
            // 
            txtArtist.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            txtArtist.DataPropertyName = "Artist";
            txtArtist.HeaderText = "Artist";
            txtArtist.MinimumWidth = 6;
            txtArtist.Name = "txtArtist";
            txtArtist.ReadOnly = true;
            txtArtist.Width = 73;
            // 
            // txtAlbum
            // 
            txtAlbum.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            txtAlbum.DataPropertyName = "Album";
            txtAlbum.HeaderText = "Album";
            txtAlbum.MinimumWidth = 6;
            txtAlbum.Name = "txtAlbum";
            txtAlbum.ReadOnly = true;
            txtAlbum.Width = 82;
            // 
            // txtWrittenby
            // 
            txtWrittenby.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            txtWrittenby.DataPropertyName = "WrittenBy";
            txtWrittenby.HeaderText = "Written By";
            txtWrittenby.MinimumWidth = 6;
            txtWrittenby.Name = "txtWrittenby";
            txtWrittenby.ReadOnly = true;
            txtWrittenby.Width = 107;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Untitled40_20240429182100;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(46, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 59);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // txbTitle
            // 
            txbTitle.BackColor = Color.Gold;
            txbTitle.BorderStyle = BorderStyle.FixedSingle;
            txbTitle.Location = new Point(161, 131);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(204, 27);
            txbTitle.TabIndex = 11;
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.Transparent;
            btnRestore.BackgroundImage = Properties.Resources._76f939f5_bc36_4aad_9432_f06fea0724c2_removebg_preview;
            btnRestore.BackgroundImageLayout = ImageLayout.Stretch;
            btnRestore.FlatAppearance.BorderSize = 0;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestore.Location = new Point(129, 234);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(168, 84);
            btnRestore.TabIndex = 13;
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = Properties.Resources._52f7c294_63ae_42d5_b8a4_0a0a66159f3f_removebg_preview;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(138, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 93);
            btnDelete.TabIndex = 13;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1331, 716);
            Controls.Add(btnDelete);
            Controls.Add(btnRestore);
            Controls.Add(pictureBox3);
            Controls.Add(txbTitle);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Archive";
            Text = "Archive";
            Load += Archive_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn txtMusicID;
        private DataGridViewTextBoxColumn txtTitle;
        private DataGridViewTextBoxColumn txtArtist;
        private DataGridViewTextBoxColumn txtAlbum;
        private DataGridViewTextBoxColumn txtWrittenby;
        private PictureBox pictureBox3;
        private TextBox txbTitle;
        private Button btnRestore;
        private Button btnDelete;
    }
}