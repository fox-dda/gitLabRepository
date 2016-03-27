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

        int _startSpeed;
        /// <summary>
        /// Начальная скорость
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

        int _time;
        /// <summary>
        /// Время движения
        /// </summary>
        public int time
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
        public string style
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
        public int CalcFinishCoor()
        {
            return startCoor + ((startSpeed * time) % amplitude);
        }

        int _amplitude;
        /// <summary>
        /// Амплитуада движения       
        /// </summary>
        public int amplitude
        {
            set
            {
                if (value < 0)
                    _amplitude = 0;
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
           startCoor = c;
           startSpeed = s;
           time = t;
           amplitude = a;
       }
    }
}
