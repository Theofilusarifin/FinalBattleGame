
namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    partial class FormAlmanac
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
            this.buttonMonster = new System.Windows.Forms.Button();
            this.buttonWitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMonster
            // 
            this.buttonMonster.BackColor = System.Drawing.Color.Transparent;
            this.buttonMonster.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Almanac_Monster;
            this.buttonMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMonster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMonster.FlatAppearance.BorderSize = 0;
            this.buttonMonster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMonster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMonster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMonster.Location = new System.Drawing.Point(86, 203);
            this.buttonMonster.Name = "buttonMonster";
            this.buttonMonster.Size = new System.Drawing.Size(447, 488);
            this.buttonMonster.TabIndex = 0;
            this.buttonMonster.UseVisualStyleBackColor = false;
            this.buttonMonster.Click += new System.EventHandler(this.buttonMonster_Click);
            // 
            // buttonWitch
            // 
            this.buttonWitch.BackColor = System.Drawing.Color.Transparent;
            this.buttonWitch.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Almanac_Witch;
            this.buttonWitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWitch.FlatAppearance.BorderSize = 0;
            this.buttonWitch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonWitch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonWitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWitch.Location = new System.Drawing.Point(554, 203);
            this.buttonWitch.Name = "buttonWitch";
            this.buttonWitch.Size = new System.Drawing.Size(447, 488);
            this.buttonWitch.TabIndex = 1;
            this.buttonWitch.UseVisualStyleBackColor = false;
            this.buttonWitch.Click += new System.EventHandler(this.buttonWitch_Click);
            // 
            // FormAlmanac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Background_Almanac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 799);
            this.Controls.Add(this.buttonWitch);
            this.Controls.Add(this.buttonMonster);
            this.DoubleBuffered = true;
            this.Name = "FormAlmanac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almanac";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMonster;
        private System.Windows.Forms.Button buttonWitch;
    }
}