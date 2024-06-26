﻿namespace Fall
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
            this.question1 = new System.Windows.Forms.Label();
            this.platWrong = new System.Windows.Forms.PictureBox();
            this.platCorrect = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.platR = new System.Windows.Forms.PictureBox();
            this.platL = new System.Windows.Forms.PictureBox();
            this.platM = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playerTick = new System.Windows.Forms.Timer(this.components);
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.fallCheck = new System.Windows.Forms.Timer(this.components);
            this.platchr = new System.Windows.Forms.Timer(this.components);
            this.platforms = new System.Windows.Forms.Timer(this.components);
            this.correctAns = new System.Windows.Forms.Label();
            this.wrongAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.platWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platM)).BeginInit();
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
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(1244, 596);
            this.screen.TabIndex = 1;
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Font = new System.Drawing.Font("OCR A Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1.Location = new System.Drawing.Point(490, 401);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(37, 12);
            this.question1.TabIndex = 7;
            this.question1.Text = "12+3";
            this.question1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // platWrong
            // 
            this.platWrong.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platWrong.Location = new System.Drawing.Point(845, 391);
            this.platWrong.Name = "platWrong";
            this.platWrong.Size = new System.Drawing.Size(118, 32);
            this.platWrong.TabIndex = 6;
            this.platWrong.TabStop = false;
            this.platWrong.Tag = "platform";
            // 
            // platCorrect
            // 
            this.platCorrect.BackColor = System.Drawing.SystemColors.ControlDark;
            this.platCorrect.Location = new System.Drawing.Point(242, 391);
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
            this.platR.Location = new System.Drawing.Point(960, 391);
            this.platR.Name = "platR";
            this.platR.Size = new System.Drawing.Size(283, 32);
            this.platR.TabIndex = 2;
            this.platR.TabStop = false;
            this.platR.Tag = "risingPlatform";
            // 
            // platL
            // 
            this.platL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platL.Location = new System.Drawing.Point(0, 391);
            this.platL.Name = "platL";
            this.platL.Size = new System.Drawing.Size(251, 32);
            this.platL.TabIndex = 1;
            this.platL.TabStop = false;
            this.platL.Tag = "risingPlatform";
            // 
            // platM
            // 
            this.platM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.platM.Location = new System.Drawing.Point(357, 391);
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
            // correctAns
            // 
            this.correctAns.AutoSize = true;
            this.correctAns.Font = new System.Drawing.Font("OCR A Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAns.Location = new System.Drawing.Point(281, 401);
            this.correctAns.Name = "correctAns";
            this.correctAns.Size = new System.Drawing.Size(37, 12);
            this.correctAns.TabIndex = 8;
            this.correctAns.Text = "12+3";
            this.correctAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // wrongAns
            // 
            this.wrongAns.AutoSize = true;
            this.wrongAns.Font = new System.Drawing.Font("OCR A Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongAns.Location = new System.Drawing.Point(883, 401);
            this.wrongAns.Name = "wrongAns";
            this.wrongAns.Size = new System.Drawing.Size(37, 12);
            this.wrongAns.TabIndex = 9;
            this.wrongAns.Text = "12+3";
            this.wrongAns.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 596);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}

