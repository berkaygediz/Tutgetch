namespace Tutgetch
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Panel_margin = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.Dot = new System.Windows.Forms.PictureBox();
            this.label_time = new System.Windows.Forms.Label();
            this.LabelChance = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Control = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Author = new System.Windows.Forms.Label();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Panel_margin.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dot)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_margin
            // 
            this.Panel_margin.BackColor = System.Drawing.Color.Black;
            this.Panel_margin.Controls.Add(this.GamePanel);
            this.Panel_margin.Controls.Add(this.label_time);
            this.Panel_margin.Controls.Add(this.LabelChance);
            this.Panel_margin.Location = new System.Drawing.Point(22, 85);
            this.Panel_margin.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_margin.Name = "Panel_margin";
            this.Panel_margin.Size = new System.Drawing.Size(533, 492);
            this.Panel_margin.TabIndex = 9;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
            this.GamePanel.Controls.Add(this.Dot);
            this.GamePanel.Location = new System.Drawing.Point(17, 16);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(500, 462);
            this.GamePanel.TabIndex = 2;
            this.GamePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GamePanel_MouseDown);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.Black;
            this.Dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dot.Location = new System.Drawing.Point(212, 199);
            this.Dot.Margin = new System.Windows.Forms.Padding(4);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(67, 62);
            this.Dot.TabIndex = 0;
            this.Dot.TabStop = false;
            this.Dot.Visible = false;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_time.ForeColor = System.Drawing.Color.Aqua;
            this.label_time.Location = new System.Drawing.Point(469, 0);
            this.label_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(50, 13);
            this.label_time.TabIndex = 5;
            this.label_time.Text = "Time: 10";
            // 
            // LabelChance
            // 
            this.LabelChance.AutoSize = true;
            this.LabelChance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelChance.ForeColor = System.Drawing.Color.Lime;
            this.LabelChance.Location = new System.Drawing.Point(405, 0);
            this.LabelChance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelChance.Name = "LabelChance";
            this.LabelChance.Size = new System.Drawing.Size(57, 13);
            this.LabelChance.TabIndex = 4;
            this.LabelChance.Text = "Chance: 5";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.label_title.Location = new System.Drawing.Point(13, 4);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(108, 25);
            this.label_title.TabIndex = 8;
            this.label_title.Text = "TUTGETCH";
            // 
            // Reset
            // 
            this.Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reset.FlatAppearance.BorderSize = 3;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(102)))), ((int)(((byte)(160)))));
            this.Reset.Location = new System.Drawing.Point(295, 41);
            this.Reset.Margin = new System.Windows.Forms.Padding(4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(260, 35);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Start
            // 
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderSize = 3;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(84)))), ((int)(((byte)(175)))));
            this.Start.Location = new System.Drawing.Point(22, 41);
            this.Start.Margin = new System.Windows.Forms.Padding(4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(257, 35);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Control
            // 
            this.Control.Interval = 375;
            this.Control.Tick += new System.EventHandler(this.Control_Tick);
            // 
            // Time
            // 
            this.Time.Interval = 1000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Author.ForeColor = System.Drawing.Color.Black;
            this.Author.Location = new System.Drawing.Point(481, 581);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(74, 13);
            this.Author.TabIndex = 13;
            this.Author.Text = "Berkay Gediz";
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ControlPanel.Controls.Add(this.Minimize);
            this.ControlPanel.Controls.Add(this.Exit);
            this.ControlPanel.Controls.Add(this.label_title);
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(574, 32);
            this.ControlPanel.TabIndex = 14;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
            this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Gold;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Minimize.Location = new System.Drawing.Point(504, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 23);
            this.Minimize.TabIndex = 1;
            this.Minimize.Text = "—";
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(536, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(194)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(574, 605);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.Panel_margin);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Author);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutgetch";
            this.Panel_margin.ResumeLayout(false);
            this.Panel_margin.PerformLayout();
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dot)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_margin;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.PictureBox Dot;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label LabelChance;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Timer Control;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Exit;
    }
}

