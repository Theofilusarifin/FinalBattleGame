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
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        int second = 1;
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            buttonOkay.BackgroundImage = Properties.Resources.Button_Click;
            timerClick.Start();
        }

        private void buttonOkay_MouseLeave(object sender, EventArgs e)
        {
            buttonOkay.BackgroundImage = Properties.Resources.Button_Over;
            buttonOkay.ForeColor = Color.LightGreen;
        }

        private void buttonOkay_MouseEnter(object sender, EventArgs e)
        {
            buttonOkay.BackgroundImage = Properties.Resources.Button_Hover;
            buttonOkay.ForeColor = Color.White;
        }

        private void timerClick_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 5)
            {
                timerClick.Stop();
                this.Close();
            }
        }
    }
}
