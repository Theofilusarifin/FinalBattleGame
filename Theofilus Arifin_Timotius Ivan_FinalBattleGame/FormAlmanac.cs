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
    public partial class FormAlmanac : Form
    {
        public FormAlmanac()
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
        private void buttonMonster_Click(object sender, EventArgs e)
        {
            Hide();
            FormAlmanacMonster formAlmanacMonster = new FormAlmanacMonster();
            formAlmanacMonster.ShowDialog();
            formAlmanacMonster = null;
            Show();
        }
        private void pictureBoxMonster_Click(object sender, EventArgs e)
        {
            Hide();
            FormAlmanacMonster formAlmanacMonster = new FormAlmanacMonster();
            formAlmanacMonster.ShowDialog();
            formAlmanacMonster = null;
            Show();
        }
        private void buttonWitch_Click(object sender, EventArgs e)
        {
            Hide();
            FormAlmanacWitch formAlmanacWitch = new FormAlmanacWitch();
            formAlmanacWitch.ShowDialog();
            formAlmanacWitch = null;
            Show();
        }
        private void pictureBoxWitch_Click(object sender, EventArgs e)
        {
            Hide();
            FormAlmanacWitch formAlmanacWitch = new FormAlmanacWitch();
            formAlmanacWitch.ShowDialog();
            formAlmanacWitch = null;
            Show();
        }

        //Design Button Back To Menu
        private void buttonBackToMenu_MouseEnter(object sender, EventArgs e)
        {
            buttonBackToMenu.BackgroundImage = Properties.Resources.Button_Back_To_Menu_Hover;
        }
        private void buttonBackToMenu_MouseLeave(object sender, EventArgs e)
        {
            buttonBackToMenu.BackgroundImage = Properties.Resources.Button_Back_To_Menu_Over;
        }
        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
