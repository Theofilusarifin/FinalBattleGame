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
        #region METHODS
        private void SelectedMan()
        {
            panelMan.BackgroundImage = Properties.Resources.Active_Background_Man;
            pictureBoxManPlayer.Image = Properties.Resources.Selected_Man;
            panelWoman.BackgroundImage = Properties.Resources.Non_Active_Background_Woman;
            pictureBoxWomanPlayer.Image = Properties.Resources.Unselected_Woman;
            pictureBoxText.BackgroundImage = Properties.Resources.Text_Man;
        }
        private void SelectedWoman()
        {
            panelWoman.BackgroundImage = Properties.Resources.Active_Background_Woman;
            pictureBoxWomanPlayer.Image = Properties.Resources.Selected_Woman;
            panelMan.BackgroundImage = Properties.Resources.Non_Active_Background_Man;
            pictureBoxManPlayer.Image = Properties.Resources.Unselected_Man;
            pictureBoxText.BackgroundImage = Properties.Resources.Text_Woman;
        }
        #endregion
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
        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Hover;
        }
        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Over;
        }
        private void pictureBoxBackgroundMan_Click(object sender, EventArgs e)
        {
            SelectedMan();
        }
        private void pictureBoxManPlayer_Click(object sender, EventArgs e)
        {
            SelectedMan();
        }
        private void pictureBoxBackgroundWoman_Click(object sender, EventArgs e)
        {
            SelectedWoman();
        }
        private void pictureBoxWomanPlayer_Click(object sender, EventArgs e)
        {
            SelectedWoman();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Hide();
            FormGame formGame = new FormGame();
            formGame.Owner = this;
            formGame.ShowDialog();
            Close();
        }
    }
}
