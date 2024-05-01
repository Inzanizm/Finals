namespace Finals.childforms
{
    partial class Music
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Music));
            player = new AxWMPLib.AxWindowsMediaPlayer();
            btn_play = new Button();
            btn_next = new Button();
            btn_prev = new Button();
            btn_open = new Button();
            progressBar1 = new ProgressBar();
            track_list = new ListBox();
            lbl_track_end = new Label();
            lbl_track_start = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.Enabled = true;
            player.Location = new Point(224, 91);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(982, 341);
            player.TabIndex = 0;
            player.Enter += player_Enter;
            // 
            // btn_play
            // 
            btn_play.BackColor = Color.Transparent;
            btn_play.BackgroundImage = Properties.Resources.Untitled56_20240427155003;
            btn_play.BackgroundImageLayout = ImageLayout.Stretch;
            btn_play.FlatAppearance.BorderSize = 0;
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.Location = new Point(648, 514);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(72, 62);
            btn_play.TabIndex = 1;
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += btn_play_Click;
            btn_play.MouseEnter += btn_play_MouseEnter;
            btn_play.MouseLeave += btn_play_MouseLeave;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.Transparent;
            btn_next.BackgroundImage = Properties.Resources.Untitled55_20240427154728;
            btn_next.BackgroundImageLayout = ImageLayout.Stretch;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Location = new Point(770, 514);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(72, 62);
            btn_next.TabIndex = 2;
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            btn_next.MouseEnter += btn_next_MouseEnter;
            btn_next.MouseLeave += btn_next_MouseLeave;
            // 
            // btn_prev
            // 
            btn_prev.BackColor = Color.Transparent;
            btn_prev.BackgroundImage = Properties.Resources.Untitled55_20240427154741;
            btn_prev.BackgroundImageLayout = ImageLayout.Stretch;
            btn_prev.FlatAppearance.BorderSize = 0;
            btn_prev.FlatStyle = FlatStyle.Flat;
            btn_prev.Location = new Point(536, 514);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(72, 62);
            btn_prev.TabIndex = 3;
            btn_prev.UseVisualStyleBackColor = false;
            btn_prev.Click += btn_prev_Click;
            btn_prev.MouseEnter += btn_prev_MouseEnter;
            btn_prev.MouseLeave += btn_prev_MouseLeave;
            // 
            // btn_open
            // 
            btn_open.BackColor = Color.Transparent;
            btn_open.BackgroundImage = Properties.Resources.Untitled46_20240427154248;
            btn_open.BackgroundImageLayout = ImageLayout.Stretch;
            btn_open.FlatAppearance.BorderSize = 0;
            btn_open.FlatStyle = FlatStyle.Flat;
            btn_open.Location = new Point(882, 514);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(72, 62);
            btn_open.TabIndex = 4;
            btn_open.UseVisualStyleBackColor = false;
            btn_open.Click += btn_open_Click;
            btn_open.MouseEnter += btn_open_MouseEnter;
            btn_open.MouseLeave += btn_open_MouseLeave;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(224, 454);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(982, 37);
            progressBar1.TabIndex = 5;
            // 
            // track_list
            // 
            track_list.BackColor = SystemColors.Menu;
            track_list.BorderStyle = BorderStyle.None;
            track_list.FormattingEnabled = true;
            track_list.Location = new Point(224, 597);
            track_list.Name = "track_list";
            track_list.Size = new Size(982, 120);
            track_list.TabIndex = 6;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.BackColor = Color.Transparent;
            lbl_track_end.FlatStyle = FlatStyle.Flat;
            lbl_track_end.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_end.ForeColor = SystemColors.ControlLightLight;
            lbl_track_end.Location = new Point(1233, 454);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(49, 20);
            lbl_track_end.TabIndex = 7;
            lbl_track_end.Text = "00:00";
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.BackColor = Color.Transparent;
            lbl_track_start.FlatStyle = FlatStyle.Flat;
            lbl_track_start.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_start.ForeColor = SystemColors.ControlLightLight;
            lbl_track_start.Location = new Point(158, 454);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(49, 20);
            lbl_track_start.TabIndex = 8;
            lbl_track_start.Text = "00:00";
            lbl_track_start.Click += lbl_track_start_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Music
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Untitled57_20240427165043;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1331, 716);
            Controls.Add(lbl_track_start);
            Controls.Add(lbl_track_end);
            Controls.Add(track_list);
            Controls.Add(progressBar1);
            Controls.Add(btn_open);
            Controls.Add(btn_prev);
            Controls.Add(btn_next);
            Controls.Add(btn_play);
            Controls.Add(player);
            DoubleBuffered = true;
            Name = "Music";
            Text = "Music";
            Load += Music_Load;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private Button btn_play;
        private Button btn_next;
        private Button btn_prev;
        private Button btn_open;
        private ProgressBar progressBar1;
        private ListBox track_list;
        private Label lbl_track_end;
        private Label lbl_track_start;
        private System.Windows.Forms.Timer timer1;
    }
}