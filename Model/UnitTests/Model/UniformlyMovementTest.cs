using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;
using NUnit.Framework.Internal;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса UniformlyMovement
    /// </summary>
    [TestFixture]
    class UniformlyMovementTest
    {
        [Test]
        [TestCase(int.MinValue, 0, 0, TestName = "Присваивание initialCoordinate, speed и time значения int.MinValue, 0, 0")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName = "Присваивание initialCoordinate, speed и time значение uint.MaxValue")]
        [TestCase(int.MinValue + 1, 1, 1, TestName = "Присваивание initialCoordinate, speed и time значения int.MinValue + 1, 1, 1")]
        [TestCase(uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName = "Присваивание initialCoordinate, speed и time значение uint.MaxValue - 1")]
        public void ConstructorPositiveTest(double initialCoordinate, double speed, double time)
        {
            var uniformlyMovement = new UniformlyMovement(initialCoordinate, speed, time);
        }

        [Test]
        [TestCase(-1, -1, -1, TestName = "Присваивание initialCoordinate, speed и time значение -1")]
        [TestCase(-1, (double)uint.MaxValue + 1, (double)uint.MaxValue + 1, TestName = "Присваивание initialCoordinate, speed и time значения -1, (double)uint.MaxValue + 1, (double)uint.MaxValue + 1")]
        [TestCase((double)int.MinValue - 1, 1, 1, TestName = "Присваивание initialCoordinate, speed и time значение (double)int.MinValue - 1, 1, 1")]
        [TestCase((double)uint.MaxValue + 1, 1, 1, TestName = "Присваивание initialCoordinate, speed и time значение (double)int.MaxValue + 1, 1, 1")]
        public void ConstructorNegativeTest(double initialCoordinate, double speed, double time)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var uniformlyMovement = new UniformlyMovement(initialCoordinate, speed, time);
                }
            );
        }

        [Test]
        [TestCase(1, 1, 1, TestName = "Присваивание initialCoordinate, speed и time значения 1, 1, 1")]
        [TestCase(int.MinValue, 0, 0, TestName = "Присваивание initialCoordinate, speed и time значения int.MinValue, 0, 0")]
        [TestCase(int.MinValue + 1, 1, 1, TestName = "Присваивание initialCoordinate, speed и time значения int.MinValue + 1, 1, 1")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName = "Присваивание initialCoordinate, speed и time значение uint.MaxValue")]
        [TestCase(uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName = "Присваивание initialCoordinate, speed и time значение uint.MaxValue - 1")]
        public void NewCoordinateTest(double initialCoordinate, double speed, double time)
        {
            var expected = initialCoordinate + time * speed;
            var uniformlyMovement = new UniformlyMovement(initialCoordinate, speed, time);
            var newCoordinate = uniformlyMovement.NewCoordinate;
            Assert.AreEqual(expected, newCoordinate);
        }
    }
}
