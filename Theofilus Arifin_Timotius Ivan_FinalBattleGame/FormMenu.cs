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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        //Design Button New Game
        private void buttonNewGame_MouseLeave(object sender, EventArgs e)
        {
            buttonNewGame.BackgroundImage = Properties.Resources.Button_New_Over;
        }
        private void buttonNewGame_MouseEnter(object sender, EventArgs e)
        {
            buttonNewGame.BackgroundImage = Properties.Resources.Button_New_Hover;
        }
        //End Design Button New Game

        //Design Button Continue
        private void buttonContinue_MouseLeave(object sender, EventArgs e)
        {
            buttonContinue.BackgroundImage = Properties.Resources.Button_Continue_Over;
        }
        private void buttonContinue_MouseEnter(object sender, EventArgs e)
        {
            buttonContinue.BackgroundImage = Properties.Resources.Button_Continue_Hover;
        }
        //End Design Button Continue

        //Design Button Almanac
        private void buttonAlmanac_MouseLeave(object sender, EventArgs e)
        {
            buttonAlmanac.BackgroundImage = Properties.Resources.Button_Almanac_Over;
        }
        private void buttonAlmanac_MouseEnter(object sender, EventArgs e)
        {
            buttonAlmanac.BackgroundImage = Properties.Resources.Button_Almanac_Hover;
        }
        //End Design Button Almanac

        //Design Button Quit
        private void buttonQuit_MouseLeave(object sender, EventArgs e)
        {
            buttonQuit.BackgroundImage = Properties.Resources.Button_Quit_Over;
        }
        private void buttonQuit_MouseEnter(object sender, EventArgs e)
        {
            buttonQuit.BackgroundImage = Properties.Resources.Button_Quit_Hover;
        }
        //End Design Button Quit
    }
}
