using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class WeaponPlayer
    {
        #region FIELDS
        private string name;
        private Image image;
        private int damage;
        #endregion
        #region CONSTRUCTORS
        public WeaponPlayer(string name, Image image, int damage)
        {
            this.Name = name;
            this.Image = image;
            this.Damage = damage;
        }
        #endregion
        #region PROPERTIES
        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public Image Image 
        { 
            get => image; 
            set => image = value; 
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