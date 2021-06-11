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

        private void buttonMonster_Click(object sender, EventArgs e)
        {
            FormAlmanacMonster formAlmanacMonster = new FormAlmanacMonster();
            formAlmanacMonster.Owner = this;
            formAlmanacMonster.ShowDialog();
        }

        private void buttonWitch_Click(object sender, EventArgs e)
        {
            FormAlmanacWitch formAlmanacWitch = new FormAlmanacWitch();
            formAlmanacWitch.Owner = this;
            formAlmanacWitch.ShowDialog();
        }
    }
}
