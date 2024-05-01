namespace Finals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            iconexit = new FontAwesome.Sharp.IconButton();
            iconminimize = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 123);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gold;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(535, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 20);
            textBox1.TabIndex = 4;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gold;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(535, 266);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 20);
            textBox2.TabIndex = 5;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Untitled40_20240426165805;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 5;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(535, 335);
            button1.Name = "button1";
            button1.Size = new Size(124, 56);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // iconexit
            // 
            iconexit.BackColor = Color.Olive;
            iconexit.BackgroundImage = Properties.Resources.images__2__removebg_preview;
            iconexit.BackgroundImageLayout = ImageLayout.Stretch;
            iconexit.Dock = DockStyle.Right;
            iconexit.FlatStyle = FlatStyle.Flat;
            iconexit.IconChar = FontAwesome.Sharp.IconChar.None;
            iconexit.IconColor = Color.Black;
            iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconexit.Location = new Point(48, 0);
            iconexit.Name = "iconexit";
            iconexit.Size = new Size(53, 39);
            iconexit.TabIndex = 7;
            iconexit.UseVisualStyleBackColor = false;
            iconexit.Click += iconexit_Click;
            // 
            // iconminimize
            // 
            iconminimize.BackColor = Color.Olive;
            iconminimize.Dock = DockStyle.Left;
            iconminimize.FlatStyle = FlatStyle.Flat;
            iconminimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconminimize.IconColor = Color.Black;
            iconminimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconminimize.Location = new Point(0, 0);
            iconminimize.Name = "iconminimize";
            iconminimize.Size = new Size(55, 39);
            iconminimize.TabIndex = 8;
            iconminimize.UseVisualStyleBackColor = false;
            iconminimize.Click += iconminimize_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(iconexit);
            panel1.Controls.Add(iconminimize);
            panel1.Location = new Point(700, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 39);
            panel1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private FontAwesome.Sharp.IconButton iconexit;
        private FontAwesome.Sharp.IconButton iconminimize;
        private Panel panel1;
    }
}
