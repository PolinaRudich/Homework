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
        public void FindMinElementOfTheDoubleArrayTest(int mocknumber, int expected)
        {
            //arrange
            int[,] arr = _hw5.GetMock(mocknumber);
            //act
            int actual = _hw5.FindMinElementOfTheDoubleArray(arr);
            //assert
            Assert.AreEqual(expected,actual);
        }
        [TestCase(1,7)]
        public void FindMaxElementOfTheDoubleArrayTest(int mocknumber,int expected)
        {
            //arrange
            int[,] arr = _hw5.GetMock(mocknumber);
            //act
            int actual = _hw5.FindMaxElementOfTheDoubleArray(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,"2 1 ")]
        public void FindIndexOfTheMinElementOfTheDoubleArrayTest(int mocknumber,string expected)
        {
            int[,] arr = _hw5.GetMock(mocknumber);
            string actual = _hw5.FindIndexOfTheMinElementOfTheDoubleArray(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,"2 0 ")]
        public void FindIndexOfTheMaxElementOfTheDoubleArrayTest(int mocknumber,string expected)
        {
            int[,] arr = _hw5.GetMock(mocknumber);
            string actual = _hw5.FindIndexOfTheMaxElementOfTheDoubleArray(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1,"5")]
        public void FindTheNumberOfMaxElementThenSosediTest(int mocknumber,string expected)
        {
            int[,] arr= _hw5.GetMock(mocknumber);
            string actual = _hw5.FindTheNumberOfMaxElementThenSosedi(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1," 4 0 0\n 5 0 2\n 5 1 1\n 7 2 0\n 4 2 2\n ")]
        public void FindAllOfTheMaxElementsTest(int mocknumber, string expected)
        {
            int[,] arr = _hw5.GetMock(mocknumber);
            string actual = _hw5.FindAllOfTheMaxElements(arr);
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
        //[TestCase(1, "0417350524")]
        //public void ReverseDoubleArrayTest(int mocknumber, string expected)
        //{


        //    int[,] arr = _hw5.GetMock(mocknumber);



        //    string actual = $"{_hw5.ReverseDoubleArray(arr)}";
        //    Assert.AreEqual(expected, actual);
    }
}
