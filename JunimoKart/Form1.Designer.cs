namespace JunimoKart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerX = new System.Windows.Forms.Label();
            this.playerY = new System.Windows.Forms.Label();
            this.playerSpeedLabel = new System.Windows.Forms.Label();
            this.jumpCheckLabel = new System.Windows.Forms.Label();
            this.gfLabel = new System.Windows.Forms.Label();
            this.singleCheckValue = new System.Windows.Forms.Label();
            this.platformHeightLabel = new System.Windows.Forms.Label();
            this.platSupportLabel = new System.Windows.Forms.Label();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.escapeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.controlsLabel = new System.Windows.Forms.Label();
            this.pinkJunimoImage = new System.Windows.Forms.PictureBox();
            this.junimoImage = new System.Windows.Forms.PictureBox();
            this.junimoKartSignImage = new System.Windows.Forms.PictureBox();
            this.orangeJunimoImage = new System.Windows.Forms.PictureBox();
            this.blueJunimoImage = new System.Windows.Forms.PictureBox();
            this.jumpLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.dashLabel = new System.Windows.Forms.Label();
            this.downLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinkJunimoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junimoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.junimoKartSignImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeJunimoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueJunimoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerX
            // 
            this.playerX.BackColor = System.Drawing.Color.Transparent;
            this.playerX.ForeColor = System.Drawing.Color.White;
            this.playerX.Location = new System.Drawing.Point(15, 11);
            this.playerX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerX.Name = "playerX";
            this.playerX.Size = new System.Drawing.Size(109, 19);
            this.playerX.TabIndex = 0;
            this.playerX.Text = "0";
            this.playerX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playerX.Visible = false;
            // 
            // playerY
            // 
            this.playerY.BackColor = System.Drawing.Color.Transparent;
            this.playerY.ForeColor = System.Drawing.Color.White;
            this.playerY.Location = new System.Drawing.Point(15, 48);
            this.playerY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerY.Name = "playerY";
            this.playerY.Size = new System.Drawing.Size(109, 19);
            this.playerY.TabIndex = 1;
            this.playerY.Text = "0";
            this.playerY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playerY.Visible = false;
            // 
            // playerSpeedLabel
            // 
            this.playerSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.playerSpeedLabel.Location = new System.Drawing.Point(15, 89);
            this.playerSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerSpeedLabel.Name = "playerSpeedLabel";
            this.playerSpeedLabel.Size = new System.Drawing.Size(109, 19);
            this.playerSpeedLabel.TabIndex = 2;
            this.playerSpeedLabel.Text = "0";
            this.playerSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playerSpeedLabel.Visible = false;
            // 
            // jumpCheckLabel
            // 
            this.jumpCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.jumpCheckLabel.ForeColor = System.Drawing.Color.White;
            this.jumpCheckLabel.Location = new System.Drawing.Point(15, 130);
            this.jumpCheckLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jumpCheckLabel.Name = "jumpCheckLabel";
            this.jumpCheckLabel.Size = new System.Drawing.Size(109, 19);
            this.jumpCheckLabel.TabIndex = 3;
            this.jumpCheckLabel.Text = "0";
            this.jumpCheckLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jumpCheckLabel.Visible = false;
            // 
            // gfLabel
            // 
            this.gfLabel.BackColor = System.Drawing.Color.Transparent;
            this.gfLabel.ForeColor = System.Drawing.Color.White;
            this.gfLabel.Location = new System.Drawing.Point(15, 171);
            this.gfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gfLabel.Name = "gfLabel";
            this.gfLabel.Size = new System.Drawing.Size(109, 19);
            this.gfLabel.TabIndex = 4;
            this.gfLabel.Text = "0";
            this.gfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gfLabel.Visible = false;
            // 
            // singleCheckValue
            // 
            this.singleCheckValue.BackColor = System.Drawing.Color.Transparent;
            this.singleCheckValue.ForeColor = System.Drawing.Color.White;
            this.singleCheckValue.Location = new System.Drawing.Point(15, 214);
            this.singleCheckValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.singleCheckValue.Name = "singleCheckValue";
            this.singleCheckValue.Size = new System.Drawing.Size(109, 19);
            this.singleCheckValue.TabIndex = 5;
            this.singleCheckValue.Text = "0";
            this.singleCheckValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.singleCheckValue.Visible = false;
            // 
            // platformHeightLabel
            // 
            this.platformHeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.platformHeightLabel.ForeColor = System.Drawing.Color.White;
            this.platformHeightLabel.Location = new System.Drawing.Point(469, 11);
            this.platformHeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platformHeightLabel.Name = "platformHeightLabel";
            this.platformHeightLabel.Size = new System.Drawing.Size(508, 19);
            this.platformHeightLabel.TabIndex = 6;
            this.platformHeightLabel.Text = "0";
            this.platformHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.platformHeightLabel.Visible = false;
            // 
            // platSupportLabel
            // 
            this.platSupportLabel.BackColor = System.Drawing.Color.Transparent;
            this.platSupportLabel.ForeColor = System.Drawing.Color.White;
            this.platSupportLabel.Location = new System.Drawing.Point(469, 48);
            this.platSupportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.platSupportLabel.Name = "platSupportLabel";
            this.platSupportLabel.Size = new System.Drawing.Size(508, 19);
            this.platSupportLabel.TabIndex = 7;
            this.platSupportLabel.Text = "0";
            this.platSupportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.platSupportLabel.Visible = false;
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
            this.playerScoreLabel.ForeColor = System.Drawing.Color.White;
            this.playerScoreLabel.Location = new System.Drawing.Point(905, 13);
            this.playerScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(88, 35);
            this.playerScoreLabel.TabIndex = 8;
            this.playerScoreLabel.Text = "0";
            this.playerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerScoreLabel.Visible = false;
            // 
            // enterLabel
            // 
            this.enterLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterLabel.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.ForeColor = System.Drawing.Color.Yellow;
            this.enterLabel.Location = new System.Drawing.Point(28, 388);
            this.enterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(470, 26);
            this.enterLabel.TabIndex = 9;
            this.enterLabel.Text = "Press \"Enter\" For a New Game!";
            this.enterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // escapeLabel
            // 
            this.escapeLabel.BackColor = System.Drawing.Color.Transparent;
            this.escapeLabel.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeLabel.ForeColor = System.Drawing.Color.Gold;
            this.escapeLabel.Location = new System.Drawing.Point(502, 388);
            this.escapeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.escapeLabel.Name = "escapeLabel";
            this.escapeLabel.Size = new System.Drawing.Size(452, 26);
            this.escapeLabel.TabIndex = 10;
            this.escapeLabel.Text = "Press \"Escape\" To Exit the Game!";
            this.escapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Khaki;
            this.scoreLabel.Location = new System.Drawing.Point(104, 426);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(771, 26);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Your Final Score Is ### Points!";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLabel.Visible = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.BackColor = System.Drawing.Color.Transparent;
            this.copyrightLabel.Font = new System.Drawing.Font("Vladimir Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.Color.White;
            this.copyrightLabel.Location = new System.Drawing.Point(71, 516);
            this.copyrightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(189, 26);
            this.copyrightLabel.TabIndex = 12;
            this.copyrightLabel.Text = "LGKartSoftware Ltd.";
            // 
            // controlsLabel
            // 
            this.controlsLabel.BackColor = System.Drawing.Color.Transparent;
            this.controlsLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsLabel.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.controlsLabel.Location = new System.Drawing.Point(445, 501);
            this.controlsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.controlsLabel.Name = "controlsLabel";
            this.controlsLabel.Size = new System.Drawing.Size(433, 26);
            this.controlsLabel.TabIndex = 16;
            this.controlsLabel.Text = "Press \"C\" For Controls!";
            this.controlsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pinkJunimoImage
            // 
            this.pinkJunimoImage.BackColor = System.Drawing.Color.Transparent;
            this.pinkJunimoImage.BackgroundImage = global::JunimoKart.Properties.Resources.pinkJunimo;
            this.pinkJunimoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinkJunimoImage.Location = new System.Drawing.Point(79, 67);
            this.pinkJunimoImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pinkJunimoImage.Name = "pinkJunimoImage";
            this.pinkJunimoImage.Size = new System.Drawing.Size(45, 41);
            this.pinkJunimoImage.TabIndex = 18;
            this.pinkJunimoImage.TabStop = false;
            this.pinkJunimoImage.Visible = false;
            // 
            // junimoImage
            // 
            this.junimoImage.BackColor = System.Drawing.Color.Transparent;
            this.junimoImage.BackgroundImage = global::JunimoKart.Properties.Resources.yellowJunimo;
            this.junimoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.junimoImage.Location = new System.Drawing.Point(882, 494);
            this.junimoImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.junimoImage.Name = "junimoImage";
            this.junimoImage.Size = new System.Drawing.Size(45, 41);
            this.junimoImage.TabIndex = 15;
            this.junimoImage.TabStop = false;
            // 
            // junimoKartSignImage
            // 
            this.junimoKartSignImage.BackColor = System.Drawing.Color.Transparent;
            this.junimoKartSignImage.BackgroundImage = global::JunimoKart.Properties.Resources.JunimoSign;
            this.junimoKartSignImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.junimoKartSignImage.Location = new System.Drawing.Point(79, 89);
            this.junimoKartSignImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.junimoKartSignImage.Name = "junimoKartSignImage";
            this.junimoKartSignImage.Size = new System.Drawing.Size(842, 296);
            this.junimoKartSignImage.TabIndex = 17;
            this.junimoKartSignImage.TabStop = false;
            // 
            // orangeJunimoImage
            // 
            this.orangeJunimoImage.BackColor = System.Drawing.Color.Transparent;
            this.orangeJunimoImage.BackgroundImage = global::JunimoKart.Properties.Resources.orangeJunimo;
            this.orangeJunimoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orangeJunimoImage.Location = new System.Drawing.Point(830, 67);
            this.orangeJunimoImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orangeJunimoImage.Name = "orangeJunimoImage";
            this.orangeJunimoImage.Size = new System.Drawing.Size(45, 41);
            this.orangeJunimoImage.TabIndex = 19;
            this.orangeJunimoImage.TabStop = false;
            this.orangeJunimoImage.Visible = false;
            // 
            // blueJunimoImage
            // 
            this.blueJunimoImage.BackColor = System.Drawing.Color.Transparent;
            this.blueJunimoImage.BackgroundImage = global::JunimoKart.Properties.Resources.blueJunimo;
            this.blueJunimoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blueJunimoImage.Location = new System.Drawing.Point(882, 89);
            this.blueJunimoImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.blueJunimoImage.Name = "blueJunimoImage";
            this.blueJunimoImage.Size = new System.Drawing.Size(45, 41);
            this.blueJunimoImage.TabIndex = 20;
            this.blueJunimoImage.TabStop = false;
            this.blueJunimoImage.Visible = false;
            // 
            // jumpLabel
            // 
            this.jumpLabel.BackColor = System.Drawing.Color.Transparent;
            this.jumpLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpLabel.ForeColor = System.Drawing.Color.Yellow;
            this.jumpLabel.Location = new System.Drawing.Point(299, 96);
            this.jumpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jumpLabel.Name = "jumpLabel";
            this.jumpLabel.Size = new System.Drawing.Size(642, 76);
            this.jumpLabel.TabIndex = 21;
            this.jumpLabel.Text = "Jump     ->     W, Up Arrow, Space";
            this.jumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.jumpLabel.Visible = false;
            // 
            // leftLabel
            // 
            this.leftLabel.BackColor = System.Drawing.Color.Transparent;
            this.leftLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.ForeColor = System.Drawing.Color.Yellow;
            this.leftLabel.Location = new System.Drawing.Point(319, 269);
            this.leftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(579, 50);
            this.leftLabel.TabIndex = 22;
            this.leftLabel.Text = "Left     ->     A, Left Arrow";
            this.leftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftLabel.Visible = false;
            // 
            // rightLabel
            // 
            this.rightLabel.BackColor = System.Drawing.Color.Transparent;
            this.rightLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.ForeColor = System.Drawing.Color.Yellow;
            this.rightLabel.Location = new System.Drawing.Point(294, 349);
            this.rightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(560, 52);
            this.rightLabel.TabIndex = 23;
            this.rightLabel.Text = "Right     ->     D, Right Arrow";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightLabel.Visible = false;
            // 
            // dashLabel
            // 
            this.dashLabel.BackColor = System.Drawing.Color.Transparent;
            this.dashLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashLabel.ForeColor = System.Drawing.Color.Yellow;
            this.dashLabel.Location = new System.Drawing.Point(299, 426);
            this.dashLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(610, 43);
            this.dashLabel.TabIndex = 24;
            this.dashLabel.Text = "Dash     ->     Shift";
            this.dashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashLabel.Visible = false;
            // 
            // downLabel
            // 
            this.downLabel.BackColor = System.Drawing.Color.Transparent;
            this.downLabel.Font = new System.Drawing.Font("Rockwell", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downLabel.ForeColor = System.Drawing.Color.Yellow;
            this.downLabel.Location = new System.Drawing.Point(296, 193);
            this.downLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.downLabel.Name = "downLabel";
            this.downLabel.Size = new System.Drawing.Size(579, 50);
            this.downLabel.TabIndex = 25;
            this.downLabel.Text = "Down     ->     S, Down Arrow";
            this.downLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1003, 606);
            this.Controls.Add(this.downLabel);
            this.Controls.Add(this.pinkJunimoImage);
            this.Controls.Add(this.orangeJunimoImage);
            this.Controls.Add(this.blueJunimoImage);
            this.Controls.Add(this.dashLabel);
            this.Controls.Add(this.rightLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.jumpLabel);
            this.Controls.Add(this.escapeLabel);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.controlsLabel);
            this.Controls.Add(this.junimoImage);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.platSupportLabel);
            this.Controls.Add(this.platformHeightLabel);
            this.Controls.Add(this.singleCheckValue);
            this.Controls.Add(this.gfLabel);
            this.Controls.Add(this.jumpCheckLabel);
            this.Controls.Add(this.playerSpeedLabel);
            this.Controls.Add(this.playerY);
            this.Controls.Add(this.playerX);
            this.Controls.Add(this.junimoKartSignImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "JunimoKart";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pinkJunimoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junimoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.junimoKartSignImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeJunimoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueJunimoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerX;
        private System.Windows.Forms.Label playerY;
        private System.Windows.Forms.Label playerSpeedLabel;
        private System.Windows.Forms.Label jumpCheckLabel;
        private System.Windows.Forms.Label gfLabel;
        private System.Windows.Forms.Label singleCheckValue;
        private System.Windows.Forms.Label platformHeightLabel;
        private System.Windows.Forms.Label platSupportLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label escapeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox junimoImage;
        private System.Windows.Forms.Label controlsLabel;
        private System.Windows.Forms.PictureBox junimoKartSignImage;
        private System.Windows.Forms.PictureBox pinkJunimoImage;
        private System.Windows.Forms.PictureBox orangeJunimoImage;
        private System.Windows.Forms.PictureBox blueJunimoImage;
        private System.Windows.Forms.Label jumpLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label dashLabel;
        private System.Windows.Forms.Label downLabel;
    }
}

