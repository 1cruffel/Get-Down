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
        int playerspeed = 7;
        int total, notTouching;
        string skin;
        string user;
        int level = 0;
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
            using (StreamReader txt = new StreamReader("../../../currentuser.txt"))
            {
                user = txt.ReadLine();
            }
            using (StreamReader reader = new StreamReader("../../../values.csv"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    playerInfo = line.Split(',');
                    //change to input usernames
                    if (playerInfo[0] == user)
                    {
                        skin = playerInfo[1];
                    }


                }
            }

            player.BackgroundImage = new Bitmap($"../../../skins/{skin}0.png");
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
            Random leftOrRight1 = new Random();
            Random questions1 = new Random();
            int num1, num2;
            Random questions2 = new Random();
            num1 = questions1.Next(0, 11);
            num2 = questions2.Next(0, 11);
            question1.Text = $"{num1} + {num2} = ?";
            int ans1 = num1 + num2;
            correctAns.Text = ans1.ToString();
            wrongAns.Text = questions1.Next(1, 21).ToString();
            int LR = leftOrRight1.Next(0, 2);
            if (LR == 0)
            {
                platCorrect.Left = platL.Width;
                platWrong.Left = platM.Width + platM.Left;
            }
            else
            {
                platCorrect.Left = platM.Width + platM.Left;
                platWrong.Left = platL.Width;
            }
        }
        private void gameTick_Tick(object sender, EventArgs e)
        {
            //check when platform set 1 reaches top
            if(platL.Top <= 0)
            {
                Random leftOrRight1 = new Random();
                Random questions1 = new Random();
                int num1, num2;
                Random questions2 = new Random();
                platL.Top = screen.Height;
                platR.Top = screen.Height;
                platM.Top = screen.Height;
                platL.Width = random.Next(0, ((screen.Width / 2) - diff));                                
                random.Next(1,1);
                platR.Width = random1.Next(0, ((screen.Width / 2) - diff));                
                platL.Left = 0;
                platM.Width = screen.Width - (platR.Width + platL.Width + (diff * 2));
                platM.Left = platL.Width + diff;
                platR.Left = screen.Width - platR.Width;
                platCorrect.Width = diff;
                platWrong.Width = diff;
                if(level < 10)
                {
                    num1 = questions1.Next(0, 11);
                    num2 = questions2.Next(0, 11);
                    question1.Text = $"{num1} + {num2} = ?";
                    int ans1 = num1 + num2;
                    correctAns.Text = ans1.ToString();
                    int fake = questions1.Next(ans1 - 2, ans1 + 3);
                    while (fake == ans1)
                    {
                        fake = questions1.Next(ans1 - 2, ans1 + 3);
                    }
                    wrongAns.Text = fake.ToString();
                    int LR = leftOrRight1.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect.Left = platL.Width;
                        platWrong.Left = platM.Width + platM.Left;
                    }
                    else
                    {
                        platCorrect.Left = platM.Width + platM.Left;
                        platWrong.Left = platL.Width;
                    }
                }
            }
                
            platL.Top -= speed;
            platR.Top = platL.Top;
            platM.Top = platL.Top;
            platCorrect.Top = platL.Top;
            platWrong.Top = platL.Top;
            wrongAns.Top = platL.Top + 10;
            correctAns.Top = platL.Top + 10;
            correctAns.Left = platCorrect.Left + ((platCorrect.Width - correctAns.Width) / 2);
            wrongAns.Left = platWrong.Left + ((platWrong.Width - wrongAns.Width) / 2);
            question1.Top = platL.Top + 10;
            question1.Left = platM.Left + (((platM.Width - question1.Width) / 2));
            if (player.Bounds.IntersectsWith(platWrong.Bounds))
            {
                playerspeed = 1;
            }
            else
            {
                playerspeed = 8;
            }
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
            if (right == true) {player.Left += playerspeed; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "1.png"); }
            if (left == true) { player.Left -= playerspeed; player.BackgroundImage = new Bitmap("../../../skins/" + skin + "2.png"); }
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
