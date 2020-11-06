using System;
using System.ComponentModel.Design.Serialization;

namespace Calculator2
{
    class Calculator
    {
        public static int Main(string[] args)
        {
            public static int Addition(int a, int b)
            {
                int number1 = a;
                int number2 = b;
                int answer = a + b;
                return answer;
            }
            public static int Substraction(int a, int b)
            {
                int number1 = a;
                int number2 = b;
                int answer = a - b;
                return answer;
            }
            public static int Multiplication(int a, int b)
            {
                int number1 = a;
                int number2 = b;
                int answer = a * b;
                return answer;
            }
            public static int Division(int a, int b)
            {
                int number1 = a;
                int number2 = b;
                int answer = a / b;
                return answer;
            }
        }
    }
}
