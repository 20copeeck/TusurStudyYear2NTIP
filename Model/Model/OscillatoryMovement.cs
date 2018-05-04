using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Колебательное движение
    /// </summary>
    public class OscillatoryMovement : IMovement
    {
        /// <summary>
        /// Амплитуда
        /// </summary>
        private double _amplitude;
        /// <summary>
        /// Частота
        /// </summary>
        private double _frequency;
        /// <summary>
        /// Начальная фаза в градусах
        /// </summary>
        private double _initialPhase;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="amplitude">Амплитуда</param>
        /// <param name="frequency">Частота</param>
        /// <param name="initialPhase">Начальная фаза в градусах</param>
        public OscillatoryMovement(double amplitude, double frequency, double initialPhase)
        {
            Amplitude = amplitude;
            Frequency = frequency;
            InitialPhase = initialPhase;
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
                _amplitude = value;
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
                _frequency = value;
            }
        }

        /// <summary>
        /// Получает или возвращает начальную фазу
        /// </summary>
        public double InitialPhase
        {
            get { return _initialPhase; }
            set { _initialPhase = value; }
        }

        /// <summary>
        /// Вычисление новой координаты
        /// </summary>
        /// <param name="time">Время в секундах</param>
        /// <returns>Значение новой координаты</returns>
        public double CalculateNewCoordinate(int time)
        {
            double newCoordinate = this._amplitude * Math.Cos((this._frequency * time + this._initialPhase) * 180 / Math.PI);
            return newCoordinate;
        }
    }
}
