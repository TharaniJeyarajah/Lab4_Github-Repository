// Project 2: TriangleTest
using NUnit.Framework;
using NUnitDemonstration;

//Tharani Jeyarajah
namespace TriangleTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";


            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
