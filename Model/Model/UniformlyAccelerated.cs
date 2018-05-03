using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Равноускоренное движение
    public class UniformlyAccelerated : IMovement
    {
        private double _initialCoordinate;
        private int _time;
        private double _initialSpeed;
        private double _acceleration;  // Ускорение

        public UniformlyAccelerated(double initialCoordinate, int time, double initialSpeed, double acceleration)
        {
            InitialCoordinate = initialCoordinate;
            Time = time;
            Speed = initialSpeed;
            InitialAcceleration = acceleration;
        }

        public double InitialCoordinate
        {
            get { return _initialCoordinate; }
            set { _initialCoordinate = value; }
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

        public double Speed
        {
            get { return _initialSpeed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная скорость");
                }
                _initialSpeed = value;
            }
        }

        public double InitialAcceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; }
        }

        public double CalculateNewCoordinate()
        {
            double newCoordinate = this._initialCoordinate + this._initialSpeed * this._time + 1.0 / 2 * this._acceleration * Math.Pow(this._time, 2); 
            return newCoordinate;
        }
    }
}
