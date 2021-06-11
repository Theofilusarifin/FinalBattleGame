using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

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
        public Player(string name, int life, int health, Image image, Point position, Size size, string description, int score, Ultimate ultimate, WeaponPlayer weapon, PowerUp powerUp, int speed, bool ultimateActive) : base ( name, life, health, image, position, size)
        {
            this.Description = description;
            this.Score = score;
            this.Ultimate = ultimate;
            this.Weapon = weapon;
            this.PowerUp = powerUp;
            this.Speed = speed;
            this.ultimateActive = ultimateActive;
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
            set => score = value; 
        }
        public Ultimate Ultimate 
        { 
            get => ultimate; 
            set => ultimate = value; 
        }
        public WeaponPlayer Weapon 
        { 
            get => weapon; 
            set => weapon = value; 
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