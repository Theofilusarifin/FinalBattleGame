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
        public static string LevelDifficulty;
        public static string PlayerChoosen;
        public FormMenu()
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

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Hide();
            FormSelectDifficulty formSelectDifficulty = new FormSelectDifficulty();
            formSelectDifficulty.ShowDialog();
            formSelectDifficulty = null;
            Show();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            Hide();
            FormLoad formLoad = new FormLoad();
            formLoad.ShowDialog();
            formLoad = null;
            Show();
        }

        private void buttonAlmanac_Click(object sender, EventArgs e)
        {
            Hide();
            FormAlmanac formAlmanac = new FormAlmanac();
            formAlmanac.ShowDialog();
            formAlmanac = null;
            Show();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End Design Button Quit
    }
}
