using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall
{
    public partial class MainGame : Form
    { 
        bool right, left, jump, rising = false;
        int G = 10, Force;
        int speed = 1, x, diff = 80;
        int total, notTouching;
        bool falling;

        private void platchr_Tick(object sender, EventArgs e)
        {
            total = 0;
            notTouching = 0;
            foreach (Control x in screen.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
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

        private void fallCheck_Tick(object sender, EventArgs e)
        {
            player.Top += 7;
        }

        Random random = new Random();
        public MainGame()
        {
            InitializeComponent();
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            //check when platform reaches top
            if(platL.Top <= 0)
            {
                x = random.Next(0, (screen.Width - diff));
                platL.Top = screen.Height;
                platR.Top = screen.Height;
                platL.Width = x;
                platR.Width = screen.Width - (x + diff);
                platR.Left = screen.Width - platR.Width;
            }
                platL.Top -= speed;
                platR.Top = platL.Top;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
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
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //left collision
            if (player.Left == platL.Width && player.Right < platL.Right - player.Width / 2 && player.Bottom > platL.Top && player.Top < platL.Bottom)
            {
                left = false;
            }
            //right collision
            if (player.Right == platR.Width && player.Left < platR.Left - player.Width / 2 && player.Bottom > platR.Top && player.Top < platR.Bottom)
            {
                right = false;
            }
           
            //gravity
            if (right == true) {player.Left += 5; }
            if (left == true) { player.Left -= 5; }
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
            // if (player.Top + player.Height >= screen.Height)
            // {
            //
            // }
            // else if(player.Top + player.Height < platL.Top && player.Top + player.Height > platL.Top - 5)
            // {
            //     if (player.Left < platL.Width || player.Right < platR.Width)
            //     {
            //         Force = 0;
            //         jump = false;
            //         rising = true;
            //     }
            //     else
            //     {
            //         player.Top += 7; //falling
            //         rising = false;
            //     }
            //
            // }
            // //else
            // {
            //     player.Top += 7; //falling
            //     rising = false;
            // }
            //
            //top collision

            if (rising)
            {
                Force = 0;
                jump = false;
                player.Top -= speed;
            }

        }
    }
}
