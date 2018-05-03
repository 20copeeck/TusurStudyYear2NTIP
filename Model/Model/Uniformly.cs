using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Равномерное движение
    public class Uniformly : IMovement
    {
        private double _initialCoordinate;
        private int _time;
        private double _speed;

        public Uniformly(double initialCoordinate, int time, double speed)
        {
            InitialCoordinate = initialCoordinate;
            Time = time;
            Speed = speed;
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
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная скорость");
                }
                _speed = value;
            }
        }

        public double CalculateNewCoordinate()
        {
            double newCoordinate = this._initialCoordinate + this._time * this._speed;
            return newCoordinate;
        }
    }
}
