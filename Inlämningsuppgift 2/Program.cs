using System;
using System.Security.Cryptography.X509Certificates;

namespace Inlämningsuppgift_2
{
  class Program
  {
    public static void Main(string[] args)
    {
      string calculator_visual = @"
_____________________
[    [           ]  ]
|    -------------  |
|    [1][2][3] [/]  |
|    [4][5][6] [*]  |
|    [7][8][9] [-]  | 
|       [0]    [+]  |
[___________________]
";
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
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 4) //2
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 4) //3
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 4) // /
          {
            Console.Beep();
           
          }
          else if (Console.CursorLeft == 6 && Console.CursorTop == 5) //4
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 5) // 5
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 5) //6
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 5) // *
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 6 && Console.CursorTop == 6) // 7
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 6) // 8
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 12 && Console.CursorTop == 6) // 9
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 6) // -
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 9 && Console.CursorTop == 7) // 0
          {
            Console.Beep();
          }
          else if (Console.CursorLeft == 16 && Console.CursorTop == 7) // +
          {
            Console.Beep();
            //Console.Write("+", Console.CursorLeft == 7 && Console.CursorTop == 3);
            //Console.Write(calculator_visual);
            //Console.SetCursorPosition(0, 0);

            //while (true)
            //{
            //  int oldCursor_left = Console.CursorLeft;
            //  int oldCursor_top = Console.CursorTop;

            //  var keyInfo = Console.ReadKey();

            //  Console.SetCursorPosition(7, 3);
            //  Console.Write(calculator_visual);

            //  Console.SetCursorPosition(old_cursor_left, old_cursor_top);
           }

         }


       }

        // lista och loops för att slippa console cursors if satser!! While loopar säger simon, fixa
        //söndag sen skicka in på github!
        // använd av funktion nedan för att göra miniräknaren
        //while loop för dem fyra räknesätten, bool,


      }
      public double Addition(double a, double b)
      {
       double sum = a + b;
       return sum;
      }
      public double Subtraction(double a, double b)
      {
       double sum = a - b;
       return sum;
      }
      public double Multiplication(double a, double b)
      {
       double sum = a * b;
       return sum;
      }
      public double Division(double a, double b)
      {
       double sum = a / b;
       return sum;
      }
    }
  }

    

