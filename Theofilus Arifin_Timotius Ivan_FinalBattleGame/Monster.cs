﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Monster : Enemy
    {
        #region FIELDS
        private string hint;
        #endregion
        #region CONSTRUCTRORS
        public Monster(string name, int life, int health, Image image, Point position, Size size, string hint) : 
        base (name, life, health, image, position, size)
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
        public string DisplayHint()
        {
            return Hint;
        }
        #endregion
    }
}