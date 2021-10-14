using System;

namespace HW5DoubleArrays
{
    public class DoubleArrays
    {
        public  void Task1()
        {
            Console.WriteLine("DoubleArrays 1");
            int[,] array = CreateDoubleArray();
            int minElement = FindMinElementOfTheDoubleArray(array);
            Console.WriteLine(minElement);

        }
        public  int[,] CreateDoubleArray ()
        {
            int[,] array1 = new int[4, 4];
            Random random = new Random();

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {

                    array1[i, j] = random.Next(100);
                    Console.Write(array1[i, j] + " "); 
                }
                Console.WriteLine();
            }
            return array1;
        }
        public  int FindMinElementOfTheDoubleArray(int [,] array)
        {
            int minElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                    }


                }
            }
            return minElement;

        }
        public  void Task2()
        {
            Console.WriteLine("DoubleArrays 2");
            int[,] array = CreateDoubleArray();
            int maxElement = FindMaxElementOfTheDoubleArray(array);
            Console.WriteLine(maxElement);

        }
        public  int FindMaxElementOfTheDoubleArray(int[,] array)
        {
            int maxElement = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                    }


                }
            }
            return maxElement;

        }
        public  void Task3()
        {
            Console.WriteLine("DoubleArrays 3");
            int[,] array = CreateDoubleArray();
            int minElement = FindMinElementOfTheDoubleArray(array);
            string indexes = FindIndexOfTheMinElementOfTheDoubleArray(array);
            Console.WriteLine(indexes);
        }
        public  string FindIndexOfTheMinElementOfTheDoubleArray (int [,]array)
        {
            
            int minElement3 = array[0, 0];
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < minElement3)
                    {

                        minElement3 = array[i, j];
                        firstIndex = i;
                        secondIndex = j;
                    }


                }
            }
            string indexes = $"{firstIndex} {secondIndex} ";
            return indexes;

        }
        public  void Task4()
        {
            Console.WriteLine("DoubleArrays 4");
            int[,] array = CreateDoubleArray();
            int maxElement = FindMaxElementOfTheDoubleArray(array);
            string indexes = FindIndexOfTheMaxElementOfTheDoubleArray(array);
            Console.WriteLine(indexes);

        }
        public  string FindIndexOfTheMaxElementOfTheDoubleArray(int [,]array)
        {
            int minElement3 = array[0, 0];
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] > minElement3)
                    {

                        minElement3 = array[i, j];
                        firstIndex = i;
                        secondIndex = j;
                    }


                }
            }
            string indexes = $"{firstIndex} {secondIndex} ";
            return indexes;
        }
        public  void Task5()
        {
            Console.WriteLine("DoubleArrays 5");
            int[,] array = CreateDoubleArray();
            int maxNumber5 = FindTheNumberOfMaxElementThenSosedi(array);
            Console.WriteLine(maxNumber5);
            string result = FindAllOfTheMaxElements(array);
            Console.WriteLine(result);

        }
        public  string FindAllOfTheMaxElements( int [,]array)
        {
            string result = " ";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int line = array.GetLength(0);
                    int column = array.GetLength(1);

                    if ((i == 0 || array[i, j] > array[i - 1, j]) &&
                             (j == 0 || array[i, j] > array[i, j - 1]) &&
                              (i == line - 1 || array[i, j] > array[i + 1, j]) &&
                               (j == column - 1 || array[i, j] > array[i, j + 1])

                   )
                    {
                        int maxelements = array[i, j];
                        
                         result = $"{maxelements}, {i}, {j}";
                        
                    }
                }
            }
            
            return result;
        }
        public  int FindTheNumberOfMaxElementThenSosedi(int [,]array)
        {
            int line = array.GetLength(0);
            int column = array.GetLength(1);
            int maxNumber5 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j]) &&
                              (j == 0 || array[i, j] > array[i, j - 1]) &&
                               (i == line - 1 || array[i, j] > array[i + 1, j]) &&
                                (j == column - 1 || array[i, j] > array[i, j + 1])
                    )
                    {
                        maxNumber5 = maxNumber5 + 1;

                    }

                }

            }
            return maxNumber5;
        }
        public  void Task6()
        {
            Console.WriteLine("DoubleArrays 6");
            int[,] array = CreateDoubleArray();
            ReverseDoubleArray(array);
            
           
        }
        public  double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public string  ReverseDoubleArray (int[,] array)
        {
            string result = " ";
            int tmp = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                    result = $"{array[i, j]}";


                }
               
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write($"{array[i, j]} ");

                }
                Console.WriteLine();
            }
            return result;
        }
    }
}
