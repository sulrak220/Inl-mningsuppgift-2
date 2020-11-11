using System;

namespace Inlämningsuppgift_2
{
  class Program
  {
    public static void Main(string[] args)
    {
      int num1 = 0;
      int num2 = 0;
      char opera = ' ';
      bool IsNum1 = true;
    
      string calculator_visual = string.Format(@"
_____________________
    {0}   
|    -------------  |
|    [1][2][3] [/]  |
|    [4][5][6] [*]  |
|    [7][8][9] [-]  | 
|       [0][=] [+]  |
[___________________]
", num1);

      Console.Write(calculator_visual);
      Console.SetCursorPosition(0, 0);
      
      while (true)
      {
        int old_cursor_left = Console.CursorLeft;
        int old_cursor_top = Console.CursorTop;

        var key_info = Console.ReadKey();

        Console.SetCursorPosition(0, 0);
        Console.Write(calculator_visual);

        Console.SetCursorPosition(old_cursor_left, old_cursor_top);

        if (key_info.Key == ConsoleKey.RightArrow)
        {
          Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);
        }

        else if (key_info.Key == ConsoleKey.DownArrow)
        {
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
        }
        else if (key_info.Key == ConsoleKey.LeftArrow)
        {
          Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        else if (key_info.Key == ConsoleKey.UpArrow)
        {
          Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }
        if (key_info.Key == ConsoleKey.Enter)
        {
          if (Console.CursorLeft == 6 && Console.CursorTop == 4)  //1
          {
            Console.Beep();

            if (IsNum1) num1 = num1 * 10 + 1;
            else num2 = num2 * 10 + 1;
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 4) //2
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 2;
            else num2 = num2 * 10 + 2;
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 4) //3
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 3;
            else num2 = num2 * 10 + 3;
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 4) // /
          {
            Console.Beep();
            IsNum1 = false;
            opera = '/';
          }
          else if (Console.CursorLeft == 6 && Console.CursorTop == 5) //4
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 4;
            else num2 = num2 * 10 + 4;
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 5) // 5
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 5;
            else num2 = num2 * 10 + 5;
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 5) //6
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 6;
            else num2 = num2 * 10 + 6;
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 5) // *
          {
            Console.Beep();
            IsNum1 = false;
            opera = '*';
          }
          else if (Console.CursorLeft == 6 && Console.CursorTop == 6) // 7
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 7;
            else num2 = num2 * 10 + 7;
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 6) // 8
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 8;
            else num2 = num2 * 10 + 8;
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 6) // 9
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 9;
            else num2 = num2 * 10 + 9;
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 6) // -
          {
            Console.Beep();
            IsNum1 = false;
            opera = '-';
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 7) // 0
          {
            Console.Beep();
            if (IsNum1) num1 = num1 * 10 + 0;
            else num2 = num2 * 10 + 0;
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 7) // +
          {
            Console.Beep();
            IsNum1 = false;
            opera = '+';

          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 7) // =
          {
            if(IsNum1 == false)
            {
              int sum = 0;
              switch(opera)
              {
                case '+': 
                  sum = Addition(num1, num2);
                break;

                case '-':
                  sum = Subtraction(num1, num2);
                break;

                case '*':
                  sum = Multiplication(num1, num2);
                break;

                case '/':
                  sum = Division(num1, num2);
                break;
              }

              calculator_visual = string.Format(@"
                _____________________
                   {0} {1} {2} = {3}
                |    -------------  |
                |    [1][2][3] [/]  |
                |    [4][5][6] [*]  |
                |    [7][8][9] [-]  | 
                |       [0][=] [+]  |
                [___________________]
                ", num1, opera, num2, sum);
              Console.Clear();
              Console.Write(calculator_visual);
              Console.SetCursorPosition(0, 0);
              Console.ReadLine();
              num1 = 0;
              num2 = 0;
              IsNum1 = true;
            }
          }
          if (IsNum1)
          {
             calculator_visual = string.Format(@"
             _____________________
              {0}   
             |    -------------  |
             |    [1][2][3] [/]  |
             |    [4][5][6] [*]  |
             |    [7][8][9] [-]  | 
             |       [0][=] [+]  |
             [___________________]
             ", num1);
          }
          else
          {
            calculator_visual = string.Format(@"
              _____________________
                 {0} {1} {2} 
              |    -------------  |
              |    [1][2][3] [/]  |
              |    [4][5][6] [*]  |
              |    [7][8][9] [-]  | 
              |       [0][=] [+]  |
              [___________________]
              ", num1, opera, num2);
            }
         

        Console.Clear();
        Console.Write(calculator_visual);
        Console.SetCursorPosition(0, 0);
        }

       
      }
      
      

    }
      public static int Addition(int a, int b)
      {
        int sum = a + b;
        return sum;
      }
      public static int Subtraction(int a, int b)
      {
        int sum = a - b;
        return sum;
      }
      public static int Multiplication(int a, int b)
      {
        int sum = a * b;
        return sum;
      }
      public static int Division(int a, int b)
      {
        int sum = a / b;
        return sum;
      }
  }

}

    

