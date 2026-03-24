//duplicate value...
using System;
class demo
{
	static void Main()
	{	
		
		Console.WriteLine("enter row size:");
		int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter colom size:");
		int c=Convert.ToInt32(Console.ReadLine());
		int [,] a=new int[r,c];
		
		
		Console.WriteLine("Enter elements of 2D array:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
				a[i,j] =Convert.ToInt32(Console.ReadLine());
				
               
		  }
        }
		Console.WriteLine("tabular format:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
					Console.Write(arr[i, j]+"/t);
			}
				Console.WriteLine();
		
		} 
		Console.WriteLine("duplicate value:");