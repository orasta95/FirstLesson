using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = AddingBirthDate(16, 6, 1995);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        #region VoidMethod
        
        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static void SayWelcome()
        {
            Console.WriteLine("You are Welcome!");
        }

        static void AddTwoNumbers()
        {
            int a = 16 + 43;
            Console.WriteLine(a);
        }

        static void MultiplyTwoNumbers()
        {
            int a = 1423;
            int b = 5674;
            int c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
        }

        static void AddTwoNumbers(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        static void DivideNumber(int firstNumber, int secondNumber)
        {
            int divided = firstNumber / secondNumber;
            Console.WriteLine(divided);
        }

        #endregion

        static int AddThreeNumbers(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        } 

        static string AddingBirthDate(int day, int month, int year)
        {
            return $"Your Birthday is in {day}.{month}.{year}";            
        }
    }
}