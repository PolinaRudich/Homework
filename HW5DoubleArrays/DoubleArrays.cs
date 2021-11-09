using System;

namespace HW5DoubleArrays
{
    public class DoubleArrays
    {
        
        public  void Task1()
        {
            Console.WriteLine("DoubleArrays 1");
            int[,] array = CreateDoubleArray();
            int minElement = FindMinElement(array);
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
        public  int FindMinElement(int [,] array)
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
            if (array.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            return minElement;

        }
        public  void Task2()
        {
            Console.WriteLine("DoubleArrays 2");
            int[,] array = CreateDoubleArray();
            int maxElement = FindMaxElement(array);
            Console.WriteLine(maxElement);

        }
        public  int FindMaxElement(int[,] array)
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
            if (array.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            return maxElement;

        }
        public  void Task3()
        {
            Console.WriteLine("DoubleArrays 3");
            int[,] array = CreateDoubleArray();
            int[] result = FindIndexOfTheMinElement(array);
            Console.WriteLine(result[0]);
            Console.WriteLine();
            Console.WriteLine(result[1]);
        }
        public  int [] FindIndexOfTheMinElement (int [,]array)
        {

            int indexI = 0;
            int indexJ = 0;
            int minElement3 = array[0, 0];
            //int firstIndex = 0;
            //int secondIndex = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] < minElement3)
                    {

                        minElement3 = array[i, j];
                        //firstIndex = i;
                        //secondIndex = j;
                        indexI = i;
                        indexJ = j;
                     
                    }


                }
            }
            
            if (array.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            //string indexes = $"{firstIndex} {secondIndex} ";
            int[] result = new int[2] { indexI, indexJ };
            return result;
        }
        public  void Task4()
        {
            Console.WriteLine("DoubleArrays 4");
            int[,] array = CreateDoubleArray();
            int[] result = FindIndexOfTheMaxElement(array);
            Console.WriteLine(result[0]);
            Console.WriteLine();
            Console.WriteLine(result[1]);

        }
        public  int[] FindIndexOfTheMaxElement(int [,]array)
        {
            int indexI = 0;
            int indexJ = 0;
            int maxElement3 = array[0, 0];
            //int firstIndex = 0;
            //int secondIndex = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] > maxElement3)
                    {

                        maxElement3 = array[i, j];
                        //firstIndex = i;
                        //secondIndex = j;
                        indexI = i;
                        indexJ = j;

                    }


                }
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Массив пуст");
            }
            //string indexes = $"{firstIndex} {secondIndex} ";
            int[] result = new int[2] { indexI, indexJ };
            return result;
        }
        public  void Task5()
        {
            Console.WriteLine("DoubleArrays 5");
            int[,] array = CreateDoubleArray();
            //string maxNumber5 = FindTheNumberOfMaxElementThenSosedi(array);
            //Console.WriteLine(maxNumber5);
           int result = FindTheNumberOfMaxElementThenNeighbors(array);
            Console.WriteLine(result);

        }
        //public  string FindAllOfTheMaxElements( int [,]array)
        //{
        //    string result = " ";
        //    for (int i = 0; i < array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < array.GetLength(1); j++)
        //        {
        //            int line = array.GetLength(0);
        //            int column = array.GetLength(1);

        //            if ((i == 0 || array[i, j] > array[i - 1, j]) &&
        //                     (j == 0 || array[i, j] > array[i, j - 1]) &&
        //                      (i == line - 1 || array[i, j] > array[i + 1, j]) &&
        //                       (j == column - 1 || array[i, j] > array[i, j + 1])

        //           )
        //            {
        //                int maxelements = array[i, j];
                        
        //                 result += $"{maxelements} {i} {j}\n ";
                       
        //            }
        //        }
        //    }
            
        //    return result;
        //}
        public int FindTheNumberOfMaxElementThenNeighbors(int[,] array)
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
        public void  ReverseDoubleArray ( int[,] array)
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
                    //result = $"{array[i, j]}";


                }
               
            }
            Console.WriteLine();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + " ");
                    result += $"{array[i, j]}";

                }
                Console.WriteLine();
            }
           
        }
        public int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        {4,3,5},
                        {1,5,2},
                        {7,0,4}
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        {4,1,7},
                        {3,5,0},
                        {5,2,4}
                    };
                    break;
                

            };
            return result;
        }
        public int[] ExpectedMock(int number)
        {

            return number switch
            {
                1 => new int[] {2,0}, 
                _=> new int[] {}
            };


       
        }
    }
}
