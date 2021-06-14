using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Witch : Enemy
    {
        #region FIELDS
        private int healthDamage;
        private WeaponWitch weapon;
        #endregion

        #region CONSTRUCTORS
        public Witch(string name, int life, int health, Image image, Point position, Size size, int healthDamage) :
        base(name, life, health, image, position, size)
        {
            this.HealthDamage = healthDamage;
        }
        #endregion

        #region PROPERTIES
        public int HealthDamage 
        { 
            get => healthDamage; 
            set => healthDamage = value;
        }
        public WeaponWitch WeaponWitch
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region METHODS
        #endregion
    }
} 