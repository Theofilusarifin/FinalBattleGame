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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pictureBoxDagger.Left -= 15;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            panelOptions.Visible = false;
        }
        
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
        #region SetWeapon
        public void SelectRock()
        {
            panelRock.Hide();
            panelKnife.Show();
            panelFire.Show();
        }
        public void SelectKnife()
        {
            panelRock.Show();
            panelKnife.Hide();
            panelFire.Show();
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
    }
}
