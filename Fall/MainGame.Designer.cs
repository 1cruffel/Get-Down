namespace Fall
{
    partial class MainGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.Panel();
            this.floor = new System.Windows.Forms.PictureBox();
            this.platR = new System.Windows.Forms.PictureBox();
            this.platL = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.platM = new System.Windows.Forms.PictureBox();
            this.playerTick = new System.Windows.Forms.Timer(this.components);
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.fallCheck = new System.Windows.Forms.Timer(this.components);
            this.platchr = new System.Windows.Forms.Timer(this.components);
            this.platforms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(425, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // screen
            // 
            this.screen.Controls.Add(this.floor);
            this.screen.Controls.Add(this.platR);
            this.screen.Controls.Add(this.platL);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.platM);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 450);
            this.screen.TabIndex = 1;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.floor.Location = new System.Drawing.Point(0, 422);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(800, 28);
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            this.floor.Tag = "platform";
            // 
            // platR
            // 
            this.platR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platR.Location = new System.Drawing.Point(567, 395);
            this.platR.Name = "platR";
            this.platR.Size = new System.Drawing.Size(233, 32);
            this.platR.TabIndex = 2;
            this.platR.TabStop = false;
            this.platR.Tag = "risingPlatform";
            // 
            // platL
            // 
            this.platL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platL.Location = new System.Drawing.Point(0, 395);
            this.platL.Name = "platL";
            this.platL.Size = new System.Drawing.Size(251, 32);
            this.platL.TabIndex = 1;
            this.platL.TabStop = false;
            this.platL.Tag = "risingPlatform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(425, 218);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // platM
            // 
            this.platM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platM.Location = new System.Drawing.Point(357, 391);
            this.platM.Name = "platM";
            this.platM.Size = new System.Drawing.Size(112, 32);
            this.platM.TabIndex = 4;
            this.platM.TabStop = false;
            this.platM.Tag = "risingPlatform";
            // 
            // playerTick
            // 
            this.playerTick.Enabled = true;
            this.playerTick.Interval = 1;
            this.playerTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameTick
            // 
            this.gameTick.Enabled = true;
            this.gameTick.Interval = 5;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // fallCheck
            // 
            this.fallCheck.Interval = 1;
            this.fallCheck.Tick += new System.EventHandler(this.fallCheck_Tick);
            // 
            // platchr
            // 
            this.platchr.Enabled = true;
            this.platchr.Interval = 1;
            this.platchr.Tick += new System.EventHandler(this.platchr_Tick);
            // 
            // platforms
            // 
            this.platforms.Enabled = true;
            this.platforms.Interval = 1;
            this.platforms.Tick += new System.EventHandler(this.platforms_Tick);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainGame";
            this.Text = "Get Down!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer playerTick;
        private System.Windows.Forms.PictureBox platL;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.PictureBox platR;
        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.Timer fallCheck;
        private System.Windows.Forms.Timer platchr;
        private System.Windows.Forms.Timer platforms;
        private System.Windows.Forms.PictureBox platM;
    }
}

