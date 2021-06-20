using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public partial class FormGame : Form
    {
        #region DefineVariable
        Player player;
        Enemy enemy;
        Time time;
        bool moveUp, moveDown, enemyMoveUp;
        bool allowThrowWeapon, enemyThrowingWeapon = true;
        bool powerUpActive = false;
        int weaponTime, powerUpTime, powerUpActiveTime, gameSoundTime = 0;
        private WMPLib.WindowsMediaPlayer wGameSound;
        #endregion

        public FormGame()
        {
            InitializeComponent();
        }

        #region SetGameSound
        private void AddGameSoundTime(ref int gameSoundTime)
        {
            gameSoundTime++;
        }
        private bool ResetGameSoundTime(ref int gameSoundTime)
        {
            if (gameSoundTime >= 12)
            {
                gameSoundTime = 0;
                return true;
            }
            return false;
        }
        #endregion

        #region No Tick Constrols
        //Optimized Controls (No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        #endregion

        #region SetPowerUp
        //Add power up time
        private void AddPowerUpTime(ref int powerUpTime)
        {
            powerUpTime++;
        }
        //Reset power up time
        private void ResetPowerUpTime(ref int powerUpTime)
        {
            powerUpTime = 0;
        }
        //Add power up active time
        private void AddPowerUpActiveTime(ref int powerUpActiveTime)
        {
            powerUpActiveTime++;
        }
        private void SetZeroPowerUpActiveTime(ref int powerUpActiveTime)
        {
            powerUpActiveTime = 0;
        }
        //Reset power up active time
        private bool ResetPowerUpActiveTime(ref int powerUpActiveTime)
        {
            if (powerUpActiveTime > 15)
            {
                SetZeroPowerUpActiveTime(ref powerUpActiveTime);
                return true;
            }
            return false;
        }

        //Set Wether power up is active or not when paused
        private void PowerUpActive(ref bool powerUpActive)
        {
            powerUpActive = true;
        }
        private void PowerUpInactive(ref bool powerUpActive)
        {
            powerUpActive = false;
        }
        #endregion

        #region SetThrowWeapon
        private void EnemyThrowingWeapon (ref bool enemyThrowingWeapon)
        {
            enemyThrowingWeapon = true;
        }
        private void EnemyNotThrowingWeapon(ref bool enemyThrowingWeapon)
        {
            enemyThrowingWeapon = false;
        }
        private void AllowThrowWeapon(ref bool allowThrowWeapon)
        {
            allowThrowWeapon = true;
        }
        private void DisallowThrowWeapon(ref bool allowThrowWeapon)
        {
            allowThrowWeapon = false;
        }
        #endregion

        #region SetWeapon
        // Method supaya weapon tidak langsung muncul saat di select
        private void SetWeapon()
        {
            if (allowThrowWeapon)
            {
                if (panelRock.Visible == false)
                {
                    player.SetWeapon("Rock", Properties.Resources.Rock);
                }
                if (panelKnife.Visible == false)
                {
                    player.SetWeapon("Knife", Properties.Resources.Knife);
                }
                if (panelFire.Visible == false)
                {
                    player.SetWeapon("Fire", Properties.Resources.Fireball);
                }
                labelPlayerInfo.Text = player.DisplayData();
            }
        }
        public void SelectRock()
        {
            panelRock.Visible = false;
            panelKnife.Visible = true;
            panelFire.Visible = true;
        }
        public void SelectKnife()
        {
            panelRock.Visible = true;
            panelKnife.Visible = false;
            panelFire.Visible = true;
        }
        public void SelectFireBall()
        {
            panelRock.Visible = true;
            panelKnife.Visible = true;
            panelFire.Visible = false;
        }
        private void pictureBoxButtonRock_Click_1(object sender, EventArgs e)
        {
            SelectRock();
        }
        private void pictureBoxRock_Click(object sender, EventArgs e)
        {
            SelectRock();
        }
        private void pictureBoxKnife_Click(object sender, EventArgs e)
        {
            SelectKnife();
        }
        private void pictureBoxButtonKnife_Click(object sender, EventArgs e)
        {
            SelectKnife();
        }
        private void pictureBoxButtonFire_Click(object sender, EventArgs e)
        {
            SelectFireBall();
        }
        private void pictureBoxFire_Click(object sender, EventArgs e)
        {
            SelectFireBall();
        }
        // To Add weapon time
        private void AddWeaponTime (ref int weaponTime)
        {
            weaponTime++;
        }
        // To reset weapon time, biar bilangan ga terlalu gede dan lag
        private void ResetWeaponTime(ref int weaponTime)
        {
            if (weaponTime > 50)
            {
                weaponTime = 0;
            }
        }
        #endregion

        #region RemoveWeaponEnemy
        private void RemoveWeaponEnemy()
        {
            timerWeaponEnemy.Stop();
            enemy.RemoveWeapon();
        }
        #endregion

        #region StartGame
        public void StartGame()
        {
            //Set Rock as default weapon
            SelectRock();
            player.SetWeapon("Rock", Properties.Resources.Rock);

            //Display player picture
            player.DisplayPicture(this);

            //Create Enemy
            CreateEnemy();

            //Create PowerUp
            CreatePowerUp();

            //Start Time Disini
            time = new Time(0, 10, 0); //Set time 10 menit
            timerTime.Start(); //Jalankan timerTime

            //Set Allow Weapon Di awal permainan
            allowThrowWeapon = true;


            //Display Player Info
            labelPlayerInfo.Text = player.DisplayData();
            labelPowerUp.Text = "Power Up: None";
            labelPowerUp.Visible = true;
        }
        #endregion

        #region StatusWeaponButton
        private void DisabledWeaponButton()
        {
            pictureBoxButtonRock.Enabled = false;
            pictureBoxRock.Enabled = false;
            pictureBoxButtonKnife.Enabled = false;
            pictureBoxKnife.Enabled = false;
            pictureBoxButtonFire.Enabled = false;
            pictureBoxFire.Enabled = false;
        }
        private void EnabledWeaponButton()
        {
            pictureBoxButtonRock.Enabled = true;
            pictureBoxRock.Enabled = true;
            pictureBoxButtonKnife.Enabled = true;
            pictureBoxKnife.Enabled = true;
            pictureBoxButtonFire.Enabled = true;
            pictureBoxFire.Enabled = true;
        }
        #endregion

        #region ResetGame
        public void ResetGame()
        {
            timerEnemy.Stop();
            timerPlayerMove.Stop();
            timerPowerUp.Stop();
            timerPowerUpActive.Stop();
            timerTime.Stop();
            timerWeaponPlayer.Stop();
            timerWeaponEnemy.Stop();
            allowThrowWeapon = false;
            SetZeroPowerUpActiveTime(ref powerUpActiveTime);
            ResetPowerUpTime(ref powerUpTime);
            ResetWeaponTime(ref weaponTime);
            player.ResetAttackGained();
            player.ResetShield();
            player.Remove();
            enemy.Remove();
            labelEnemyInfo.Visible = true;
            labelPlayerInfo.Visible = true;
            labelPowerUp.Visible = true;

            EnabledWeaponButton();
        }
        #endregion

        #region DisabledControl
        private void DisabledControl()
        {
            //Set enable to false (buttonOptions)
            buttonOptions.Enabled = false;
            DisallowThrowWeapon(ref allowThrowWeapon);

            labelEnemyInfo.Visible = false;
            labelPlayerInfo.Visible = false;
            labelPowerUp.Visible = false;

            DisabledWeaponButton();
        }
        #endregion

        #region CreatePlayer
        private void CreatePlayer()
        {
            if (player != null)
            {
                player.Remove();
            }

            //Initiate Starting Position and Size Player
            Point startingPoint = new Point(87, 497);
            Size playerSize = new Size(70, 107);
            if (FormMenu.PlayerChoosen == "Man")
            {
                player = new Player("INCREDIBLE BOY", 10, 100, Properties.Resources.Man_Idle, startingPoint, playerSize, "I'm the superhero with incredible strength amd honor", 0, 15);
            }
            else
            {
                player = new Player("PERFECTA GIRL", 10, 100, Properties.Resources.Woman_Idle, startingPoint, playerSize, "I'm the superhero with calm and perfect play", 0, 15);
            }
        }
        #endregion

        #region CreateEnemy
        public void CreateEnemy()
        {
            Random random = new Random();
            int enemyType = random.Next(2); //0 Monster or Mega Monster || 1 Witch

            Point startingPoint = new Point(824, 475);
            Size enemySize;

            //Kalau enemy sudah ada, maka akan diremove
            if (enemy != null)
            {
                enemy.Remove();
            }

            //Buat enemy baru
            if (enemyType == 0) //0 Monster
            {
                //Daftar random --> 0 = Dragon, 1 = Godzilla, 2 = Dino (Easy) || 0 = MegaDragon, 1 = MegaGodzilla, 2 = MegaDino (Hard)
                int monsterType = random.Next(3);

                if (FormMenu.LevelDifficulty == "Easy")
                {
                    //Buat Dragon ==> 0
                    if (monsterType == 0)
                    {
                        enemySize = new Size(162, 151);
                        enemy = new Monster(7, "Dragon", 5, 100, Properties.Resources.Dragon, startingPoint, enemySize, "Only the heat can defeat me");
                        enemy.SetWeapon("Fire", Properties.Resources.Dragon_Weapon);

                    }
                    //Buat Godzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(147, 139);
                        enemy = new Monster(5, "Godzilla", 5, 100, Properties.Resources.Godzilla, startingPoint, enemySize, "I can't help the hard stuff");
                        enemy.SetWeapon("Fist", Properties.Resources.Godzilla_Weapon);
                    }
                    //Buat Dino ==> 2
                    else
                    {
                        enemySize = new Size(167, 89);
                        enemy = new Monster(6, "Dino", 5, 100, Properties.Resources.Dino, startingPoint, enemySize, "Ouch.. no sharp item please..");
                        enemy.SetWeapon("Claw", Properties.Resources.Dino_Weapon);
                    }
                }
                else
                {
                    //Buat MegaDragon ==> 0
                    if (monsterType == 0)
                    {
                        enemySize = new Size(163, 120);
                        enemy = new MegaMonster(7, "Mega Dragon", 7, 100, Properties.Resources.Mega_Dragon, startingPoint, enemySize, "Only the heat can defeat me", 30);
                        enemy.SetWeapon("Fire", Properties.Resources.Mega_Dragon_Weapon);
                    }
                    //Buat MegaGodzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(157, 130);
                        enemy = new MegaMonster(5, "Mega Godzilla", 7, 100, Properties.Resources.Mega_Godzilla, startingPoint, enemySize, "I can't help the hard stuff", 30);
                        enemy.SetWeapon("Fist", Properties.Resources.Mega_Godzilla_Weapon);
                    }
                    //Buat MegaDino ==> 2
                    else
                    {
                        enemySize = new Size(176, 75);
                        enemy = new MegaMonster(6, "Mega Dino", 7, 100, Properties.Resources.Mega_Dino, startingPoint, enemySize, "Ouch.. no sharp item please..", 30);
                        enemy.SetWeapon("Claw", Properties.Resources.Mega_Dino_Weapon);
                    }
                }
            }

            else //1 Witch
            {
                //Daftar random --> 0 = Broom Witch, 1 = Ancient Witch, 2 = Green Witch
                int witchType = random.Next(3);

                if (FormMenu.LevelDifficulty == "Easy")
                {
                    //Buat Broom Witch ==> 0
                    if (witchType == 0)
                    {
                        enemySize = new Size(112, 98);
                        enemy = new Witch(5, "Broom Witch", 1, 100, Properties.Resources.Broom_Witch, startingPoint, enemySize, 10);
                        enemy.SetWeapon("Sphere Energy", Properties.Resources.Broom_Witch_Weapon);
                    }
                    //Buat Ancient Witch ==> 1
                    else if (witchType == 1)
                    {
                        enemySize = new Size(84, 104);
                        enemy = new Witch(5, "Ancient Witch", 3, 100, Properties.Resources.Ancient_Witch, startingPoint, enemySize, 20);
                        enemy.SetWeapon("Cursed Spell", Properties.Resources.Ancient_Witch_Weapon);
                    }
                    //Buat Green Witch ==> 2
                    else
                    {
                        enemySize = new Size(131, 98);
                        enemy = new Witch(5, "Green Witch", 5, 100, Properties.Resources.Green_Witch, startingPoint, enemySize, 50);
                        enemy.SetWeapon("Green Spirit", Properties.Resources.Green_Witch_Weapon);
                    }
                }
                else
                {
                    //Buat Broom Witch ==> 0
                    if (witchType == 0)
                    {
                        enemySize = new Size(112, 98);
                        enemy = new Witch(5, "Broom Witch", 3, 100, Properties.Resources.Broom_Witch, startingPoint, enemySize, 10);
                        enemy.SetWeapon("Sphere Energy", Properties.Resources.Broom_Witch_Weapon);
                    }
                    //Buat Ancient Witch ==> 1
                    else if (witchType == 1)
                    {
                        enemySize = new Size(84, 104);
                        enemy = new Witch(5, "Ancient Witch", 5, 100, Properties.Resources.Ancient_Witch, startingPoint, enemySize, 20);
                        enemy.SetWeapon("Cursed Spell", Properties.Resources.Ancient_Witch_Weapon);
                    }
                    //Buat Green Witch ==> 2
                    else
                    {
                        enemySize = new Size(131, 98);
                        enemy = new Witch(5, "Green Witch", 7, 100, Properties.Resources.Green_Witch, startingPoint, enemySize, 50);
                        enemy.SetWeapon("Green Spirit", Properties.Resources.Green_Witch_Weapon);
                    }
                }
            }

            //Display Enemy
            enemy.DisplayPicture(this);
            //Display Enemy Info
            labelEnemyInfo.Text = enemy.DisplayDataEnemy();

            //Set Enemy Move Up == True In Beginning
            enemyMoveUp = true;
            //Start TimerEnemy
            timerEnemy.Start();
        }
        #endregion

        #region CreatePowerUp
        public void CreatePowerUp()
        {
            Random random = new Random();
            //0 --> Attack; 1 --> Life; 2 --> Shield
            int powerUpType = random.Next(3);

            if (powerUpType == 0) //Attack
            {
                player.SetPowerUp("Attack", Properties.Resources.Power_Up_Attack);
            }
            else if (powerUpType == 1) //Life
            {
                player.SetPowerUp("Life", Properties.Resources.Power_Up_Heal);
            }
            else
            {
                player.SetPowerUp("Shield", Properties.Resources.Power_Up_Shield);
            }

            player.DisplayPowerUp(this);

            labelPlayerInfo.Text = player.DisplayData();

            timerPowerUp.Start();
        }
        #endregion

        #region FormLoad
        private void FormGame_Load(object sender, EventArgs e)
        {
            //Stop Music Main Menu (MP3)
            FormMenu.wMenuSound.controls.stop();

            //Play Music (using MP3)
            wGameSound = new WMPLib.WindowsMediaPlayer();
            wGameSound.URL = Application.StartupPath + "\\Sound_Game.mp3";
            wGameSound.controls.play();
            timerGameSound.Start();

            //Create Player
            CreatePlayer();
            timerPlayerMove.Start();
        }
        #endregion

        #region FormClosed
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Play Music (using MP3)
            FormMenu.wMenuSound.controls.play();
            wGameSound.controls.stop();
            timerGameSound.Stop();

            ResetGame();

            //Play Again Main Menu Music
            FormMenu.StopMenuMusic = true;
        }
        #endregion

        #region NotificationButton
        //Design Button Next
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Controls;
                buttonNext.Visible = false;
                buttonStart.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.Button_Next_Hover;
        }
        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.Button_Next_Over;
        }

        //Design Button Start
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                //Set visible
                panelMiddle.Visible = false;
                //Changing picture visibility in panelMiddle
                buttonStart.Visible = false;
                pictureBoxNotifications.Visible = false;
                pictureBoxOptions.Visible = true;
                buttonResume.Visible = true;
                buttonExit.Visible = true;

                //Change The focus, supaya ga nge bug waktu tekan space
                this.Focus();

                //Call method StartGame
                StartGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.Button_Start_Hover;
        }
        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.Button_Start_Over;
        }

        //Design ButtonPlayAgain
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            try
            {
                panelMiddle.Visible = false;
                //Changing picture visibility in panelMiddle
                buttonPlayAgain.Visible = false;
                buttonQuitGame.Visible = false;
                pictureBoxNotifications.Visible = false;
                
                //set supaya bisa tekan option lagi
                buttonOptions.Enabled = true;

                //Change The focus, supaya ga nge bug waktu tekan space
                this.Focus();

                ResetGame();

                //Create Player with same gender that already selected
                CreatePlayer();
                timerPlayerMove.Start();

                //Call method StartGame
                StartGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonPlayAgain_MouseEnter(object sender, EventArgs e)
        {
            buttonPlayAgain.BackgroundImage = Properties.Resources.Button_Play_Again_Hover;
        }
        private void buttonPlayAgain_MouseLeave(object sender, EventArgs e)
        {
            buttonPlayAgain.BackgroundImage = Properties.Resources.Button_Play_Again_Over;
        }

        //Design ButtonQuitGame
        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

                ResetGame();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonQuitGame_MouseEnter(object sender, EventArgs e)
        {
            buttonQuitGame.BackgroundImage = Properties.Resources.Button_Quit_Game_Hover;
        }
        private void buttonQuitGame_MouseLeave(object sender, EventArgs e)
        {
            buttonQuitGame.BackgroundImage = Properties.Resources.Button_Quit_Game_Over;
        }
        #endregion

        #region OptionButton
        //Design Button Options
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            //Stop Timer
            timerTime.Stop();
            timerEnemy.Stop();
            timerPowerUp.Stop();
            if (powerUpActive) //Kalau lagi pake power up durasi power upnya di stop dulu
            {
                timerPowerUpActive.Stop();
            }
            if (!allowThrowWeapon) // Kalau player weapon ada, dihentikan dahulu
            {
                timerWeaponPlayer.Stop();
            }
            else
            {
                DisallowThrowWeapon(ref allowThrowWeapon); // Supya tidak bisa mengeluarkan weapon saat pause
            }
            if (enemyThrowingWeapon) // Kalau enemy weapon ada, dihentikan dahulu
            {
                timerWeaponEnemy.Stop();
            }

            //Changing Panel Visibility
            panelMiddle.Visible = true;
            panelMiddle.BringToFront();
            pictureBoxOptions.Visible = true;
            buttonExit.Visible = true;
            buttonResume.Visible = true;

            //Buton Weapon Set To Enable False
            DisabledWeaponButton();
        }
        private void buttonOptions_MouseEnter(object sender, EventArgs e)
        {
            buttonOptions.BackgroundImage = Properties.Resources.Button_Options_Hover;
        }
        private void buttonOptions_MouseLeave(object sender, EventArgs e)
        {
            buttonOptions.BackgroundImage = Properties.Resources.Button_Options_Over;
        }
        //Design Button Resume (Options)
        private void buttonResume_Click(object sender, EventArgs e)
        {
            //Changing panel visibility
            panelMiddle.Visible = false;
            this.Focus();

            // Start Timer Back
            timerTime.Start();
            timerEnemy.Start();
            timerPowerUp.Start();
            if (powerUpActive) //Kalau lagi pake power up di kembalikan waktunya
            {
                timerPowerUpActive.Start();
            }
            if (!allowThrowWeapon) // Kalau player weapon ada, dijalankan kembali
            {
                timerWeaponPlayer.Start();
            }
            if (enemyThrowingWeapon) // Kalau enemy weapon ada, dijalankan kembali
            {
                timerWeaponEnemy.Start();
            }

            //Buton Weapon Set To Enable True
            EnabledWeaponButton();
        }
        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.Button_Resume_Hover;
        }
        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.Button_Resume_Over;
        }

        //Design Button Exit (Options)
        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

                ResetGame(); //Memastikan Control Lama Hilang Semua
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }
        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Button_Exit_Over;
        }
        #endregion

        #region PlayerMove
        private void timerPlayerMove_Tick(object sender, EventArgs e)
        {
            try
            {
                //Melakukan Pengecekan Weapon
                SetWeapon();

                //Pada saat pictureBox Enemy ada di di bawah koordinat 305 pictureBox akan turun
                if (moveUp && player.Picture.Top >= 305)
                {
                    player.MoveUp();
                    if (player.ShieldActive) // Check Apakah Ada Shield
                    {
                        // Gerakan Shield agar mengikuti gerakan player
                        player.Shield.MoveUp();
                    }
                    player.DisplayPicture(this);
                }
                //Pada saat pictureBox Enemy ada di atas  koordinat 761, pictureBox akan naik
                if (moveDown && player.Picture.Top <= 761)
                {
                    player.MoveDown();
                    if (player.ShieldActive) // Check Apakah Ada Shield
                    {
                        // Gerakan Shield agar mengikuti gerakan player
                        player.Shield.MoveDown();
                    }
                    player.DisplayPicture(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    moveDown = true;
                }
                if (e.KeyCode == Keys.Space && allowThrowWeapon)
                {
                    //Play Music
                    WMPLib.WindowsMediaPlayer wWeaponPlayer = new WMPLib.WindowsMediaPlayer();
                    wWeaponPlayer.URL = Application.StartupPath + "\\Sound_Weapon_Player.mp3";
                    wWeaponPlayer.controls.play();

                    //Set Weapon
                    player.SetWeapon(player.Weapon.Name, player.Weapon.Picture.Image);

                    //Tampilkan Weapon saat pengguna menekan spasi
                    player.DisplayWeapon(this);
                    timerWeaponPlayer.Start();

                    //Set Allow Weapon ke false karena sudah melempar weapon
                    DisallowThrowWeapon(ref allowThrowWeapon);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormGame_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    moveDown = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region CheckWeapon
        private bool CheckWeapon()
        {
            //Pengecekan Weapon untuk Monster
            if (enemy is Monster || enemy is MegaMonster)
            {
                //Fireball Hit Dragon or Mega Dragon
                if ((enemy.Name == "Dragon" || enemy.Name == "Mega Dragon") && player.Weapon.Name == "Fire")
                {
                    return true;
                }
                //Rock Hit Godzilla or Mega Godzilla
                else if ((enemy.Name == "Godzilla" || enemy.Name == "Mega Godzilla") && player.Weapon.Name == "Rock")
                {
                    return true;
                }
                //Knife Hit Dino or Mega Dino
                else if ((enemy.Name == "Dino" || enemy.Name == "Mega Dino") && player.Weapon.Name == "Knife")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //Pengecekan Weapon untuk Witch
            else
            {
                //Knife Hit Witch (All Type)
                if (player.Weapon.Name == "Knife")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Timer

        #region TimerEnemy
        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            try
            {
                //Pada saat pictureBox Enemy ada di di bawah koordinat 305 pictureBox akan turun
                if (enemy.Picture.Top <= 305)
                {
                    enemyMoveUp = false;
                }
                //Pada saat pictureBox Enemy ada di atas  koordinat 761, pictureBox akan naik
                else if (enemy.Picture.Top >= 761)
                {
                    enemyMoveUp = true;
                }

                //Pengecekan untuk menjalankan moveUp dan moveDown
                if (enemyMoveUp)
                {
                    enemy.MoveUp();
                }
                else
                {
                    enemy.MoveDown();
                }

                ResetWeaponTime(ref weaponTime); //Reset WeaponTime apabila sudah lebih dari 100
                AddWeaponTime(ref weaponTime); //Weapon Time ditambah
                if (weaponTime % 50 == 0) //Tiap kelipatan 50, Enemy menembakkan weapon
                {
                    //Set Weapon Enemy
                    enemy.SetWeapon(enemy.Weapon.Name, enemy.Weapon.Picture.Image);

                    EnemyThrowingWeapon(ref enemyThrowingWeapon); // Set enemy throwing weapon status to true

                    //Tampilkan Weapon Enemy
                    enemy.DisplayWeapon(this);
                    timerWeaponEnemy.Start();

                    //Play Sound Enemy When Attack
                    WMPLib.WindowsMediaPlayer wWeaponEnemy = new WMPLib.WindowsMediaPlayer();
                    wWeaponEnemy.URL = Application.StartupPath + "\\Sound_Weapon_Enemy.mp3";
                    wWeaponEnemy.controls.play();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerTime
        private void timerTime_Tick(object sender, EventArgs e)
        {
            try
            {
                //Display Time in labelTime
                labelTime.Text = time.DisplayTime();

                //Cek Waktu Habis
                if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
                {
                    timerTime.Stop();

                    //Display Lose Notification
                    panelMiddle.Visible = true;
                    //Set true to notification
                    buttonPlayAgain.Visible = true;
                    buttonQuitGame.Visible = true;
                    pictureBoxNotifications.Visible = true;
                    pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Lose;
                    //Set false to other
                    pictureBoxOptions.Visible = false;
                    buttonResume.Visible = false;
                    buttonExit.Visible = false;
                    //Call method DisenabledControl
                    DisabledControl();
                }
                //Timer Countdown
                else
                {
                    time.AddSecond(-1);
                }

                if (powerUpTime > 120)
                {
                    ResetPowerUpTime(ref powerUpTime); //Reset PowerUpTime apabila sudah 120 (2 menit)
                }
                AddPowerUpTime(ref powerUpTime); //Power Up Time ditambah
                if (powerUpTime % 120 == 0) //Tiap kelipatan 120 (2 menit), Power Up akan muncul
                {
                    //Set Power Up
                    player.SetPowerUp(player.PowerUp.Name, player.PowerUp.Picture.Image);
                    //Tampilkan PoweUp
                    player.DisplayPowerUp(this);
                    timerPowerUp.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerPowerUp
        private void timerPowerUp_Tick(object sender, EventArgs e)
        {
            try
            {
                //Kalau PowerUp mengenai Player
                if (player.PowerUp.Picture.Bounds.IntersectsWith(player.Picture.Bounds))
                {
                    //Play Sound PowerUp
                    WMPLib.WindowsMediaPlayer wPowerUp = new WMPLib.WindowsMediaPlayer();
                    wPowerUp.URL = Application.StartupPath + "\\Sound_Power_Up.mp3";
                    wPowerUp.controls.play();

                    //timerPowerUp diberhentikan
                    timerPowerUp.Stop();

                    //Player mendapatkan powerUp
                    player.GetPowerUp(player.PowerUp);

                    //Apabila dapat life powerUp
                    player.EffectPowerUp();

                    //timerPowerUpActive dijalankan
                    timerPowerUpActive.Start();

                    //Hapus power up dari formGame
                    player.RemovePowerUp();

                    //Display new info (update) - Player
                    labelPlayerInfo.Text = player.DisplayData();
                }
                else if (player.PowerUp.Picture.Location.X <= -50) //Koordinat -50 merupakan batas form game bagian kiri
                {
                    //timerPowerUp diberhentikan
                    timerPowerUp.Stop();
                    //Hapus power up dari formGame
                    player.RemovePowerUp();
                }
                else
                {
                    player.ReleasePowerUp();
                    player.DisplayPowerUp(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerPowerUpActive
        private void timerPowerUpActive_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player.PowerUp.Name != "Life")
                {
                    labelPowerUp.Text = "Power Up Time : " + (15 - powerUpActiveTime).ToString(); // Show Power Up Active Time
                }
                PowerUpActive(ref powerUpActive);// Set power up status to active
                AddPowerUpActiveTime(ref powerUpActiveTime); // Power Up Second + 1
                if (ResetPowerUpActiveTime(ref powerUpActiveTime)) //Check apakah waktu power up sudah habis
                {
                    //Menghilangkan semua power up
                    timerPowerUpActive.Stop();
                    //Attack
                    player.ResetAttackGained();
                    //Shield
                    if (player.ShieldActive)
                    {
                        player.RemoveShield();
                    }
                    player.ResetShield();
                    PowerUpInactive(ref powerUpActive);// Set power up status to inactive
                    labelPowerUp.Text = "Power Up : None";  // Set Power Up Active Time To None
                }
                else
                {
                    player.ActivePowerUp(); //Mengaktifkan Power Up Attack / Shield
                    if (player.ShieldActive) //Shield Active
                    {
                        if (powerUpActiveTime == 1)//Munculkan Shield 1 kali saja agar tidak bug
                        {
                            player.SetShield(Properties.Resources.Shield); //Set Shield
                        }
                        player.DisplayShield(this);
                        player.Picture.BringToFront(); //Picture player di depan picture shield
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerWeaponPlayer
        private void timerWeapon_Tick(object sender, EventArgs e) //Timer Weapon Player
        {
            try
            {
                //Kalau Weapon mengenai Enemy
                if (player.Weapon.Picture.Bounds.IntersectsWith(enemy.Picture.Bounds))
                {
                    timerWeaponPlayer.Stop();
                    player.RemoveWeapon();
                    AllowThrowWeapon(ref allowThrowWeapon);//Set Allow Weapon jadi true karena udah mengenai enemy

                    //Check Weapon (sesuai dengan kelemahan musuh atau tidak waktu terkena)
                    if (CheckWeapon())
                    {
                        //Jalankan suara hit saat weapon player yang tepat mengenai enemy
                        WMPLib.WindowsMediaPlayer wWeaponPlayer = new WMPLib.WindowsMediaPlayer();
                        wWeaponPlayer.URL = Application.StartupPath + "\\Sound_Hit_Enemy.mp3";
                        wWeaponPlayer.controls.play();

                        //Panggil method DefeatEnemy di class Player
                        player.DefeatEnemy(enemy);
                        //Display new info (update) - Player and Enemy
                        labelPlayerInfo.Text = player.DisplayData();
                        labelEnemyInfo.Text = enemy.DisplayDataEnemy();

                        //Kalau Enemy sudah kalah (Life == 0)
                        if (enemy.Life == 0)
                        {
                            //Hapus Enemy
                            enemy.Picture.Dispose();

                            //Berhentikan semua timer
                            timerWeaponPlayer.Stop();
                            timerEnemy.Stop();
                            timerTime.Stop();
                            timerPlayerMove.Stop();

                            //Display Win Notification
                            panelMiddle.Visible = true;
                            //Set true to notification
                            buttonPlayAgain.Visible = true;
                            buttonQuitGame.Visible = true;
                            pictureBoxNotifications.Visible = true;
                            pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Win;
                            //Set false to other
                            pictureBoxOptions.Visible = false;
                            buttonResume.Visible = false;
                            buttonExit.Visible = false;

                            //Call method DisenabledControl
                            DisabledControl();

                            // Change Focus supaya teken space ga nyambung ke button click
                            this.Focus();
                        }
                    }
                }
                //Kalau Weapon sudah melewati Enemy
                else if (player.Weapon.Picture.Location.X >= 1030) //Koordinat 1030 merupakan batas form game
                {
                    timerWeaponPlayer.Stop();
                    player.RemoveWeapon();
                    AllowThrowWeapon(ref allowThrowWeapon); //Set Allow Weapon jadi true karena udah melewati enemy
                }
                //Kalau Weapon Berjalan Menuju Enemy
                else
                {
                    player.ReleaseWeapon();
                    player.DisplayWeapon(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerWeaponEnemy
        private void timerWeaponEnemy_Tick(object sender, EventArgs e)
        {
            try
            {
                if (player.ShieldActive)
                {
                    if (enemy.Weapon.Picture.Bounds.IntersectsWith(player.Shield.Picture.Bounds))
                    {
                        //Jalankan suara hit saat weapon enemy mengenai player saat power up shield aktif
                        WMPLib.WindowsMediaPlayer wShield = new WMPLib.WindowsMediaPlayer();
                        wShield.URL = Application.StartupPath + "\\Sound_Shield.mp3";
                        wShield.controls.play();

                        RemoveWeaponEnemy();
                        EnemyNotThrowingWeapon(ref enemyThrowingWeapon); // Set enemy throwing weapon status to false;
                    }
                    //Kalau Weapon sudah melewati Player
                    else if (enemy.Weapon.Picture.Location.X <= -50) //Koordinat -50 merupakan batas form game
                    {
                        RemoveWeaponEnemy();
                        EnemyNotThrowingWeapon(ref enemyThrowingWeapon); // Set enemy throwing weapon status to false;
                    }
                    //Kalau Weapon Berjalan Menuju Player
                    else
                    {
                        enemy.ReleaseWeapon();
                        enemy.DisplayWeapon(this);
                    }
                }
                else
                {
                    //Kalau enemy weapon mengenai player
                    if (enemy.Weapon.Picture.Bounds.IntersectsWith(player.Picture.Bounds))
                    {
                        //Jalankan suara hit saat weapon enemy mengenai player
                        WMPLib.WindowsMediaPlayer wWeaponEnemy = new WMPLib.WindowsMediaPlayer();
                        wWeaponEnemy.URL = Application.StartupPath + "\\Sound_Hit_Player.mp3";
                        wWeaponEnemy.controls.play();

                        RemoveWeaponEnemy();
                        EnemyNotThrowingWeapon(ref enemyThrowingWeapon); // Set enemy throwing weapon status to false;

                        //Panggil method DefeatEnemy di class Player
                        enemy.DefeatPlayer(player, FormMenu.LevelDifficulty);

                        ////Display new info (update) - Player and Enemy
                        labelPlayerInfo.Text = player.DisplayData();
                        labelEnemyInfo.Text = enemy.DisplayDataEnemy();

                        if (player.Life == 0)
                        {
                            //Hapus Enemy
                            player.Picture.Dispose();

                            //Berhentikan semua timer
                            timerWeaponPlayer.Stop();
                            timerEnemy.Stop();
                            timerTime.Stop();
                            timerPlayerMove.Stop();
                            timerWeaponEnemy.Stop();

                            //Display Lose Notification
                            panelMiddle.Visible = true;
                            //Set true to notification
                            buttonPlayAgain.Visible = true;
                            buttonQuitGame.Visible = true;
                            pictureBoxNotifications.Visible = true;
                            pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Lose;
                            //Set false to other
                            pictureBoxOptions.Visible = false;
                            buttonResume.Visible = false;
                            buttonExit.Visible = false;

                            //Call method DisenabledControl
                            DisabledControl();

                            // Change Focus supaya teken space ga nyambung ke button click
                            this.Focus();
                        }

                    }
                    //Kalau Weapon sudah melewati Player
                    else if (enemy.Weapon.Picture.Location.X <= -50) //Koordinat -50 merupakan batas form game
                    {
                        RemoveWeaponEnemy();
                        EnemyNotThrowingWeapon(ref enemyThrowingWeapon); // Set enemy throwing weapon status to false;
                    }
                    //Kalau Weapon Berjalan Menuju Player
                    else
                    {
                        enemy.ReleaseWeapon();
                        enemy.DisplayWeapon(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region TimerGameSound
        private void timerGameSound_Tick(object sender, EventArgs e)
        {
            AddGameSoundTime(ref gameSoundTime);
            if (ResetGameSoundTime(ref gameSoundTime))
            {
                wGameSound.controls.stop();
                wGameSound.controls.play();
            }
        }
        #endregion

        #endregion
    }
}
