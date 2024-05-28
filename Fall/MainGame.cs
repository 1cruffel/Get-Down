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
        int G = 20, Force;
        int speed = 1, x, diff = 80;
        Random random = new Random();
        public MainGame()
        {
            InitializeComponent();
            x = random.Next(0, (screen.Width - diff));
            platL.Top = screen.Height;
            platR.Top = screen.Height;
            platL.Width = x;
            platR.Width = screen.Width - (x + diff);
            platR.Left = screen.Width - (x + diff);
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
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
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height; //stop falling at bottom
                jump = false;
            }
            else if(player.Top + player.Height < platL.Top && player.Top + player.Height > platL.Top - 5)
            //else if (player.Bottom < platL.Bottom + platL.Height && player.Left < platL.Width && player.Bottom < platL.Bottom + platL.Height + 5)
            {
                if (player.Left < platL.Width || player.Right < platR.Width)
                {
                    Force = 0;
                    jump = false;
                    rising = true;
                }
                else
                {
                    player.Top += 7; //falling
                    rising = false;
                }

            }
            //else if (player.Bottom < platR.Bottom + platR.Height && player.Right < platR.Width && player.Bottom < platR.Bottom + platR.Height + 5)
           // {
           //     Force = 0;
           //     jump = false;
           //     rising = true;
           // }
            else
            {
                player.Top += 7; //falling
                rising = false;
            }
            if (player.Left + player.Width <= 0)
            {
                player.Left = screen.Width - 1;
            }
            if (player.Left >= screen.Width)
            {
                player.Left = 1;
            }

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
