//duplicate value
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [" + i + "," + j + "]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nArray in tabular format:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nDuplicate values:");

        bool found = false;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                bool alreadyCounted = false;

                // Check if this value appeared earlier
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if (x == i && y == j)
                            goto CHECK_COUNT;

                        if (arr[x, y] == arr[i, j])
                        {
                            alreadyCounted = true;
                            goto CHECK_COUNT;
                        }
                    }
                }

            CHECK_COUNT:

                if (alreadyCounted)
                    continue;

                int count = 0;

                // Count occurrences
                for (int x = 0; x < rows; x++)
                {
                    for (int y = 0; y < cols; y++)
                    {
                        if (arr[x, y] == arr[i, j])
                            count++;
                    }
                }

                if (count > 1)
                {
                    Console.WriteLine(arr[i, j] + " count " + count + " times");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No duplicate values found.");
        }
    }
}
