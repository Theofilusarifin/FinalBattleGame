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
        public void StartGame()
        {
            SelectRock();

            //SET WEAPON/////////////////////////////////////////////////////////////////////////////////

            player.DisplayPicture(this);

            //Start Time Disini
            time = new Time(0, 10, 0); //Set time 10 menit
            timerTime.Start(); //Jalankan timerTime

            //Create Enemy
            CreateEnemy();
        }
        public void DisplayPlayerInfo()
        {
            labelPlayerName.Text = player.Name;
            labelHealthPlayer.Text = player.Health.ToString() + "%";
            labelLifePlayer.Text = player.Life.ToString();
            labelScore.Text = player.Score.ToString();
            labelWeapon.Text = player.Weapon.Name.ToString();
        }
        public void DisplayEnemyInfo()
        {
            labelEnemyName.Text = enemy.Name;
            labelHealthEnemy.Text = enemy.Health.ToString() + "%";
            labelLifeEnemy.Text = enemy.Life.ToString();
            labelSpeed.Text = enemy.Speed.ToString();

            //BELUM FIX//////////////////////////////////////////////////////////////////////////////////

            if (enemy is Monster)
            {
                //Display hint
                labelHintHealthDamage.Text = "Hint: ";
            }
            else if (enemy is Witch)
            {
                //Display healthDamage
                labelHintHealthDamage.Text = "Health Damage: ";
            }
        }
        public void CreateEnemy()
        {
            Random random = new Random();
            int enemyType = random.Next(2); // 0 Monster || 1 Witch

            Point startingPoint = new Point(824, 387);
            Size enemySize = new Size(163, 120);

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

                //Buat Dragon or MegaDragon ==> 0
                if (monsterType == 0)
                {
                    enemy = new Monster(100, "Dragon", 3, 100, Properties.Resources.Dragon, startingPoint, enemySize, "Only the heat can defeat me", false);
                }
                //Buat Godzilla or MegaGodzilla ==> 1
                else if (monsterType == 1)
                {
                    enemy = new Monster(30, "Godzilla", 5, 100, Properties.Resources.Godzilla, startingPoint, enemySize, "Really can't help the hard stuff upon me", false);
                }
                //Buat Dino or MegaDino ==> 2
                else
                {
                    enemy = new Monster(150, "Dino", 7, 100, Properties.Resources.Dino, startingPoint, enemySize, "Ouch.. no sharp item please..", false);
                }
            }

            else //1 Witch
            {
                //Daftar random --> 0 = Broom Witch, 1 = Ancient Witch, 2 = Green Witch
                int witchType = random.Next(3);

                //Buat Broom Witch ==> 0
                if (witchType == 0)
                {
                    enemy = new Witch(100, "Broom Witch", 1, 100, Properties.Resources.Broom_Witch, startingPoint, enemySize, 10);
                }
                //Buat Ancient Witch ==> 1
                else if (witchType == 1)
                {
                    enemy = new Witch(150, "Ancient Witch", 2, 100, Properties.Resources.Ancient_Witch, startingPoint, enemySize, 20);
                }
                //Buat Green Witch ==> 2
                else
                {
                    enemy = new Witch(200, "Green Witch", 1, 100, Properties.Resources.Green_Witch, startingPoint, enemySize, 50);
                }
            }

            //Display Enemy
            enemy.DisplayPicture(this);
            //Display Enemy Info
            DisplayEnemyInfo();
            //Set Interval Enemy Speed
            timerEnemy.Interval = enemy.Speed;

            //Set Enemy Move Up == True In Beginning
            enemyMoveUp = true;
            //Start TimerEnemy
            timerEnemy.Start();
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelOptions.Visible = false;
            timerPlayerMove.Start();

            Point startingPoint = new Point(87, 497);
            Size playerSize = new Size(108, 120);

            Image playerImage = Properties.Resources.Active_Background_Man;
            player = new Player("name", 10, 100, playerImage, startingPoint, playerSize, "desc", 0, 20, false);
        }

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

        //Design Button Save (Options)
        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            buttonSave.BackgroundImage = Properties.Resources.Button_Save_Hover;
        }
        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            buttonSave.BackgroundImage = Properties.Resources.Button_Save_Over;
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
            panelOptions.Visible = true;
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

        #region SetWeapon
        public void SelectRock()
        {
            panelRock.Hide();
            panelKnife.Show();
            panelFire.Show();
            player.SetWeapon("Rock", "It's a heavy giant rock", Properties.Resources.Rock);
        }
        public void SelectKnife()
        {
            panelRock.Show();
            panelKnife.Hide();
            panelFire.Show();
            player.SetWeapon("Rock", "It's a heavy giant rock", Properties.Resources.Rock);
        }
        public void SelectFire()
        {
            panelRock.Show();
            panelKnife.Show();
            panelFire.Hide();
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
            SelectFire();
        }
        private void pictureBoxFire_Click(object sender, EventArgs e)
        {
            SelectFire();
        }
        #endregion
        private void buttonResume_Click(object sender, EventArgs e)
        {
            panelOptions.Visible = false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void timerPlayerMove_Tick(object sender, EventArgs e)
        {
            //pictureBoxEnemy.Top -= 20;
            if (moveUp)
            {
                pictureBoxPlayer.Top -= player.Speed;
            }
            if (moveDown)
            {
                pictureBoxPlayer.Top += player.Speed;
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
        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            //Pada saat pictureBox Enemy ada di di bawah (labelHintHealthDamage + 50), pictureBox akan turun
            if (enemy.Picture.Location.Y <= labelHintHealthDamage.Height + 50)
            {
                enemyMoveUp = false;
            }
            //Pada saat pictureBox Enemy ada di atas bagian bawah FormGame, pictureBox akan naik
            else if (enemy.Picture.Location.Y >= this.Height - enemy.Picture.Size.Height)
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
    }
}
