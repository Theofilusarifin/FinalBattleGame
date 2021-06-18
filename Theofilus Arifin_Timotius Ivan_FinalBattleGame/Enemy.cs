using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public abstract class Enemy : GameEntity
    {
        #region FIELDS
        private int speed;
        private WeaponEnemy weapon;
        #endregion

        #region CONSTRUCTORS
        public Enemy(int speed, string name, int life, int health, Image image, Point position, Size size) :
        base (name, life, health, image, position, size)
        {
            this.Speed = speed;
        }
        #endregion

        #region PROPERTIES
        public int Speed 
        { 
            get => speed;
            set 
            {
                if (value >= 0)
                {
                    speed = value;
                }
                else
                {
                    throw new Exception("Speed must be greater than 0");
                }
            }
        }

        public WeaponEnemy WeaponEnemy
        {
            get => weapon;
            private set
            {
                weapon = value;
            }
        }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            return DisplayDataActor() + "\nSpeed: " + Speed;
        }
        public abstract string DisplayDataEnemy();
        public override void MoveUp()
        {
            Picture.Top -= Speed;
        }
        public override void MoveDown()
        {
            Picture.Top += Speed;
        }
        public abstract void SetWeapon(string name, Image image);
        public abstract void DisplayWeapon(Control displayContainer);
        public abstract void ReleaseWeapon();
        public abstract void RemoveWeapon();
        public abstract void DefeatPlayer(Player player, int damage);
        #endregion
    }
}