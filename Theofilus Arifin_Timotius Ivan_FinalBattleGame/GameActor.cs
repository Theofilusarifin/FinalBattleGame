using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public abstract class GameEntity
    {
        #region FIELDS
        private string name;
        private int life;
        private int health;
        private PictureBox picture;
        #endregion
        #region CONSTRUCTORS
        public GameEntity(string name, int life, int health, Image image, Point position, Size size)
        {
            this.Name = name;
            this.Life = life;
            this.Health = health;
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
        public int Life 
        { 
            get => life; 
            set => life = value; 
        }
        public int Health 
        { 
            get => health; 
            set => health = value; 
        }
        public PictureBox Picture
        { 
            get => picture; 
            set => picture = value; 
        }
        #endregion
        #region METHODS
        public void DisplayPicture(Control displayContainer)
        {
            Picture.Parent = displayContainer;
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.BackColor = Color.Transparent;
            Picture.BringToFront();
        }
        public abstract void MoveUp();
        public abstract void  MoveDown();
        public void Remove()
        {
            Picture.Dispose();
        }
        #endregion
    }
}