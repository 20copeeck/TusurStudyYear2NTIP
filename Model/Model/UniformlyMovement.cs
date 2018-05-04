using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Равномерное движение
    /// </summary>
    public class UniformlyMovement : IMovement
    {
        /// <summary>
        /// Начальная координата
        /// </summary>
        private double _initialCoordinate;
        /// <summary>
        /// Скорость в м/с
        /// </summary>
        private double _speed;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="speed">Скорость в м/с</param>
        public UniformlyMovement(double initialCoordinate, double speed)
        {
            InitialCoordinate = initialCoordinate;
            Speed = speed;
        }

        /// <summary>
        /// Получить или вернуть начальную координату
        /// </summary>
        public double InitialCoordinate
        {
            get { return _initialCoordinate; }
            set { _initialCoordinate = value; }
        }

        /// <summary>
        /// Получить или вернуть скорость
        /// </summary>
        public double Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Скорость не может быть отрицательной!");
                }
                _speed = value;
            }
        }

        /// <summary>
        /// Вычисление новой координаты
        /// </summary>
        /// <param name="time">Время в секудах</param>
        /// <returns>Значение новой координаты</returns>
        public double CalculateNewCoordinate(int time)
        {
            double newCoordinate = this._initialCoordinate + time * this._speed;
            return newCoordinate;
        }
    }
}
