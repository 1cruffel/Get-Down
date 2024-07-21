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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.Panel();
            this.levelTag = new System.Windows.Forms.Label();
            this.wrongAns = new System.Windows.Forms.Label();
            this.correctAns = new System.Windows.Forms.Label();
            this.question1 = new System.Windows.Forms.Label();
            this.platWrong = new System.Windows.Forms.PictureBox();
            this.platCorrect = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.platR = new System.Windows.Forms.PictureBox();
            this.platL = new System.Windows.Forms.PictureBox();
            this.platM = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.wrongAns2 = new System.Windows.Forms.Label();
            this.correctAns2 = new System.Windows.Forms.Label();
            this.question2 = new System.Windows.Forms.Label();
            this.platWrong2 = new System.Windows.Forms.PictureBox();
            this.platCorrect2 = new System.Windows.Forms.PictureBox();
            this.platR2 = new System.Windows.Forms.PictureBox();
            this.platL2 = new System.Windows.Forms.PictureBox();
            this.platM2 = new System.Windows.Forms.PictureBox();
            this.playerTick = new System.Windows.Forms.Timer(this.components);
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.fallCheck = new System.Windows.Forms.Timer(this.components);
            this.platchr = new System.Windows.Forms.Timer(this.components);
            this.platforms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platWrong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platCorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM2)).BeginInit();
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
            this.screen.Controls.Add(this.levelTag);
            this.screen.Controls.Add(this.wrongAns);
            this.screen.Controls.Add(this.correctAns);
            this.screen.Controls.Add(this.question1);
            this.screen.Controls.Add(this.platWrong);
            this.screen.Controls.Add(this.platCorrect);
            this.screen.Controls.Add(this.floor);
            this.screen.Controls.Add(this.platR);
            this.screen.Controls.Add(this.platL);
            this.screen.Controls.Add(this.platM);
            this.screen.Controls.Add(this.player);
            this.screen.Controls.Add(this.wrongAns2);
            this.screen.Controls.Add(this.correctAns2);
            this.screen.Controls.Add(this.question2);
            this.screen.Controls.Add(this.platWrong2);
            this.screen.Controls.Add(this.platCorrect2);
            this.screen.Controls.Add(this.platR2);
            this.screen.Controls.Add(this.platL2);
            this.screen.Controls.Add(this.platM2);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1244, 596);
            this.screen.TabIndex = 1;
            // 
            // levelTag
            // 
            this.levelTag.AutoSize = true;
            this.levelTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelTag.Location = new System.Drawing.Point(12, 9);
            this.levelTag.Name = "levelTag";
            this.levelTag.Size = new System.Drawing.Size(31, 13);
            this.levelTag.TabIndex = 10;
            this.levelTag.Text = "12+3";
            this.levelTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wrongAns
            // 
            this.wrongAns.AutoSize = true;
            this.wrongAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAns.Location = new System.Drawing.Point(884, 10);
            this.wrongAns.Name = "wrongAns";
            this.wrongAns.Size = new System.Drawing.Size(31, 13);
            this.wrongAns.TabIndex = 9;
            this.wrongAns.Text = "12+3";
            this.wrongAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // correctAns
            // 
            this.correctAns.AutoSize = true;
            this.correctAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAns.Location = new System.Drawing.Point(282, 10);
            this.correctAns.Name = "correctAns";
            this.correctAns.Size = new System.Drawing.Size(31, 13);
            this.correctAns.TabIndex = 8;
            this.correctAns.Text = "12+3";
            this.correctAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1.Location = new System.Drawing.Point(491, 10);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(31, 13);
            this.question1.TabIndex = 7;
            this.question1.Text = "12+3";
            this.question1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // platWrong
            // 
            this.platWrong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platWrong.Location = new System.Drawing.Point(846, 0);
            this.platWrong.Name = "platWrong";
            this.platWrong.Size = new System.Drawing.Size(118, 32);
            this.platWrong.TabIndex = 6;
            this.platWrong.TabStop = false;
            this.platWrong.Tag = "platform";
            // 
            // platCorrect
            // 
            this.platCorrect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platCorrect.Location = new System.Drawing.Point(243, 0);
            this.platCorrect.Name = "platCorrect";
            this.platCorrect.Size = new System.Drawing.Size(118, 32);
            this.platCorrect.TabIndex = 5;
            this.platCorrect.TabStop = false;
            this.platCorrect.Tag = "";
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.floor.Location = new System.Drawing.Point(-1, 568);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(1244, 28);
            this.floor.TabIndex = 3;
            this.floor.TabStop = false;
            this.floor.Tag = "platform";
            // 
            // platR
            // 
            this.platR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platR.Location = new System.Drawing.Point(961, 0);
            this.platR.Name = "platR";
            this.platR.Size = new System.Drawing.Size(283, 32);
            this.platR.TabIndex = 2;
            this.platR.TabStop = false;
            this.platR.Tag = "risingPlatform";
            // 
            // platL
            // 
            this.platL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platL.Location = new System.Drawing.Point(1, 0);
            this.platL.Name = "platL";
            this.platL.Size = new System.Drawing.Size(251, 32);
            this.platL.TabIndex = 1;
            this.platL.TabStop = false;
            this.platL.Tag = "risingPlatform";
            // 
            // platM
            // 
            this.platM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platM.Location = new System.Drawing.Point(358, 0);
            this.platM.Name = "platM";
            this.platM.Size = new System.Drawing.Size(491, 32);
            this.platM.TabIndex = 4;
            this.platM.TabStop = false;
            this.platM.Tag = "risingPlatform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(508, 250);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(32, 32);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // wrongAns2
            // 
            this.wrongAns2.AutoSize = true;
            this.wrongAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAns2.Location = new System.Drawing.Point(884, 332);
            this.wrongAns2.Name = "wrongAns2";
            this.wrongAns2.Size = new System.Drawing.Size(31, 13);
            this.wrongAns2.TabIndex = 18;
            this.wrongAns2.Text = "12+3";
            this.wrongAns2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // correctAns2
            // 
            this.correctAns2.AutoSize = true;
            this.correctAns2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAns2.Location = new System.Drawing.Point(282, 332);
            this.correctAns2.Name = "correctAns2";
            this.correctAns2.Size = new System.Drawing.Size(31, 13);
            this.correctAns2.TabIndex = 17;
            this.correctAns2.Text = "12+3";
            this.correctAns2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2.Location = new System.Drawing.Point(491, 332);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(31, 13);
            this.question2.TabIndex = 16;
            this.question2.Text = "12+3";
            this.question2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // platWrong2
            // 
            this.platWrong2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platWrong2.Location = new System.Drawing.Point(846, 322);
            this.platWrong2.Name = "platWrong2";
            this.platWrong2.Size = new System.Drawing.Size(118, 32);
            this.platWrong2.TabIndex = 15;
            this.platWrong2.TabStop = false;
            this.platWrong2.Tag = "platform";
            // 
            // platCorrect2
            // 
            this.platCorrect2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platCorrect2.Location = new System.Drawing.Point(243, 322);
            this.platCorrect2.Name = "platCorrect2";
            this.platCorrect2.Size = new System.Drawing.Size(118, 32);
            this.platCorrect2.TabIndex = 14;
            this.platCorrect2.TabStop = false;
            this.platCorrect2.Tag = "";
            // 
            // platR2
            // 
            this.platR2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platR2.Location = new System.Drawing.Point(961, 322);
            this.platR2.Name = "platR2";
            this.platR2.Size = new System.Drawing.Size(283, 32);
            this.platR2.TabIndex = 12;
            this.platR2.TabStop = false;
            this.platR2.Tag = "risingPlatform";
            // 
            // platL2
            // 
            this.platL2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platL2.Location = new System.Drawing.Point(1, 322);
            this.platL2.Name = "platL2";
            this.platL2.Size = new System.Drawing.Size(251, 32);
            this.platL2.TabIndex = 11;
            this.platL2.TabStop = false;
            this.platL2.Tag = "risingPlatform";
            // 
            // platM2
            // 
            this.platM2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platM2.Location = new System.Drawing.Point(358, 322);
            this.platM2.Name = "platM2";
            this.platM2.Size = new System.Drawing.Size(491, 32);
            this.platM2.TabIndex = 13;
            this.platM2.TabStop = false;
            this.platM2.Tag = "risingPlatform";
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
            this.gameTick.Interval = 2;
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
            this.ClientSize = new System.Drawing.Size(1244, 596);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainGame";
            this.Text = "Get Down!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platWrong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platCorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM2)).EndInit();
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
        private System.Windows.Forms.PictureBox platWrong;
        private System.Windows.Forms.PictureBox platCorrect;
        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.Label wrongAns;
        private System.Windows.Forms.Label correctAns;
        private System.Windows.Forms.Label levelTag;
        private System.Windows.Forms.Label wrongAns2;
        private System.Windows.Forms.Label correctAns2;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.PictureBox platWrong2;
        private System.Windows.Forms.PictureBox platCorrect2;
        private System.Windows.Forms.PictureBox platR2;
        private System.Windows.Forms.PictureBox platL2;
        private System.Windows.Forms.PictureBox platM2;
    }
}

