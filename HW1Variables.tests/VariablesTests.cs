using NUnit.Framework;
using System;

namespace HW1Variables.tests
{
    public class VariablesTests
    {
        private Variables _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new Variables(12, 14, 10, 1, 5);
        }

        [TestCase(3, 2, -19)]

        public void CountNumbersTest(double a, double b, double expected)
        {
            //arrange

            //act
            double actual = _hw1.CountNumbers(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2,2)]
        public void CountNumbersNegativeTest(double a, double b)
        {
            Assert.Throws(typeof(ArgumentException), () => _hw1.CountNumbers(a, b));
        }
        [TestCase("qwe", "asd", "asdqwe")]
        public void ActionsWithStringsTest( ref string stringOne, ref string stringTwo,  ref string expected)
        {
            //act
            string actual = _hw1.ActionsWithStrings(stringOne, stringTwo);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, 6, 0)]
        public void DivideNumbersWithoutRemainderTest(double a, double b, int expected)
        {
            //act 
            double actual = _hw1.DivideNumbersWithoutRemainder(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,1,0)]
        public void DivideNumbersWithRemainderTest( double a, double b, int expected)
        {
            //act 
            double actual = _hw1.DivideNumbersWithRemainder(a,b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,3,2)]
        public void DoLinearEquationNegativeTest(double a, double b, double c)
        {
            //act, assert 
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.DoLinearEquation(a, b, c));
            
          
        }
        [TestCase(7,7,7,7)]
        public void FindCoefficienEquationNegativeTest(double x1, double x2, double y1, double y2)
        {
            //act, assert
            Assert.Throws(typeof(DivideByZeroException), () => _hw1.FindCoefficienEquation(x1, x2, y1, y2));
        }
        [TestCase(2,4,3,9,3)]
        public void FindCoefficienEquationTest(double x1,double x2, double y1, double y2,double expected)
        {
            double actual = _hw1.FindCoefficienEquation(x1, x2, y1, y2);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(2, 0.5, 3, 0.5)]
        public void FindFreeMemberTest(double y2, double A, double x2, double expected)
        {
            // act
            double actual = _hw1.FindFreeMember(y2, A, x2);
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}