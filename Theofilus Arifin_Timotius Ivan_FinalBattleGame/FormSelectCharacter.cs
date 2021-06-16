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
    public partial class FormSelectCharacter : Form
    {
        bool man = true;
        public FormSelectCharacter()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                // Define Choosen Player
                if (man)
                {
                    FormMenu.PlayerChoosen = "Man";
                }
                else
                {
                    FormMenu.PlayerChoosen = "Woman";
                }
                Hide();
                FormGame formGame = new FormGame();
                formGame.Owner = this;
                formGame.ShowDialog();
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSelectCharacter_Load(object sender, EventArgs e)
        {
            radioButtonMan.Checked = true;
        }

        //Button Play
        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Hover;
        }
        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Over;
        }

        //PictureBox and Panel Man Clicked
        private void pictureBoxManPlayer_Click(object sender, EventArgs e)
        {
            radioButtonMan.PerformClick();
            man = true;
        }
        private void pictureBoxWomanPlayer_Click(object sender, EventArgs e)
        {
            radioButtonWoman.PerformClick();
            man = false;
        }

        //PictureBox and Panel Woman Clicked
        private void panelMan_Click(object sender, EventArgs e)
        {
            radioButtonMan.PerformClick();
            man = true;
        }

        private void panelWoman_Click(object sender, EventArgs e)
        {
            radioButtonWoman.PerformClick();
            man = false;
        }

        //Radio Button Man Checked ==> True
        private void radioButtonMan_CheckedChanged(object sender, EventArgs e)
        {
            panelMan.BackgroundImage = Properties.Resources.Active_Background_Man;
            pictureBoxManPlayer.Image = Properties.Resources.Selected_Man;
            panelWoman.BackgroundImage = Properties.Resources.Non_Active_Background_Woman;
            pictureBoxWomanPlayer.Image = Properties.Resources.Unselected_Woman;
            pictureBoxText.BackgroundImage = Properties.Resources.Text_Man;
        }

        //Radia Button Woman Checked ==> True
        private void radioButtonWoman_CheckedChanged(object sender, EventArgs e)
        {
            panelWoman.BackgroundImage = Properties.Resources.Active_Background_Woman;
            pictureBoxWomanPlayer.Image = Properties.Resources.Selected_Woman;
            panelMan.BackgroundImage = Properties.Resources.Non_Active_Background_Man;
            pictureBoxManPlayer.Image = Properties.Resources.Unselected_Man;
            pictureBoxText.BackgroundImage = Properties.Resources.Text_Woman;
        }
    }
}
