using System;
using System.Collections.Generic;
using System.Text;

namespace MagicSquare
{
    public static class EvenSquare
    {
        public static void generateSquare(int n)
        {
            int[,] magicSquare = new int[n, n];

            int i = n / 2;
            int j = n - 1;

            for (int num = 1; num <= n * n;)
            {
                if (i == -1 && j == n)
                {
                    j = n - 2;
                    i = 0;
                }
                else
                {
                    if (j == n)
                        j = 0;

                    if (i < 0)
                        i = n - 1;
                }

                if (magicSquare[i, j] != 0)
                {
                    j -= 2;
                    i++;
                    continue;
                }
                else
                    magicSquare[i, j] = num++;

                j++;
                i--;
            }

            Console.WriteLine("The Magic Square for " + n
                              + ":");
            Console.WriteLine("Sum of each row or column "
                              + n * (n * n + 1) / 2 + ":");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(magicSquare[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
