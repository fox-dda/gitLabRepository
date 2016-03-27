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
        private int _startCoor;
        /// <summary>
        /// Начальная координата движения
        /// </summary>
        public int startCoor
        {
            set
            {
                _startCoor = value;
            }
            get 
            { 
                return _startCoor; 
            }
        }

        private int _startSpeed;
        /// <summary>
        /// Начальная скорость движения
        /// </summary>
        public int startSpeed
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
        public int time
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
        public string style
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
            return startCoor + startSpeed * time;
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
           startCoor = c;
           /// <summary>
           /// Начальная скорость
           /// </summary>
           startSpeed = s;
           /// <summary>
           /// Время движения
           /// </summary>
           time = t;
       }
    }
}
