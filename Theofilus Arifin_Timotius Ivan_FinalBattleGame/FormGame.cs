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
        public Player player;
        Enemy enemy;
        Time time;
        bool moveUp, moveDown, enemyMoveUp;
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

        #region SetWeapon
        public void SelectRock()
        {
            panelRock.Hide();
            panelKnife.Show();
            panelFire.Show();
            player.SetWeapon("Rock", Properties.Resources.Rock);
        }
        public void SelectKnife()
        {
            panelRock.Show();
            panelKnife.Hide();
            panelFire.Show();
            player.SetWeapon("Knife", Properties.Resources.Knife);
        }
        public void SelectFireBall()
        {
            panelRock.Show();
            panelKnife.Show();
            panelFire.Hide();
            player.SetWeapon("FireBall", Properties.Resources.Fireball);
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

        public void StartGame()
        {
            //Set Rock as default weapon
            SelectRock();

            //Display player picture
            player.DisplayPicture(this);

            //Create Enemy
            CreateEnemy();

            //Start Time Disini
            time = new Time(0, 10, 0); //Set time 10 menit
            timerTime.Start(); //Jalankan timerTime

            labelPlayerInfo.Text = player.DisplayData();
        }

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
                    }
                    //Buat Godzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(157, 149);
                        enemy = new Monster(5, "Godzilla", 5, 100, Properties.Resources.Godzilla, startingPoint, enemySize, "I can't help the hard stuff");
                    }
                    //Buat Dino ==> 2
                    else
                    {
                        enemySize = new Size(182, 104);
                        enemy = new Monster(5, "Dino", 7, 100, Properties.Resources.Dino, startingPoint, enemySize, "Ouch.. no sharp item please..");
                    }
                }
                else
                {
                    //Buat MegaDragon ==> 0
                    if (monsterType == 0)
                    {
                        enemySize = new Size(163, 120);
                        enemy = new Monster(5, "Mega Dragon", 3, 100, Properties.Resources.Mega_Dragon, startingPoint, enemySize, "Only the heat can defeat me");
                    }
                    //Buat MegaGodzilla ==> 1
                    else if (monsterType == 1)
                    {
                        enemySize = new Size(167, 149);
                        enemy = new Monster(5, "Mega Godzilla", 5, 100, Properties.Resources.Mega_Godzilla, startingPoint, enemySize, "I can't help the hard stuff");
                    }
                    //Buat MegaDino ==> 2
                    else
                    {
                        enemySize = new Size(186, 149);
                        enemy = new Monster(5, "Mega Dino", 7, 100, Properties.Resources.Mega_Dino, startingPoint, enemySize, "Ouch.. no sharp item please..");
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
                }
                //Buat Ancient Witch ==> 1
                else if (witchType == 1)
                {
                    enemySize = new Size(94, 114);
                    enemy = new Witch(5, "Ancient Witch", 2, 100, Properties.Resources.Ancient_Witch, startingPoint, enemySize, 20);
                }
                //Buat Green Witch ==> 2
                else
                {
                    enemySize = new Size(136, 103);
                    enemy = new Witch(5, "Green Witch", 1, 100, Properties.Resources.Green_Witch, startingPoint, enemySize, 50);
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

        private void FormGame_Load(object sender, EventArgs e)
        {
            //Initiate Starting Position and Size Player
            Point startingPoint = new Point(87, 497);
            Size playerSize = new Size(70, 107);
            if (FormMenu.PlayerChoosen == "Man")
            {
                player = new Player("INCREDIBLE BOY", 10, 100, Properties.Resources.Man_Idle, startingPoint, playerSize, "I'm the superhero with incredible strength amd honor", 0, 20, false);
            }
            else
            {
                player = new Player("PERFECTA GIRL", 10, 100, Properties.Resources.Woman_Idle, startingPoint, playerSize, "I'm the superhero with calm and perfect play", 0, 20, false);
            }

            timerPlayerMove.Start();

            //Call method StartGame in FormGame
            StartGame();

            //Set Visible
            pictureBoxOptions.Visible = false;
            buttonResume.Visible = false;
            buttonExit.Visible = false;
            buttonStart.Visible = false;
        }
        #region NotificationButton
        //Design Button Next
        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.Button_Next_Hover;
        }
        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.Button_Next_Over;
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            pictureBoxNotifications.BackgroundImage = Properties.Resources.Notif_Controls;
            buttonNext.Visible = false;
            buttonStart.Visible = true;
        }
        //Design Button Start
        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.Button_Start_Hover;
        }
        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.Button_Start_Over;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            panelMiddle.Visible = false;
            //Changing Picture Visibility in panelMiddle
            buttonStart.Visible = false;
            pictureBoxNotifications.Visible = false;
            pictureBoxOptions.Visible = true;
            buttonResume.Visible = true;
            buttonExit.Visible = true;
        }
        #endregion
        #region OptionButton
        //Design Button Resume (Options)
        private void buttonResume_MouseEnter(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.Button_Resume_Hover;
        }
        private void buttonResume_MouseLeave(object sender, EventArgs e)
        {
            buttonResume.BackgroundImage = Properties.Resources.Button_Resume_Over;
        }

        //Design Button Exit (Options)
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
        private void buttonResume_Click(object sender, EventArgs e)
        {
            panelMiddle.Visible = false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region PlayerMove
        private void timerPlayerMove_Tick(object sender, EventArgs e)
        {
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
            if (e.KeyCode == Keys.Space)
            {
                //Play Music
                //System.Media.SoundPlayer weaponSound = new System.Media.SoundPlayer(Properties.Resources.namaFile);
                //weaponSound.Play();

                //Set Weapon
                player.SetWeapon(player.Weapon.Name, player.Weapon.Picture.Image);

                //Tampilkan Weapon saat pengguna menekan spasi
                player.DisplayWeapon(this);
                timerWeapon.Start();
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

        private void timerWeapon_Tick(object sender, EventArgs e)
        {
            //Kalau Weapon mengenai Enemy
            if (player.Weapon.Picture.Bounds.IntersectsWith(enemy.Picture.Bounds))
            {
                timerWeapon.Stop();
                player.RemoveWeapon();
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
                        timerWeapon.Stop();
                        timerEnemy.Stop();
                        timerTime.Stop();
                        timerPlayerMove.Stop();
                        //Display custom message Win

                    }
                }
            }
            //Kalau Weapon sudah melewati Enemy
            else if (player.Weapon.Picture.Location.X == 558)
            {
                timerWeapon.Stop();
                player.RemoveWeapon();
            }
            //Kalau Weapon tidak mengenai Enemy
            else
            {
                player.ReleaseWeapon();
                player.DisplayWeapon(this);
            }
        }


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
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            //Display Time in labelTime
            labelTime.Text = time.DisplayTime();

            //Cek Waktu Habis
            if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
            {
                timerTime.Stop();
            }
            //Timer Countdown
            else
            {
                time.AddSecond(-1);
            }
        }
    }
}
