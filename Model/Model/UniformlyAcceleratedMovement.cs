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
        /// Конструктор класса
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="initialSpeed">Начальная скорость в м/с</param>
        /// <param name="acceleration">Ускорение</param>
        public UniformlyAcceleratedMovement(double initialCoordinate, double initialSpeed, double acceleration)
        {
            InitialCoordinate = initialCoordinate;
            Speed = initialSpeed;
            Acceleration = acceleration;
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
        /// Вычисление новой координаты
        /// </summary>
        /// <param name="time">Время в секундах</param>
        /// <returns>Значение новой координаты</returns>
        public double CalculateNewCoordinate(int time)
        {
            double newCoordinate = this._initialCoordinate + this._initialSpeed * time + 1.0 / 2 * this._acceleration * time * time; 
            return newCoordinate;
        }
    }
}
