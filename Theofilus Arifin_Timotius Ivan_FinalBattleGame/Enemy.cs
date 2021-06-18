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
            this.Weapon = null;
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
        public WeaponEnemy Weapon
        {
            get => weapon;
            private set => weapon = value;
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
        public void SetWeapon(string name, Image image)
        {
            Point position = new Point(Picture.Location.X - 30, Picture.Location.Y + 40);
            Size size = new Size(50, 50);
            Weapon = new WeaponEnemy(name, image, position, size);
        }
        public void DisplayWeapon(Control displayContainer)
        {
            Weapon.Picture.Parent = displayContainer;
            Weapon.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Weapon.Picture.BackColor = Color.Transparent;
            Weapon.Picture.BringToFront();
        }
        public void ReleaseWeapon()
        {
            Weapon.Picture.Left -= 30;
        }
        public void RemoveWeapon()
        {
            Weapon.Picture.Dispose();
        }
        public void DefeatPlayer(Player player, string LevelDifficulty)
        {
            if (LevelDifficulty == "Easy")
            {
                player.Health -= 20;
            }
            else
            {
                player.Health -= 50;
            }
            if (player.Health <= 0 && player.Life > 0)
            {
                player.Life--;
                player.Health = 100;
            }
        }
        #endregion
    }
}