using System;

namespace sumnumberss
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            
            number1 = int.Parse(Console.ReadLine());
            number2=int.Parse(Console.ReadLine());
            int sum = number1 + number2;


            Console.WriteLine(sum);
        }
    }
}
