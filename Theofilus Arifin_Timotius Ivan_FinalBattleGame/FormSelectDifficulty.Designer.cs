
namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    partial class FormSelectDifficulty
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
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Easy_Over;
            this.buttonEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEasy.FlatAppearance.BorderSize = 0;
            this.buttonEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEasy.Location = new System.Drawing.Point(226, 317);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(232, 110);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.UseVisualStyleBackColor = false;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            this.buttonEasy.MouseEnter += new System.EventHandler(this.buttonEasy_MouseEnter);
            this.buttonEasy.MouseLeave += new System.EventHandler(this.buttonEasy_MouseLeave);
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.Transparent;
            this.buttonHard.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Hard_Over;
            this.buttonHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHard.FlatAppearance.BorderSize = 0;
            this.buttonHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHard.Location = new System.Drawing.Point(226, 468);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(232, 110);
            this.buttonHard.TabIndex = 1;
            this.buttonHard.UseVisualStyleBackColor = false;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            this.buttonHard.MouseEnter += new System.EventHandler(this.buttonHard_MouseEnter);
            this.buttonHard.MouseLeave += new System.EventHandler(this.buttonHard_MouseLeave);
            // 
            // FormSelectDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Background_Select_Difficulty;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 667);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonEasy);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSelectDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Difficulty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonHard;
    }
}