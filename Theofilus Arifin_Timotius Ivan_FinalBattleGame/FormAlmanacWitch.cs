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
    public partial class FormAlmanacWitch : Form
    {
        public FormAlmanacWitch()
        {
            InitializeComponent();
        }

        //Design Button Close
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Close_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Close_Over;
        }

        //Design Button Back To Almanac Index
        private void buttonBackToAlmanac_MouseEnter(object sender, EventArgs e)
        {
            buttonBackToAlmanac.BackgroundImage = Properties.Resources.Button_Back_Almanac_Hover;
        }
        private void buttonBackToAlmanac_MouseLeave(object sender, EventArgs e)
        {
            buttonBackToAlmanac.BackgroundImage = Properties.Resources.Button_Back_Almanac_Over;
        }
        private void buttonBackToAlmanac_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTheBroom_Click(object sender, EventArgs e)
        {

        }

        private void buttonAncientWitch_Click(object sender, EventArgs e)
        {

        }

        private void buttonGreenWitch_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }
    }
}
