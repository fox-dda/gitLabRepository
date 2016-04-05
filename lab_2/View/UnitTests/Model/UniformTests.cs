using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model
{
    /// <summary>
    /// Набор тестов для класса Uniform
    /// </summary>
    [TestFixture]
    public class UniformTests
    {
        [Test]
        [TestCase(4, TestName = "Тестирование StartCoordinate при присваивании 4.")]
        public void StartCoordinateTest(int startCoordinate)
        {
            var uniform = new Uniform(0,0,0);
            uniform.StartCoordinate = startCoordinate;    
        }
    }
}
