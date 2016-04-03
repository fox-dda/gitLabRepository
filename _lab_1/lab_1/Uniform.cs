using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс равномерное движение
    /// </summary>
    public class Uniform : IMotion
    {
        private int _startCoorditate;
        /// <summary>
        /// Начальная координата движения
        /// </summary>
        public int StartCoordinate
        {
            set
            {
                _startCoorditate = value;
            }
            get 
            { 
                return _startCoorditate; 
            }
        }

        private int _startSpeed;
        /// <summary>
        /// Начальная скорость движения
        /// </summary>
        public int StartSpeed
        {
            set
            {
                _startSpeed = value;
            }
            get
            { 
                return _startSpeed;
            }
        }
        private int _time;
        /// <summary>
        /// Время движения
        /// </summary>
        public int Time
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else _time = value;
            }
            get 
            { 
                return _time;
            }
        }

        /// <summary>
        /// тип движения
        /// </summary>
        public string Style
        {
            get
            {
                return "Uniform";
            }
        }

        /// <summary>
        /// Расчет конечной координаты
        /// </summary>
        public int CalcFinishCoor()
        {
            return StartCoordinate + StartSpeed * Time;
        }

        /// <summary>
        /// Конструктор класса равномерное движение
        /// </summary>
        /// <param name="c">Начальная координата</param>
        /// <param name="s">Начальная скорость</param>
        /// <param name="t">Время движения</param>
       public Uniform(int c, int s, int t)
       {
           /// <summary>
           /// Начальная координата
           /// </summary>
           StartCoordinate = c;
           /// <summary>
           /// Начальная скорость
           /// </summary>
           StartSpeed = s;
           /// <summary>
           /// Время движения
           /// </summary>
           Time = t;
       }
    }
}
