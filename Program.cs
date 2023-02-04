using System;
 
namespace factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int chisloN = int.Parse(Console.ReadLine());
            int i = 1;
            double factorial = 1;
            while ( i <= chisloN)
            {
                factorial = factorial * i;
                i = i + 1;
            }
            Console.WriteLine("Факториал числа " + chisloN + " равен " + factorial);
        }
    }
}
