﻿using System;
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
        public Player player;
        Enemy enemy;
        Time time;
        bool moveUp, moveDown, enemyMoveUp;
        bool allowThrowWeapon = true;
        int weaponTime = 0;
        int powerUpTime = 0;
        public FormGame()
        {
            InitializeComponent();
        }
        //Optimized Form (Loading Screen)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        #region SetThrowWeapon
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
                    player.SetWeapon("FireBall", Properties.Resources.Fireball);
                }
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

        // To reset weapon time, biar bilangan ga terlalu gede dan lag
        private void ResetWeaponTime(ref int weaponTime)
        {
            if (weaponTime > 100)
            {
                weaponTime = 0;
            }
        }

        //Reset power up time
        private void ResetPowerUpTime(ref int powerUpTime)
        {
            if (powerUpTime > 120)
            {
                powerUpTime = 0;
            }
        }
        #endregion

        #region UseUltimate
        private void pictureBoxButtonUltimate_Click(object sender, EventArgs e)
        {
            panelUltimate.BackgroundImage = Properties.Resources.Inactive_Ultimate;
            pictureBoxUltimateIcon.Hide();
            pictureBoxButtonUltimate.Hide();
        }
        private void pictureBoxUltimateIcon_Click(object sender, EventArgs e)
        {
            panelUltimate.BackgroundImage = Properties.Resources.Inactive_Ultimate;
            pictureBoxUltimateIcon.Hide();
            pictureBoxButtonUltimate.Hide();
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

            labelPlayerInfo.Text = player.DisplayData();
        }
        #endregion

        #region CreatePlayer
        private void CreatePlayer()
        {
            //Initiate Starting Position and Size Player
            Point startingPoint = new Point(87, 497);
            Size playerSize = new Size(70, 107);
            if (FormMenu.PlayerChoosen == "Man")
            {
                player = new Player("INCREDIBLE BOY", 10, 100, Properties.Resources.Man_Idle, startingPoint, playerSize, "I'm the superhero with incredible strength amd honor", 0, 15, false);
            }
            else
            {
                player = new Player("PERFECTA GIRL", 10, 100, Properties.Resources.Woman_Idle, startingPoint, playerSize, "I'm the superhero with calm and perfect play", 0, 15, false);
            }
        }
        #endregion

        #region CreateEnemy
        public void CreateEnemy()
        {
            Random random = new Random();
            int enemyType = random.Next(2); // 0 Monster || 1 Witch

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
                        enemySize = new Size(167, 156);
                        enemy = new Monster(5, "Dragon", 3, 100, Properties.Resources.Dragon, startingPoint, enemySize, "Only the heat can defeat me");
                        enemy.SetWeapon("Fire", Properties.Resources.Dragon_Weapon);

                    }
                    //Buat Godzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(157, 149);
                        enemy = new Monster(5, "Godzilla", 5, 100, Properties.Resources.Godzilla, startingPoint, enemySize, "I can't help the hard stuff");
                        enemy.SetWeapon("Fist", Properties.Resources.Godzilla_Weapon);
                    }
                    //Buat Dino ==> 2
                    else
                    {
                        enemySize = new Size(182, 104);
                        enemy = new Monster(5, "Dino", 7, 100, Properties.Resources.Dino, startingPoint, enemySize, "Ouch.. no sharp item please..");
                        enemy.SetWeapon("Claw", Properties.Resources.Dino_Weapon);
                    }
                }
                else
                {
                    //Buat MegaDragon ==> 0
                    if (monsterType == 0)
                    {
                        enemySize = new Size(163, 120);
                        enemy = new MegaMonster(5, "Mega Dragon", 3, 100, Properties.Resources.Mega_Dragon, startingPoint, enemySize, "Only the heat can defeat me", 30);
                        enemy.SetWeapon("Fire", Properties.Resources.Mega_Dragon_Weapon);
                    }
                    //Buat MegaGodzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(167, 149);
                        enemy = new MegaMonster(5, "Mega Godzilla", 5, 100, Properties.Resources.Mega_Godzilla, startingPoint, enemySize, "I can't help the hard stuff", 30);
                        enemy.SetWeapon("Fist", Properties.Resources.Mega_Godzilla_Weapon);
                    }
                    //Buat MegaDino ==> 2
                    else
                    {
                        enemySize = new Size(186, 149);
                        enemy = new MegaMonster(5, "Mega Dino", 7, 100, Properties.Resources.Mega_Dino, startingPoint, enemySize, "Ouch.. no sharp item please..", 30);
                        enemy.SetWeapon("Claw", Properties.Resources.Mega_Dino_Weapon);
                    }
                }
            }

            else //1 Witch
            {
                //Daftar random --> 0 = Broom Witch, 1 = Ancient Witch, 2 = Green Witch
                int witchType = random.Next(3);

                //Buat Broom Witch ==> 0
                if (witchType == 0)
                {
                    enemySize = new Size(117, 103);
                    enemy = new Witch(5, "Broom Witch", 1, 100, Properties.Resources.Broom_Witch, startingPoint, enemySize, 10);
                    enemy.SetWeapon("Sphere Energy", Properties.Resources.Broom_Witch_Weapon);
                }
                //Buat Ancient Witch ==> 1
                else if (witchType == 1)
                {
                    enemySize = new Size(94, 114);
                    enemy = new Witch(5, "Ancient Witch", 2, 100, Properties.Resources.Ancient_Witch, startingPoint, enemySize, 20);
                    enemy.SetWeapon("Cursed Spell", Properties.Resources.Ancient_Witch_Weapon);
                }
                //Buat Green Witch ==> 2
                else
                {
                    enemySize = new Size(136, 103);
                    enemy = new Witch(5, "Green Witch", 1, 100, Properties.Resources.Green_Witch, startingPoint, enemySize, 50);
                    enemy.SetWeapon("Green Spirit", Properties.Resources.Green_Witch_Weapon);
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
                player.SetPowerUp("Attack", Properties.Resources.Power_Up_Attack, 5);
            }
            else if (powerUpType == 1) //Life
            {
                player.SetPowerUp("Life", Properties.Resources.Power_Up_Heal, 5);
            }
            else
            {
                player.SetPowerUp("Shield", Properties.Resources.Power_Up_Shield, 5);
            }

            player.DisplayPowerUp(this);

            labelPlayerInfo.Text = player.DisplayData();

            timerPowerUp.Start();
        }
        #endregion

        private void FormGame_Load(object sender, EventArgs e)
        {
            CreatePlayer();
            timerPlayerMove.Start();
        }

        #region NotificationButton
        //Design Button Next
        private void buttonNext_Click(object sender, EventArgs e)
        {
            pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Controls;
            buttonNext.Visible = false;
            buttonStart.Visible = true;
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
            panelMiddle.Visible = false;
            //Changing picture visibility in panelMiddle
            buttonStart.Visible = false;
            pictureBoxNotifications.Visible = false;
            pictureBoxOptions.Visible = true;
            buttonResume.Visible = true;
            buttonExit.Visible = true;

            //Call method StartGame
            StartGame();
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
            panelMiddle.Visible = false;
            //Changing picture visibility in panelMiddle
            buttonPlayAgain.Visible = false;
            buttonExit.Visible = false;
            pictureBoxNotifications.Visible = false;

            //Remove old player and old enemy
            player.Remove();
            enemy.Remove();

            //Create A new player (Same gender as selected)
            CreatePlayer();
            timerPlayerMove.Start();

            //Call method StartGame
            StartGame();
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
            this.Close();
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
        //Design Button Resume (Options)
        private void buttonResume_Click(object sender, EventArgs e)
        {
            panelMiddle.Visible = false;
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
            this.Close();
        }
        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Button_Exit_Hover;
        }
        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.BackgroundImage = Properties.Resources.Button_Exit_Over;
        }

        //Design Button Options
        private void buttonOptions_Click(object sender, EventArgs e)
        {
            panelMiddle.Visible = true;
        }
        private void buttonOptions_MouseEnter(object sender, EventArgs e)
        {
            buttonOptions.BackgroundImage = Properties.Resources.Button_Options_Hover;
        }
        private void buttonOptions_MouseLeave(object sender, EventArgs e)
        {
            buttonOptions.BackgroundImage = Properties.Resources.Button_Options_Over;
        }
        #endregion

        #region PlayerMove
        private void timerPlayerMove_Tick(object sender, EventArgs e)
        {
            //Melakukan Pengecekan Weapon
            SetWeapon();

            //Pada saat pictureBox Enemy ada di di bawah koordinat 280 pictureBox akan turun
            if (moveUp && player.Picture.Top >= 280)
            {
                player.MoveUp();
                player.DisplayPicture(this);
            }
            //Pada saat pictureBox Enemy ada di atas  koordinat 710, pictureBox akan naik
            if (moveDown && player.Picture.Top <= 710)
            {
                player.MoveDown();
                player.DisplayPicture(this);
            }
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
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
                //System.Media.SoundPlayer weaponSound = new System.Media.SoundPlayer(Properties.Resources.namaFile);
                //weaponSound.Play();

                //Set Weapon
                player.SetWeapon(player.Weapon.Name, player.Weapon.Picture.Image);

                //Tampilkan Weapon saat pengguna menekan spasi
                player.DisplayWeapon(this);
                timerWeaponPlayer.Start();

                //Set Allow Weapon ke false karena sudah melempar weapon
                DisallowThrowWeapon(ref allowThrowWeapon);
            }
        }
        private void FormGame_KeyUp(object sender, KeyEventArgs e)
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
        #endregion

        #region CheckWeapon
        private bool CheckWeapon()
        {
            //Pengecekan Weapon untuk Monster
            if (enemy is Monster)
            {
                //Fireball Hit Dragon or Mega Dragon
                if ((enemy.Name == "Dragon" || enemy.Name == "Mega Dragon") && player.Weapon.Name == "FireBall")
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
            //Pada saat pictureBox Enemy ada di di bawah koordinat 280 pictureBox akan turun
            if (enemy.Picture.Top <= 280)
            {
                enemyMoveUp = false;
            }
            //Pada saat pictureBox Enemy ada di atas  koordinat 710, pictureBox akan naik
            else if (enemy.Picture.Top >= 710)
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
            weaponTime++; //Weapon Time ditambah
            if (weaponTime % 100 == 0) //Tiap kelipatan 100, Enemy menembakkan weapon
            {
                //Set Weapon Enemy
                enemy.SetWeapon(enemy.Weapon.Name, enemy.Weapon.Picture.Image);

                //Tampilkan Weapon Enemy
                enemy.DisplayWeapon(this);
                timerWeaponEnemy.Start();
            }
        }
        #endregion

        #region TimerTime
        private void timerTime_Tick(object sender, EventArgs e)
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
            }
            //Timer Countdown
            else
            {
                time.AddSecond(-1);
            }

            ResetPowerUpTime(ref powerUpTime); //Reset PowerUpTime apabila
            powerUpTime++; //Power Up Time ditambah
            if (powerUpTime % 120 == 0) //Tiap kelipatan 120 (2 menit), Power Up akan muncul
            {
                //Set Power Up
                player.SetPowerUp(player.PowerUp.Name, player.PowerUp.Picture.Image, player.PowerUp.Duration);
                //Tampilkan PoweUp
                player.DisplayPowerUp(this);
                timerPowerUp.Start();
            }
        }
        #endregion

        #region TimerPowerUp
        private void timerPowerUp_Tick(object sender, EventArgs e)
        {
            //Kalau PowerUp mengenai Player
            if (player.PowerUp.Picture.Bounds.IntersectsWith(player.Picture.Bounds))
            {
                //timerPowerUp diberhentikan
                timerPowerUp.Stop();
                //Hapus power up dari formGame
                player.RemovePowerUp();

                //Panggil method untuk mengkalkulasikan benefit yang didapat dari power up
                player.EffectPowerUp();

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
        #endregion

        #region TimerPowerUpActive
        private void timerPowerUpActive_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        #region TimerWeaponPlayer
        private void timerWeapon_Tick(object sender, EventArgs e) //Timer Weapon Player
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
                    //Play Music
                    //System.Media.SoundPlayer hitSound = new System.Media.SoundPlayer(Properties.Resources.namaFile);
                    //hitSound.Play();

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
        #endregion

        #region TimerWeaponEnemy
        private void timerWeaponEnemy_Tick(object sender, EventArgs e)
        {
            //Kalau enemy weapon mengenai player
            if (enemy.Weapon.Picture.Bounds.IntersectsWith(player.Picture.Bounds))
            {
                timerWeaponEnemy.Stop();
                enemy.RemoveWeapon();

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
                }
            }
            //Kalau Weapon sudah melewati Player
            else if (enemy.Weapon.Picture.Location.X <= -50) //Koordinat -50 merupakan batas form game
            {
                timerWeaponEnemy.Stop();
                enemy.RemoveWeapon();
            }
            //Kalau Weapon Berjalan Menuju Player
            else
            {
                enemy.ReleaseWeapon();
                enemy.DisplayWeapon(this);
            }
        }
        #endregion

        #region TimerPowerUp

        #endregion

        #endregion
    }
}
