/*using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 22, 2, 33 },
            { 2, 6, 0 }   // extra element, use nathi thavanu
        };

        int rows = 2;
        int[] cols = { 3, 2 }; // row-wise actual size

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols[i]; j++)
            {
                Console.Write(" [{i},{j}] ="+arr[i,j]);
            }
            Console.WriteLine();
        }
    }
}*/
using System;

class Program
{
    static void Main()
    {
        int rows, cols, sum = 0;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        // Input elements
        Console.WriteLine("\nEnter elements of 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("arr[{i},{j}] = ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i, j];
            }
        }

        // Print in tabular format with index
        Console.WriteLine("\n2D Array (Index + Value):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("["+i+","+j+"]="+arr[i, j]+"\t");
				//Console.WriteLine("["+i+","+j+"]="+a[i,j]);
            }
            Console.WriteLine();
        }

        // Print sum
        Console.WriteLine("\nSum of all elements = " + sum);
    }
}
