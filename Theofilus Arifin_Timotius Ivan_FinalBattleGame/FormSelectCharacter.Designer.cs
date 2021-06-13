
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
            this.pictureBoxManPlayer = new System.Windows.Forms.PictureBox();
            this.panelMan = new System.Windows.Forms.Panel();
            this.panelWoman = new System.Windows.Forms.Panel();
            this.pictureBoxText = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWomanPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManPlayer)).BeginInit();
            this.panelMan.SuspendLayout();
            this.panelWoman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pictureBoxWomanPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWomanPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxWomanPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWomanPlayer.Image")));
            this.pictureBoxWomanPlayer.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxWomanPlayer.Name = "pictureBoxWomanPlayer";
            this.pictureBoxWomanPlayer.Size = new System.Drawing.Size(163, 187);
            this.pictureBoxWomanPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWomanPlayer.TabIndex = 2;
            this.pictureBoxWomanPlayer.TabStop = false;
            this.pictureBoxWomanPlayer.Click += new System.EventHandler(this.pictureBoxWomanPlayer_Click);
            // 
            // pictureBoxManPlayer
            // 
            this.pictureBoxManPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxManPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxManPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxManPlayer.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Selected_Man;
            this.pictureBoxManPlayer.Location = new System.Drawing.Point(6, 35);
            this.pictureBoxManPlayer.Name = "pictureBoxManPlayer";
            this.pictureBoxManPlayer.Size = new System.Drawing.Size(163, 187);
            this.pictureBoxManPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxManPlayer.TabIndex = 5;
            this.pictureBoxManPlayer.TabStop = false;
            this.pictureBoxManPlayer.Click += new System.EventHandler(this.pictureBoxManPlayer_Click);
            // 
            // panelMan
            // 
            this.panelMan.BackColor = System.Drawing.Color.Transparent;
            this.panelMan.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Active_Background_Man;
            this.panelMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMan.Controls.Add(this.pictureBoxManPlayer);
            this.panelMan.Location = new System.Drawing.Point(195, 180);
            this.panelMan.Name = "panelMan";
            this.panelMan.Size = new System.Drawing.Size(169, 241);
            this.panelMan.TabIndex = 6;
            // 
            // panelWoman
            // 
            this.panelWoman.BackColor = System.Drawing.Color.Transparent;
            this.panelWoman.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Non_Active_Background_Woman;
            this.panelWoman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelWoman.Controls.Add(this.pictureBoxWomanPlayer);
            this.panelWoman.Location = new System.Drawing.Point(575, 180);
            this.panelWoman.Name = "panelWoman";
            this.panelWoman.Size = new System.Drawing.Size(169, 241);
            this.panelWoman.TabIndex = 7;
            // 
            // pictureBoxText
            // 
            this.pictureBoxText.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxText.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Text_Man;
            this.pictureBoxText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxText.Location = new System.Drawing.Point(381, 262);
            this.pictureBoxText.Name = "pictureBoxText";
            this.pictureBoxText.Size = new System.Drawing.Size(171, 74);
            this.pictureBoxText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxText.TabIndex = 8;
            this.pictureBoxText.TabStop = false;
            // 
            // FormSelectCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 608);
            this.Controls.Add(this.pictureBoxText);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.panelMan);
            this.Controls.Add(this.panelWoman);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSelectCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Player";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWomanPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManPlayer)).EndInit();
            this.panelMan.ResumeLayout(false);
            this.panelWoman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.PictureBox pictureBoxWomanPlayer;
        private System.Windows.Forms.PictureBox pictureBoxManPlayer;
        private System.Windows.Forms.Panel panelMan;
        private System.Windows.Forms.Panel panelWoman;
        private System.Windows.Forms.PictureBox pictureBoxText;
    }
}