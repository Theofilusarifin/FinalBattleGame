
namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    partial class FormSelectCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectCharacter));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxWomanPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroundMan = new System.Windows.Forms.PictureBox();
            this.pictureBoxBackgroundWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxManPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWomanPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Montserrat Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(358, 463);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(224, 79);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.MouseEnter += new System.EventHandler(this.buttonPlay_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            // 
            // pictureBoxWomanPlayer
            // 
            this.pictureBoxWomanPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWomanPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWomanPlayer.Location = new System.Drawing.Point(575, 215);
            this.pictureBoxWomanPlayer.Name = "pictureBoxWomanPlayer";
            this.pictureBoxWomanPlayer.Size = new System.Drawing.Size(163, 187);
            this.pictureBoxWomanPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWomanPlayer.TabIndex = 2;
            this.pictureBoxWomanPlayer.TabStop = false;
            this.pictureBoxWomanPlayer.Click += new System.EventHandler(this.pictureBoxWomanPlayer_Click);
            // 
            // pictureBoxBackgroundMan
            // 
            this.pictureBoxBackgroundMan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackgroundMan.Location = new System.Drawing.Point(195, 180);
            this.pictureBoxBackgroundMan.Name = "pictureBoxBackgroundMan";
            this.pictureBoxBackgroundMan.Size = new System.Drawing.Size(169, 241);
            this.pictureBoxBackgroundMan.TabIndex = 3;
            this.pictureBoxBackgroundMan.TabStop = false;
            this.pictureBoxBackgroundMan.Click += new System.EventHandler(this.pictureBoxBackgroundMan_Click);
            // 
            // pictureBoxBackgroundWoman
            // 
            this.pictureBoxBackgroundWoman.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBackgroundWoman.Location = new System.Drawing.Point(575, 180);
            this.pictureBoxBackgroundWoman.Name = "pictureBoxBackgroundWoman";
            this.pictureBoxBackgroundWoman.Size = new System.Drawing.Size(169, 241);
            this.pictureBoxBackgroundWoman.TabIndex = 4;
            this.pictureBoxBackgroundWoman.TabStop = false;
            this.pictureBoxBackgroundWoman.Click += new System.EventHandler(this.pictureBoxBackgroundWoman_Click);
            // 
            // pictureBoxManPlayer
            // 
            this.pictureBoxManPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxManPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxManPlayer.Location = new System.Drawing.Point(201, 215);
            this.pictureBoxManPlayer.Name = "pictureBoxManPlayer";
            this.pictureBoxManPlayer.Size = new System.Drawing.Size(163, 187);
            this.pictureBoxManPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxManPlayer.TabIndex = 5;
            this.pictureBoxManPlayer.TabStop = false;
            this.pictureBoxManPlayer.Click += new System.EventHandler(this.pictureBoxManPlayer_Click);
            // 
            // FormSelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 608);
            this.Controls.Add(this.pictureBoxManPlayer);
            this.Controls.Add(this.pictureBoxBackgroundMan);
            this.Controls.Add(this.pictureBoxWomanPlayer);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxBackgroundWoman);
            this.DoubleBuffered = true;
            this.Name = "FormSelectCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWomanPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackgroundWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBoxWomanPlayer;
        private System.Windows.Forms.PictureBox pictureBoxBackgroundMan;
        private System.Windows.Forms.PictureBox pictureBoxBackgroundWoman;
        private System.Windows.Forms.PictureBox pictureBoxManPlayer;
    }
}