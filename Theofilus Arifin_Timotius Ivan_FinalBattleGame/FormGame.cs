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
        #region METHODS
        private void DesignWeaponHover(Panel panel)
        {
            panel.BackgroundImage = Properties.Resources.Weapon_Hover;
        }
        private void DesignWeaponOver(Panel panel)
        {
            panel.BackgroundImage = Properties.Resources.Weapon_Over;
        }
        private void DesignWeaponClick(Panel panel)
        {
            panel.BackgroundImage = Properties.Resources.Weapon_Click;
        }
        #endregion
        public FormGame()
        {
            InitializeComponent();
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

        //Click picture box --> radio button active
        private void pictureBoxRock_Click(object sender, EventArgs e)
        {
            radioButtonRock.Checked = true;
        }
        private void pictureBoxKnife_Click(object sender, EventArgs e)
        {
            radioButtonKnife.Checked = true;
        }
        private void pictureBoxFire_Click(object sender, EventArgs e)
        {
            radioButtonFire.Checked = true;
        }

        //Design Rock (Button) - Weapon
        private void radioButtonRock_CheckedChanged(object sender, EventArgs e)
        {
            //DesignWeaponClick(panelRock);
        }
        private void radioButtonRock_Click(object sender, EventArgs e)
        {
            if (radioButtonRock.Checked)
            {
                DesignWeaponClick(panelRock);
            }
            else
            {
                DesignWeaponOver(panelRock);
            }
        }
        private void pictureBoxRock_MouseEnter(object sender, EventArgs e)
        {
            if (radioButtonRock.Checked == false)
            {
                DesignWeaponHover(panelRock);
            }
        }
        private void pictureBoxRock_MouseLeave(object sender, EventArgs e)
        {
            if (radioButtonRock.Checked == false)
            {
                DesignWeaponOver(panelRock);
            }
        }

        //Design Knife (Button) - Weapon
        private void radioButtonKnife_CheckedChanged(object sender, EventArgs e)
        {
            DesignWeaponClick(panelKnife);
        }
    }
}
