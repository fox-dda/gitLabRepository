using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Model
{
    /// <summary>
    /// Набор тестов для класса Uniform
    /// </summary>
    [TestFixture]
    public class UniformTests
    {
        /// <summary>
        /// Тестирование свойства StartCoordinate 
        /// </summary>
        /// <param name="startCoordinate">начальная координата</param>
        [Test]
        [TestCase(0, TestName = "Тестирование StartCoordinate при присваивании 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование StartCoordinate при присваивании int.MinValue.")]
        [TestCase(int.MaxValue, TestName = "Тестирование StartCoordinate при присваивании int.MaxValue.")]
        public void StartCoordinateTest(int startCoordinate)
        {
            var uniform = new Uniform(0,0,0);
            uniform.StartCoordinate = startCoordinate;    
        }

        /// <summary>
        /// Тестирование свойства StartSpeed
        /// </summary>
        /// <param name="startSpeed">начальная скорость</param>
        [Test]
        [TestCase(0, TestName = "Тестирование StartSpeed при присваивании 0.")]
        [TestCase(int.MinValue, TestName = "Тестирование StartSpeed при присваивании int.MinValue.")]
        [TestCase(int.MaxValue, TestName = "Тестирование StartSpeed при присваивании int.MaxValue.")]
        public void StartSpeedTest(int startSpeed)
        {
            var uniform = new Uniform(0, 0, 0);
            uniform.StartSpeed = startSpeed;
        }

        /// <summary>
        /// Тестирование свойства Time
        /// </summary>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(0, TestName = "Тестирование Time при присваивании 0.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Time при присваивании int.MaxValue.")]
        public void TimeTest(int time)
        {
            var uniform = new Uniform(0, 0, 0);
            uniform.Time = time;
        }

        /// <summary>
        /// Негативный тест Time
        /// </summary>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(int.MinValue, TestName = "Тестирование Time при присваивании int.minValue.")]
        [TestCase(-50, TestName = "Тестирование Time при присваивании -50.")]
        [TestCase(-1, TestName = "Тестирование Time при присваивании -1.")]
        public void TimeTestNegative(int time)
        {
            var uniform = new Uniform(0, 0, 0);
            NUnit.Framework.Assert.Throws(typeof (ArgumentException), () => { uniform.Time = time; });   //!!!//
        }

        /// <summary>
        /// Тестирование метода CalcFinishCoordinate
        /// </summary>
        /// <param name="startCoordinate">начальная координата  </param>
        /// <param name="startSpeed">начальная скорость</param>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(1, 2, 3, TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, 3 в аргументы")]
        [TestCase(-1, 2, int.MaxValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании -1, 2, int.MaxValue в аргументы")]
        [TestCase(int.MaxValue, 2, int.MaxValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, 2, int.MaxValue в аргументы")]
        [TestCase(1, int.MinValue, 3, TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, int.MinValue, 3 в аргументы")]
        [TestCase(int.MaxValue, -2, 0, TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, -2, 0 в аргументы")]
        public void CalcFinishCoordinateTest(int startCoordinate, int startSpeed, int time)
        {
            var uniform = new Uniform(startCoordinate, startSpeed, time);
            uniform.CalcFinishCoordinate();
        }
    }
}
