using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Shield
    {
        #region FIELDS
        private PictureBox picture = new PictureBox();
        #endregion
        #region CONSTRUCTORS
        public Shield(Image image, Point position, Size size)
        {
            Picture.Image = image;
            Picture.Location = position;
            Picture.Size = size;
        }
        #endregion
        #region PROPERTIES
        public PictureBox Picture 
        { 
            get => picture; 
            set => picture = value; 
        }
        #endregion
        public void MoveUp()
        {
            Picture.Top -= 15;
        }
        public void MoveDown()
        {
            Picture.Top += 15;
        }
    }
}