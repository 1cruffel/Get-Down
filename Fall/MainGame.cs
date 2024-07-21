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
        int speed = 2, x, diff = 80;
        int playerspeed = 7;
        int total, notTouching;
        string skin;
        string user;
        int score = 0;
        int level = 0;
        string[] playerInfo;
        bool answered1 = false, answered2 = false;

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
                            // Do nothing if not intersecting
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
            // Platform update logic if needed
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
            levelTag.Text = $"Questions Answered: {level}";
        }

        private async void gameTick_Tick(object sender, EventArgs e)
        {
            // Check when platform set 1 reaches top
            if (platL.Top <= 0 - platL.Height)
            {
                answered1 = false;
                Random leftOrRight1 = new Random();
                Random questions1 = new Random();
                int num1, num2;
                Random questions2 = new Random();
                platL.Top = screen.Height;
                platR.Top = screen.Height;
                platM.Top = screen.Height;
                platL.Width = random.Next(diff, (screen.Width / 3));
                platR.Width = random1.Next(diff, (screen.Width / 3));
                platL.Left = 0;
                platM.Width = screen.Width - (platR.Width + platL.Width + (diff * 2));
                platM.Left = platL.Width + diff;
                platR.Left = screen.Width - platR.Width;
                platCorrect.Width = diff;
                platWrong.Width = diff;

                if (level < 6)
                {
                    num1 = questions1.Next(0, 11);
                    num2 = num1 - questions2.Next(-11 + num1, num1 - 1);
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
                else if (level < 11)
                {
                    num1 = questions1.Next(0, 21);
                    num2 = num1 - questions2.Next(-21 + num1, num1 - 1);
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
                else if (level < 16)
                {
                    num1 = questions1.Next(0, 11);
                    num2 = num1 - questions2.Next(-11 + num1, num1 - 1);
                    question1.Text = $"{num1} - {num2} = ?";
                    int ans1 = num1 - num2;
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
                else if (level < 21)
                {
                    speed = 3;
                    num1 = questions1.Next(0, 6);
                    num2 = num1 - questions2.Next(-6 + num1, num1 - 1);
                    question1.Text = $"{num1} x {num2} = ?";
                    int ans1 = num1 * num2;
                    correctAns.Text = ans1.ToString();
                    int fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    while (fake == ans1)
                    {
                        fake = questions1.Next(num1 - 2, num1 + 3) * num2;
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
                else
                {
                    speed = 5;
                    num1 = questions1.Next(0, 13);
                    num2 = num1 - questions2.Next(-13 + num1, num1 - 1);
                    question1.Text = $"{num1} x {num2} = ?";
                    int ans1 = num1 * num2;
                    correctAns.Text = ans1.ToString();
                    int fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    while (fake == ans1)
                    {
                        fake = questions1.Next(num1 - 2, num1 + 3) * num2;
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
                correctAns.Left = platCorrect.Left + ((platCorrect.Width - correctAns.Width) / 2);
                wrongAns.Left = platWrong.Left + ((platWrong.Width - wrongAns.Width) / 2);
                question1.Left = platM.Left + (((platM.Width - question1.Width) / 2));
            }

            
            if (player.Bounds.IntersectsWith(platWrong.Bounds))
            {
                playerspeed = 1;
            }
            else
            {
                playerspeed = 8;
            }
            if (player.Bounds.IntersectsWith(platCorrect.Bounds) && !answered1)
            {
                level += 1;
                levelTag.Text = $"Questions Answered: {level}";
                answered1 = true;
            }
            if (player.Bottom > screen.Height)
            {
                player.Top = screen.Height - player.Height; // Place player on the ground
                jump = false; // Stop jumping if hitting the bottom
                Force = 0;
            }


            // Check when platform set 2 reaches top
            if (platL2.Top <= 0 - platL2.Height)
            {
                answered2 = false;
                Random leftOrRight2 = new Random();
                Random questions1 = new Random();
                Random questions2 = new Random();
                int num1, num2;

                platL2.Top = screen.Height;
                platR2.Top = screen.Height;
                platM2.Top = screen.Height;
                platL2.Width = random.Next(diff, (screen.Width / 3));
                platR2.Width = random1.Next(diff, (screen.Width / 3));
                platL2.Left = 0;
                platM2.Width = screen.Width - (platR2.Width + platL2.Width + (diff * 2));
                platM2.Left = platL2.Width + diff;
                platR2.Left = screen.Width - platR2.Width;
                platCorrect2.Width = diff;
                platWrong2.Width = diff;

                if (level < 6)
                {
                    num1 = questions1.Next(0, 11);
                    num2 = num1 - questions2.Next( -11 + num1, num1 - 1);
                    question2.Text = $"{num1} + {num2} = ?";
                    int ans2 = num1 + num2;
                    correctAns2.Text = ans2.ToString();
                    int fake = questions1.Next(ans2 - 2, ans2 + 3);
                    while (fake == ans2)
                    {
                        fake = questions1.Next(ans2 - 2, ans2 + 3);
                    }
                    wrongAns2.Text = fake.ToString();
                    int LR = leftOrRight2.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect2.Left = platL2.Width;
                        platWrong2.Left = platM2.Width + platM2.Left;
                    }
                    else
                    {
                        platCorrect2.Left = platM2.Width + platM2.Left;
                        platWrong2.Left = platL2.Width;
                    }
                }
                else if (level < 11)
                {
                    num1 = questions1.Next(0, 21);
                    num2 = num1 - questions2.Next(-21 + num1, num1 - 1);
                    question2.Text = $"{num1} + {num2} = ?";
                    int ans2 = num1 + num2;
                    correctAns2.Text = ans2.ToString();
                    int fake = questions1.Next(ans2 - 2, ans2 + 3);
                    while (fake == ans2)
                    {
                        fake = questions1.Next(ans2 - 2, ans2 + 3);
                    }
                    wrongAns2.Text = fake.ToString();
                    int LR = leftOrRight2.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect2.Left = platL2.Width;
                        platWrong2.Left = platM2.Width + platM2.Left;
                    }
                    else
                    {
                        platCorrect2.Left = platM2.Width + platM2.Left;
                        platWrong2.Left = platL2.Width;
                    }
                }
                else if (level < 16)
                {
                    num1 = questions1.Next(0, 11);
                    num2 = num1 - questions2.Next(-9 + num1, num1 - 1);
                    question2.Text = $"{num1} - {num2} = ?";
                    int ans2 = num1 - num2;
                    correctAns2.Text = ans2.ToString();
                    int fake = questions1.Next(ans2 - 2, ans2 + 3);
                    while (fake == ans2)
                    {
                        fake = questions1.Next(ans2 - 2, ans2 + 3);
                    }
                    wrongAns2.Text = fake.ToString();
                    int LR = leftOrRight2.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect2.Left = platL2.Width;
                        platWrong2.Left = platM2.Width + platM2.Left;
                    }
                    else
                    {
                        platCorrect2.Left = platM2.Width + platM2.Left;
                        platWrong2.Left = platL2.Width;
                    }
                }
                else if (level < 21)
                {
                    num1 = questions1.Next(0, 6);
                    num2 = num1 - questions2.Next(-6 + num1, num1 - 1);
                    question2.Text = $"{num1} x {num2} = ?";
                    int ans2 = num1 * num2;
                    correctAns2.Text = ans2.ToString();
                    int fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    while (fake == ans2)
                    {
                        fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    }
                    wrongAns2.Text = fake.ToString();
                    int LR = leftOrRight2.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect2.Left = platL2.Width;
                        platWrong2.Left = platM2.Width + platM2.Left;
                    }
                    else
                    {
                        platCorrect2.Left = platM2.Width + platM2.Left;
                        platWrong2.Left = platL2.Width;
                    }
                }
                else
                {
                    num1 = questions1.Next(0, 13);
                    num2 = num1 - questions2.Next(-13 + num1, num1 - 1);
                    question2.Text = $"{num1} x {num2} = ?";
                    int ans2 = num1 * num2;
                    correctAns2.Text = ans2.ToString();
                    int fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    while (fake == ans2)
                    {
                        fake = questions1.Next(num1 - 2, num1 + 3) * num2;
                    }
                    wrongAns2.Text = fake.ToString();
                    int LR = leftOrRight2.Next(0, 2);
                    if (LR == 0)
                    {
                        platCorrect2.Left = platL2.Width;
                        platWrong2.Left = platM2.Width + platM2.Left;
                    }
                    else
                    {
                        platCorrect2.Left = platM2.Width + platM2.Left;
                        platWrong2.Left = platL2.Width;
                    }
                }
                question2.Left = platM2.Left + (((platM2.Width - question2.Width) / 2));
                correctAns2.Left = platCorrect2.Left + ((platCorrect2.Width - correctAns2.Width) / 2);
                wrongAns2.Left = platWrong2.Left + ((platWrong2.Width - wrongAns2.Width) / 2);
            }

            

            if (player.Bounds.IntersectsWith(platWrong2.Bounds))
            {
                playerspeed = 1;
            }
            else
            {
                playerspeed = 8;
            }
            if (player.Bounds.IntersectsWith(platCorrect2.Bounds) && !answered2)
            {
                level += 1;
                levelTag.Text = $"Questions Answered: {level}";
                answered2 = true;
            }
            if (player.Bottom > screen.Height - floor.Height)
            {
                player.Top = screen.Height - player.Height; // Place player on the ground
                jump = false; // Stop jumping if hitting the bottom
                Force = 0;
            }

            Rise1();
            Rise2();
            if (player.Top <= 0)
            {
                GameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && player.Right < screen.Width)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (!jump)
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
            {
                right = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Handle left movement
            if (left)
            {
                player.Left -= playerspeed;
                if (player.Left < 0)
                {
                    player.Left = 0; // Prevent player from moving out of bounds
                }
            }

            // Handle right movement
            if (right)
            {
                player.Left += playerspeed;
                if (player.Right > screen.Width)
                {
                    player.Left = screen.Width - player.Width; // Prevent player from moving out of bounds
                }
            }

            // Handle gravity and jumping
            if (jump)
            {
                player.Top -= Force;
                Force -= 1;
                if (player.Top < 0)
                {
                    player.Top = 0; // Prevent player from moving above the screen
                }
            }

            // Additional collision and boundary checks
            if (player.Bottom > screen.Height)
            {
                player.Top = screen.Height - player.Height; // Place player on the ground
                jump = false; // Stop jumping if hitting the bottom
                Force = 0;
            }

            // Left collision
            if (player.Left < platL.Right && player.Right > platL.Left && player.Bottom > platL.Top && player.Top < platL.Bottom)
            {
                left = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }

            // Right collision
            if (player.Right > platR.Left && player.Left < platR.Right && player.Bottom > platR.Top && player.Top < platR.Bottom)
            {
                right = false;
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "0.png");
            }

            // Update player image based on movement
            if (right)
            {
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "1.png");
            }
            if (left)
            {
                player.BackgroundImage = new Bitmap("../../../skins/" + skin + "2.png");
            }
        }
        private void Rise1(){
            platL.Top -= speed;
            platR.Top = platL.Top;
            platM.Top = platL.Top;
            platCorrect.Top = platL.Top;
            platWrong.Top = platL.Top;
            wrongAns.Top = platL.Top + 10;
            correctAns.Top = platL.Top + 10;
            question1.Top = platL.Top + 10;
        }

        private void Rise2(){
            platL2.Top -= speed;
            platR2.Top = platL2.Top;
            platM2.Top = platL2.Top;
            platCorrect2.Top = platL2.Top;
            platWrong2.Top = platL2.Top;
            wrongAns2.Top = platL2.Top + 10;
            correctAns2.Top = platL2.Top + 10;
            question2.Top = platL2.Top + 10;
        }
        private void GameOver()
        {
            List<string> users = new List<string>();
            List<string> oldInfo = new List<string>();
            int lines = 0, lineNo;
            string[] playerInfo, currInfo;
            string playersInfo = "";
            using (StreamReader reader = new StreamReader("../../../values.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines++;
                    playerInfo = line.Split(',');
                    //change to input usernames
                    if (playerInfo[0] == user)
                    {
                        lineNo = lines;
                        currInfo = line.Split(',');
                        foreach (string s in currInfo)
                        {
                            oldInfo.Add(s);
                        }
                        if (int.Parse(oldInfo[2]) < level)
                        {
                            oldInfo[2] = level.ToString();
                        }
                        
                        oldInfo[3] = (int.Parse(currInfo[3]) + level).ToString();
                        foreach (string x in oldInfo)
                        {
                            playersInfo = $"{playersInfo}{x},";
                        }
                        users.Add(playersInfo);
                    }
                    else
                    {
                        users.Add(line);
                    }
                }
            }
            using (StreamWriter csv = new StreamWriter("../../../values.csv"))
            {
                foreach (string x in users)
                {
                    csv.WriteLine(x);
                }
            }
            Form Start = new Start();
            Start.Show();
            this.Close();
        }
    }
}
