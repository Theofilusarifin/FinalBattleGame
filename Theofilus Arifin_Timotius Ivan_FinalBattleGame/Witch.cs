using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Witch : Enemy
    {
        #region FIELDS
        private int healthDamage;
        private WeaponWitch weapon;
        #endregion

        #region CONSTRUCTORS
        public Witch(int speed, string name, int life, int health, Image image, Point position, Size size, int healthDamage) :
        base(speed, name, life, health, image, position, size)
        {
            this.HealthDamage = healthDamage;
            this.Weapon = null;
        }
        #endregion

        #region PROPERTIES
        public int HealthDamage 
        { 
            get => healthDamage; 
            set
            {
                if (value > 0 && value <= 100)
                {
                    healthDamage = value;
                }
                else
                {
                    throw new Exception("Health Damage must be between 1% and 100%");
                }
            }
        }
        public WeaponWitch Weapon
        {
            get => weapon;
            private set => weapon = value;
        }
        #endregion
        #region METHODS
        public void SetWeapon(string name, Image image)
        {
            Point position = new Point(Picture.Location.X + 80, Picture.Location.Y + 80);
            Size size = new Size(30, 30);
            Weapon = new WeaponWitch(name, image, position, size);
        }
        public void DisplayWeapon(Control displayContainer)
        {
            Weapon.Picture.Parent = displayContainer;
            Weapon.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Weapon.Picture.BackColor = Color.Transparent;
            Weapon.Picture.BringToFront();
        }
        public void ReleaseWeapon()
        {
            Weapon.Picture.Left += 30;
        }
        #endregion
    }
} 