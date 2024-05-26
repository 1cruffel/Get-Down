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
            this.platR = new System.Windows.Forms.PictureBox();
            this.platL = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playerTick = new System.Windows.Forms.Timer(this.components);
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
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
            this.screen.Controls.Add(this.platR);
            this.screen.Controls.Add(this.platL);
            this.screen.Controls.Add(this.player);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 450);
            this.screen.TabIndex = 1;
            // 
            // platR
            // 
            this.platR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platR.Location = new System.Drawing.Point(425, 395);
            this.platR.Name = "platR";
            this.platR.Size = new System.Drawing.Size(375, 28);
            this.platR.TabIndex = 2;
            this.platR.TabStop = false;
            // 
            // platL
            // 
            this.platL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platL.Location = new System.Drawing.Point(0, 395);
            this.platL.Name = "platL";
            this.platL.Size = new System.Drawing.Size(402, 28);
            this.platL.TabIndex = 1;
            this.platL.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Black;
            this.player.Location = new System.Drawing.Point(425, 218);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(25, 25);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Get Down!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.platR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
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
    }
}

