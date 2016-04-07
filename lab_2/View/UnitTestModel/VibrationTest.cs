using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model
{
    [TestFixture]
    public class VibrationalTests
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
            var vibrational = new Vibrational(0, 0, 0, 0);
            vibrational.StartCoordinate = startCoordinate;
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
            var vibrational = new Vibrational(0, 0, 0, 0);
            vibrational.StartSpeed = startSpeed;
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
            var vibrational = new Vibrational(0, 0, 0, 0);
            vibrational.Time = time;
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
            var vibrational = new Vibrational(0, 0, 0, 0);
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { vibrational.Time = time; }); //!!!//
        }

        /// <summary>
        /// Тестирование свойства Amplitude
        /// </summary>
        /// <param name="time">время движения</param>
        [Test]
        [TestCase(0, TestName = "Тестирование Amplitude при присваивании 0.")]
        [TestCase(int.MaxValue, TestName = "Тестирование Amplitude при присваивании int.MaxValue.")]
        public void AmplitudeTest(int Amplitude)
        {
            var vibrational = new Vibrational(0, 0, 0, 0);
            vibrational.Time = Amplitude;
        }
        
        /// <summary>
        /// Негативный тест Amplitude
        /// </summary>
        /// <param name="amplitude">амплитуда</param>
        [Test]
        [TestCase(int.MinValue, TestName = "Тестирование Amplitude при присваивании int.minValue.")]
        [TestCase(-50, TestName = "Тестирование Amplitude при присваивании -50.")]
        [TestCase(-1, TestName = "Тестирование Amplitude при присваивании -1.")]
        public void AmplitudeTestNegative(int amplitude)
        {
            var vibrational = new Uniform(0, 0, 0);
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () => { vibrational.Time = amplitude; });
            //!!!//
        }

        /// <summary>
        /// Тестирование метода CalcFinishCoordinate
        /// </summary>
        /// <param name="startCoordinate">начальная координата  </param>
        /// <param name="startSpeed">начальная скорость</param>
        /// <param name="time">время движения</param>
        /// <param name="amplitude">амплитуда</param>
        [Test]
        [TestCase(1, 2, 3,
            TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, 3 в аргументы")]
        [TestCase(-1, 2, int.MaxValue,
            TestName = "Тестирование метода CalcFinishCoordinate при присваивании -1, 2, int.MaxValue в аргументы")]
        [TestCase(int.MaxValue, 2, int.MaxValue,
            TestName =
                "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, 2, int.MaxValue в аргументы"
            )]
        [TestCase(1, int.MinValue, 3,
            TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, int.MinValue, 3 в аргументы")]
        [TestCase(int.MaxValue, -2, 0,
            TestName = "Тестирование метода CalcFinishCoordinate при присваивании int.MaxValue, -2, 0 в аргументы")]
        public void CalcFinishCoordinateTest(int startCoordinate, int startSpeed, int time, int amplitude)
        {
            var vibrational = new Vibrational(startCoordinate, startSpeed, time, amplitude);
            vibrational.CalcFinishCoordinate();
        }

        /// <summary>
        /// Тестирование метода CalcFinishCoordinate
        /// </summary>
        /// <param name="startCoordinate">начальная координата  </param>
        /// <param name="startSpeed">начальная скорость</param>
        /// <param name="time">время движения</param>
        /// <param name="amplitude">амплитуда</param>
        [Test]
        [TestCase(1, 2, -3, int.MinValue,
            TestName =
                "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, -3, int.MinValue в аргументы")]
        [TestCase(1, 2, -3, 0,
            TestName = "Тестирование метода CalcFinishCoordinate при присваивании 1, 2, -3, 0 в аргументы")]
        public void CalcFinishCoordinateTestNegative(int startCoordinate, int startSpeed, int time, int amplitude)
        {
            NUnit.Framework.Assert.Throws(typeof(ArgumentException), () =>
            {
                var uniform = new Accelerated(startCoordinate, startSpeed, time, amplitude);
                uniform.CalcFinishCoordinate();
            });

        }
    }
}
