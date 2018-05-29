using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Движение
    /// </summary>
   public interface IMovement
    {
        /// <summary>
        /// Метод позволяет рассчитать значение новой координаты
        /// </summary>
        /// <param name="time">Время в секундах</param>
        /// <returns>Возвращает значение новой координаты</returns>
        double CalculateNewCoordinate(int time);
    }
}
