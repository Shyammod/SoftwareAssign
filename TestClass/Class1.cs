using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 
using TriangleSolver;



namespace TriangleSolver.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        // 1. For equilateral triangle 
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ReturnsEquilateral()
        {
            // Arrange
            int side1 = 3, side2 = 3, side3 = 3;

            // Acte
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }

        // 2. For isosceles triangle (two sides equal)
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_TwoSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        // 3. For isosceles triangle (different two sides equal)
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_OtherTwoSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 7, side2 = 10, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        // 4. For isosceles triangle (first and third sides equal)
        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_FirstAndThirdSidesEqual_ReturnsIsosceles()
        {
            // Arrange
            int side1 = 6, side2 = 9, side3 = 6;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        // 5. For valid scalene triangle (all sides different)
        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 4, side2 = 6, side3 = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        // 6. For scalene triangle
        [Test]
        public void AnalyzeTriangle_AnotherScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 5, side2 = 7, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        // 7. For scalene triangle
        [Test]
        public void AnalyzeTriangle_ThirdScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 8, side2 = 15, side3 = 17;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        // 8. For another valid scalene triangle
        [Test]
        public void AnalyzeTriangle_FourthScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 9, side2 = 12, side3 = 13;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        // 9. For large scalene triangle
        [Test]
        public void AnalyzeTriangle_LargeScaleneTriangle_ReturnsScalene()
        {
            // Arrange
            int side1 = 100, side2 = 150, side3 = 200;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        // 10. For zero-length side
        [Test]
        public void AnalyzeTriangle_ZeroLengthFirstSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = 0, side2 = 5, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        // 11. For zero-length second side
        [Test]
        public void AnalyzeTriangle_ZeroLengthSecondSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = 5, side2 = 0, side3 = 5;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        // 12. For zero-length third side
        [Test]
        public void AnalyzeTriangle_ZeroLengthThirdSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = 5, side2 = 5, side3 = 0;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        // 13. For invalid triangle (sum of two sides not greater than the third)
        [Test]
        public void AnalyzeTriangle_InvalidTriangleSides_ReturnsInvalid()
        {
            // Arrange
            int side1 = 1, side2 = 2, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID!"));
        }

        // 14. For another invalid triangle
        [Test]
        public void AnalyzeTriangle_AnotherInvalidTriangleSides_ReturnsInvalid()
        {
            // Arrange
            int side1 = 7, side2 = 2, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID!"));
        }

        // 15. For invalid triangle with negative side
        [Test]
        public void AnalyzeTriangle_InvalidNegativeSide_ReturnsInvalid()
        {
            // Arrange
            int side1 = -5, side2 = 7, side3 = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);

            // Assert
            Assert.That(result, Is.EqualTo("INVALID!"));
        }
    }
}
    


