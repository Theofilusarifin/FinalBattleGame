﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class WeaponWitch
    {
        #region FIELDS
        private Image picture;
        private string name;
        private int damage;
        #endregion
        #region CONSTRUCTORS
        public WeaponWitch(Image picture, string name, int damage)
        {
            this.Picture = picture;
            this.Name = name;
            this.Damage = damage;
        }
        #endregion
        #region PROPERTIES
        public Image Picture 
        { 
            get => picture; 
            set => picture = value; 
        }
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public int Damage 
        { 
            get => damage; 
            set => damage = value; 
        }
        #endregion
        #region METHODS
        #endregion
    }
}