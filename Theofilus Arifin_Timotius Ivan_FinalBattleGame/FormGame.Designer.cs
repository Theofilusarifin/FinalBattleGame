
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.panelRock = new System.Windows.Forms.Panel();
            this.panelKnife = new System.Windows.Forms.Panel();
            this.pictureBoxKnife = new System.Windows.Forms.PictureBox();
            this.panelFire = new System.Windows.Forms.Panel();
            this.pictureBoxFire = new System.Windows.Forms.PictureBox();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.radioButtonKnife = new System.Windows.Forms.RadioButton();
            this.radioButtonFire = new System.Windows.Forms.RadioButton();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            this.panelRock.SuspendLayout();
            this.panelKnife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnife)).BeginInit();
            this.panelFire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.Color.Transparent;
            this.panelOptions.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Options;
            this.panelOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelOptions.Controls.Add(this.buttonExit);
            this.panelOptions.Controls.Add(this.buttonSave);
            this.panelOptions.Controls.Add(this.buttonResume);
            this.panelOptions.Location = new System.Drawing.Point(311, 335);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(399, 403);
            this.panelOptions.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Exit_Over;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(109, 280);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 69);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Save_Over;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(109, 191);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 69);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
            // 
            // buttonResume
            // 
            this.buttonResume.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Resume_Over;
            this.buttonResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResume.FlatAppearance.BorderSize = 0;
            this.buttonResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.ForeColor = System.Drawing.Color.White;
            this.buttonResume.Location = new System.Drawing.Point(109, 103);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(180, 69);
            this.buttonResume.TabIndex = 0;
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.MouseEnter += new System.EventHandler(this.buttonResume_MouseEnter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.buttonResume_MouseLeave);
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Options_Over;
            this.buttonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(595, 54);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(79, 109);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.UseVisualStyleBackColor = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            this.buttonOptions.MouseEnter += new System.EventHandler(this.buttonOptions_MouseEnter);
            this.buttonOptions.MouseLeave += new System.EventHandler(this.buttonOptions_MouseLeave);
            // 
            // pictureBoxRock
            // 
            this.pictureBoxRock.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRock.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Rock;
            this.pictureBoxRock.Location = new System.Drawing.Point(13, 15);
            this.pictureBoxRock.Name = "pictureBoxRock";
            this.pictureBoxRock.Size = new System.Drawing.Size(61, 58);
            this.pictureBoxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRock.TabIndex = 5;
            this.pictureBoxRock.TabStop = false;
            this.pictureBoxRock.Click += new System.EventHandler(this.pictureBoxRock_Click);
            this.pictureBoxRock.MouseEnter += new System.EventHandler(this.pictureBoxRock_MouseEnter);
            this.pictureBoxRock.MouseLeave += new System.EventHandler(this.pictureBoxRock_MouseLeave);
            // 
            // panelRock
            // 
            this.panelRock.BackColor = System.Drawing.Color.Transparent;
            this.panelRock.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Weapon_Over;
            this.panelRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRock.Controls.Add(this.pictureBoxRock);
            this.panelRock.Controls.Add(this.radioButtonRock);
            this.panelRock.Location = new System.Drawing.Point(381, 175);
            this.panelRock.Name = "panelRock";
            this.panelRock.Size = new System.Drawing.Size(86, 86);
            this.panelRock.TabIndex = 3;
            // 
            // panelKnife
            // 
            this.panelKnife.BackColor = System.Drawing.Color.Transparent;
            this.panelKnife.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Weapon_Over;
            this.panelKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelKnife.Controls.Add(this.pictureBoxKnife);
            this.panelKnife.Controls.Add(this.radioButtonKnife);
            this.panelKnife.Location = new System.Drawing.Point(485, 175);
            this.panelKnife.Name = "panelKnife";
            this.panelKnife.Size = new System.Drawing.Size(86, 86);
            this.panelKnife.TabIndex = 6;
            // 
            // pictureBoxKnife
            // 
            this.pictureBoxKnife.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxKnife.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Knife;
            this.pictureBoxKnife.Location = new System.Drawing.Point(17, 26);
            this.pictureBoxKnife.Name = "pictureBoxKnife";
            this.pictureBoxKnife.Size = new System.Drawing.Size(54, 36);
            this.pictureBoxKnife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxKnife.TabIndex = 5;
            this.pictureBoxKnife.TabStop = false;
            this.pictureBoxKnife.Click += new System.EventHandler(this.pictureBoxKnife_Click);
            // 
            // panelFire
            // 
            this.panelFire.BackColor = System.Drawing.Color.Transparent;
            this.panelFire.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Weapon_Over;
            this.panelFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFire.Controls.Add(this.pictureBoxFire);
            this.panelFire.Controls.Add(this.radioButtonFire);
            this.panelFire.Location = new System.Drawing.Point(588, 175);
            this.panelFire.Name = "panelFire";
            this.panelFire.Size = new System.Drawing.Size(86, 86);
            this.panelFire.TabIndex = 7;
            // 
            // pictureBoxFire
            // 
            this.pictureBoxFire.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFire.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Fireball;
            this.pictureBoxFire.Location = new System.Drawing.Point(18, 26);
            this.pictureBoxFire.Name = "pictureBoxFire";
            this.pictureBoxFire.Size = new System.Drawing.Size(52, 36);
            this.pictureBoxFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFire.TabIndex = 5;
            this.pictureBoxFire.TabStop = false;
            this.pictureBoxFire.Click += new System.EventHandler(this.pictureBoxFire_Click);
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRock.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonRock.FlatAppearance.BorderSize = 0;
            this.radioButtonRock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButtonRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButtonRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonRock.Location = new System.Drawing.Point(0, 0);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(86, 86);
            this.radioButtonRock.TabIndex = 8;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "                    ";
            this.radioButtonRock.UseVisualStyleBackColor = false;
            this.radioButtonRock.CheckedChanged += new System.EventHandler(this.radioButtonRock_CheckedChanged);
            this.radioButtonRock.Click += new System.EventHandler(this.radioButtonRock_Click);
            // 
            // radioButtonKnife
            // 
            this.radioButtonKnife.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonKnife.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonKnife.FlatAppearance.BorderSize = 0;
            this.radioButtonKnife.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButtonKnife.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonKnife.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButtonKnife.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonKnife.Location = new System.Drawing.Point(0, 0);
            this.radioButtonKnife.Name = "radioButtonKnife";
            this.radioButtonKnife.Size = new System.Drawing.Size(86, 86);
            this.radioButtonKnife.TabIndex = 9;
            this.radioButtonKnife.TabStop = true;
            this.radioButtonKnife.Text = "                    ";
            this.radioButtonKnife.UseVisualStyleBackColor = false;
            this.radioButtonKnife.CheckedChanged += new System.EventHandler(this.radioButtonKnife_CheckedChanged);
            // 
            // radioButtonFire
            // 
            this.radioButtonFire.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonFire.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButtonFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFire.FlatAppearance.BorderSize = 0;
            this.radioButtonFire.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.radioButtonFire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonFire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButtonFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonFire.Location = new System.Drawing.Point(0, 0);
            this.radioButtonFire.Name = "radioButtonFire";
            this.radioButtonFire.Size = new System.Drawing.Size(86, 86);
            this.radioButtonFire.TabIndex = 10;
            this.radioButtonFire.TabStop = true;
            this.radioButtonFire.Text = "                    ";
            this.radioButtonFire.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 961);
            this.Controls.Add(this.panelFire);
            this.Controls.Add(this.panelKnife);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelRock);
            this.DoubleBuffered = true;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            this.panelRock.ResumeLayout(false);
            this.panelKnife.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnife)).EndInit();
            this.panelFire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.Panel panelRock;
        private System.Windows.Forms.Panel panelKnife;
        private System.Windows.Forms.PictureBox pictureBoxKnife;
        private System.Windows.Forms.Panel panelFire;
        private System.Windows.Forms.PictureBox pictureBoxFire;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.RadioButton radioButtonKnife;
        private System.Windows.Forms.RadioButton radioButtonFire;
    }
}