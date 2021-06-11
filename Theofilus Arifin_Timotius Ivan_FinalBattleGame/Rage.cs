using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Rage : Witch
    {
        #region FIELDS
        private WeaponWitch weapon;
        #endregion
        #region CONSTRUCTORS
        public Rage(string name, int life, int health, Image image, Point position, Size size, int healthDamage, WeaponWitch weapon) :
        base(name, life, health, image, position, size, healthDamage)
        {
            this.Weapon = weapon;
        }
        #endregion
        #region PROPERTIES
        public WeaponWitch Weapon 
        { 
            get => weapon; 
            set => weapon = value; 
        }
        #endregion
        #region METHODS
        #endregion
    }
}