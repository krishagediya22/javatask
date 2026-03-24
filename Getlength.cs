// 12...using GetLength()
using System;
class demo
{
	static void Main()
	{	
		int [,]a=new [2,3];
		a[0,0]=6;
		a[0,1]=16;
		a[0,2]=61;
		a[1,0]=23;
		a[1,1]=5;
		a[1,2]=8;


		for(int i=0;i<a.GetLength(0);i++)
		{
				for(int j=0;j<a.GetLength(1);j++)
				{ 
					Console.WriteLine("["+i+","+j+"]="+a[i,j]);
					//Console.WriteLine(a[i,j]);
					
				}
		
		} 
	}