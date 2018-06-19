using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// Равноускоренное движение
    /// </summary>
    [DataContract]
    public class UniformlyAcceleratedMovement : IMovement
    {
        /// <summary>
        /// Начальная координата
        /// </summary>
        [DataMember]
        private double _initialCoordinate;
        /// <summary>
        /// Начальная скорость в м/с
        /// </summary>
        [DataMember]
        private double _initialSpeed;
        /// <summary>
        /// Ускорение
        /// </summary>
        [DataMember]
        private double _acceleration;
        /// <summary>
        /// Время в сек.
        /// </summary>
        [DataMember]
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
        /// Получает или задает начальную координату
        /// </summary>
        public double InitialCoordinate
        {
            get { return _initialCoordinate; }
            set
            {
                if (value < int.MinValue)
                {
                    throw new Exception("Начальная координата не может быть меньше int.MinValue!");
                }
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Начальная координата не может быть больше uint.MaxValue!");
                }
                else
                {
                    _initialCoordinate = value;
                }
            }
        }

        /// <summary>
        /// Получает или задает скорость
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
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Скорость не может быть больше uint.MaxValue!");
                }
                else
                {
                    _initialSpeed = value;
                }
            }
        }

        /// <summary>
        /// Получает или задает ускорение
        /// </summary>
        public double Acceleration
        {
            get { return _acceleration; }
            set
            {
                if (value < int.MinValue)
                {
                    throw new Exception("Ускорение не может быть меньше int.MinValue!");
                }
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Ускорение не может быть больше uint.MaxValue!");
                }
                else
                {
                    _acceleration = value;
                } 
            }
        }

        /// <summary>
        /// Получает или задает время
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
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Время не может быть больше uint.MaxValue!");
                }
                else
                {
                    _time = value;
                }
            }
        }

        /// <summary>
        /// Получает новую координату
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
        /// Получает тип движения
        /// </summary>
        public string Type
        {
            get { return "Равноускоренное движение"; }
        }
    }
}
