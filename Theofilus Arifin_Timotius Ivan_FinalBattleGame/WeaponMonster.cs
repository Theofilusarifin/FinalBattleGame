using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class WeaponMonster
    {
        #region FIELDS
        private string name;
        private Image picture;
        private int damage;
        #endregion
        #region CONSTRUCTORS
        public WeaponMonster(string name, Image picture, int damage)
        {
            this.Name = name;
            this.Picture = picture;
            this.Damage = damage;
        }
        #endregion
        #region PROPERTIES
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public Image Picture 
        { 
            get => picture; 
            set => picture = value; 
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