
using NUnit.Framework;

namespace Rectangle.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        [SetUp]
        public void SetUp()
        {
            Rectangle rec = new Rectangle();

        }
        [Test]
        public void GetLengthMethod_Input_2_Expct2()
        {
            // Arrange
            var rec = new Rectangle(2,3);

            // Act
            int actualResult = rec.GetLength();

            // Assert
            Assert.AreEqual(2, actualResult);

        }
        [Test]
        public void SetLengthMethod_Input_20_Expct20()
        {
            // Arrange
            var rec = new Rectangle(22, 30);

            // Act
            int actualResult = rec.SetLength(20);

            // Assert
            Assert.AreEqual(20, actualResult);

        }
        [Test]
        public void GetWidthMethod_Input_13_Expct13()
        {
            // Arrange
            var rec = new Rectangle(12, 13);

            // Act
            int actualResult = rec.GetWidth();

            // Assert
            Assert.AreEqual(13, actualResult);

        }
        [Test]
        public void SetWidthMethod_Input_45_Expct45()
        {
            // Arrange
            var rec = new Rectangle(22, 30);

            // Act
            int actualResult = rec.SetWidth(45);

            // Assert
            Assert.AreEqual(45, actualResult);

        }



        [Test]
        public void GetAreaMethod_Input_5_4_Expct2()
        {
            // Arrange
            var rec = new Rectangle(5, 4);

            // Act
            int actualResult = rec.GetArea();

            // Assert
            Assert.AreEqual(20, actualResult);

        }
        [Test]
        public void GetPerimeterMethod_Input_24_30_Expct20()
        {
            // Arrange
            var rec = new Rectangle(24, 30);

            // Act
            int actualResult = rec.GetPerimeter();

            // Assert
            Assert.AreEqual(108, actualResult);

        }
    }
}
