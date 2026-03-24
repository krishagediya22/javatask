//18...3d jagged array from the user
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of Dimension (1st Dimension): ");
        int d = Convert.ToInt32(Console.ReadLine());

        int[][][] arr = new int[d][][];

        for (int i = 0; i <  arr.Length; i++)
        {
            Console.Write("\nEnter number of Rows for Block {i}: ");
            int r = Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[r][];

            for (int j = 0; j < r; j++)
            {
                Console.Write("Enter number of Columns for Block ["+i+"], Row ["+j+"]: ");
                int c = Convert.ToInt32(Console.ReadLine());

                arr[i][j] = new int[c];

                for (int k = 0; k < c; k++)
                {
                    Console.Write("Enter element ["+i+"]["+j+"]["+k+"]: ");
                    arr[i][j][k] =Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Display the 3D Jagged Array
        Console.WriteLine("\n--- 3D Jagged Array Output ---");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("\nBlock ["+i+"]:");
            for (int j = 0; j < arr[i].Length; j++)
            {
                for (int k = 0; k < arr[i][j].Length; k++)
                {
                    Console.Write(arr[i][j][k] );
                }
              
            }
        }
    }
}
