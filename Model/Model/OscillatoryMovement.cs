using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{

    /// <summary>
    /// Колебательное движение
    /// </summary>
    [DataContract]
    public class OscillatoryMovement : IMovement
    {
        /// <summary>
        /// Амплитуда
        /// </summary>
        [DataMember]
        private double _amplitude;
        /// <summary>
        /// Частота
        /// </summary>
        [DataMember]
        private double _frequency;
        /// <summary>
        /// Начальная фаза в градусах
        /// </summary>
        [DataMember]
        private double _initialPhase;
        /// <summary>
        /// Время в сек.
        /// </summary>
        [DataMember]
        private double _time;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="amplitude">Амплитуда</param>
        /// <param name="frequency">Частота</param>
        /// <param name="initialPhase">Начальная фаза в градусах</param>
        /// <param name="time">Время в сек.</param>
        public OscillatoryMovement(double amplitude, double frequency, double initialPhase, double time)
        {
            Amplitude = amplitude;
            Frequency = frequency;
            InitialPhase = initialPhase;
            Time = time;
        }

        /// <summary>
        /// Получает или возвращает амплитуду
        /// </summary>
        public double Amplitude
        {
            get { return _amplitude; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Амплитуда не может быть отрицательной или равняться нулю!");
                }
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Амплитуда не может быть больше uint.MaxValue!");
                }
                else
                {
                    _amplitude = value;
                }
            }
        }

        /// <summary>
        /// Получает или возвращает частоту
        /// </summary>
        public double Frequency
        {
            get { return _frequency; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Частота не может быть отрицательной или равняться нулю!");
                }
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Частота не может быть больше uint.MaxValue!");
                }
                else
                {
                    _frequency = value;
                } 
            }
        }

        /// <summary>
        /// Получает или возвращает начальную фазу
        /// </summary>
        public double InitialPhase
        {
            get { return _initialPhase; }
            set
            {
                if (value < int.MinValue)
                {
                    throw new Exception("Начальная фаза не может быть меньше int.MinValue!");
                }
                else if (value > uint.MaxValue)
                {
                    throw new Exception("Начальная фаза не может быть больше uint.MaxValue!");
                }
                else
                {
                    _initialPhase = value;
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
                double newCoordinate = this._amplitude * Math.Cos((this._frequency * this._time + this._initialPhase) * 180 / Math.PI);
                return newCoordinate;
            }
        }

        /// <summary>
        /// Получить тип движения
        /// </summary>
        public string Type
        {
            get { return "Колебательное движение"; }
        }
    }
}
