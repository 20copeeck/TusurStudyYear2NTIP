using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// Равномерное движение
    /// </summary>
    [DataContract]
    public class UniformlyMovement : IMovement
    {
        /// <summary>
        /// Начальная координата
        /// </summary>
        [DataMember]
        private double _initialCoordinate;
        /// <summary>
        /// Скорость в м/с
        /// </summary>
        [DataMember]
        private double _speed;
        /// <summary>
        /// Время в сек.
        /// </summary>
        [DataMember]
        private double _time;

        public UniformlyMovement(){ }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="initialCoordinate">Начальная координата</param>
        /// <param name="speed">Скорость в м/с</param>
        /// <param name="time">Время в сек.</param>
        public UniformlyMovement(double initialCoordinate, double speed, double time)
        {
            InitialCoordinate = initialCoordinate;
            Speed = speed;
            Time = time;
        }

        /// <summary>
        /// Получить или вернуть начальную координату
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
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Скорость не может быть больше uint.MaxValue!");
                }
                else
                {
                    _speed = value;
                }
            }
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
        /// Получить новую координату
        /// </summary>
        public double NewCoordinate
        {
            get
            {
                double newCoordinate = this._initialCoordinate + this._time * this._speed;
                return newCoordinate;
            }
        }

        /// <summary>
        /// Получить тип движения
        /// </summary>
        public string Type
        {
            get { return "Равномерное движение"; }
        }
    }
}
