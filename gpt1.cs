using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of blocks (1st dimension): ");
        int d = Convert.ToInt32(Console.ReadLine());

        // Declare 3D jagged array
        int[][][] arr = new int[d][][];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("\nEnter number of rows in block ["+i+"]: ");
            int r = Convert.ToInt32(Console.ReadLine());

            arr[i] = new int[r][];
		

            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write("Enter number of columns in block ["+i+"["+j+"]: ");
                int c = Convert.ToInt32(Console.ReadLine());

                arr[i][j] = new int[c];
			

                for (int k = 0; k < arr[i][j].Length; k++)
                {
                    Console.Write("Enter value for ["+i+"]["+j+"]["+k+"]: ");
                    arr[i][j][k] = Convert.ToInt32(Console.ReadLine());
                }
			}
		
        }    
        

        // Print all values
        Console.WriteLine("\n3D Jagged Array Values:");
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                for (int k = 0; k < arr[i][j].Length; k++)
                {
                    Console.WriteLine(arr[i][j][k] );
                }
            }
        }
    }
}
