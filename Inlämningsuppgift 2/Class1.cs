using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämningsuppgift_2
{
    class Calculator
    {
        public static int Addition(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int sum = a + b;
            return sum;
        }
        public static int Substraction(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int sum = a - b;
            return sum;
        }
        public static int Multiplication(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int sum = a * b;
            return sum;
        }
        public static int Division(int a, int b)
        {
            int number1 = a;
            int number2 = b;
            int sum = a / b;
            return sum;
        }
    }
}
