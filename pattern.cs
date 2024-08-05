using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            // Printing leading spaces
            for (int j = 0; j < n - i; j++)
            {
                Console.Write(" ");
            }

            // Printing stars
            for (int k = 0; k < (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Moveing to the next line
            Console.WriteLine();
        }
    }
}
