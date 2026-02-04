// 17...2d_jagged array from get user
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int r =  Convert.ToInt32(Console.ReadLine());

        // Declare jagged array
        int[][] arr = new int[r][];

        // Taking input
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter number of columns for row {"+i+"}: ");
            int c =  Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[c];
		}
		for (int i = 0; i < arr.Length; i++)
		{

            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write("Enter value for ["+i+"]["+j+"]: ");
                arr[i][j] =  Convert.ToInt32(Console.ReadLine());
            }
        }

        // Printing output
        Console.WriteLine("\nJagged Array Values:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.WriteLine("["+i+"]["+j+"]: "+arr[i][j]);
            }
         
        }
    }
}
