// 11....2 d array from get user row and colom sizw.and element                   
using System;
class demo
{
	static void Main()
	{	
		int sum=0;
		Console.WriteLine("enter row size:");
		int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter colom size:");
		int c=Convert.ToInt32(Console.ReadLine());
		int [,] a=new int[r,c];
		
		Console.WriteLine("total number of element :"+a.Length);
		Console.WriteLine("row size :"+a.GetLength(0));
		Console.WriteLine("colom size :"+a.GetLength(1));
	
		Console.WriteLine("Enter elements of 2D array:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
				a[i,j] =Convert.ToInt32(Console.ReadLine());
				//sum=i+j;
               
		  }
        }
		for(int i=0;i<a.GetLength(0);i++)
		{
				for(int j=0;j<a.GetLength(1);j++)
				{ 
					Console.WriteLine("["+i+","+j+"]="+a[i,j]);
					//Console.WriteLine(a[i,j]);
					sum+=a[i,j];
				}
		
		} 
		Console.WriteLine("sum:"+sum);
		Console.ReadLine();
}
}