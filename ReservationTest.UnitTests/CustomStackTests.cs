using EvaluationSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvaluationSampleCode.CustomStack;

namespace EvaluationSampleTest.UnitTests
{
    [TestClass]
    public class CustomStackTests
    {
        private CustomStack _customstack;
        [TestInitialize]
        public void Init()
        {
            // Arrange
            _customstack = new CustomStack();
        }

        [TestMethod]

        public void Count_WhenListIsNotEmpty_ReturnNumber()
        {
            var result = _customstack.Count();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(5)]
        public void Push_WhenValue_PushInList(int iteration)
        {
            var expectedResult = _customstack.Count() + iteration;

            for (int i = 0; i < iteration; i++)
            {
                _customstack.Push(1);
            } 
            
            var result = _customstack.Count();

            

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Pop_WhenListIsUnder0_ThrowsArgumentException()
        {

            var _customstack2 = new CustomStack();

            // Act & Assert
            Assert.ThrowsException<StackCantBeEmptyException>(() => _customstack2.Pop());
        }

        [TestMethod]
        public void Pop_WhenPop_ReturnElementPopped()
        {
            var _customstack2 = new CustomStack();
            _customstack.Push(1);
            _customstack.Push(2);
            _customstack.Push(3);
            var result = _customstack.Pop();

            Assert.AreEqual(3, result);
        }
    }
}
