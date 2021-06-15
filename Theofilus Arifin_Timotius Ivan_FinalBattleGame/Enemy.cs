﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Enemy : GameEntity
    {
        #region FIELDS
        private int speed;
        #endregion
        #region CONSTRUCTORS
        public Enemy(int speed, string name, int life, int health, Image image, Point position, Size size) :
        base (name, life, health, image, position, size)
        {

        }
        #endregion
        #region PROPERTIES
        public int Speed 
        { 
            get => speed;
            set 
            {
                if (value >= 10)
                {
                    speed = value;
                }
                else
                {
                    throw new Exception("Speed must be greater that 10");
                }
            }
        }
        #endregion
        #region METHODS
        public override void MoveUp()
        {
            Picture.Top -= Speed;
        }
        public override void MoveDown()
        {
            Picture.Top -= Speed;
        }
        #endregion
    }
}