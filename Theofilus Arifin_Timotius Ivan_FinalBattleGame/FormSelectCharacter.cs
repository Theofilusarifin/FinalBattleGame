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
            pictureBoxBackgroundMan.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxManPlayer.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxBackgroundWoman.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxWomanPlayer.BackgroundImage = Properties.Resources.Button_Click;
        }
        private void SelectedWoman()
        {
            pictureBoxBackgroundMan.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxManPlayer.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxBackgroundWoman.BackgroundImage = Properties.Resources.Button_Click;
            pictureBoxWomanPlayer.BackgroundImage = Properties.Resources.Button_Click;
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
    }
}
