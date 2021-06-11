using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Evolution : Monster
    {
        #region FIELDS
        private WeaponMonster weapon;
        #endregion
        #region CONSTRUCTORS
        public Evolution(string name, int life, int health, Image image, Point position, Size size, string hint) :
        base(name, life, health, image, position, size, hint)
        {
            this.Weapon = weapon;
        }
        #endregion
        #region PROPERTIES
        public WeaponMonster Weapon 
        { 
            get => weapon; 
            set => weapon = value; 
        }
        #endregion
        #region METHODS
        #endregion
    }
}