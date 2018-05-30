using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Равноускоренное движение
    /// </summary>
    public class UniformlyAcceleratedMovement : IMovement
    {
        /// <summary>
        /// Начальная координата
        /// </summary>
        private double _initialCoordinate;
        /// <summary>
        /// Начальная скорость в м/с
        /// </summary>
        private double _initialSpeed;
        /// <summary>
        /// Ускорение
        /// </summary>
        private double _acceleration;
        /// <summary>
        /// Время в сек.
        /// </summary>
        private double _time;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="initialSpeed">Начальная скорость в м/с</param>
        /// <param name="acceleration">Ускорение</param>
        /// <param name="time">Время в сек.</param>
        public UniformlyAcceleratedMovement(double initialCoordinate, double initialSpeed, double acceleration, double time)
        {
            InitialCoordinate = initialCoordinate;
            Speed = initialSpeed;
            Acceleration = acceleration;
            Time = time;
        }

        /// <summary>
        /// Получает или возвращает начальную координату
        /// </summary>
        public double InitialCoordinate
        {
            get { return _initialCoordinate; }
            set { _initialCoordinate = value; }
        }

        /// <summary>
        /// Получает или возвращает скорость
        /// </summary>
        public double Speed
        {
            get { return _initialSpeed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Скорость не может быть отрицательной!");
                }
                _initialSpeed = value;
            }
        }

        /// <summary>
        /// Получает или возвращает ускорение
        /// </summary>
        public double Acceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; }
        }

        /// <summary>
        /// Получить или вернуть время
        /// </summary>
        public double Time
        {
            get { return _time; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Время не может быть отрицательным!");
                }
                _time = value;
            }
        }

        /// <summary>
        /// Получить новую координату
        /// </summary>
        public double NewCoordinate
        {
            get
            {
                double newCoordinate = this._initialCoordinate + this._initialSpeed * this._time + 1.0 / 2 * this._acceleration * this._time * this._time;
                return newCoordinate;
            }
        }

        /// <summary>
        /// Получить тип движения
        /// </summary>
        public string Type
        {
            get { return "Равноускоренное движение"; }
        }
    }
}
