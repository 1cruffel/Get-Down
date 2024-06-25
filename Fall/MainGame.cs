using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fall
{
    public partial class MainGame : Form
    { 
        bool right, left, jump, rising = false;
        Random random = new Random();
        Random random1 = new Random();
        int G = 10, Force;
        int speed = 1, x, diff = 80;
        int total, notTouching;
        const int HEIGHT = 10;
        bool falling;
        string skin;
        string[] playerInfo;

        private void platchr_Tick(object sender, EventArgs e)
        {
            total = 0;
            notTouching = 0;
            foreach (Control x in screen.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform" || (string)x.Tag == "risingPlatform")
                    {
                        if (!(player.Bounds.IntersectsWith(x.Bounds)))
                        {
                            
                        }
                        else
                        {
                            notTouching += 1;
                            jump = false;
                            Force = 0;
                            player.Top = x.Top - player.Height - 1;
                        }

                    }
                }
            }
            if (total == notTouching && !jump)
            {
                fallCheck.Start();
            }
            else
            {
                fallCheck.Stop();
            }

        }

        private void platforms_Tick(object sender, EventArgs e)
        {

        }

        private void fallCheck_Tick(object sender, EventArgs e)
        {
            player.Top += 7;
        }

        
        public MainGame()
        {
            InitializeComponent();
            string line;
            using (StreamReader reader = new StreamReader("../../../values.csv"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    playerInfo = line.Split(',');
                    //change to input usernames
                    if (playerInfo[0] == "charlie")
                    {
                        skin = playerInfo[1];
                    }
                   

                }
            }

            player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            foreach (Control x in screen.Controls)
                {
                    if (x is PictureBox)
                    {
                        if ((string)x.Tag == "risingPlatform")
                        {
                            x.BackgroundImage = new Bitmap("../../../textures/platform.png");
                        }
                    }
                }
        }
        private void gameTick_Tick(object sender, EventArgs e)
        {
            //check when platform set 1 reaches top
            if(platL.Top <= 0)
            {
                platL.Top = screen.Height;
                platR.Top = screen.Height;
                platL.Width = random.Next(0, ((screen.Width / 2) - diff));                                
                random.Next(1,1);
                platR.Width = random1.Next(0, ((screen.Width / 2) - diff));                
                platL.Left = 0;
                platM.Width = screen.Width - (platR.Width + platL.Width + (diff * 2));
                platM.Left = platL.Width + diff;
                platR.Width = screen.Width - (platM.Left + platM.Width + diff);
                platR.Left = platM.Width + platM.Right + diff;
            }
                platL.Top -= speed;
                platR.Top = platL.Top;
                platM.Top = platL.Top;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && player.Left + player.Width < screen.Width) { right = true; }
            else if(player.Left + player.Width >= screen.Width){ right = false; }
            if(e.KeyCode == Keys.Left && player.Left > floor.Left) { left = true; }
            else if (player.Left <= 0) { left = false; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (jump != true)
            {
                if (e.KeyCode == Keys.Up) 
                     { 
                       jump = true;
                       Force = G;         
                     }
            }
            
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            { right = false; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png"); }
            if (e.KeyCode == Keys.Left) { left = false; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //left collision
            if (player.Left == platL.Width && player.Right < platL.Right - player.Width / 2 && player.Bottom > platL.Top && player.Top < platL.Bottom)
            {
                left = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }
            //right collision
            if (player.Right == platR.Width && player.Left < platR.Left - player.Width / 2 && player.Bottom > platR.Top && player.Top < platR.Bottom)
            {
                right = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }
           
            //gravity
            if (right == true) {player.Left += 5; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "1.png"); }
            if (left == true) { player.Left -= 5; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "2.png"); }
            if (jump == true)
            {
                player.Top -= Force;
                Force -= 1;
            }
            if (player.Right < 0)
            {
                right = false;
            }
            if (player.Left < 0)
            {
                left = false;
            }
            if (rising)
            {
                Force = 0;
                jump = false;
                player.Top -= speed;
            }
        }
    }
}
