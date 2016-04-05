using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс равноускоренное движение
    /// </summary>
    public class Accelerated : IMotion
      {
        int _startCoor;
        /// <summary>
        /// Начальная координата
        /// </summary>
        public int StartCoordinate
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

        int _startSpeed;
        /// <summary>
        /// Начальная скорость
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
        int _time;
        /// <summary>
        /// Время движения
        /// </summary>
        public int Time
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                else _time = value;
            }
            get 
            { 
                return _time;
            }
        }
     
        /// <summary>
        /// Тип движения
        /// </summary>
        public string Style
        {
            get
            {
                return "Acceleraited";
            }
        }

        int _acceleration;
        /// <summary>
        /// Ускорение движения
        /// </summary>
        public int Acceleration
        {
            set
            {
                _acceleration = value;
            }
            get
            {
                return _acceleration;
            }
        }

        /// <summary>
        /// Расчет конечной координаты
        /// </summary>
        public int CalcFinishCoordinate()
        {
            return StartCoordinate + StartSpeed * Time + Acceleration * Time * Time / 2;
        }

        /// <summary>
        /// Конструктор класса равноускоренное движение
        /// </summary>
        /// <param name="c">Начальная координата</param>
        /// <param name="s">Начальная скорость</param>
        /// <param name="t">Время движения</param>
        /// <param name="a">Ускорение</param>
       public Accelerated(int c, int s, int t, int a)
       {
           StartCoordinate = c;
           StartSpeed = s;
           Time = t;
           Acceleration = a; 
       }
    }
}
