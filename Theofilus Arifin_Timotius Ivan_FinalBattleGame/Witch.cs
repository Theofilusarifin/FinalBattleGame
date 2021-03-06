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
        #endregion

        #region CONSTRUCTORS
        public Witch(int speed, string name, int life, int health, Image image, Point position, Size size, int healthDamage) :
        base(speed, name, life, health, image, position, size)
        {
            this.HealthDamage = healthDamage;
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
        #endregion

        #region METHODS
        public override string DisplayDataEnemy()
        {
            return "WITCH " + DisplayData() + "\nHealth Damage: " + HealthDamage;
        }
        #endregion
    }
} 