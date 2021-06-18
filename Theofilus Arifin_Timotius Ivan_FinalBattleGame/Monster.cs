using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Monster : Enemy
    {
        #region FIELDS
        private string hint;
        #endregion

        #region CONSTRUCTRORS
        public Monster(int speed, string name, int life, int health, Image image, Point position, Size size, string hint) : 
        base (speed, name, life, health, image, position, size)
        {
            this.Hint = hint;
        }
        #endregion

        #region PROPERTIES
        public string Hint 
        { 
            get => hint; 
            set => hint = value;
        }
        #endregion

        #region METHODS
        public override string DisplayDataEnemy()
        {
            return "MONSTER " + DisplayData() + "\nHint: " + Hint;
        }
        #endregion
    }
}