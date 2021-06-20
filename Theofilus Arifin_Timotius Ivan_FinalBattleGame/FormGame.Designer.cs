
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
            this.buttonOptions = new System.Windows.Forms.Button();
            this.pictureBoxRock = new System.Windows.Forms.PictureBox();
            this.panelRock = new System.Windows.Forms.Panel();
            this.pictureBoxButtonRock = new System.Windows.Forms.PictureBox();
            this.panelKnife = new System.Windows.Forms.Panel();
            this.pictureBoxKnife = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonKnife = new System.Windows.Forms.PictureBox();
            this.panelFire = new System.Windows.Forms.Panel();
            this.pictureBoxFire = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonFire = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPlayerInfo = new System.Windows.Forms.Label();
            this.labelEnemyInfo = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerWeaponPlayer = new System.Windows.Forms.Timer(this.components);
            this.timerPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.buttonQuitGame = new System.Windows.Forms.Button();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBoxNotifications = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.pictureBoxOptions = new System.Windows.Forms.PictureBox();
            this.timerWeaponEnemy = new System.Windows.Forms.Timer(this.components);
            this.timerPowerUp = new System.Windows.Forms.Timer(this.components);
            this.timerPowerUpActive = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).BeginInit();
            this.panelRock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonRock)).BeginInit();
            this.panelKnife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonKnife)).BeginInit();
            this.panelFire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOptions
            // 
            this.buttonOptions.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOptions.BackgroundImage")));
            this.buttonOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Location = new System.Drawing.Point(595, 54);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(79, 109);
            this.buttonOptions.TabIndex = 0;
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
            // 
            // panelRock
            // 
            this.panelRock.BackColor = System.Drawing.Color.Transparent;
            this.panelRock.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Unselect_Weapon_Background;
            this.panelRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRock.Controls.Add(this.pictureBoxRock);
            this.panelRock.Controls.Add(this.pictureBoxButtonRock);
            this.panelRock.Location = new System.Drawing.Point(381, 175);
            this.panelRock.Name = "panelRock";
            this.panelRock.Size = new System.Drawing.Size(86, 86);
            this.panelRock.TabIndex = 3;
            // 
            // pictureBoxButtonRock
            // 
            this.pictureBoxButtonRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonRock.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxButtonRock.Name = "pictureBoxButtonRock";
            this.pictureBoxButtonRock.Size = new System.Drawing.Size(86, 86);
            this.pictureBoxButtonRock.TabIndex = 8;
            this.pictureBoxButtonRock.TabStop = false;
            this.pictureBoxButtonRock.Click += new System.EventHandler(this.pictureBoxButtonRock_Click_1);
            // 
            // panelKnife
            // 
            this.panelKnife.BackColor = System.Drawing.Color.Transparent;
            this.panelKnife.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Unselect_Weapon_Background;
            this.panelKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelKnife.Controls.Add(this.pictureBoxKnife);
            this.panelKnife.Controls.Add(this.pictureBoxButtonKnife);
            this.panelKnife.Location = new System.Drawing.Point(485, 175);
            this.panelKnife.Name = "panelKnife";
            this.panelKnife.Size = new System.Drawing.Size(86, 86);
            this.panelKnife.TabIndex = 4;
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
            // pictureBoxButtonKnife
            // 
            this.pictureBoxButtonKnife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonKnife.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxButtonKnife.Name = "pictureBoxButtonKnife";
            this.pictureBoxButtonKnife.Size = new System.Drawing.Size(86, 86);
            this.pictureBoxButtonKnife.TabIndex = 7;
            this.pictureBoxButtonKnife.TabStop = false;
            this.pictureBoxButtonKnife.Click += new System.EventHandler(this.pictureBoxButtonKnife_Click);
            // 
            // panelFire
            // 
            this.panelFire.BackColor = System.Drawing.Color.Transparent;
            this.panelFire.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Unselect_Weapon_Background;
            this.panelFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFire.Controls.Add(this.pictureBoxFire);
            this.panelFire.Controls.Add(this.pictureBoxButtonFire);
            this.panelFire.Location = new System.Drawing.Point(588, 175);
            this.panelFire.Name = "panelFire";
            this.panelFire.Size = new System.Drawing.Size(86, 86);
            this.panelFire.TabIndex = 5;
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
            // pictureBoxButtonFire
            // 
            this.pictureBoxButtonFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxButtonFire.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxButtonFire.Name = "pictureBoxButtonFire";
            this.pictureBoxButtonFire.Size = new System.Drawing.Size(86, 86);
            this.pictureBoxButtonFire.TabIndex = 8;
            this.pictureBoxButtonFire.TabStop = false;
            this.pictureBoxButtonFire.Click += new System.EventHandler(this.pictureBoxButtonFire_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Knife;
            this.pictureBox2.Location = new System.Drawing.Point(500, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(605, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(426, 96);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 31);
            this.labelTime.TabIndex = 6;
            // 
            // labelPlayerInfo
            // 
            this.labelPlayerInfo.AutoSize = true;
            this.labelPlayerInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayerInfo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.labelPlayerInfo.ForeColor = System.Drawing.Color.White;
            this.labelPlayerInfo.Location = new System.Drawing.Point(62, 124);
            this.labelPlayerInfo.Name = "labelPlayerInfo";
            this.labelPlayerInfo.Size = new System.Drawing.Size(0, 20);
            this.labelPlayerInfo.TabIndex = 1;
            // 
            // labelEnemyInfo
            // 
            this.labelEnemyInfo.AutoSize = true;
            this.labelEnemyInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemyInfo.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.labelEnemyInfo.ForeColor = System.Drawing.Color.White;
            this.labelEnemyInfo.Location = new System.Drawing.Point(724, 124);
            this.labelEnemyInfo.Name = "labelEnemyInfo";
            this.labelEnemyInfo.Size = new System.Drawing.Size(0, 20);
            this.labelEnemyInfo.TabIndex = 2;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Interval = 10;
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // timerWeaponPlayer
            // 
            this.timerWeaponPlayer.Interval = 5;
            this.timerWeaponPlayer.Tick += new System.EventHandler(this.timerWeapon_Tick);
            // 
            // timerPlayerMove
            // 
            this.timerPlayerMove.Interval = 1;
            this.timerPlayerMove.Tick += new System.EventHandler(this.timerPlayerMove_Tick);
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackColor = System.Drawing.Color.Transparent;
            this.panelMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMiddle.Controls.Add(this.buttonQuitGame);
            this.panelMiddle.Controls.Add(this.buttonPlayAgain);
            this.panelMiddle.Controls.Add(this.buttonStart);
            this.panelMiddle.Controls.Add(this.buttonNext);
            this.panelMiddle.Controls.Add(this.pictureBoxNotifications);
            this.panelMiddle.Controls.Add(this.buttonExit);
            this.panelMiddle.Controls.Add(this.buttonResume);
            this.panelMiddle.Controls.Add(this.pictureBoxOptions);
            this.panelMiddle.Location = new System.Drawing.Point(324, 336);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(400, 400);
            this.panelMiddle.TabIndex = 9;
            // 
            // buttonQuitGame
            // 
            this.buttonQuitGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuitGame.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Quit_Game_Over;
            this.buttonQuitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuitGame.FlatAppearance.BorderSize = 0;
            this.buttonQuitGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonQuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuitGame.Location = new System.Drawing.Point(210, 290);
            this.buttonQuitGame.Name = "buttonQuitGame";
            this.buttonQuitGame.Size = new System.Drawing.Size(136, 53);
            this.buttonQuitGame.TabIndex = 16;
            this.buttonQuitGame.UseVisualStyleBackColor = false;
            this.buttonQuitGame.Visible = false;
            this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
            this.buttonQuitGame.MouseEnter += new System.EventHandler(this.buttonQuitGame_MouseEnter);
            this.buttonQuitGame.MouseLeave += new System.EventHandler(this.buttonQuitGame_MouseLeave);
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayAgain.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Play_Again_Over;
            this.buttonPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlayAgain.FlatAppearance.BorderSize = 0;
            this.buttonPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayAgain.Location = new System.Drawing.Point(54, 290);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(136, 53);
            this.buttonPlayAgain.TabIndex = 15;
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Visible = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            this.buttonPlayAgain.MouseEnter += new System.EventHandler(this.buttonPlayAgain_MouseEnter);
            this.buttonPlayAgain.MouseLeave += new System.EventHandler(this.buttonPlayAgain_MouseLeave);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Start_Over;
            this.buttonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Location = new System.Drawing.Point(111, 283);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(180, 69);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.MouseEnter += new System.EventHandler(this.buttonStart_MouseEnter);
            this.buttonStart.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Next_Over;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(111, 283);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(180, 69);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            this.buttonNext.MouseEnter += new System.EventHandler(this.buttonNext_MouseEnter);
            this.buttonNext.MouseLeave += new System.EventHandler(this.buttonNext_MouseLeave);
            // 
            // pictureBoxNotifications
            // 
            this.pictureBoxNotifications.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNotifications.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Notif_Welcome;
            this.pictureBoxNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNotifications.Location = new System.Drawing.Point(4, 100);
            this.pictureBoxNotifications.Name = "pictureBoxNotifications";
            this.pictureBoxNotifications.Size = new System.Drawing.Size(393, 222);
            this.pictureBoxNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotifications.TabIndex = 12;
            this.pictureBoxNotifications.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Exit_Over;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(111, 253);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 69);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseLeave);
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Transparent;
            this.buttonResume.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Button_Resume_Over;
            this.buttonResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResume.FlatAppearance.BorderSize = 0;
            this.buttonResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Location = new System.Drawing.Point(111, 136);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(180, 69);
            this.buttonResume.TabIndex = 10;
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            this.buttonResume.MouseEnter += new System.EventHandler(this.buttonResume_MouseEnter);
            this.buttonResume.MouseLeave += new System.EventHandler(this.buttonResume_MouseLeave);
            // 
            // pictureBoxOptions
            // 
            this.pictureBoxOptions.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOptions.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.Options;
            this.pictureBoxOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxOptions.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxOptions.Name = "pictureBoxOptions";
            this.pictureBoxOptions.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOptions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOptions.TabIndex = 0;
            this.pictureBoxOptions.TabStop = false;
            this.pictureBoxOptions.Visible = false;
            // 
            // timerWeaponEnemy
            // 
            this.timerWeaponEnemy.Interval = 5;
            this.timerWeaponEnemy.Tick += new System.EventHandler(this.timerWeaponEnemy_Tick);
            // 
            // timerPowerUp
            // 
            this.timerPowerUp.Interval = 10;
            this.timerPowerUp.Tick += new System.EventHandler(this.timerPowerUp_Tick);
            // 
            // timerPowerUpActive
            // 
            this.timerPowerUpActive.Interval = 1000;
            this.timerPowerUpActive.Tick += new System.EventHandler(this.timerPowerUpActive_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Theofilus_Arifin_Timotius_Ivan_FinalBattleGame.Properties.Resources.In_Game_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 961);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelEnemyInfo);
            this.Controls.Add(this.labelPlayerInfo);
            this.Controls.Add(this.panelFire);
            this.Controls.Add(this.panelKnife);
            this.Controls.Add(this.panelRock);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Battle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRock)).EndInit();
            this.panelRock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonRock)).EndInit();
            this.panelKnife.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonKnife)).EndInit();
            this.panelFire.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.PictureBox pictureBoxRock;
        private System.Windows.Forms.Panel panelRock;
        private System.Windows.Forms.Panel panelKnife;
        private System.Windows.Forms.PictureBox pictureBoxKnife;
        private System.Windows.Forms.Panel panelFire;
        private System.Windows.Forms.PictureBox pictureBoxFire;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxButtonKnife;
        private System.Windows.Forms.PictureBox pictureBoxButtonFire;
        private System.Windows.Forms.PictureBox pictureBoxButtonRock;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPlayerInfo;
        private System.Windows.Forms.Label labelEnemyInfo;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Timer timerWeaponPlayer;
        private System.Windows.Forms.Timer timerPlayerMove;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.PictureBox pictureBoxOptions;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBoxNotifications;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuitGame;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Timer timerWeaponEnemy;
        private System.Windows.Forms.Timer timerPowerUp;
        private System.Windows.Forms.Timer timerPowerUpActive;
    }
}