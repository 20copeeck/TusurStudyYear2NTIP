﻿using System;
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
    class UniformlyAcceleratedMovementTest
    {
        [Test]
        [TestCase(int.MinValue, 0, int.MinValue, 0, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения int.MinValue, 0, int.MinValue, 0")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значение uint.MaxValue")]
        [TestCase(int.MinValue + 1, 1, int.MinValue + 1, 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения int.MinValue + 1, 1, int.MinValue + 1, 1")]
        [TestCase(uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName =
            "Присваивание initialCoordinate, iniyialSpeed, acceleration и time значение uint.MaxValue - 1")]
        public void ConstructorPositiveTest(double initialCoordinate, double initialSpeed, double acceleration, double time)
        {
            var uniformlyAcceleratedMovement = new UniformlyAcceleratedMovement(initialCoordinate, initialSpeed, acceleration, time);
        }

        [Test]
        [TestCase(-1, -1, -1, -1, TestName = 
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значение -1")]
        [TestCase(-1, (double)uint.MaxValue + 1, -1, (double)uint.MaxValue + 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения -1, (double)uint.MaxValue + 1, -1, (double)uint.MaxValue + 1")]
        [TestCase((double)int.MinValue - 1, 1, (double)int.MinValue - 1, 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения (double)int.MinValue - 1, 1, (double)int.MinValue - 1, 1")]
        [TestCase((double)uint.MaxValue + 1, 1, (double)uint.MaxValue + 1, 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения (double)uint.MaxValue + 1, 1, (double)uint.MaxValue + 1, 1")]
        public void ConstructorNegativeTest(double initialCoordinate, double initialSpeed, double acceleration, double time)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var uniformlyAcceleratedMovement = new UniformlyAcceleratedMovement(initialCoordinate, initialSpeed, acceleration, time);
                }
            );
        }

        [Test]
        [TestCase(1, 1, 1, 1, TestName = 
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значение 1")]
        [TestCase(int.MinValue, 0, 0, 0, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения int.MinValue, 0, 0, 0")]
        [TestCase(int.MinValue + 1, 1, 1, 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значения int.MinValue + 1, 1, 1, 1")]
        [TestCase(uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значение uint.MaxValue")]
        [TestCase(uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, uint.MaxValue - 1, TestName =
            "Присваивание initialCoordinate, initialSpeed, acceleration и time значение uint.MaxValue - 1")]
        public void NewCoordinateTest(double initialCoordinate, double initialSpeed, double acceleration, double time)
        {
            var expected = initialCoordinate + initialSpeed * time + 1.0 / 2 * acceleration * time * time;
            var uniformlyAcceleratedMovement = new UniformlyAcceleratedMovement(initialCoordinate, initialSpeed, acceleration, time);
            var newCoordinate = uniformlyAcceleratedMovement.NewCoordinate;
            Assert.AreEqual(expected, newCoordinate);
        }
    }
}
