using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theofilus_Arifin_Timotius_Ivan_FinalBattleGame
{
    public class Time
    {
        #region FIELDS
        private int hour;
        private int minute;
        private int second;
        #endregion
        #region CONSTRUCTORS
        public Time(int hour, int minute, int second)
        {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        #endregion
        #region PROPERTIES
        public int Hour 
        { 
            get => hour; 
            set => hour = value; 
        }
        public int Minute 
        { 
            get => minute; 
            set => minute = value; 
        }
        public int Second 
        { 
            get => second; 
            set => second = value; 
        }
        #endregion
        #region METHODS
        #endregion
    }
}