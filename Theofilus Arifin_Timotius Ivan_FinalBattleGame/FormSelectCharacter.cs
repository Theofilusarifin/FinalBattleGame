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
        public FormSelectCharacter()
        {
            InitializeComponent();
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Hover;
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.Button_Play_Select_Character_Over;
        }
    }
}
