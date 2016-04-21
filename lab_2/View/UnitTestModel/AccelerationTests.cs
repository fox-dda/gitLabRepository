using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model
{
    [TestFixture]
    public class AccelerationTests
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
            var accelerated = new Accelerated(0, 0, 0, 0);
            accelerated.StartCoordinate = startCoordinate;
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
            var accelerated = new Accelerated(0, 0, 0, 0);
            accelerated.StartSpeed = startSpeed;
        }

        /// <summary>
        /// Тестирование свойства Acceleration
        /// </summary>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(0, TestName = "Тестирование Time при присваивании 0.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Time при присваивании int.MaxValue.")]
        public void IimeTest(int time)
        {
            var accelerated = new Accelerated(0, 0, 0, 0);
            accelerated.Time = time;
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
            var accelerated = new Accelerated(0, 0, 0, 0);
            Assert.Throws(typeof(ArgumentException), () => { accelerated.Time = time; });   //!!!//
        }

        /// <summary>
        /// Тестирование свойства Acceleration
        /// </summary>
        /// <param name="time">ускорение</param>
        [Test]
        [TestCase(0, TestName = "Тестирование Acceleration при присваивании 0.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Acceleration при присваивании int.MaxValue.")]
        [TestCase(int.MinValue, TestName = "Тестирование Acceleration при присваивании int.MinValue.")]
        public void AccelerationTest(int acceleration)
        {
            var accelerated = new Accelerated(0, 0, 0, 0);
            accelerated.Acceleration = acceleration;
        }

        /// <summary>
        /// Тестирование метода CalcFinishCoordinate
        /// </summary>
        /// <param name="startCoordinate">начальная координата  </param>
        /// <param name="startSpeed">начальная скорость</param>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(1, 2, 3, 4, TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, 3 в аргументы")]
        [TestCase(-1, 2, int.MaxValue, 4, TestName = "Тестирование метода CalcFinishCoordinate при присваивании -1, 2, int.MaxValue в аргументы")]
        [TestCase(int.MaxValue, 2, int.MaxValue, int.MaxValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, 2, int.MaxValue в аргументы")]
        [TestCase(1, int.MinValue, 3, int.MaxValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, int.MinValue, 3 в аргументы")]
        [TestCase(int.MaxValue, -2, 0, int.MinValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, -2, 0 в аргументы")]
        public void CalcFinishCoordinateTest(int startCoordinate, int startSpeed, int time, int acceleration)
        {
            var accelerated = new Accelerated(startCoordinate, startSpeed, time, acceleration);
            accelerated.CalcFinishCoordinate();
        }

        /// <summary>
        /// Негативный тест метода CalcFinishCoordinate
        /// </summary>
        /// <param name="startCoordinate">начальная координата</param>
        /// <param name="startSpeed">начальная скорость</param>
        /// <param name="time">время</param>
        [Test]
        [TestCase(1, 2, -3, 0, TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, -3 в аргументы")]
        [TestCase(-1, -2, -3, int.MinValue, TestName = "Тестирование метода CalcFinishCoordinate при присваивании -1, -2, -3 в аргументы")]
        [TestCase(int.MinValue, -2, -3, -1, TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MinValue, -2, -3 в аргументы")]
        public void CalcFinishCoordinateTestNegative(int startCoordinate, int startSpeed, int time, int acceleration)
        {
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () =>
            {
                var accelerated = new Accelerated(startCoordinate, startSpeed, time, acceleration);
                accelerated.CalcFinishCoordinate();
            });

        }
    }
}
