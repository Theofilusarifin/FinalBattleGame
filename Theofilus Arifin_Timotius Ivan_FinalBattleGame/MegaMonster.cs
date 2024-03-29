﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class MegaMonster : Enemy
    {
        #region FIELDS
        private string hint;
        private int damageReduction;
        #endregion
        #region CONSTRUCTORS
        public MegaMonster(int speed, string name, int life, int health, Image image, Point position, Size size, string hint, int damageReduction) :
        base(speed, name, life, health, image, position, size)
        {
            this.Hint = hint;
            this.DamageReduction = damageReduction;
        }
        #endregion
        #region PROPERTIES
        public string Hint
        {
            get => hint;
            set => hint = value;
        }
        public int DamageReduction
        {
            get => damageReduction;
            set => damageReduction = value;
        }
        #endregion
        #region METHODS
        public override string DisplayDataEnemy()
        {
            return "MEGA MONSTER " + DisplayData() + "\nHint: " + Hint;
        }
        #endregion
    }
}