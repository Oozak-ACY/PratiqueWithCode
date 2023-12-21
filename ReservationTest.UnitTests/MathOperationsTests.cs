using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleTest.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations _operations;
        [TestInitialize]
        public void Init()
        {
            // Arrange
            _operations = new MathOperations();
        }

        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(1, 20, 21)]
        [DataRow(-2, 2, 0)]
        public void Add_WhenNumbersAreAdditionned(int number1, int number2, int expectedResult)
        {
            var result = _operations.Add(number1, number2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(2, 2, 1)]
        [DataRow(10, 2, 5)]
        [DataRow(-300, 2, -150)]

        public void Divide_WhenNumbersAreDivided(int number1, int number2, int expectedResult)
        {
            var result = _operations.Divide(number1, number2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, 0)]
        [DataRow(18, 0)]
        [DataRow(400, 0)]
        public void Divide_WhenNumber2Is0_ThrowsArgumentException(int number1, int number2)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _operations.Divide(number1, number2));
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-6)]
        [DataRow(-400)]
        public void GetOddNumbers_WhenNumberIsUnder0_ThrowsArgumentException(int limit)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _operations.GetOddNumbers(limit));
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(6)]
        [DataRow(400)]

        public void GetOddNumbers_WhenNumbersAreDivided(int limit)
        {
            List<int> notExpectedResult = new List<int>();
            var result = _operations.GetOddNumbers(limit);

            Assert.AreNotEqual(notExpectedResult, result);
        }
    }
   }
