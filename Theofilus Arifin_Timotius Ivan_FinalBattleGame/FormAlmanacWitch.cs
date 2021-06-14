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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        private void FormAlmanacWitch_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Broom_Witch;
            SetImage(Properties.Resources.Broom_Witch, 717, 236, 175, 157);
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
        //Change image into selected witch
        #region ChangeImage
        public void SetImage(Image monsterImage, int x, int y, int width, int height)
        {
            pictureBoxWitch.Image = monsterImage;
            pictureBoxWitch.Location = new Point(x, y);
            pictureBoxWitch.Size = new System.Drawing.Size(width, height);
        }
        private void buttonTheBroom_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Broom_Witch;
            SetImage(Properties.Resources.Broom_Witch, 717, 236, 175, 157);
        }
        private void pictureBoxBroomWitch_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Broom_Witch;
            SetImage(Properties.Resources.Broom_Witch, 717, 236, 175, 157);
        }
        private void buttonAncientWitch_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Ancient_Witch;
            SetImage(Properties.Resources.Ancient_Witch, 729, 225, 146, 169);
        }
        private void pictureBoxAncientWitch_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Ancient_Witch;
            SetImage(Properties.Resources.Ancient_Witch, 729, 225, 146, 169);
        }
        private void buttonGreenWitch_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Green_Witch;
            SetImage(Properties.Resources.Green_Witch, 683, 216, 251, 169);
        }
        private void pictureBoxGreenWitch_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Green_Witch;
            SetImage(Properties.Resources.Green_Witch, 683, 216, 251, 169);
        }
        #endregion
    }
}
