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
            private set => powerUp = value; 
        }
        public int Speed 
        { 
            get => speed; 
            set => speed = value; 
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
            Point position = new Point(Picture.Location.X + 80, Picture.Location.Y + 20);
            Size size = new Size(40, 40);
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
                Score += 100;
            }
            else if (enemy is MegaMonster)
            {
                int damageReduce = ((MegaMonster)enemy).DamageReduction;
                enemy.Health -= (50-damageReduce);
                Score += 200;
            }
            else if (enemy is Witch)
            {
                int healthDamage = ((Witch)enemy).HealthDamage;
                enemy.Health -= healthDamage;
                Score += 50 * healthDamage;
            }
            if (enemy.Health <= 0 && enemy.Life > 0)
            {
                enemy.Life--;
                enemy.Health = 100;
            }
        }
        public void SetPowerUp(string name, Image image, int duration)
        {
            Random random = new Random();
            int positionY = random.Next(280, 710);

            Point position = new Point(1050, positionY);
            Size size = new Size(40, 40);
            PowerUp = new PowerUp(name, duration, image, position, size);
        }
        public void DisplayPowerUp(Control displayContainer)
        {
            PowerUp.Picture.Parent = displayContainer;
            PowerUp.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            PowerUp.Picture.BackColor = Color.Transparent;
            PowerUp.Picture.BringToFront();
        }
        public void ReleasePowerUp()
        {
            PowerUp.Picture.Left -= 10;
        }
        public void RemovePowerUp()
        {
            PowerUp.Picture.Dispose();
        }
        public void EffectPowerUp()
        {
            if (PowerUp.Name == "Attack")
            {

            }
            else if (PowerUp.Name == "Life")
            {
                Life++;
            }
            else //Shield
            {
                
            }
        }
        public void ActivePowerUp()
        {

        }
        #endregion
    }
}