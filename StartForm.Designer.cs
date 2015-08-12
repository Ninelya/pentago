namespace pentago
{
    partial class StartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSectorCount = new System.Windows.Forms.ComboBox();
            this.cbPlayerCount = new System.Windows.Forms.ComboBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.tbName3 = new System.Windows.Forms.TextBox();
            this.tbName4 = new System.Windows.Forms.TextBox();
            this.tbName5 = new System.Windows.Forms.TextBox();
            this.tbName6 = new System.Windows.Forms.TextBox();
            this.tbName7 = new System.Windows.Forms.TextBox();
            this.tbName8 = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите количество секторов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите количество игроков:";
            // 
            // cbSectorCount
            // 
            this.cbSectorCount.FormattingEnabled = true;
            this.cbSectorCount.Items.AddRange(new object[] {
            "4 (2 х 2)",
            "9 (3 х 3)",
            "16 (4 х 4)",
            "25 (5 х 5)"});
            this.cbSectorCount.Location = new System.Drawing.Point(198, 13);
            this.cbSectorCount.Name = "cbSectorCount";
            this.cbSectorCount.Size = new System.Drawing.Size(121, 21);
            this.cbSectorCount.TabIndex = 10;
            this.cbSectorCount.Text = "9 (3 х 3)";
            // 
            // cbPlayerCount
            // 
            this.cbPlayerCount.FormattingEnabled = true;
            this.cbPlayerCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbPlayerCount.Location = new System.Drawing.Point(198, 50);
            this.cbPlayerCount.MaxLength = 1;
            this.cbPlayerCount.Name = "cbPlayerCount";
            this.cbPlayerCount.Size = new System.Drawing.Size(121, 21);
            this.cbPlayerCount.TabIndex = 11;
            this.cbPlayerCount.Text = "2";
            this.cbPlayerCount.SelectedIndexChanged += new System.EventHandler(this.cbPlayerCount_SelectedIndexChanged);
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(58, 112);
            this.tbName1.MaxLength = 9;
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(92, 20);
            this.tbName1.TabIndex = 12;
            this.tbName1.Text = "Игрок 1";
            this.toolTip1.SetToolTip(this.tbName1, "Введите имя");
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(227, 112);
            this.tbName2.MaxLength = 9;
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(92, 20);
            this.tbName2.TabIndex = 12;
            this.tbName2.Text = "Игрок 2";
            this.toolTip1.SetToolTip(this.tbName2, "Введите имя");
            // 
            // tbName3
            // 
            this.tbName3.Enabled = false;
            this.tbName3.Location = new System.Drawing.Point(58, 159);
            this.tbName3.MaxLength = 9;
            this.tbName3.Name = "tbName3";
            this.tbName3.Size = new System.Drawing.Size(92, 20);
            this.tbName3.TabIndex = 12;
            this.tbName3.Text = "Игрок 3";
            this.toolTip1.SetToolTip(this.tbName3, "Введите имя");
            // 
            // tbName4
            // 
            this.tbName4.Enabled = false;
            this.tbName4.Location = new System.Drawing.Point(227, 159);
            this.tbName4.MaxLength = 9;
            this.tbName4.Name = "tbName4";
            this.tbName4.Size = new System.Drawing.Size(92, 20);
            this.tbName4.TabIndex = 12;
            this.tbName4.Text = "Игрок 4";
            this.toolTip1.SetToolTip(this.tbName4, "Введите имя");
            // 
            // tbName5
            // 
            this.tbName5.Enabled = false;
            this.tbName5.Location = new System.Drawing.Point(58, 207);
            this.tbName5.MaxLength = 9;
            this.tbName5.Name = "tbName5";
            this.tbName5.Size = new System.Drawing.Size(92, 20);
            this.tbName5.TabIndex = 12;
            this.tbName5.Text = "Игрок 5";
            this.toolTip1.SetToolTip(this.tbName5, "Введите имя");
            // 
            // tbName6
            // 
            this.tbName6.Enabled = false;
            this.tbName6.Location = new System.Drawing.Point(227, 207);
            this.tbName6.MaxLength = 9;
            this.tbName6.Name = "tbName6";
            this.tbName6.Size = new System.Drawing.Size(92, 20);
            this.tbName6.TabIndex = 12;
            this.tbName6.Text = "Игрок 6";
            this.toolTip1.SetToolTip(this.tbName6, "Введите имя");
            // 
            // tbName7
            // 
            this.tbName7.Enabled = false;
            this.tbName7.Location = new System.Drawing.Point(58, 256);
            this.tbName7.MaxLength = 9;
            this.tbName7.Name = "tbName7";
            this.tbName7.Size = new System.Drawing.Size(92, 20);
            this.tbName7.TabIndex = 12;
            this.tbName7.Text = "Игрок 7";
            this.toolTip1.SetToolTip(this.tbName7, "Введите имя");
            // 
            // tbName8
            // 
            this.tbName8.Enabled = false;
            this.tbName8.Location = new System.Drawing.Point(227, 256);
            this.tbName8.MaxLength = 9;
            this.tbName8.Name = "tbName8";
            this.tbName8.Size = new System.Drawing.Size(92, 20);
            this.tbName8.TabIndex = 12;
            this.tbName8.Text = "Игрок 8";
            this.toolTip1.SetToolTip(this.tbName8, "Введите имя");
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(217, 334);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(102, 23);
            this.btnPlay.TabIndex = 21;
            this.btnPlay.Text = "Новая игра";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.btnOpen.Enabled = false;
            this.btnOpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(15, 334);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(102, 23);
            this.btnOpen.TabIndex = 23;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox8.Location = new System.Drawing.Point(183, 152);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.TabIndex = 53;
            this.pictureBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox8, "Голубой");
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(183, 200);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.TabIndex = 52;
            this.pictureBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox7, "Желтый");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(183, 249);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "Коричневый");
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(15, 105);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Красный");
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(15, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Синий");
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(15, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Розовый");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(15, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Чёрный");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(183, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Зелёный");
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(342, 373);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tbName8);
            this.Controls.Add(this.tbName7);
            this.Controls.Add(this.tbName6);
            this.Controls.Add(this.tbName5);
            this.Controls.Add(this.tbName4);
            this.Controls.Add(this.tbName3);
            this.Controls.Add(this.tbName2);
            this.Controls.Add(this.tbName1);
            this.Controls.Add(this.cbPlayerCount);
            this.Controls.Add(this.cbSectorCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать в Pentago :-)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSectorCount;
        private System.Windows.Forms.ComboBox cbPlayerCount;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.TextBox tbName3;
        private System.Windows.Forms.TextBox tbName4;
        private System.Windows.Forms.TextBox tbName5;
        private System.Windows.Forms.TextBox tbName6;
        private System.Windows.Forms.TextBox tbName7;
        private System.Windows.Forms.TextBox tbName8;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}