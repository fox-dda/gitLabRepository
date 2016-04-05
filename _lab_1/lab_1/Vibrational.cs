using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс колебательное движение
    /// </summary>
    public class Vibrational : IMotion
     {
        private int _startCoor;
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
                return "Vibrational";
            }
        }

        /// <summary>
        /// Расчет конечной координаты
        /// </summary>
        /// <returns></returns>
        public int CalcFinishCoordinate()
        {
            return StartCoordinate + ((StartSpeed * Time) % Amplitude);
        }

        int _amplitude;
        /// <summary>
        /// Амплитуада движения       
        /// </summary>
        public int Amplitude
        {
            set
            {
                if (value < 0 && value != 0)
                    throw new ArgumentException();
                else _amplitude = value;
            }
            get
            {
                return _amplitude;
            }
        }

        /// <summary>
        /// Конструктор для класса колебательного движения
        /// </summary>
        /// <param name="c">Начальная координата</param>
        /// <param name="s">Начальная скорость</param>
        /// <param name="t">Время движения</param>
        /// <param name="a">Амплитуда движения</param>
       public Vibrational(int c, int s, int t, int a)
       {
           StartCoordinate = c;
           StartSpeed = s;
           Time = t;
           Amplitude = a;
       }
    }
}
