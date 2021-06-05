
namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    partial class FormGame
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
            this.pictureBoxDagger = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDagger)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDagger
            // 
            this.pictureBoxDagger.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDagger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDagger.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Dagger;
            this.pictureBoxDagger.Location = new System.Drawing.Point(800, 293);
            this.pictureBoxDagger.Name = "pictureBoxDagger";
            this.pictureBoxDagger.Size = new System.Drawing.Size(125, 79);
            this.pictureBoxDagger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDagger.TabIndex = 0;
            this.pictureBoxDagger.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 664);
            this.Controls.Add(this.pictureBoxDagger);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDagger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDagger;
        private System.Windows.Forms.Timer timer1;
    }
}