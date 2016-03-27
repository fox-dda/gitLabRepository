using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    /// <summary>
    /// Класс равноускоренное движение
    /// </summary>
    class Accelerated : IMotion
      {
        int _startCoor;
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
                return "Accelerated";
            }
        }

        int _acceleration;
        /// <summary>
        /// Ускорение движения
        /// </summary>
        public int acceleration
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
        public int CalcFinishCoor()
        {
            return startCoor + startSpeed * time + acceleration * time * time / 2;
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
           startCoor = c;
           startSpeed = s;
           time = t;
           acceleration = a; 
       }
    }
}
