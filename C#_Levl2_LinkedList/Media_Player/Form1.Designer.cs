namespace Media_Player
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.laCurrentTime = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.laNameOfPlaying = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.laReciterName = new System.Windows.Forms.Label();
            this.laTotalTime = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.trackBarVolume = new Guna.UI2.WinForms.Guna2TrackBar();
            this.buReset = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buNextLeft = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buNextRight = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buPlay = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMainPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.laTracksNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderRadius = 5;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ProgressBar1.Location = new System.Drawing.Point(34, 495);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2ProgressBar1.Size = new System.Drawing.Size(470, 10);
            this.guna2ProgressBar1.TabIndex = 3;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // laCurrentTime
            // 
            this.laCurrentTime.AutoSize = true;
            this.laCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.laCurrentTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCurrentTime.ForeColor = System.Drawing.Color.White;
            this.laCurrentTime.Location = new System.Drawing.Point(31, 517);
            this.laCurrentTime.Name = "laCurrentTime";
            this.laCurrentTime.Size = new System.Drawing.Size(57, 16);
            this.laCurrentTime.TabIndex = 6;
            this.laCurrentTime.Text = "00:00:00";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // laNameOfPlaying
            // 
            this.laNameOfPlaying.AutoSize = true;
            this.laNameOfPlaying.Font = new System.Drawing.Font("Traditional Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNameOfPlaying.ForeColor = System.Drawing.Color.White;
            this.laNameOfPlaying.Location = new System.Drawing.Point(208, 362);
            this.laNameOfPlaying.Name = "laNameOfPlaying";
            this.laNameOfPlaying.Size = new System.Drawing.Size(137, 49);
            this.laNameOfPlaying.TabIndex = 12;
            this.laNameOfPlaying.Text = "سورة الانسان";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.laReciterName);
            this.guna2CustomGradientPanel1.Controls.Add(this.laTotalTime);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.trackBarVolume);
            this.guna2CustomGradientPanel1.Controls.Add(this.laCurrentTime);
            this.guna2CustomGradientPanel1.Controls.Add(this.buReset);
            this.guna2CustomGradientPanel1.Controls.Add(this.buNextLeft);
            this.guna2CustomGradientPanel1.Controls.Add(this.buNextRight);
            this.guna2CustomGradientPanel1.Controls.Add(this.buPlay);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.pbMainPicture);
            this.guna2CustomGradientPanel1.Controls.Add(this.laNameOfPlaying);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ProgressBar1);
            this.guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(26, 82);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(538, 706);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            // 
            // laReciterName
            // 
            this.laReciterName.AutoSize = true;
            this.laReciterName.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laReciterName.ForeColor = System.Drawing.Color.White;
            this.laReciterName.Location = new System.Drawing.Point(232, 411);
            this.laReciterName.Name = "laReciterName";
            this.laReciterName.Size = new System.Drawing.Size(89, 32);
            this.laReciterName.TabIndex = 21;
            this.laReciterName.Text = "سورة الانسان";
            // 
            // laTotalTime
            // 
            this.laTotalTime.AutoSize = true;
            this.laTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.laTotalTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalTime.ForeColor = System.Drawing.Color.White;
            this.laTotalTime.Location = new System.Drawing.Point(439, 517);
            this.laTotalTime.Name = "laTotalTime";
            this.laTotalTime.Size = new System.Drawing.Size(65, 16);
            this.laTotalTime.TabIndex = 20;
            this.laTotalTime.Text = "00\\:00\\:00";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.DimGray;
            this.guna2PictureBox1.Image = global::Media_Player.Properties.Resources.icons8_sound_20;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(185, 659);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.LargeChange = 3;
            this.trackBarVolume.Location = new System.Drawing.Point(222, 656);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(96, 27);
            this.trackBarVolume.TabIndex = 18;
            this.trackBarVolume.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.trackBarVolume.Value = 1;
            this.trackBarVolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBarVolume_Scroll);
            // 
            // buReset
            // 
            this.buReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buReset.ForeColor = System.Drawing.Color.White;
            this.buReset.Image = global::Media_Player.Properties.Resources.icons8_stop_24;
            this.buReset.ImageSize = new System.Drawing.Size(25, 25);
            this.buReset.Location = new System.Drawing.Point(282, 579);
            this.buReset.Name = "buReset";
            this.buReset.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buReset.Size = new System.Drawing.Size(45, 45);
            this.buReset.TabIndex = 17;
            this.buReset.Click += new System.EventHandler(this.buStop_Click);
            // 
            // buNextLeft
            // 
            this.buNextLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buNextLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buNextLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buNextLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buNextLeft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buNextLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buNextLeft.ForeColor = System.Drawing.Color.White;
            this.buNextLeft.Image = global::Media_Player.Properties.Resources.icons8_previous_track_30;
            this.buNextLeft.ImageSize = new System.Drawing.Size(25, 25);
            this.buNextLeft.Location = new System.Drawing.Point(150, 579);
            this.buNextLeft.Name = "buNextLeft";
            this.buNextLeft.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buNextLeft.Size = new System.Drawing.Size(45, 45);
            this.buNextLeft.TabIndex = 16;
            this.buNextLeft.Click += new System.EventHandler(this.buNextLeft_Click);
            // 
            // buNextRight
            // 
            this.buNextRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buNextRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buNextRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buNextRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buNextRight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buNextRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buNextRight.ForeColor = System.Drawing.Color.White;
            this.buNextRight.Image = global::Media_Player.Properties.Resources.icons8_end_30;
            this.buNextRight.ImageSize = new System.Drawing.Size(25, 25);
            this.buNextRight.Location = new System.Drawing.Point(343, 579);
            this.buNextRight.Name = "buNextRight";
            this.buNextRight.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buNextRight.Size = new System.Drawing.Size(45, 45);
            this.buNextRight.TabIndex = 15;
            this.buNextRight.Click += new System.EventHandler(this.buNextRight_Click);
            // 
            // buPlay
            // 
            this.buPlay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buPlay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buPlay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buPlay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buPlay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buPlay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buPlay.ForeColor = System.Drawing.Color.White;
            this.buPlay.Image = global::Media_Player.Properties.Resources.play_button__1_;
            this.buPlay.ImageOffset = new System.Drawing.Point(1, 0);
            this.buPlay.ImageSize = new System.Drawing.Size(25, 25);
            this.buPlay.Location = new System.Drawing.Point(211, 574);
            this.buPlay.Name = "buPlay";
            this.buPlay.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buPlay.Size = new System.Drawing.Size(55, 55);
            this.buPlay.TabIndex = 14;
            this.buPlay.Click += new System.EventHandler(this.buPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "NOW PLAYING";
            // 
            // pbMainPicture
            // 
            this.pbMainPicture.BorderRadius = 30;
            this.pbMainPicture.Image = global::Media_Player.Properties.Resources.الانسان;
            this.pbMainPicture.ImageRotate = 0F;
            this.pbMainPicture.Location = new System.Drawing.Point(124, 86);
            this.pbMainPicture.Name = "pbMainPicture";
            this.pbMainPicture.Size = new System.Drawing.Size(290, 260);
            this.pbMainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainPicture.TabIndex = 0;
            this.pbMainPicture.TabStop = false;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.DimGray;
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.BorderThickness = 1;
            this.guna2CustomGradientPanel2.Controls.Add(this.flowLayoutPanel1);
            this.guna2CustomGradientPanel2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(604, 82);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(522, 706);
            this.guna2CustomGradientPanel2.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.laTracksNo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 706);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 20, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(391, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "PLAY LIST";
            // 
            // laTracksNo
            // 
            this.laTracksNo.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.laTracksNo.ForeColor = System.Drawing.Color.LightGray;
            this.laTracksNo.Location = new System.Drawing.Point(414, 20);
            this.laTracksNo.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.laTracksNo.Name = "laTracksNo";
            this.laTracksNo.Size = new System.Drawing.Size(105, 46);
            this.laTracksNo.TabIndex = 15;
            this.laTracksNo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "MP3 Player";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = global::Media_Player.Properties.Resources.close;
            this.guna2CircleButton1.Location = new System.Drawing.Point(1127, 9);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(38, 38);
            this.guna2CircleButton1.TabIndex = 20;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DimGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Media_Player.Properties.Resources.headphone;
            this.guna2Button1.Location = new System.Drawing.Point(12, 9);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 40);
            this.guna2Button1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1177, 827);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Media Player Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainPicture)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label laCurrentTime;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label laNameOfPlaying;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbMainPicture;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton buPlay;
        private Guna.UI2.WinForms.Guna2CircleButton buNextRight;
        private Guna.UI2.WinForms.Guna2CircleButton buNextLeft;
        private Guna.UI2.WinForms.Guna2CircleButton buReset;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TrackBar trackBarVolume;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label laTracksNo;
        private System.Windows.Forms.Label laTotalTime;
        private System.Windows.Forms.Label laReciterName;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        // private MixedColorPanel mixedColorPanel1;
    }
}


