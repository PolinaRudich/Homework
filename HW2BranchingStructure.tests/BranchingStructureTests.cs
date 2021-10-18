using NUnit.Framework;
using System;

namespace HW2BranchingStructure.tests
{
    public class BranchingStructureTests
    {
        private BranchingStructure _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new BranchingStructure();
        }

        [TestCase(3,4,-1)]
        public void CompareasTest( double a, double b, double expected)
        {
            //arrange 
            //act 
            double actual = _hw2.Compareas(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, 4, "I")]
        public void FindQuaterTest(double X, double Y, string expected)
        {
            //arrange 
            //act 
            string actual = _hw2.FindQuater(X, Y);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, 4, 1, "1,3,4")]
        public void CompareTest(double a, double b, double c, string expected)
        {
            //arrange 
            //act 
            string actual = _hw2.Compare(a, b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 3, 9)]
        public void CountDiscriminantNegativeTest(double a, double b, double c)
        {
          
            //act, assert 
            Assert.Throws(typeof(ArgumentException), () => _hw2.CountDiscriminant(a, b, c));
        }
        [TestCase(0,1,1)]
        public void CountDiscriminantNegativeDivideByZeroTest(double a, double b, double c)
        {

            //act, assert 
            Assert.Throws(typeof(DivideByZeroException), () => _hw2.CountDiscriminant(a, b, c));
        }
        [TestCase(45, "Результат: Сорок пять")]
        public void ConvertToLettersTest(int a, string expected)
        {
            //act
            string actual = _hw2.ConvertToLetters(a);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}