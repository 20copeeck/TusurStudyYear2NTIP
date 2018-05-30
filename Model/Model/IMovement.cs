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
        /// Получить новую координату
        /// </summary>
        double NewCoordinate { get; }
        
        /// <summary>
        /// Получить тип движения
        /// </summary>
        string Type { get; }
    }
}
