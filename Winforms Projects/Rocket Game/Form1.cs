using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rocket_Game.Properties;

namespace Rocket_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<PictureBox> listRocket = new List<PictureBox>();
        public List<PictureBox> listBullet = new List<PictureBox>();
        public List<PictureBox> listHeart = new List<PictureBox>();
        public PictureBox rocket = new PictureBox();
        public PictureBox jet = new PictureBox();
        public System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Resources.bomb_small);
        Random rand = new Random();
        int direction = 0;
        int score = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set jet
            jet.Image = Resources.jet2;
            jet.SizeMode = PictureBoxSizeMode.StretchImage;
            jet.Width = jet.Image.Width;
            jet.Height = jet.Image.Height;
            int x = this.Width / 2 - jet.Width / 2;
            int y = this.Height - jet.Image.Height - 10;
            jet.Location = new Point(x, y);
            this.Controls.Add(jet);

            //Set health
            for (int i = 0; i < 3; i++)
            {
                PictureBox heart = new PictureBox();
                heart.Image = Resources.hearth;
                heart.SizeMode = PictureBoxSizeMode.StretchImage;
                heart.Width = heart.Image.Width;
                heart.Height = heart.Image.Height;
                listHeart.Add(heart);
                this.Controls.Add(heart);
            }

            ShowHealth();

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listRocket.Add(CreateRocket(++direction));
        }

        private PictureBox CreateRocket(int direction)
        {
            PictureBox rocket = new PictureBox();
            rocket.Image = Resources.rocket;
            rocket.SizeMode = PictureBoxSizeMode.StretchImage;
            rocket.Width = rocket.Image.Width;
            rocket.Height = rocket.Image.Height;
            int boundary = this.Width - rocket.Width;      
            int x, y = 0;

            if (direction % 2 == 0) { x = rand.Next(0, this.Width/2); }
            else { x = rand.Next(this.Width/2, boundary); }
            rocket.Location = new Point(x, y);
            this.Controls.Add(rocket);

            return rocket;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            PictureBox rmRocket = null;

            foreach (var rocket in listRocket)
            {
                int x = rocket.Location.X;
                int y = rocket.Location.Y;
                rocket.Location = new Point(x, y + 10);

                if (rocket.Location.Y > this.Height)
                {
                    if (listHeart.Count == 0) 
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        timer4.Enabled = false;

                        this.MouseMove -= Form1_MouseMove;
                        this.MouseDown -= Form1_MouseDown;

                        foreach (var rkt in listRocket)
                        {
                            this.Controls.Remove(rkt);
                        }

                        foreach (var blt in listBullet)
                        {
                            this.Controls.Remove(blt);
                        }

                        Label dialog = new Label();
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Game Over !\n\n");
                        sb.Append($"Your score: {score}");
                        dialog.Text = sb.ToString();
                        dialog.Font = new Font("Microsoft Sans Serif", 24f, FontStyle.Bold);
                        dialog.TextAlign = ContentAlignment.MiddleCenter;
                        dialog.BackColor = Color.HotPink;
                        dialog.Width = this.Width / 2;
                        dialog.Height = this.Height / 2;
                        int w = this.Width / 2 - dialog.Width / 2;
                        int h = this.Height / 2 - dialog.Height / 2;
                        dialog.Location = new Point(w, h);
                        dialog.BringToFront();
                        this.Controls.Add(dialog);
                    }
                    else
                    {
                        rmRocket = rocket;
                        this.Controls.Remove(listHeart[listHeart.Count-1]);
                        listHeart.RemoveAt(listHeart.Count-1);
                        ShowHealth();
                    }
                }
            }
            listRocket.Remove(rmRocket);
        }

        private void ShowHealth()
        {
            int x = labelScore.Right;

            foreach (var hearth in listHeart)
            {
                int y = labelScore.Top;
                x += hearth.Width;
                hearth.Location = new Point(x, y);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            PictureBox rmBullet = null;

            foreach (var bullet in listBullet)
            {
                bullet.Location = new Point(bullet.Location.X, bullet.Location.Y - 10);

                if (bullet.Location.Y < this.Top)
                {
                    rmBullet = bullet;
                    this.Controls.Remove(bullet);
                }

            }
            listBullet.Remove(rmBullet);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            PictureBox rmBullet = null;
            PictureBox rmRocket = null;

            foreach (var bullet in listBullet)
            {
                foreach (var rocket in listRocket)
                {
                    if (bullet.Bounds.IntersectsWith(rocket.Bounds))
                    {
                        sound.Play();
                        this.Controls.Remove(bullet);
                        this.Controls.Remove(rocket);
                        rmBullet = bullet;
                        rmRocket = rocket;

                        score++;
                        labelScore.Text = score.ToString();
                    }
                }
            }
            listBullet.Remove(rmBullet);
            listRocket.Remove(rmRocket);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            jet.Left = e.X - jet.Width / 2;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Set bullet
            PictureBox bullet = new PictureBox();
            bullet.Image = Resources.bullet;
            bullet.SizeMode = PictureBoxSizeMode.StretchImage;
            bullet.Width = bullet.Image.Width;
            bullet.Height = bullet.Image.Height;
            int x = jet.Left;
            int y = jet.Top;
            bullet.Location = new Point(x, y);
            listBullet.Add(bullet);
            this.Controls.Add(bullet);
        }
    }
}
