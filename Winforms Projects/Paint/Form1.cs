using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Pen pen;
        public Bitmap bitmap;
        public Graphics graphics;
        public bool isDrawing = false;
        public int w = 750, h = 500;
        public Form1()
        {

            InitializeComponent();

            pen = new Pen(Color.Black, 5);
            bitmap = new Bitmap(w, h);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = bitmap;

            this.Width = w;
            this.Height = h + 100;

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
        }

            private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                graphics.DrawEllipse(pen, e.X, e.Y, 3, 1);
                pictureBox.Image = bitmap;
            }
        }

        private void labelRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            buttonClear.ForeColor = Color.Red;
        }

        private void labelGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
            buttonClear.ForeColor = Color.Lime;
        }

        private void labelBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
            buttonClear.ForeColor = Color.Blue;
        }

        private void labelYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            buttonClear.ForeColor = Color.Yellow;
        }

        private void labelPurple_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Fuchsia;
            buttonClear.ForeColor = Color.Fuchsia;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                w = int.Parse(inputWidth.Text.ToString());
                h = int.Parse(inputHeight.Text.ToString());

                if (w >= 750 && h >= 500)
                {
                    bitmap = new Bitmap(w, h);
                    graphics = Graphics.FromImage(bitmap);
                    graphics.Clear(pictureBox.BackColor);
                    pictureBox.Image = bitmap;

                    this.Width = w;
                    this.Height = h + 100;
                }
                else
                {
                    MessageBox.Show("Minimum size must be 750x500");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid size !");
            }
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPeg Image|*.jpg";
            saveFileDialog.Title = "Save file";

            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != string.Empty)
            {
                System.IO.FileStream fileStream = (System.IO.FileStream)saveFileDialog.OpenFile();
                this.pictureBox.Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (graphics != null)
            {
                graphics.Clear(pictureBox.BackColor);
                pictureBox.Image = bitmap;
            }
        }
    }
}
