using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReproductorDeVideo
{
    public partial class Form1 : Form
    {
        string[] archivosMP4;
        string[] rutaArchivosMP4;
        public Form1()
        {
            InitializeComponent();
            mediaPlayer.uiMode = "none";
            volumeBar.Value = 50;
            mediaPlayer.settings.volume = 50;
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (pnArchivoSubMenu.Visible == false)
            {
                pnArchivoSubMenu.Visible = true;
            }
            else
            {
                pnArchivoSubMenu.Visible = false;
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarVideo = new OpenFileDialog();
            buscarVideo.Filter = "Archivos de Video(.mp4;.mov;.wmv;.avi;.mkv)|*.mp4;*.mov;*.wmv;*.avi;*.mkv|Archivos de Audio(.mp3;.wav;.aiff;.wma;.ogg;.flac;.fla)|*.mp3;*.wav;*.aiff;*.wma;*.ogg;*.flac;*.fla";

            if (buscarVideo.ShowDialog() == DialogResult.OK)
            {

                mediaPlayer.URL = buscarVideo.FileName;
                pnArchivoSubMenu.Visible = false;
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            if (pnPlaylist.Visible == false)
            {
                pnPlaylist.Visible = true;
            }
            else
            {
                pnPlaylist.Visible = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.play();
            btnPlay.Visible = false;
            btnPause.Visible = true;

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mediaPlayer.Ctlcontrols.pause();
            btnPause.Visible = false;
            btnPlay.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timerBar.Value = (int)mediaPlayer.Ctlcontrols.currentPosition;
                lblStartVideo.Text = mediaPlayer.Ctlcontrols.currentPositionString;
                lblFinalVideo.Text = mediaPlayer.currentMedia.durationString;
            }
            catch 
            {
            
            }
        }

        private void timerBar_ValueChanged(object sender, decimal value)
        {
            timerBar.Maximum = (int)mediaPlayer.currentMedia.duration;

            if (timerBar.Value == (int)mediaPlayer.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                mediaPlayer.Ctlcontrols.currentPosition = timerBar.Value;
            }
        }

        private void volumeBar_ValueChanged(object sender, decimal value)
        {
            mediaPlayer.settings.volume = volumeBar.Value;
            lblVolumen.Text = mediaPlayer.settings.volume.ToString() + "%";
        }

        private void mediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (mediaPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
            {
                timerBar.Maximum = (int)mediaPlayer.currentMedia.duration;
                timer1.Start();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if ((timerBar.Value = timerBar.Value - 15) < 0)
            {
                timerBar.Value = 0;
            }
            else
            {
                timerBar.Value = timerBar.Value - 15;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((timerBar.Value = timerBar.Value + 15) < 0)
            {
                timerBar.Value = 0;
            }
            else
            {
                timerBar.Value = timerBar.Value + 15;
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            timerBar.Value = 0;
        }

        private void videoPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediaPlayer.URL = rutaArchivosMP4[videoPlaylist.SelectedIndex];
            pnPlaylist.Visible = false;
        }

        private void btnAbrirArchivos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarVideo = new OpenFileDialog();
            buscarVideo.Multiselect = true;
            buscarVideo.Filter = "Archivos de Video(.mp4;.mov;.wmv;.avi;.mkv)|*.mp4;*.mov;*.wmv;*.avi;*.mkv|Archivos de Audio(.mp3;.wav;.aiff;.wma;.ogg;.flac;.fla)|*.mp3;*.wav;*.aiff;*.wma;*.ogg;*.flac;*.fla";

            if (buscarVideo.ShowDialog() == DialogResult.OK)
            {
                archivosMP4 = buscarVideo.SafeFileNames;
                rutaArchivosMP4 = buscarVideo.FileNames;
                foreach (var archivoMP4 in archivosMP4)
                {
                    videoPlaylist.Items.Add(archivoMP4);
                }
                mediaPlayer.URL = rutaArchivosMP4[0];
                videoPlaylist.SelectedIndex = 0;
                pnArchivoSubMenu.Visible = false;
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }
        }
    }
}
