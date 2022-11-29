namespace ReproductorDeVideo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.pnBottomMenu = new System.Windows.Forms.Panel();
            this.lblFinalVideo = new System.Windows.Forms.Label();
            this.lblStartVideo = new System.Windows.Forms.Label();
            this.timerBar = new XComponent.SliderBar.MACTrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.volumeBar = new XComponent.SliderBar.MACTrackBar();
            this.pnArchivoSubMenu = new System.Windows.Forms.Panel();
            this.btnAbrirArchivos = new System.Windows.Forms.Button();
            this.btnAbrirArchivo = new System.Windows.Forms.Button();
            this.pnPlaylist = new System.Windows.Forms.Panel();
            this.videoPlaylist = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnTopMenu.SuspendLayout();
            this.pnBottomMenu.SuspendLayout();
            this.pnArchivoSubMenu.SuspendLayout();
            this.pnPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnTopMenu.Controls.Add(this.btnArchivo);
            this.pnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(884, 44);
            this.pnTopMenu.TabIndex = 0;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArchivo.FlatAppearance.BorderSize = 0;
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Location = new System.Drawing.Point(0, 0);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(188, 44);
            this.btnArchivo.TabIndex = 0;
            this.btnArchivo.Text = "Medio";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // pnBottomMenu
            // 
            this.pnBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnBottomMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnBottomMenu.Controls.Add(this.lblFinalVideo);
            this.pnBottomMenu.Controls.Add(this.lblStartVideo);
            this.pnBottomMenu.Controls.Add(this.timerBar);
            this.pnBottomMenu.Controls.Add(this.lblVolumen);
            this.pnBottomMenu.Controls.Add(this.btnPause);
            this.pnBottomMenu.Controls.Add(this.btnPlaylist);
            this.pnBottomMenu.Controls.Add(this.btnVolume);
            this.pnBottomMenu.Controls.Add(this.btnRepeat);
            this.pnBottomMenu.Controls.Add(this.btnNext);
            this.pnBottomMenu.Controls.Add(this.btnPlay);
            this.pnBottomMenu.Controls.Add(this.btnBack);
            this.pnBottomMenu.Controls.Add(this.btnShuffle);
            this.pnBottomMenu.Controls.Add(this.volumeBar);
            this.pnBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottomMenu.Location = new System.Drawing.Point(0, 405);
            this.pnBottomMenu.Name = "pnBottomMenu";
            this.pnBottomMenu.Size = new System.Drawing.Size(884, 56);
            this.pnBottomMenu.TabIndex = 1;
            // 
            // lblFinalVideo
            // 
            this.lblFinalVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalVideo.AutoSize = true;
            this.lblFinalVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalVideo.ForeColor = System.Drawing.Color.White;
            this.lblFinalVideo.Location = new System.Drawing.Point(673, 35);
            this.lblFinalVideo.Name = "lblFinalVideo";
            this.lblFinalVideo.Size = new System.Drawing.Size(29, 16);
            this.lblFinalVideo.TabIndex = 11;
            this.lblFinalVideo.Text = "00:00";
            // 
            // lblStartVideo
            // 
            this.lblStartVideo.AutoSize = true;
            this.lblStartVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStartVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartVideo.ForeColor = System.Drawing.Color.White;
            this.lblStartVideo.Location = new System.Drawing.Point(242, 35);
            this.lblStartVideo.Name = "lblStartVideo";
            this.lblStartVideo.Size = new System.Drawing.Size(29, 16);
            this.lblStartVideo.TabIndex = 10;
            this.lblStartVideo.Text = "00:00";
            // 
            // timerBar
            // 
            this.timerBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerBar.BackColor = System.Drawing.Color.Transparent;
            this.timerBar.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.timerBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.timerBar.IndentHeight = 6;
            this.timerBar.Location = new System.Drawing.Point(233, 16);
            this.timerBar.Maximum = 1000;
            this.timerBar.Minimum = 0;
            this.timerBar.Name = "timerBar";
            this.timerBar.Size = new System.Drawing.Size(474, 22);
            this.timerBar.TabIndex = 14;
            this.timerBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.timerBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.timerBar.TickHeight = 1;
            this.timerBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.timerBar.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timerBar.TrackerSize = new System.Drawing.Size(10, 10);
            this.timerBar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.timerBar.TrackLineHeight = 3;
            this.timerBar.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.timerBar.Value = 0;
            this.timerBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.timerBar_ValueChanged);
            // 
            // lblVolumen
            // 
            this.lblVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumen.ForeColor = System.Drawing.Color.White;
            this.lblVolumen.Location = new System.Drawing.Point(846, 24);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(25, 16);
            this.lblVolumen.TabIndex = 15;
            this.lblVolumen.Text = "50%";
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(79, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(40, 36);
            this.btnPause.TabIndex = 9;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.BackgroundImage")));
            this.btnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Location = new System.Drawing.Point(187, 12);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(40, 36);
            this.btnPlaylist.TabIndex = 8;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolume.BackgroundImage")));
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Location = new System.Drawing.Point(711, 12);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(40, 36);
            this.btnVolume.TabIndex = 7;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRepeat.BackgroundImage")));
            this.btnRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRepeat.FlatAppearance.BorderSize = 0;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Location = new System.Drawing.Point(148, 12);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(40, 36);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(113, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 36);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(79, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 36);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(43, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 36);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.BackgroundImage")));
            this.btnShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShuffle.FlatAppearance.BorderSize = 0;
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Location = new System.Drawing.Point(7, 12);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(40, 36);
            this.btnShuffle.TabIndex = 0;
            this.btnShuffle.UseVisualStyleBackColor = true;
            // 
            // volumeBar
            // 
            this.volumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumeBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumeBar.IndentHeight = 6;
            this.volumeBar.Location = new System.Drawing.Point(745, 19);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Minimum = 0;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(102, 22);
            this.volumeBar.TabIndex = 13;
            this.volumeBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.volumeBar.TickHeight = 1;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.volumeBar.TrackerSize = new System.Drawing.Size(10, 10);
            this.volumeBar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumeBar.TrackLineHeight = 3;
            this.volumeBar.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumeBar.Value = 0;
            this.volumeBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.volumeBar_ValueChanged);
            // 
            // pnArchivoSubMenu
            // 
            this.pnArchivoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnArchivoSubMenu.Controls.Add(this.btnAbrirArchivos);
            this.pnArchivoSubMenu.Controls.Add(this.btnAbrirArchivo);
            this.pnArchivoSubMenu.Location = new System.Drawing.Point(0, 44);
            this.pnArchivoSubMenu.Name = "pnArchivoSubMenu";
            this.pnArchivoSubMenu.Size = new System.Drawing.Size(188, 91);
            this.pnArchivoSubMenu.TabIndex = 3;
            this.pnArchivoSubMenu.Visible = false;
            // 
            // btnAbrirArchivos
            // 
            this.btnAbrirArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirArchivos.FlatAppearance.BorderSize = 0;
            this.btnAbrirArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArchivos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivos.ForeColor = System.Drawing.Color.White;
            this.btnAbrirArchivos.Location = new System.Drawing.Point(0, 44);
            this.btnAbrirArchivos.Name = "btnAbrirArchivos";
            this.btnAbrirArchivos.Size = new System.Drawing.Size(188, 44);
            this.btnAbrirArchivos.TabIndex = 1;
            this.btnAbrirArchivos.Text = "Abrir archivos...";
            this.btnAbrirArchivos.UseVisualStyleBackColor = true;
            this.btnAbrirArchivos.Click += new System.EventHandler(this.btnAbrirArchivos_Click);
            // 
            // btnAbrirArchivo
            // 
            this.btnAbrirArchivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirArchivo.FlatAppearance.BorderSize = 0;
            this.btnAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirArchivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAbrirArchivo.Location = new System.Drawing.Point(0, 0);
            this.btnAbrirArchivo.Name = "btnAbrirArchivo";
            this.btnAbrirArchivo.Size = new System.Drawing.Size(188, 44);
            this.btnAbrirArchivo.TabIndex = 0;
            this.btnAbrirArchivo.Text = "Abrir archivo...";
            this.btnAbrirArchivo.UseVisualStyleBackColor = true;
            this.btnAbrirArchivo.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.Controls.Add(this.videoPlaylist);
            this.pnPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlaylist.Location = new System.Drawing.Point(0, 44);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.Size = new System.Drawing.Size(884, 361);
            this.pnPlaylist.TabIndex = 4;
            this.pnPlaylist.Visible = false;
            // 
            // videoPlaylist
            // 
            this.videoPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.videoPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlaylist.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videoPlaylist.ForeColor = System.Drawing.Color.White;
            this.videoPlaylist.FormattingEnabled = true;
            this.videoPlaylist.ItemHeight = 25;
            this.videoPlaylist.Location = new System.Drawing.Point(0, 0);
            this.videoPlaylist.Name = "videoPlaylist";
            this.videoPlaylist.Size = new System.Drawing.Size(884, 361);
            this.videoPlaylist.TabIndex = 0;
            this.videoPlaylist.SelectedIndexChanged += new System.EventHandler(this.videoPlaylist_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(0, 44);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(884, 361);
            this.mediaPlayer.TabIndex = 2;
            this.mediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.mediaPlayer_OpenStateChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pnArchivoSubMenu);
            this.Controls.Add(this.pnPlaylist);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.pnBottomMenu);
            this.Controls.Add(this.pnTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnTopMenu.ResumeLayout(false);
            this.pnBottomMenu.ResumeLayout(false);
            this.pnBottomMenu.PerformLayout();
            this.pnArchivoSubMenu.ResumeLayout(false);
            this.pnPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopMenu;
        private System.Windows.Forms.Panel pnBottomMenu;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Panel pnArchivoSubMenu;
        private System.Windows.Forms.Button btnAbrirArchivo;
        private System.Windows.Forms.Button btnAbrirArchivos;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel pnPlaylist;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFinalVideo;
        private System.Windows.Forms.Label lblStartVideo;
        private XComponent.SliderBar.MACTrackBar timerBar;
        private XComponent.SliderBar.MACTrackBar volumeBar;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.ListBox videoPlaylist;
    }
}

