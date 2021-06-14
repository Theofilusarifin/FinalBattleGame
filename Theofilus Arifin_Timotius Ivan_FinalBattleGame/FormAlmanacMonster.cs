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
    public partial class FormAlmanacMonster : Form
    {
        public FormAlmanacMonster()
        {
            InitializeComponent();
        }
        private void FormAlmanacMonster_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Properties.Resources.Almanac_Dragon;
            //SetImage(Properties.Resources.Dragon, 713, 180, 254, 226);
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

        //Change image into selected monster
        #region ChangeImage
        public void SetImage(Image monsterImage, int x, int y, int width, int height)
        {
            pictureBoxMonster.Image = monsterImage;
            pictureBoxMonster.Location = new Point(x,y);
            pictureBoxMonster.Size = new System.Drawing.Size(width, height);
        }
        private void buttonDragon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Dragon;
            SetImage(Properties.Resources.Dragon, 713, 180, 254, 226);
        }
        private void pictureBoxDragon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Dragon;
            SetImage(Properties.Resources.Dragon, 713, 180, 254, 226);
        }
        private void buttonGodzilla_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Godzilla;
            SetImage(Properties.Resources.Godzilla, 713, 191, 227, 215);
        }
        private void pictureBoxGodzilla_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Godzilla;
            SetImage(Properties.Resources.Godzilla, 713, 191, 227, 215);
        }
        private void buttonDino_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Dino;
            SetImage(Properties.Resources.Dino, 670, 239, 292, 160);
        }
        private void pictureBoxDino_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Dino;
            SetImage(Properties.Resources.Dino, 670, 239, 292, 160);
        }
        private void buttonMegaDragon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Dragon;
            SetImage(Properties.Resources.Mega_Dragon, 638, 177, 352, 229);
        }
        private void pictureBoxMegaDragon_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Dragon;
            SetImage(Properties.Resources.Mega_Dragon, 638, 177, 352, 229);
        }
        private void buttonMegaGodzilla_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Godzilla;
            SetImage(Properties.Resources.Mega_Godzilla, 635, 200, 272, 202);
        }
        private void pictureBoxMegaGodzilla_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Godzilla;
            SetImage(Properties.Resources.Mega_Godzilla, 635, 200, 272, 202);
        }
        private void buttonMegaDino_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Dino;
            SetImage(Properties.Resources.Mega_Dino, 700, 199, 281, 202);
        }
        private void pictureBoxMegaDino_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Almanac_Mega_Dino;
            SetImage(Properties.Resources.Mega_Dino, 700, 199, 281, 202);
        }
        #endregion
    }
}
