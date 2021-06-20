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
        public static bool StopMenuMusic = false;
        public static WMPLib.WindowsMediaPlayer wMenuSound;
        int menuSoundTime = 0;
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

        #region MenuSoundTime
        private void AddMenuSoundTime(ref int menuSoundTime)
        {
            menuSoundTime++;
        }
        private bool ResetMenuSoundTime(ref int menuSoundTime)
        {
            if (menuSoundTime >= 8)
            {
                menuSoundTime = 0;
                return true;
            }
            return false;
        }
        #endregion

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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //Play Music (using MP3)
            wMenuSound = new WMPLib.WindowsMediaPlayer();
            wMenuSound.URL = Application.StartupPath + "\\Sound_Main_Menu.mp3";
            wMenuSound.controls.play();
            timerMenuSound.Start();
        }

        private void timerMenuSound_Tick(object sender, EventArgs e)
        {
            if (!StopMenuMusic)
            {
                AddMenuSoundTime(ref menuSoundTime);
                if (ResetMenuSoundTime(ref menuSoundTime))
                {
                    wMenuSound.controls.stop();
                    wMenuSound.controls.play();
                }
            }
        }
    }
}
