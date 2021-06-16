﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class MonsterEvolution : Enemy
    {
        #region FIELDS
        private string hint;
        private WeaponMonsterEvolution weapon;
        #endregion
        #region CONSTRUCTORS
        public MonsterEvolution(int speed, string name, int life, int health, Image image, Point position, Size size, string hint) :
        base(speed, name, life, health, image, position, size)
        {
            this.Hint = hint;
            this.Weapon = null;
        }
        #endregion
        #region PROPERTIES
        public string Hint 
        { 
            get => hint; 
            set => hint = value; 
        }
        public WeaponMonsterEvolution Weapon 
        { 
            get => weapon; 
            private set => weapon = value; 
        }
        #endregion
        #region METHODS
        public string DisplayHint()
        {
            return Hint;
        }
        public void SetWeapon(string name, Image image)
        {
            Point position = new Point(Picture.Location.X + 80, Picture.Location.Y + 80);
            Size size = new Size(30, 30);
            Weapon = new WeaponMonsterEvolution(name, image, position, size);
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