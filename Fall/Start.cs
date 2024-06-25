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
    public partial class Start : Form
    {
        private PictureBox skin;
        private PictureBox title;

        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.PictureBox();
            this.skin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackgroundImage = global::Fall.Properties.Resources.title;
            this.title.Location = new System.Drawing.Point(207, 97);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(256, 128);
            this.title.TabIndex = 0;
            this.title.TabStop = false;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // skin
            // 
            this.skin.Location = new System.Drawing.Point(331, 171);
            this.skin.Name = "skin";
            this.skin.Size = new System.Drawing.Size(32, 32);
            this.skin.TabIndex = 1;
            this.skin.TabStop = false;
            // 
            // Start
            // 
            this.ClientSize = new System.Drawing.Size(678, 396);
            this.Controls.Add(this.skin);
            this.Controls.Add(this.title);
            this.Name = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skin)).EndInit();
            this.ResumeLayout(false);

        }

        private void title_Click(object sender, EventArgs e)
        {

        }
        public Start()
        {
            InitializeComponent();
            title.BackgroundImage = new Bitmap("../../../textures/title.png");
            skin.BackgroundImage = new Bitmap("../../../skins/default0.png");
        }
    }
}
