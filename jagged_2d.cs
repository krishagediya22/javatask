// 16...jagged array using GetLength()
using System;
class demo
{
	static void Main()
	{	
		int [,]a=new [3][];
		
		a[0]=new int []{1,2,3};
		a[1]=new int []{4,5};
		a[2]=new int []{6,7,8,9};
		


		for(int i=0;i<a.Length;i++)
		{
				for(int j=0;j<a[i].Length;j++)
				{ 
					Console.WriteLine("["+i+"]["+j+"]="+a[i][j]);
					
				}
		
		} 
	}