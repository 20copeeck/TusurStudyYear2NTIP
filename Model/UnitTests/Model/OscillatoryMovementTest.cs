using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса UniformlyAcceleratedMovement
    /// </summary>
    [TestFixture]
    class OscillatoryMovementTest
    {
        [Test]
        [TestCase(0.01, 0.01, int.MinValue, 0, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения 0.01, 0.01, int.MinValue, 0")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значение uint.MaxValue")]
        [TestCase(1.01, 1.01, int.MinValue + 1, 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения 1.01, 1.01, int.MinValue + 1, 1")]
        [TestCase(uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значение uint.MaxValue - 1")]
        public void ConstructorPositiveTest(double amplitude, double frequency, double initialPhase, double time)
        {
            var oscillatoryMovement = new OscillatoryMovement(amplitude, frequency, initialPhase, time);
        }

        [Test]
        [TestCase(-1, -1, 1, 1, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значения -1, -1, 1, 1")]
        [TestCase(0, 0, 1, 1, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значения 0, 0, 1, 1")]
        [TestCase((double)uint.MaxValue + 1, (double)uint.MaxValue + 1, 1, 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения (double)uint.MaxValue + 1, (double)uint.MaxValue + 1, 1, 1")]
        [TestCase(1, 1, (double)int.MinValue - 1, 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения 1, 1, (double)int.MinValue - 1, 1")]
        [TestCase(1, 1, (double)uint.MaxValue + 1, 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения 1, 1, (double)uint.MaxValue + 1, 1")]
        [TestCase(1, 1, 1, -1, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значения 1, 1, 1, -1")]
        [TestCase(1, 1, 1, (double)uint.MaxValue + 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значения 1, 1, 1, (double)uint.MaxValue + 1")]
        public void ConstructorNegativeTest(double amplitude, double frequency, double initialPhase, double time)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var oscillatoryMovement = new OscillatoryMovement(amplitude, frequency, initialPhase, time);
                }
            );
        }

        [Test]
        [TestCase(1, 1, 1, 1, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значение 1")]
        [TestCase(0.01, 0.01, int.MinValue, 0, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значения 0.01, 0.01, int.MinValue, 0")]
        [TestCase(1.01, 1.01, int.MinValue + 1, 1, TestName = 
            "Присваивание amplitude, frequency, initialPhase и time значения 1.01, 1.01, int.MaxValue + 1, 1")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значение uint.MaxValue")]
        [TestCase(uint.MaxValue - 1 , uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName =
            "Присваивание amplitude, frequency, initialPhase и time значение uint.MaxValue - 1")]
        public void NewCoordinateTest(double amplitude, double frequency, double initialPhase, double time)
        {
            var expected = amplitude * Math.Cos((frequency * time + initialPhase) * 180 / Math.PI);
            var oscillatoryMovement = new OscillatoryMovement(amplitude, frequency, initialPhase, time);
            var newCoordinate = oscillatoryMovement.NewCoordinate;
            Assert.AreEqual(expected, newCoordinate);
        }
    }
}
