using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player2
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        String s;
        public Form1()
        {
            InitializeComponent();
        }
        private void hide()
        {
            panel4.Visible = false;
        }
        private void presently()
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
        }

        private void icbtnmedia_Click(object sender, EventArgs e)
        {
            presently();
        }

        private void icbtnmusic_Click(object sender, EventArgs e)
        {
            hide();
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                s = dlg.FileName;
                runmp3();
            }
        }
        private void runmp3()
        {
            WindowsMediaPlayer1.URL = s;
            WindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void icbtnfile_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2ProgressBar1.Maximum = (int)WindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                guna2ProgressBar1.Value = (int)WindowsMediaPlayer1.Ctlcontrols.currentPosition;

            }
        }
    }
}
