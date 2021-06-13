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
    public partial class FormSelectDifficulty : Form
    {
        public FormSelectDifficulty()
        {
            InitializeComponent();
        }

        //Design Button Easy
        private void buttonEasy_MouseEnter(object sender, EventArgs e)
        {
            buttonEasy.BackgroundImage = Properties.Resources.Button_Easy_Hover;
        }
        private void buttonEasy_MouseLeave(object sender, EventArgs e)
        {
            buttonEasy.BackgroundImage = Properties.Resources.Button_Easy_Over;
        }

        //Design Button Hard
        private void buttonHard_MouseEnter(object sender, EventArgs e)
        {
            buttonHard.BackgroundImage = Properties.Resources.Button_Hard_Hover;
        }
        private void buttonHard_MouseLeave(object sender, EventArgs e)
        {
            buttonHard.BackgroundImage = Properties.Resources.Button_Hard_Over;
        }
    }
}
