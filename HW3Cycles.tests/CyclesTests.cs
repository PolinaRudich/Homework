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
        [TestCase(32,2,1024)]
        [TestCase(1024,2,1048576)]
        [TestCase(-2,3,-8)]
        [TestCase(5,3,125)]
        public void PowerTests(int a, int b, long expected)

        {
            //act 
            long actual = _hw3.Power(a, b);
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
        public void FindNodTest(int a, int expected)
        {
            //arrange 



            //act
            int actual = _hw3.FindNod(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-7, 21, 35)]
        [TestCase(25, 70, 343)]
        [TestCase(70, 25, 343)]
        public void FindSummeryOfNumbersTests(int a, int b, int expected)
        {
            //act
            int actual = _hw3.FindSummeryOfNumbers(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-8, -21)]
        [TestCase(0,0)]
        [TestCase(-2,-1)]
        //−8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, ...
        public void FindNumberOfFibonachaTest(int N, int expected)
        {
            //act
            int actual = _hw3.FindNumberOfFibonacha(N);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-100, -10, -10)]
        [TestCase(8, 0, 8)]
        [TestCase(7,6,1)]
        public void FindNodEvklidTest(int a, int b, int expected)
        {
            //act
            int actual = _hw3.FindNodEvklid(a, b);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-1234, 2)]
        public void FindSumOfOddNumbersTest(int a, int expected)
        {
            //act
            int actual = _hw3.FindSumOfOddNumbers(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(-123, -321)]
        [TestCase(5500,0055)]
        public void MakeMirrorTest(int a, int expected)
        {
            //act
            int actual = _hw3.MakeMirror(a);
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestCase(278, 781, "yes")]
        [TestCase(104, 0, "yes")]
        [TestCase(0, 0, "Введеные числа равны 0")]
        [TestCase(0, 104, "yes")]
        public void SayIfTheSameGigitsFoundTest(int a, int b, string expected)
        {
            //act
            string actual = _hw3.SayIfTheSameGigitsFound(a, b);
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
        [TestCase(999, "0 999 ")]
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
            Assert.Throws(typeof(DivideByZeroException), () => _hw3.FindNod(a));
        }
        [TestCase(5, "2 4 ")]
        [TestCase(6, "2 4 6 ")]
        [TestCase(1, "")]
        public void FindSumEvenMoreThanSumOddTest(int a, string expected)
        {
            //arrange 
            //act
            string actual = _hw3.FindSumEvenMoreThanSumOdd(a);

            //assert
            Assert.AreEqual(expected, actual);
        }
        
       
    }
}