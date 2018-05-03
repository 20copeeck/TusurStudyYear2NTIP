using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Колебательное движение
    public class Oscillatory : IMovement
    {
        private double _amplitude;
        private double _cyclicFrequency; // Циклическая частота
        private int _time;
        private double _initialPhase; // Начальная фаза

        public Oscillatory(double amplitude, double cyclicFrequency, int time, double initialPhase)
        {
            Amplitude = amplitude;
            CyclicFrequency = cyclicFrequency;
            Time = time;
            InitialPhase = initialPhase;
        }

        public double Amplitude
        {
            get { return _amplitude; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректная амплитуда");
                }
                _amplitude = value;
            }
        }

        public double CyclicFrequency
        {
            get { return _cyclicFrequency; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Некорректная частота");
                }
                _cyclicFrequency = value;
            }
        }

        public int Time
        {
            get { return _time; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректное время");
                }
                _time = value;
            }
        }

        public double InitialPhase
        {
            get { return _initialPhase; }
            set { _initialPhase = value; }
        }

        public double CalculateNewCoordinate()
        {
            double newCoordinate = this._amplitude * Math.Cos((this._cyclicFrequency * this._time + this._initialPhase) * 180 / Math.PI);
            return newCoordinate;
        }
    }
}
