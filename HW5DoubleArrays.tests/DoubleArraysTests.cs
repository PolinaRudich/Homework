using NUnit.Framework;

namespace HW5DoubleArrays.tests
{
    public class DoubleArraysTests
    {
        private DoubleArrays _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new DoubleArrays();
        }

        [TestCase(1, 0)]
        public void FindMinElementTest(int mocknumber, int expected)
        {
            //arrange
            int[,] arr = _hw5.GetMock(mocknumber);
            //act
            int actual = _hw5.FindMinElement(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 7)]
        public void FindMaxElementTest(int mocknumber, int expected)
        {
            //arrange
            int[,] arr = _hw5.GetMock(mocknumber);
            //act
            int actual = _hw5.FindMaxElement(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new int[] { 2, 1 })]
        public void FindIndexOfTheMinElementTest(int mocknumber, int []expected)
        {
            int[,] arr = _hw5.GetMock(mocknumber);
           
           int [] actual = _hw5.FindIndexOfTheMinElement(arr);
            
            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, new int[] {2,0 })]
        public void FindIndexOfTheMaxElementTest(int mocknumber, int[]expected)
        {
            int[,] arr = _hw5.GetMock(mocknumber);
            int[] actual = _hw5.FindIndexOfTheMaxElement(arr);
            Assert.AreEqual(actual, expected);
        }
        //[TestCase(1,"2 0 ")]
        //public void FindIndexOfTheMaxElementTest(int mocknumber,string expected)
        //{
        //    int[,] arr = _hw5.GetMock(mocknumber);
        //    string actual = _hw5.FindIndexOfTheMaxElement(arr);
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestCase(1,"5")]
        //public void FindTheNumberOfMaxElementThenSosediTest(int mocknumber,string expected)
        //{
        //    int[,] arr= _hw5.GetMock(mocknumber);
        //    string actual = _hw5.FindTheNumberOfMaxElementThenSosedi(arr);
        //    Assert.AreEqual(expected, actual);
        //}
       [TestCase(1,5)]
       public void FindTheNumberOfMaxElementThenNeighborsTest(int mocknumber, int expected)
        {
            int [,]arr =_hw5.GetMock(mocknumber);
            int actual = _hw5.FindTheNumberOfMaxElementThenNeighbors(arr);
            Assert.AreEqual(expected, actual);

        }
        [TestCase(1, 2)]
        public void ReverseDoubleArrayTest(int mocknumber, int mocknumber2)
        {

            
            int[,] actual = _hw5.GetMock(mocknumber);
            int[,] expected = _hw5.GetMock(mocknumber2);
           


             _hw5.ReverseDoubleArray(actual);
            Assert.AreEqual(expected, actual);
        }
       
    }
}
