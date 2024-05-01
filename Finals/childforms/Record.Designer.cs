namespace Finals.childforms
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            dataGridView1 = new DataGridView();
            txtMusicID = new DataGridViewTextBoxColumn();
            txtTitle = new DataGridViewTextBoxColumn();
            txtArtist = new DataGridViewTextBoxColumn();
            txtAlbum = new DataGridViewTextBoxColumn();
            txtWrittenby = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txbTitle = new TextBox();
            txbArtist = new TextBox();
            txbAlbum = new TextBox();
            txbWrittenBy = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label7 = new Label();
            txbSearch = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            btn_open = new Button();
            txbfilename = new TextBox();
            txbfilepath = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Left;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtMusicID, txtTitle, txtArtist, txtAlbum, txtWrittenby, Column1, Column2 });
            dataGridView1.Location = new Point(548, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(762, 569);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // txtMusicID
            // 
            txtMusicID.DataPropertyName = "MusicID";
            txtMusicID.HeaderText = "Music ID";
            txtMusicID.MinimumWidth = 6;
            txtMusicID.Name = "txtMusicID";
            txtMusicID.ReadOnly = true;
            txtMusicID.Width = 60;
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
            txtWrittenby.DataPropertyName = "WrittenBy";
            txtWrittenby.HeaderText = "Written By";
            txtWrittenby.MinimumWidth = 6;
            txtWrittenby.Name = "txtWrittenby";
            txtWrittenby.ReadOnly = true;
            txtWrittenby.Width = 99;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "File Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 97;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column2.HeaderText = "File Path";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 86;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Untitled40_202404271556451;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(180, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 58);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(0, 31);
            label2.TabIndex = 3;
            // 
            // txbTitle
            // 
            txbTitle.BackColor = Color.Gold;
            txbTitle.BorderStyle = BorderStyle.FixedSingle;
            txbTitle.Location = new Point(234, 141);
            txbTitle.Name = "txbTitle";
            txbTitle.Size = new Size(289, 27);
            txbTitle.TabIndex = 5;
            // 
            // txbArtist
            // 
            txbArtist.BackColor = Color.Gold;
            txbArtist.BorderStyle = BorderStyle.FixedSingle;
            txbArtist.Location = new Point(234, 209);
            txbArtist.Name = "txbArtist";
            txbArtist.Size = new Size(289, 27);
            txbArtist.TabIndex = 5;
            // 
            // txbAlbum
            // 
            txbAlbum.BackColor = Color.Gold;
            txbAlbum.BorderStyle = BorderStyle.FixedSingle;
            txbAlbum.Location = new Point(234, 283);
            txbAlbum.Name = "txbAlbum";
            txbAlbum.Size = new Size(289, 27);
            txbAlbum.TabIndex = 5;
            // 
            // txbWrittenBy
            // 
            txbWrittenBy.BackColor = Color.Gold;
            txbWrittenBy.BorderStyle = BorderStyle.FixedSingle;
            txbWrittenBy.Location = new Point(234, 380);
            txbWrittenBy.Name = "txbWrittenBy";
            txbWrittenBy.Size = new Size(289, 27);
            txbWrittenBy.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.BackgroundImage = Properties.Resources.Untitled40_20240429182221;
            btnSave.BackgroundImageLayout = ImageLayout.Stretch;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(35, 617);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 74);
            btnSave.TabIndex = 7;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.BackgroundImage = Properties.Resources.Untitled40_20240429182236;
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(204, 617);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 74);
            btnUpdate.TabIndex = 7;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = Properties.Resources.Untitled40_20240429182252;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(373, 617);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 74);
            btnDelete.TabIndex = 7;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(508, 35);
            label7.Name = "label7";
            label7.Size = new Size(0, 35);
            label7.TabIndex = 4;
            // 
            // txbSearch
            // 
            txbSearch.BackColor = Color.Gold;
            txbSearch.BorderStyle = BorderStyle.FixedSingle;
            txbSearch.Location = new Point(574, 81);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(672, 27);
            txbSearch.TabIndex = 8;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._1200px_Magnifying_glass_icon_svg;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1261, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Untitled40_20240429182100;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(61, 109);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 59);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.Untitled40_20240429182110;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(59, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(111, 59);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.Untitled40_20240429182118;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(59, 265);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(111, 59);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.Untitled40_20240429182200;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(12, 353);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(207, 94);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // btn_open
            // 
            btn_open.BackColor = Color.Transparent;
            btn_open.BackgroundImage = Properties.Resources.Untitled46_20240427154248;
            btn_open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_open.FlatAppearance.BorderSize = 0;
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.Location = new Point(12, 495);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(90, 78);
            btn_open.TabIndex = 14;
            btn_open.UseVisualStyleBackColor = false;
            btn_open.Click += btn_open_Click;
            btn_open.MouseEnter += btn_open_MouseEnter;
            btn_open.MouseLeave += btn_open_MouseLeave;
            // 
            // txbfilename
            // 
            txbfilename.BackColor = Color.Gold;
            txbfilename.BorderStyle = BorderStyle.FixedSingle;
            txbfilename.Location = new Point(313, 486);
            txbfilename.Name = "txbfilename";
            txbfilename.ReadOnly = true;
            txbfilename.Size = new Size(210, 27);
            txbfilename.TabIndex = 15;
            // 
            // txbfilepath
            // 
            txbfilepath.BackColor = Color.Gold;
            txbfilepath.BorderStyle = BorderStyle.FixedSingle;
            txbfilepath.Location = new Point(313, 556);
            txbfilepath.Name = "txbfilepath";
            txbfilepath.ReadOnly = true;
            txbfilepath.Size = new Size(210, 27);
            txbfilepath.TabIndex = 16;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(100, 453);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(207, 94);
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(100, 526);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(207, 94);
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // Record
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._042e6f2a_53a7_48f4_92d0_ab7240b811f1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1331, 716);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(txbfilepath);
            Controls.Add(txbfilename);
            Controls.Add(btn_open);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txbWrittenBy);
            Controls.Add(txbAlbum);
            Controls.Add(txbArtist);
            Controls.Add(txbTitle);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            Name = "Record";
            Text = "Record";
            Load += Record_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txbTitle;
        private TextBox txbArtist;
        private TextBox txbAlbum;
        private TextBox txbWrittenBy;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label7;
        private TextBox txbSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btn_open;
        private TextBox txbfilename;
        private TextBox txbfilepath;
        private DataGridViewTextBoxColumn txtMusicID;
        private DataGridViewTextBoxColumn txtTitle;
        private DataGridViewTextBoxColumn txtArtist;
        private DataGridViewTextBoxColumn txtAlbum;
        private DataGridViewTextBoxColumn txtWrittenby;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}