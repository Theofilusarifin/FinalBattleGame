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
            timer1.Start();
        }
    }
}
