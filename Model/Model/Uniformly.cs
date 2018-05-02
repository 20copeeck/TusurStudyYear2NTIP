using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Равномерное движение
    class Uniformly : IMovement
    {
        private double _initialCoordinate;
        private int _time;
        private double _speed;

        //public Uniformly(double initialCoordinate, int time, double speed)
        //{
        //    _initialCoordinate = initialCoordinate;
        //    _time = time;
        //    _speed = speed;
        //}

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
            get { return _speed; }

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Некорректная скорость");
                }
                _speed = value;
            }
        }

        public double CalculateNewCoordinate(double initialCoordinate, int time, double speed)
        {
            double newCoordinate = initialCoordinate + time * speed;
            return newCoordinate;
        }
    }
}
