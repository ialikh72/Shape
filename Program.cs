using System;

class Program
{
    static void Main()
    {
        int n = 7;

        // Outer loop for rows
        for (int i = n; i >= 1; i--)
        {
            // Left alphabets
            for (int j = 0; j < i; j++)
                Console.Write((char)('A' + j) + " ");

            // Middle spaces
            for (int s = 1; s <= (n - i) * 4; s++)
                Console.Write(" ");

            // Right alphabets
            for (int j = i - 1; j >= 0; j--)
                Console.Write((char)('A' + j) + " ");

            Console.WriteLine();
        }
    }
}

