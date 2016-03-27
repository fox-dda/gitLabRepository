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
         int startCoor{ get; set; }
         /// <summary>
         /// Начальная скорость
         /// </summary>
         int startSpeed{ get; set; }
         /// <summary>
         /// Время движения
         /// </summary>
         int time { get; set; }
         /// <summary>
         /// Тип движения
         /// </summary>
         string style { get; }
         /// <summary>
         /// Расчет конечной координаты
         /// </summary>
         /// <returns></returns>
         int CalcFinishCoor();

    }
}
