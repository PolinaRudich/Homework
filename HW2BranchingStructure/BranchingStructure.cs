using System;

namespace HW2BranchingStructure
{
    public class BranchingStructure
    {
        public  void Task1()
        {
            Console.WriteLine("Branching Structure 1");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double result = OrderNumbers(a, b);
            Console.WriteLine(result);

        }
        public  double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
      
        public  double OrderNumbers(double a, double b)
        {
            double result = 0;
            if (a > b)
            {
                 result = a + b;
               
            }
            else if (a == b)
            {
                result = a*b;
               
            }
            else
            {
                 result = a/b;
               
            }
            return result;
        }
        public  void Task2()
        {
            Console.WriteLine("Branching Structure 2");
            double X = GetNumberFromUser("Введите число a");
            double Y = GetNumberFromUser("Введите число b");
            int result = FindQuater(X, Y);
            string result1 = ShowQuater(result);
            Console.WriteLine(result1);



        }
        public string ShowQuater(int result)
        {
            
           
           
             string result1 = result switch
            {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                0=> "Не лежит на четверти",
                _ => "",
            };
            return result1;
        }
        public int FindQuater(double X, double Y)
        {
            int result = 0;
            if (X > 0 && Y > 0)
            {
                result = 1;


            }
            else if (X < 0 && Y > 0)
            {
                result = 2;
            }
            else if (X < 0 && Y < 0)
            {
                result = 3;
            }
            else
            {
                result = 4;
            }
            if (X == 0 || Y == 0)
            {
                result = 0;
            }
            return result;
        }


        public  void Task3()
        {
            Console.WriteLine("Branching Structure 3");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double c = GetNumberFromUser("Введите число c");
            string result = Compare(a, b, c);
            Console.WriteLine(result);
        }




        public  string Compare(double a, double b, double c)
        {
            string result = "";
            if (a <= b && b <= c)
            {

                result = $"{a},{b},{c}";
            }
            else if (b <= a && a <= c)
            {
               result = $"{b},{a},{c}";
            }
            else if (c <= a && a <= b)
            {
                result = $"{c},{a},{b}";
            }
            else if (a <= c && c <= b)
            {
                result = $"{a},{c},{b}";
            }
            else if (b <= c && c <= a)
            {

               result = $"{b},{c},{a}";
            }
            else if (c <= b && b <= a)
            {
                result =$"{c},{b},{a}";
            }
            return result;
        }
        //Пользователь вводит 3 числа (A, B и С).
        //Выведите в консоль решение(значения X) квадратного уравнения стандартного вида,
        //где AX2+BX+C=0.
        public  void Task4()
        {
            Console.WriteLine("Branching Structure 4");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double c = GetNumberFromUser("Введите число c");
            string result = CountDiscriminant(a, b, c);
            Console.WriteLine(result);
        }
        public  string CountDiscriminant(double a, double b, double c)
        {

            string result = "";
            double discriminant = Math.Pow(b, 2) - 4 * (a) * (c);
            double x1 = ((-1 * (b)) - Math.Sqrt(discriminant)) / (2 * (a));
            double x2 = ((-1 * (b)) + Math.Sqrt(discriminant)) / (2 * (a));
            if (double.IsInfinity(x1) ||  double.IsInfinity(x2))
            {
                throw new DivideByZeroException("a не может быть  нулем");
            }
            if(double.IsNaN(x2) || double.IsNaN(x1) )
            {
                
                throw new ArgumentException("Дискриминант отрицательный");
            }
            if (discriminant > 0)
            {
                 result=$"Ответ x1={x1} x2={x2}";
            }
            
            else if (discriminant == 0)
            {
                result = $"Ответ x1={x1} x2={x2}";
            }
            return result;
           
            
        }
        public  void Task5()
        {
            Console.WriteLine("Branching Structure 5");
            int a = (int)GetNumberFromUser("Введите двузначное число");
            string result = ConvertToLetters(a);
            Console.WriteLine(result);
        }
        public  string ConvertToLetters(int a)
        {
            string fromTenToNineteen = "";
            string result = "";
            fromTenToNineteen = a switch
            {
                10 => "десять",
                11 => "одинадцать",
                12 => "двенадцать",
                13 => "тринадцать",
                14 => "Четырнадцать",
                15 => "Пятнадцать",
                16 => "Шестнадцать",
                17 => "Семнадцать",
                18 => "Восемнадцать",
                19 => "Девятнадцать",
                _ => "",
            };
            
            int ten = a / 10;
            int one = a % 10;
            string tens = "";
            string ones = "";
            tens = ten switch
            {
                2 => "Двадцать",
                3 => "Тридцать",
                4 => "Сорок",
                5 => "Пятьдесят",
                6 => "Шестьдесят",
                7 => "Семьдесят",
                8 => "Восемдесят",
                9 => "Девяносто",
                _ => "",
            };
            ones = one switch
            {
                1 => "один",
                2 => "два",
                3 => "три",
                4 => "четыре",
                5 => "пять",
                6 => "шесть",
                7 => "семь",
                8 => "восемь",
                9 => "девять",
                _=> "",
            };
            if (a < 20 && a > 9)
            {
                result =$"Результат: " + fromTenToNineteen;
            }
            else if (a < 10 || a > 99)
            {
                result ="Результат: Число не принадлежит диапазону от 10 до 99";
            }
            else if (a > 19 && a < 100)
            {
                result=$"Результат: " +  tens + " " + ones;
            }
            return result;
        }   
    }   
}