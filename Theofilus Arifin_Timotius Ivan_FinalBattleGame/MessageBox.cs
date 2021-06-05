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

        private void MessageBox_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOkay_MouseLeave(object sender, EventArgs e)
        {
            this.buttonOkay.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Button_Over));
            buttonOkay.ForeColor = Color.LightGreen;
        }

        private void buttonOkay_MouseEnter(object sender, EventArgs e)
        {
            this.buttonOkay.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.Button_Hover));
            buttonOkay.ForeColor = Color.White;
        }
    }
}
