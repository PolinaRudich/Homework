using NUnit.Framework;

namespace HW4Arrays.test
{
    public class ArraysTests

    {
        private Arrays _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new Arrays();
        }

        [TestCase( new int[4] {1, 2, 3, 0}, 0)]
        public void FindMinTest(int [] a, int expected)
        {
            //arrange
         


            //act
            int actual = _hw4.FindMin(a);
            Assert.AreEqual(expected,actual);
        }
        [TestCase(new int[4] { 1, 2, 3, 0 }, 3)]
        public void FindMaxTest(int[] a, int expected)
        {
            //arrange



            //act
            int actual = _hw4.FindMax(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] { 1, 2, 3, 0 }, 3)]
        public void FindIndexOfMinElementTest(int[] a, int expected)
        {
            //arrange



            //act
            int actual = _hw4.FindIndexOfMinElement(a);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {1,2,3,4},3)]
        public void FindIndexOfMaxElementTest(int[]a, int expected)
        {
            //arannge
            //act
            int actual = _hw4.FindIndexOfMaxElement(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {1,2,3,4}, 6)]
        public void CountSumOfElementsWithNechetIndexesTest(int[]a,int expected)
        {
            //arange
            //act
            int actual = _hw4.CountSumOfElementsWithNechetIndexes(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {1,2,3,4}, new int[4] {4,3,2,1})]
        public void ReverseArray(int[]a, int [] expected)
        {
            //arrange
            //act 
            int[] actual = _hw4.ReverseArray(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {1,2,3,4}, new int[4] {3,4,1,2})]
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, new int[5] { 4, 5, 3, 1, 2 })]
        public void SwapHalvesOfTheArraysTest(int[]a,int[]expected)
        {
            //arrange
            //act
            int[] actual = _hw4.SwapHalvesOfTheArrays(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {3,5,2,1}, new int[4] {1,2,3,5})]
        public void SortArrayTest(int[]a, int[]expected)
        {
            //arrange
            //act
            int[] actual = _hw4.SortArray(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[4] {6,1,2,4}, new int[4] {6,4,2,1})]
        public void SortArraySecondWayTest(int[]a,int[]expected)
        {
            //arrange
            //act
            int[] actual = _hw4.SortArraySecondWay(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 3)]
        public void CountTheNumberOfOddElementsInAnArrayTest(int []a, int expected)
        {
            int actual = _hw4.CountTheNumberOfOddElementsInAnArray(a);
            Assert.AreEqual(expected, actual);
        }
    }
}