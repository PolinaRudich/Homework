using NUnit.Framework;
using System;

namespace HW3Cycles.tests
{
    public class CyclesTests
    {
        private Cycles _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new Cycles();
        }

        [TestCase(0, 0, 0)]
        public void ElevateTests(int a, int b, long expected)

        {
            //act 
            long actual = _hw3.Elevate(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(25, 5)]
        public void FindNumbersTest(int a, int expected)
        {
            //arrange 
            //act
            int actual = _hw3.FindNumbers(a);

            //assert
            Assert.AreEqual(actual, expected);
        }
        //[TestCase]
        [TestCase(6, 3)]
        public void FindNODTest(int a, int expected)
        {
            //arrange 



            //act
            int actual = _hw3.FindNOD(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-7, 21, 35)]
        
        public void FindSummeryOfNumbersTests(int a, int b, int expected)
        {
            //act
            int actual = _hw3.FindSummeryOfNumbers(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-8, -21)]
        public void FindNumberOfFibonachaTest(int N, int expected)
        {
            //act
            int actual = _hw3.FindNumberOfFibonacha(N);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-100, -10, -10)]
        public void FindNODEvklidTest(int a, int b, int expected)
        {
            //act
            int actual = _hw3.FindNODEvklid(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-1234, 2)]
        public void FindSumOfNechetNumbersTest(int a, int expected)
        {
            //act
            int actual = _hw3.FindSumOfNechetNumbers(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-123, -321)]
        public void MakeMirrorTest(int a, int expected)
        {
            //act
            int actual = _hw3.MakeMirror(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(278, 781, "yes")]
        public void SayIfTheSameNumbersTest(int a, int b, string expected)
        {
            //act
            string actual = _hw3.SayIfTheSameNumbers(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-1, -1)]
        public void NumberCubFromUsersNumberTest(int a, int expected)

        {   //act
            int actual = _hw3.NumberCubFromUsersNumber(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1000, "0 1000 ")]
        [TestCase(-1000, "0 1000 ")]
        public void DisplayTheNumberDivisibleByATest(int a, string expected)
        {
           //act
            string actual = _hw3.DisplayTheNumberDivisibleByA(a);
            //assert
            Assert.AreEqual(expected,actual);


        }
        [TestCase(0, "На ноль делить нельзя")]
        public void DisplayTheNumberDivisibleByANegativeTest(int a, string expected)
        {

            //act, assert 
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.DisplayTheNumberDivisibleByA(a));
        }
        [TestCase(0, "На ноль делить нельзя")]
        public void FindNODNegativeTest(int a, string expected)
        {

            //act, assert 
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.FindNOD(a));
        }
        [TestCase(5, "2 4 ")]
        public void FindSumChetMoreThanSumNechetTest(int a, string expected)
        {
            //arrange 
            //act
            string actual = _hw3.FindSumChetMoreThanSumNechet(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
       
    }
}