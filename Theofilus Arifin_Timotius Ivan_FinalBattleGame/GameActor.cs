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
        private PictureBox picture = new PictureBox();
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
            set
            {
                if (value >= 0)
                {
                    life = value;
                }
                else
                {
                    throw new Exception("Life must be grater than 0");
                }
            }
        }
        public int Health 
        { 
            get => health;
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    health = value;
                }
                else if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    throw new Exception("Health must be between 0 and 100");
                }
            }
        }
        public PictureBox Picture
        { 
            get => picture; 
            set => picture = value; 
        }
        #endregion

        #region METHODS
        public abstract string DisplayData();
        protected string DisplayDataActor()
        {
            return "(" + Name + ")" + "\n\nHealth: " + Health + "      Life: " + Life;
        }
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