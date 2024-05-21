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
        bool right, left;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right) { right = true; }
            if(e.KeyCode == Keys.Left) { left = true; }
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
        }
    }
}
