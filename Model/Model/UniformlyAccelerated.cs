using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class UniformlyAccelerated
    {
        private double _initialCoordinate;
        private int _time;
        private double _initialSpeed;
        private double _acceleration;

        public int Time
        {
            get { return _time; }

            private set
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

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная скорость");
                }
                _initialSpeed = value;
            }
        }

        public double CalculateNewCoordinate(double initialCoordinate, int time, double initialSpeed, double acceleration)
        {
            double newCoordinate = initialCoordinate + initialSpeed * time + 1/2 * acceleration * time * time;
            return newCoordinate;
        }
    }
}
