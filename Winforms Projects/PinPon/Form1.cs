using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinPong
{
    public partial class Form1 : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int scorePoint = 0;
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Cursor.Hide();

            score.Left = playground.Left + 10;
            score.Top = playground.Top + 10;

            point.Left = score.Right;
            point.Top = score.Top + 1;

            menu.Left = playground.Width / 2 - menu.Width / 2;
            menu.Top = playground.Height / 2 - menu.Height / 2;
            menu.Visible = false;


            ball.Left = playground.Left + 50;
            ball.Top = playground.Top + 50;

            racket.Left = playground.Width / 2 - menu.Width / 2;
            racket.Top = playground.Height - 25;

            timer.Enabled = true;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - racket.Width / 2;

            ball.Left += speedLeft;
            ball.Top += speedTop;


            //Game Over
            if ( ball.Top > playground.Bottom)
            {
                timer.Enabled = false;
                menu.Visible = true;
            }

            if (ball.Left <= playground.Left) { speedLeft = -speedLeft;}
            if (ball.Right >= playground.Right) { speedLeft = -speedLeft; }
            if (ball.Top <= playground.Top) { speedTop = -speedTop; }

            if (ball.Left >= racket.Left && ball.Right <= racket.Right && ball.Bottom >= racket.Top)
            {
                speedLeft += 1;
                speedTop += 1;
                speedTop = -speedTop;
                scorePoint++;
                point.Text = scorePoint.ToString();
                this.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));
                soundPlayer.Play();
            }



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F1:
                    speedLeft = speedTop = 4;
                    scorePoint = 0;
                    point.Text = "0";

                    ball.Left = playground.Left + 50;
                    ball.Top = playground.Top + 50;

                    menu.Visible = false;
                    timer.Enabled = true;
                    break;

            }
        }
    }
}
