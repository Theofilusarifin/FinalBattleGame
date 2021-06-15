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
        Player player;
        bool moveUp, moveDown;
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
            player.DisplayPicture(this);

            //Start Time Disini
        }
        public void CreateEnemy()
        {
            Random random = new Random();
            int enemyType = random.Next(2); // 0 Monster || 1 Witch
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            panelOptions.Visible = false;
            timerPlayerMove.Start();
            Point startingPoint = new Point(87, 497);
            Size PlayerSize = new Size(108, 120);
            Image playerImage = Properties.Resources.Active_Background_Man;
            player = new Player("name", 10, 100, playerImage, startingPoint, PlayerSize, "desc", 0, 20, false);
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
