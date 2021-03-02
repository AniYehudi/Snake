namespace Snake
{
    partial class NewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGame));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxD = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxL = new System.Windows.Forms.PictureBox();
            this.pictureBoxR = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Wheat;
            this.pbCanvas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCanvas.BackgroundImage")));
            this.pbCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(600, 600);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(678, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(834, 27);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(117, 46);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Label";
            // 
            // pictureBoxD
            // 
            this.pictureBoxD.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxD.BackgroundImage")));
            this.pictureBoxD.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxD.Name = "pictureBoxD";
            this.pictureBoxD.Size = new System.Drawing.Size(600, 25);
            this.pictureBoxD.TabIndex = 5;
            this.pictureBoxD.TabStop = false;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUp.BackgroundImage")));
            this.pictureBoxUp.InitialImage = null;
            this.pictureBoxUp.Location = new System.Drawing.Point(0, 565);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(600, 35);
            this.pictureBoxUp.TabIndex = 6;
            this.pictureBoxUp.TabStop = false;
            // 
            // pictureBoxL
            // 
            this.pictureBoxL.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBoxL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxL.BackgroundImage")));
            this.pictureBoxL.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxL.Name = "pictureBoxL";
            this.pictureBoxL.Size = new System.Drawing.Size(26, 600);
            this.pictureBoxL.TabIndex = 7;
            this.pictureBoxL.TabStop = false;
            // 
            // pictureBoxR
            // 
            this.pictureBoxR.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBoxR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxR.BackgroundImage")));
            this.pictureBoxR.Location = new System.Drawing.Point(560, 0);
            this.pictureBoxR.Name = "pictureBoxR";
            this.pictureBoxR.Size = new System.Drawing.Size(40, 600);
            this.pictureBoxR.TabIndex = 8;
            this.pictureBoxR.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(642, 146);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(60, 47);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "field.bmp");
            this.imageList1.Images.SetKeyName(1, "desert.bmp");
            this.imageList1.Images.SetKeyName(2, "ice.bmp");
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 601);
            this.ControlBox = false;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBoxR);
            this.Controls.Add(this.pictureBoxL);
            this.Controls.Add(this.pictureBoxUp);
            this.Controls.Add(this.pictureBoxD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(982, 601);
            this.MinimumSize = new System.Drawing.Size(982, 601);
            this.Name = "NewGame";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBoxD;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.PictureBox pictureBoxL;
        private System.Windows.Forms.PictureBox pictureBoxR;
        public System.Windows.Forms.PictureBox pbCanvas;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

