using System;

class Program
{
    static void Main()
    {
        int rows = 7;

        // Jagged array create
        int[][] arr = new int[rows][];

		for(int i = 0; i < rows; i++)
        {
			arr[i]=new int[5];
		}
        

		 for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
				if(j == 0 || i == 0 || i == rows/2 || i == rows-1)
				{
					arr[i][j]=1;
				}
				else
				{
					arr[i][j]=0;
				}
			}
		}
				
				
		for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
				if(arr[i][j]==1)
				{
					Console.Write("1 ");
				}
			else
			{
				Console.Write(" ");
			}
        }
			 Console.WriteLine();
        }
    }
}