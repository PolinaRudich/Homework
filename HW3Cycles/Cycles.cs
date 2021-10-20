using System;


namespace HW3Cycles
{
    public class Cycles
    {
        public void Task1()
        {
            Console.WriteLine("Cycles 1");
               int a = (int)GetNumberFromUser("Введите число a");
            int b = (int)GetNumberFromUser("Введите число b");
            long resultOfOperation = Elevate(a, b);
            Console.WriteLine(resultOfOperation);
        }
        public long Elevate( int a, int b)
        {

            long resultOfOperation = 1;
            if (a==0)
            {
                resultOfOperation = 0;
            }
            for (int q = 0; q < b; q++)
            {
                resultOfOperation *= a;
            }
            
            return resultOfOperation;
        }
        public  void Task2()
        {
            Console.WriteLine("Cycles 2");
            int a = (int)GetNumberFromUser("Введите число a");
           string result = DisplayTheNumberDivisibleByA(a);
            Console.WriteLine(result);
        }
        public  string DisplayTheNumberDivisibleByA ( int a)
        {
            
            string result = "";
            if (a == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            if (a < 0)
            {
                for (int p = 0; a * p >= -1000; p++)
                {
                    result += $"{(a * p) * (-1)} ";

                }
            }
            else
                for (int p = 0; a * p <= 1000; p++)
            {
                result += $"{a * p} ";
               
                   
            }
            return result;
        }
        public  void Task3()
        {
            int a = (int)GetNumberFromUser("Введите число a");
            int count = (int)FindNumbers(a);
            Console.WriteLine(count);
        }
        public int FindNumbers (int a)
        {
            int count = 0;
            for (int TmpNumber = 0; (Math.Pow(count, 2)) < a; TmpNumber++)
            {
                count++;
                


            }
            return count;
        }
        public  void Task4()
        {
            int a = (int)GetNumberFromUser("Введите число a");
            int nd = FindNOD(a);
            Console.WriteLine(nd);
        }
        public  int FindNOD(int a)
        {
            if(a==0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            int nd = 1;
            for (int o = 1; o < a; o++)
            {
                if (a % o == 0)
                {
                    nd = o;
                }
            }
            return nd;
        }
        public  void Task5()
        {
            Console.WriteLine("Cycles5");
            int a = (int)GetNumberFromUser("Введите число a");
            int b = (int)GetNumberFromUser("Введите число b");
            int sum = FindSummeryOfNumbers(a, b);
            Console.WriteLine(sum);
        }
        public  int  FindSummeryOfNumbers(int a, int b)
        {
            int sum = 0;
            if (a < b)
            {
                for (int m = a; m <= b; m++)
                {
                    if (m % 7 == 0)
                    {
                        sum += m;
                    }
                }
            }
            else if (a > b)
            {
                for (int r = b; r <= a; r++)
                {
                    if (r % 7 == 0)
                    {
                        sum += r;
                    }
                }
            }

            return sum;
        }
        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
        public void Task6()
        {
            int N = (int)GetNumberFromUser("Введите число N");
            int Fibonachi = FindNumberOfFibonacha(N);
            Console.WriteLine(Fibonachi);
        }
        public  int FindNumberOfFibonacha(int N)
        {
            int Fibonachi = 1;
            int previos1 = 0;
            int previos2 = 1;
            if(N<0)
            {
                
             for (int i = 0; i >N+1; i--)
                {
                    Fibonachi = previos1 - previos2;
                    previos1 = previos2;
                    previos2 = Fibonachi;
                }
                
            }
            else if(N==0)
            {
                Fibonachi = 0;
            }
            for (int h = 1; h < N; h++)
            {
                Fibonachi = previos1 + previos2;
                previos1 = previos2;
                previos2 = Fibonachi;
            }
            return Fibonachi;
        }
        public  void Task7()
        {
            int a = (int)GetNumberFromUser("Введите число a");
            int b = (int)GetNumberFromUser("Введите число b");
            int nod = (int)FindNODEvklid(a, b);
            Console.WriteLine(nod);
        }
        public  int FindNODEvklid(int a, int b)
        {
            int nod = 1;
            int tmpEvklid = 0;
            if (a > b&&b!=0&&b>0)
            {
                while (a != b)
                {
                    a = a - b;
                    if (a < b)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else if (a!=0&&a < b&&a>0)
            {
                while (a != b)
                {
                    b = b - a;
                    if (b < a)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else if (a != 0 && a < b&&b>0)
            {
                while (a != b)
                {
                    b = b + a;
                    if (b < a)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else if (a < b&&a==0)
            {
                while (a != b)
                {
                    a = a + b;
                    
                    if (b < a)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else if (b < a && b == 0)
            {
                while (a != b)
                {
                    b = a + b;

                    if (a < b)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else if (b > a && b != 0&&b<0)
            {
                while (a != b)
                {
                    a = a - b;

                    if (a > b)
                    {
                        tmpEvklid = b;
                        b = a;
                        a = tmpEvklid;
                    }
                }
                nod = b;
            }
            else
            {
                nod = a;
            }
            return nod;
                 
        }

        public  void Task8()
        {
            Console.WriteLine("Cycles 8");
            int a = (int)GetNumberFromUser("Введите число a");
            int mid =(int)NumberCubFromUsersNumber(a);
            Console.WriteLine(mid);
        }
        public int NumberCubFromUsersNumber(int a)
        {
            int left = 0;
            int mid = 0;
            int right = a;

            if (a <= 1 && a >= -1)
            {
                mid = a * a * a;
            }
           
            else
            {
                while (Math.Pow(mid, 3) != a)
                {
                    if (left < right)
                    {


                        mid = (left + right) / 2;
                        if (Math.Pow(mid, 3) > a)
                        { right = mid; }
                        else
                        { left = mid; }
                    }
                    else if (left > right) ;
                    {
                        mid = left;
                        mid = (mid + right) / 2;
                    }
                    
                   
                }

            }

            return mid;
        }
        public  void Task9()
        {
            Console.WriteLine("Cycles 9");
            long a = (long)GetNumberFromUser("Введите  одно число ");
            int count = FindSumOfNechetNumbers(a);
            Console.WriteLine(count);
        }
        public  int FindSumOfNechetNumbers ( long a)
        {
           
            int count = 0;
            long tmp = 0;
            if (a < 0)
            {
                for (long i = a; i < 0; i++)
                {
                    tmp = a % 10;
                    if (tmp % 2 != 0)
                    {
                        count += 1;
                    }
                    a /= 10;
                    i = a;
                }
                count += 1;
            }
            else
            {


                while (a > 0)
                {
                    tmp = a % 10;
                    if (tmp % 2 != 0)
                    {
                        count += 1;
                    }
                    a /= 10;
                }
            }
                return count;
        }
        public  void Task10()
        {
            Console.WriteLine("Cycles 10");
            int a = (int)GetNumberFromUser("Введите  одно число ");
            int num = MakeMirror(a);
            Console.WriteLine(num);
        }
        public  int MakeMirror(int a)
        {
            int num = 0;
            if(a<0)
            {
                for (int i = a; a <0; i++)
                {
                    num = num * 10 + (a) % 10;
                    a = a / 10;
                }
            }
            while (a > 0)
            {
                num = num * 10 + a % 10;
                a = a / 10;
            }
            return num;
        }
        public  void Task11()
        {
            Console.WriteLine("Cycles 11");
            int t = (int)GetNumberFromUser("Введите число ");
            Console.WriteLine();
            string tmp2 = FindSumChetMoreThanSumNechet(t);
           
        }
        public  string FindSumChetMoreThanSumNechet (int t)
        {
            int sumChet = 0;
            int sumNechet = 0;
            int tmp1 = 0;
            int tmp2 = 0;
            string result = "";
            for (int s = 1; s <= t; s++)
            {
                
                tmp2 = s;
                while (tmp2> 0)
                {
                    tmp1 = tmp2 % 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumChet += tmp1;
                    }
                    else
                    {
                        sumNechet += tmp1;
                    }
                    tmp2 = tmp2 / 10;
                }
                if (sumChet > sumNechet)
                {
                    result += $"{s} ";
                    Console.WriteLine(s);
                    sumChet = 0;
                    sumNechet = 0;
                }
                else
                {
                    sumChet = 0;
                    sumNechet = 0;
                }
                
            }
            
            return result;
        }
        public  void Task12()
        {
            Console.WriteLine("Cycles 12");
            int a = (int)GetNumberFromUser("Введите число a");
            int b = (int)GetNumberFromUser("Введите число b");
            string res = SayIfTheSameNumbers(a, b);
            Console.WriteLine(res);
        }
        public  string SayIfTheSameNumbers(int a, int b)
        {
            int tmp11 = Math.Abs(a);
            int tmp22 = Math.Abs(b);
            int srav = 0;
            int i = 0;
            int j = 0;
            string res = "";
            if (a != 0 || b != 0)
            {
                while (tmp11 > 0)
                {
                    i = tmp11 % 10;
                    tmp11 = tmp11 / 10;
                    while (tmp22 > 0)
                    {
                        j = tmp22 % 10;
                        tmp22 = tmp22 / 10;
                        if (i == j)
                        {
                            srav++;

                        }

                    }
                    tmp22 = b;
                }
                if (srav != 0)
                {
                    res = "yes";
                }
                else
                {
                    res = "no";
                }
            }
            else
            {
               res ="Введеные числа равны 0";
            }
            return res;
        }
        public  double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
    }
}
