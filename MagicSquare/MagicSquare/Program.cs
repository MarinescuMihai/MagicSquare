using System;

namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set the number of columns for EVEN SQUARE: ");
            int n = int.Parse(Console.ReadLine());
            EvenSquare.generateSquare(n);

            Console.WriteLine("Set the number of columns for ODD SQUARE: ");
            n = int.Parse(Console.ReadLine());
            OddSquare.generateSquare(n);
        }
    }
}
