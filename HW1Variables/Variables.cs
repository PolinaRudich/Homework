using System;


namespace HW1Variables
{
    public  class Variables
    {
        public  void Task1()
        {
            Console.WriteLine("Variables 1");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double result = CountNumbers(a, b);
            Console.WriteLine(result);
        }

        public  void Task2()
        {
            Console.WriteLine("Variables 2");
            string stringOne = GetStringFromUser("Введите первую строку");
            string stringTwo = GetStringFromUser("Введите вторую строку");
            string result = ReverseStrings(stringOne, stringTwo);
            Console.WriteLine($"Результат: {result}");



        }
        public  void Task3()
        {
            Console.WriteLine("Variables 3");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double result = DivideNumberswithoutRemainder(a, b);
            double result1 = DivideNumberswithRemainder(a, b);
            Console.WriteLine($"Результат третьей задачи: {result}, {result1}");
        }
        public  void Task4()
        {
            Console.WriteLine("Variables 4");
            double a = GetNumberFromUser("Введите число a");
            double b = GetNumberFromUser("Введите число b");
            double c = GetNumberFromUser("Введите число c");
            double x = DoLinearEquation(a, b, c);
            Console.WriteLine($"Результат:{x}");
        }
        public  void Task5()
        {
            Console.WriteLine("Variables 5");
            double x1 = GetNumberFromUser("Введите число x1");
            double x2 = GetNumberFromUser("Введите число x2");
            double y1 = GetNumberFromUser("Введите число y1");
            double y2 = GetNumberFromUser("Введите число y2");
            double A = FindCoefficienEquation(x1, x2, y1, y2);
            double B = FindFreeMember(y2, A, x2);
            Console.WriteLine($"Y = {A}*X + {B} ");

        }

        public  double FindCoefficienEquation(double x1, double x2, double y1, double y2)
        {
            double A = (y2 - y1) / (x2 - x1);
            return A;
        }
        public  double FindFreeMember(double y2, double A, double x2)
        {
            double B = (y2 - (A * x2));
            return B;
        }
        public  double DivideNumberswithoutRemainder(double a, double b)
        {
            double result = a / b;
            return result;

        }
        public  double DivideNumberswithRemainder(double a, double b)
        {
            double result1 = a % b;
            return result1;

        }

        public  double CountNumbers(double a, double b)
        {
            double result = (5 * a + Math.Pow(b, 2)) / (b - a);
            return result;
        }
        public  string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            string stringOne = Console.ReadLine();
            return stringOne;
        }
        public  double GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;
        }
        public  double DoLinearEquation(double a, double b, double c)
        {
            double x = (c - b) / a;
            return x;
        }

        public  void ActionsWithStrings(string stringOne, string stringTwo)
        {
            string tmp = stringTwo;
            stringTwo = stringOne;
            stringOne = tmp;

        }
        public  string ReverseStrings(string stringOne, string stringTwo)
        {
            string result = stringTwo + stringOne;
            return result;
        }
    }
}
