using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdditionPass()
        {
            // Arrange
            double num1 = 5;
            double num2 = 10;
            double expected = 15;

            // Act
            double result = Calculator.Soma(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void TestAdditionFailed()
        {
            // Arrange
            double num1 = 5;
            double num2 = 10;
            double expected = 20;

            // Act
            double result = Calculator.Soma(num1, num2);

            // Assert
            Assert.AreNotEqual(expected, result);
        }
    

        [TestMethod]
        public void TestSubtractionPass()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 5;

            // Act
            double result = Calculator.Subtracao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        /*
        [TestMethod]
        public void TestSubtractionFailed()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 3;

            // Act
            double result = Calculator.Subtracao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        */
        [TestMethod]
        public void TestMultiplicationPass()
        {
            // Arrange
            double num1 = 5;
            double num2 = 10;
            double expected = 50;

            // Act
            double result = Calculator.Multiplicacao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        /*
        [TestMethod]
        public void TestMultiplicationFailed()
        {
            // Arrange
            double num1 = 5;
            double num2 = 10;
            double expected = 60;

            // Act
            double result = Calculator.Multiplicacao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        */
        [TestMethod]
        public void TestDivisionPass()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 2;

            // Act
            double result = Calculator.Divisao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        /*
        [TestMethod]
        public void TestDivisionFailed()
        {
            // Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 4;

            // Act
            double result = Calculator.Divisao(num1, num2);

            // Assert
            Assert.AreEqual(expected, result);
        }
        */
    }
}
