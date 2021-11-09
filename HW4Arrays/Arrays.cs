using System;

namespace HW4Arrays
{
    public class Arrays
    {


        public  void Task1()
        {
            Console.WriteLine("Arrays 1");
            int[] a = CreateArray();
            Console.WriteLine();
            int min = FindMin(a);
            Console.WriteLine(min);


        }

        public  void Task2()
        {
            Console.WriteLine("Arrays 2");
            int[] a = CreateArray();
            Console.WriteLine();
            int max = FindMax(a);
            Console.WriteLine(max);
        }
        public  int FindMax(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {

                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        public  int[] CreateArray()
        {
            int[] arr = new int[10];

            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
                Console.Write(arr[i]+ " ");
                
            }
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");

            //}
            return arr;
        }
        public  int FindMin(int[] a)
        {
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {

                if (min > a[i])
                {
                    min = a[i];
                }
            }
            if (a.Length == 0)
            {
                throw  new ArgumentException("Массив пуст");
            }
            return min;
           
        }



        public  void Task3()
        {
            Console.WriteLine("Arrays 3");
            int[] a = CreateArray();
            Console.WriteLine();
            int indexOfMinElement = FindIndexOfMinElement(a);
            Console.WriteLine(indexOfMinElement);
        }
        public  int FindIndexOfMinElement(int[] a)
        {
            int indexOfMinElement = 0;
            int minElement = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (minElement > a[i])
                {
                    minElement = a[i];
                    indexOfMinElement = i;
                }

            }
            if (a.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            return indexOfMinElement;
        }
        public  void Task4()
        {
            Console.WriteLine("Arrays 4");
            int[] a = CreateArray();
            Console.WriteLine();
            int indexOfMaxElement = FindIndexOfMaxElement(a);
            Console.WriteLine(indexOfMaxElement);
        }
        public  int FindIndexOfMaxElement(int[] a)
        {
            int indexOfMaxElement = 0;
            int maxElement = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (maxElement < a[i])
                {
                    maxElement = a[i];
                    indexOfMaxElement = i;
                }

            }
            if (a.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            return indexOfMaxElement;
        }
        public  void Task5()
        {
            Console.WriteLine("Arrays 5");
            int[] a = CreateArray();
            Console.WriteLine();
            int sumNechet = CountSumOfElementsWithOddIndexes(a);
            Console.WriteLine(sumNechet);

        }
        public  int CountSumOfElementsWithOddIndexes(int [] a)
        {

            int sumElementsOfNecetIndex = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumElementsOfNecetIndex += a[i];
                }
            }
            if (a.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            return sumElementsOfNecetIndex;
        }
        public  void Task6()
        {
            Console.WriteLine("Arrays 6");
            int[] a = CreateArray();
            Console.WriteLine();
              ReverseArray(a);
            Console.WriteLine();
        }
        public  void ReverseArray (int []a )
        {
           
            for (int i = 0; i < a.Length / 2; i++)
            {
                
                 int c = a[i];
                a[i] = a[a.Length - i - 1];
                a[a.Length - i - 1] = c;

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
               
            }
           

          
        }
        public  void Task7()
        {
            Console.WriteLine("Arrays 7");
            int[] a = CreateArray();
            Console.WriteLine();
            int sumnech = CountTheNumberOfOddElementsInAnArray(a);
            Console.WriteLine(sumnech);
        }
        public  int CountTheNumberOfOddElementsInAnArray(int []a)
        {
             int sumnech = 0;

        int nechet7 = a[0];
            for (int i = 0; i<a.Length; i++)
            {
                if (nechet7 % 2 != 0)
                {

                    sumnech = sumnech + 1;
                }
                nechet7 = a[i];
                
            }
            Console.WriteLine();
            return sumnech;

        }
        public  void Task8()
        {
            Console.WriteLine("Arrays 8");
            int[] a = CreateArray();
            Console.WriteLine();
             SwapHalvesOfTheArrays(a);
            
        }
        public  void SwapHalvesOfTheArrays(int []a)
        {
            int[] array = a;
            int tmp = 0;
            int odd = 0;
            int j = a.Length / 2;
            if (a.Length % 2 != 0)
            {
                odd = 1;
            }
            for (int i = 0; i < j; i++)
            {
                tmp = a[i];
                a[i] = a[j + i + odd];
                a[j + i + odd] = tmp;

            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            
        }
        public  void Task9()
        {
            Console.WriteLine("Arrays 9");
            int[] a = CreateArray();
            Console.WriteLine();
            SortArray(a);
        }
        public  void SortArray (int []a)
        {
            int[] array = a;
            int l = a.Length;
            for (int i = 0; i < l - 1; i++)
            {
                
                int minValue = a[i];
                int minIndex = i;
                for (int o = i + 1; o < l; o++)
                {
                    if (minValue > a[o])
                    {
                        minValue = a[o];
                        minIndex = o;
                    }
                }

                minValue = a[i];
                a[i] = a[minIndex];
                a[minIndex] = minValue;
                
                foreach (var item in a)
                {
                    Console.Write(item + " ");
                    
                }
                Console.WriteLine();
                
            }
        
        }
        public  void Task10()
        {
            Console.WriteLine("Arrays 10");
            int[] a = CreateArray();
            Console.WriteLine();
             SortArraySecondWay(a);
            Console.WriteLine();
        }
        public  void  SortArraySecondWay(int[]a)
        {
            int[] array = a;
            for (int i1 = 1; i1 < a.Length; i1++)
            {
                int tmp10 = a[i1];
                int j1 = i1;
                while (j1 > 0 && tmp10 > a[j1 - 1])
                {
                    a[j1] = a[j1 - 1];
                    j1--;
                }
                a[j1] = tmp10;
            }
            for (int i1 = 0; i1 < a.Length; i1++)
            {
                Console.Write(a[i1] + " ");
            }
           
        }
        public  double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
    }
}
