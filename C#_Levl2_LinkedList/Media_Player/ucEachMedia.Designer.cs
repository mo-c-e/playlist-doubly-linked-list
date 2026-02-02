namespace Media_Player
{
    partial class ucEachMedia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.laMediaNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.laSurahName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.laReciterName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.laTotalTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // laMediaNumber
            // 
            this.laMediaNumber.BackColor = System.Drawing.Color.Transparent;
            this.laMediaNumber.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMediaNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.laMediaNumber.Location = new System.Drawing.Point(16, 22);
            this.laMediaNumber.Name = "laMediaNumber";
            this.laMediaNumber.Size = new System.Drawing.Size(13, 23);
            this.laMediaNumber.TabIndex = 1;
            this.laMediaNumber.Text = "1";
            this.laMediaNumber.Click += new System.EventHandler(this.laMediaNumber_Click);
            // 
            // laSurahName
            // 
            this.laSurahName.AutoSize = false;
            this.laSurahName.BackColor = System.Drawing.Color.Transparent;
            this.laSurahName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSurahName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.laSurahName.Location = new System.Drawing.Point(119, 7);
            this.laSurahName.Name = "laSurahName";
            this.laSurahName.Size = new System.Drawing.Size(213, 23);
            this.laSurahName.TabIndex = 2;
            this.laSurahName.Text = "SurahName";
            // 
            // laReciterName
            // 
            this.laReciterName.AutoSize = false;
            this.laReciterName.BackColor = System.Drawing.Color.Transparent;
            this.laReciterName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laReciterName.ForeColor = System.Drawing.Color.Silver;
            this.laReciterName.Location = new System.Drawing.Point(119, 36);
            this.laReciterName.Name = "laReciterName";
            this.laReciterName.Size = new System.Drawing.Size(213, 23);
            this.laReciterName.TabIndex = 3;
            this.laReciterName.Text = "ReciterName";
            this.laReciterName.Click += new System.EventHandler(this.laReciterName_Click);
            // 
            // laTotalTime
            // 
            this.laTotalTime.BackColor = System.Drawing.Color.Transparent;
            this.laTotalTime.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTotalTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.laTotalTime.Location = new System.Drawing.Point(408, 22);
            this.laTotalTime.Name = "laTotalTime";
            this.laTotalTime.Size = new System.Drawing.Size(55, 17);
            this.laTotalTime.TabIndex = 4;
            this.laTotalTime.Text = "hh\\:mm\\:ss";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pbPhoto);
            this.guna2Panel1.Controls.Add(this.laTotalTime);
            this.guna2Panel1.Controls.Add(this.laMediaNumber);
            this.guna2Panel1.Controls.Add(this.laReciterName);
            this.guna2Panel1.Controls.Add(this.laSurahName);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(3, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(477, 66);
            this.guna2Panel1.TabIndex = 5;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderRadius = 15;
            this.pbPhoto.Image = global::Media_Player.Properties.Resources.waves;
            this.pbPhoto.ImageRotate = 0F;
            this.pbPhoto.Location = new System.Drawing.Point(44, 10);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(60, 47);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 0;
            this.pbPhoto.TabStop = false;
            // 
            // ucEachMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucEachMedia";
            this.Size = new System.Drawing.Size(483, 66);
            this.Load += new System.EventHandler(this.ucEachMedia_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2HtmlLabel laMediaNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel laSurahName;
        private Guna.UI2.WinForms.Guna2HtmlLabel laReciterName;
        private Guna.UI2.WinForms.Guna2HtmlLabel laTotalTime;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
