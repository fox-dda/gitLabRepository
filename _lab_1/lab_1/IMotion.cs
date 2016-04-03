using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// интерфейс для классов движения
    /// </summary>
     public interface IMotion
    { 
          /// <summary>
          /// Начальная координата
          /// </summary>
         int StartCoordinate{ get; set; }
         /// <summary>
         /// Начальная скорость
         /// </summary>
         int StartSpeed{ get; set; }
         /// <summary>
         /// Время движения
         /// </summary>
         int Time { get; set; }
         /// <summary>
         /// Тип движения
         /// </summary>
         string Style { get; }
         /// <summary>
         /// Расчет конечной координаты
         /// </summary>
         /// <returns></returns>
         int CalcFinishCoor();
    }
}
