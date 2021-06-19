using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class PowerUp
    {
        #region FIELDS
        private string name;
        private PictureBox picture = new PictureBox();
        #endregion

        #region CONSTRUCTORS
        public PowerUp(string name, Image image, Point position, Size size)
        {
            this.Name = name;
            this.Picture.Image = image;
            this.Picture.Location = position;
            this.Picture.Size = size;
        }
        #endregion

        #region PROPERTIES
        public string Name
        {
            get => name;
            set => name = value;
        }

        public PictureBox Picture
        {
            get => picture;
            set => picture = value;
        }

        #endregion
    }
}