using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
           
        {
            openFileDialog1.Title = "Please select an mp3 file";
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "mp3 files(*.mp3)|";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int index = openFileDialog1.FileName.LastIndexOf('\\');
                textBoxMusic.Text = openFileDialog1.FileName.Substring(index+1);

                Player.URL = openFileDialog1.FileName;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
