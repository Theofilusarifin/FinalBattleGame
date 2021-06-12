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
            set
            {
                if (value >= 0 && value <= 23)
                {
                    hour = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the number in range correctly");
                }
            } 
        }
        public int Minute 
        { 
            get => minute;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    minute = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the number in range correctly");
                }
            } 
        }
        public int Second 
        { 
            get => second;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    second = value;
                }
                else
                {
                    throw new ArgumentException("Please enter the number in range correctly");
                }
            } 
        }
        #endregion
        #region METHODS
        public int ConvertToSecond()
        {
            int totalSecond = Second + Minute * 60 + Hour * 3600;
            return totalSecond;
        }
        public void AddSecond(int addSecond)
        {
            int currentTotalSecond = ConvertToSecond();

            int totalSecond = currentTotalSecond + addSecond;

            Hour = totalSecond / 3600;
            Minute = totalSecond % 3600 / 60;
            Second = totalSecond % 3600 % 60;
        }
        public string DisplayTime()
        {
            string time = Hour.ToString().PadLeft(2, '0') + ":" +
                          Minute.ToString().PadLeft(2, '0') + ":" +
                          Second.ToString().PadLeft(2, '0');
            return time;
        }
        #endregion
    }
}