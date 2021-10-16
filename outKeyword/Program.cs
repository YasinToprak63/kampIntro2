using System;

namespace outKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 15;

            var result2 = Add(out number1, number2);

            Console.WriteLine(result2);

        }

        static int Add(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
    
}
