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
    public class Start : Form
    {
        private PictureBox skin;
        private PictureBox buttonStart;
        private PictureBox buttonLoad;
        private TextBox textBoxUsername;
        private Label label1;
        private Label labelUser;
        private PictureBox title;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox buttonShop;
        string user;
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.buttonLoad = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.PictureBox();
            this.skin = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonShop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShop)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(585, 366);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(64, 32);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.TabStop = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click_1);
            this.buttonLoad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLoad_MouseDown);
            this.buttonLoad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLoad_MouseUp);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(325, 366);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(64, 32);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.TabStop = false;
            this.buttonStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown);
            this.buttonStart.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave);
            this.buttonStart.MouseHover += new System.EventHandler(this.buttonStart_MouseHover);
            this.buttonStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseUp);
            // 
            // skin
            // 
            this.skin.Location = new System.Drawing.Point(483, 221);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(64, 64);
            this.skin.TabIndex = 1;
            this.skin.TabStop = false;
            this.skin.Click += new System.EventHandler(this.skin_Click);
            // 
            // title
            // 
            this.title.BackgroundImage = global::Fall.Properties.Resources.platform;
            this.title.Image = global::Fall.Properties.Resources.title1;
            this.title.Location = new System.Drawing.Point(235, 73);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(512, 256);
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(568, 404);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.Text = "Username";
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            this.textBoxUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged in as: ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(84, 13);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(42, 13);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "No one";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Money:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "High Score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // buttonShop
            // 
            this.buttonShop.Location = new System.Drawing.Point(457, 439);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(64, 32);
            this.buttonShop.TabIndex = 11;
            this.buttonShop.TabStop = false;
            this.buttonShop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShop_MouseDown);
            this.buttonShop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShop_MouseUp);
            // 
            // Start
            // 
            this.ClientSize = new System.Drawing.Size(983, 564);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.skin);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        public Start()
        {
            InitializeComponent();
            title.BackgroundImage = new Bitmap("../../../textures/platform.png");
            title.Image = new Bitmap("../../../textures/title.png");
            skin.BackgroundImage = new Bitmap("../../../skins/large/default.png");
            buttonStart.BackgroundImage = new Bitmap("../../../startscreen/buttons/start.png");
            buttonLoad.BackgroundImage = new Bitmap("../../../startscreen/buttons/load.png");
            buttonShop.BackgroundImage = new Bitmap("../../../startscreen/buttons/shop0.png");
            using (StreamReader reader = new StreamReader("../../../currentuser.txt"))
            {
                user = reader.ReadLine();
            }
            labelUser.Text = user;
            using (StreamReader reader = new StreamReader("../../../values.csv"))
            {
                string line;
                string[] playerInfo;
                while ((line = reader.ReadLine()) != null)
                {
                    playerInfo = line.Split(',');
                    //change to input usernames
                    if (playerInfo[0] == user)
                    {

                        string userSkin = playerInfo[1];
                        label3.Text = playerInfo[3];
                        label5.Text = playerInfo[2];
                        skin.BackgroundImage = new Bitmap("../../../skins/large/" + userSkin + ".png");
                    }
                }
            }
        }

        private void skin_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            buttonLoad.BackgroundImage = new Bitmap("../../../startscreen/buttons/loadClick.png");
        }

        private void buttonLoad_MouseUp(object sender, MouseEventArgs e)
        {
            buttonLoad.BackgroundImage = new Bitmap("../../../startscreen/buttons/load.png");
            user = textBoxUsername.Text;
            if (user == "user")
            {

            }
            else
            {
                using (StreamWriter txt = new StreamWriter("../../../currentuser.txt"))
                {
                    txt.WriteLine(user);
                }
                bool newPlayer = true;
                List<string> users = new List<string>();
                using (StreamReader reader = new StreamReader("../../../values.csv"))
                {
                    string line;
                    string[] playerInfo;                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        users.Add(line);
                        playerInfo = line.Split(',');
                        //change to input usernames
                        if (playerInfo[0] == user)
                        {
                            newPlayer = false;
                            string userSkin = playerInfo[1];
                            label3.Text = playerInfo[3];
                            label5.Text = playerInfo[2];
                            skin.BackgroundImage = new Bitmap("../../../skins/large/" + userSkin + ".png");
                        }
                    }                    
                }
                if (newPlayer)
                    {
                        using (StreamWriter csv = new StreamWriter("../../../values.csv"))
                        {
                            foreach(string x in users)
                            {
                                csv.WriteLine(x);
                            }

                            csv.Write(user + ",default,0,0,1");
                            int skins = users[0].Split(',').Length - 5;
                            for (int i = 0; i < skins; i++) 
                            {
                                csv.Write(",0");
                            }
                            
                        }
                    }
            }
            labelUser.Text = user;
        }

        private void buttonLoad_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLoad.BackgroundImage = new Bitmap("../../../startscreen/buttons/loadClick.png");
        }

        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (user == null)
            {

            }
            else { buttonStart.BackgroundImage = new Bitmap("../../../startscreen/buttons/startClick.png"); }
        }

        private void buttonStart_MouseHover(object sender, EventArgs e)
        {
            if (user == null)
            {
                buttonStart.BackgroundImage = new Bitmap("../../../startscreen/buttons/startNo.png");
            }
            else { }
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = new Bitmap("../../../startscreen/buttons/start.png");
        }

        private void buttonStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (user == null)
            {

            }
            else
            {
                buttonStart.BackgroundImage = new Bitmap("../../../startscreen/buttons/start.png");
                Form play = new MainGame();
                play.Show();
                this.Hide();
            }
            
        }

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLoad_MouseDown(user, null);
            }
        }

        private void textBoxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLoad_MouseUp(user, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonLoad_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonShop_MouseDown(object sender, MouseEventArgs e)
        {
            buttonShop.BackgroundImage = new Bitmap("../../../startscreen/buttons/shop1.png");
        }

        private void buttonShop_MouseUp(object sender, MouseEventArgs e)
        {
            buttonShop.BackgroundImage = new Bitmap("../../../startscreen/buttons/shop0.png");
        }
    }
}
