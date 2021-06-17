using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Player : GameEntity
    {
        #region FIELDS
        private string description;
        private int score;
        private Ultimate ultimate;
        private WeaponPlayer weapon;
        private PowerUp powerUp;
        private int speed;
        private bool ultimateActive;
        #endregion

        #region CONSTRUCTORS
        public Player(string name, int life, int health, Image image, Point position, Size size, string description, int score, int speed, bool ultimateActive) : 
                base ( name, life, health, image, position, size)
        {
            this.Description = description;
            this.Score = score;
            this.Weapon = null;
            this.Speed = speed;
        }
        #endregion

        #region PROPERTIES
        public string Description 
        { 
            get => description; 
            set => description = value; 
        }
        public int Score 
        { 
            get => score;
            set 
            {
                if (value >= 0)
                {
                    score = value;
                }
                else
                {
                    throw new Exception("Score minimum is 0");
                }
            } 
        }
        public Ultimate Ultimate 
        { 
            get => ultimate; 
            set => ultimate = value; 
        }
        public WeaponPlayer Weapon 
        { 
            get => weapon; 
            private set => weapon = value; 
        }
        public PowerUp PowerUp 
        { 
            get => powerUp; 
            set => powerUp = value; 
        }
        public int Speed 
        { 
            get => speed; 
            set => speed = 10; 
        }
        public bool UltimateActive
        {
            get => ultimateActive;
            set => ultimateActive = value;
        }
        #endregion

        #region METHODS
        public override string DisplayData()
        {
            return "PLAYER " + DisplayDataActor() + "\nScore: " + Score + "\nWeapon: " + Weapon.Name;
        }
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
            Point position = new Point(Picture.Location.X + 80, Picture.Location.Y + 80);
            Size size = new Size(30, 30);
            Weapon = new WeaponPlayer(name, image, position, size);
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
            Weapon.Picture.Left += 30;
        }
        public void RemoveWeapon()
        {
            Weapon.Picture.Dispose();
        }
        public void DefeatEnemy(Enemy enemy)
        {
            if (enemy is Monster)
            {
                enemy.Health -= 50;
                score += 100;
            }
            else if (enemy is Witch)
            {
                int healthDamage = ((Witch)enemy).HealthDamage;
                enemy.Health -= healthDamage;
                score += 50 * healthDamage;
            }
            if (enemy.Health <= 0 && enemy.Life > 0)
            {
                enemy.Life--;
                enemy.Health = 100;
            }
        }
        #endregion
    }
}