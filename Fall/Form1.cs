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
    public partial class Form1 : Form
    { 
        bool right, left, jump;
        int G = 20, Force;
        int speed = 1, x, diff = 10;
        Random random = new Random();
        public Form1()
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
                platR.Left = screen.Width - (x + diff);
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
            else
            {
                player.Top += 7; //falling
            }
            if (player.Left + player.Width <= 0)
            {
                player.Left = screen.Width - 1;
            }
            if (player.Left >= screen.Width)
            {
                player.Left = 1;
            }
        }
    }
}
