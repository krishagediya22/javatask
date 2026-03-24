using System;
class demo
{
	static void Main()
	{
	int [,] a=new int[3,4];
	a[0,0]=6;
	a[0,1]=61;
	a[0,2]=4;
	a[1,0]=43;
	a[1,1]=2;
	a[1,2]=1;
	Console.WriteLine("total number of element :"+a.Length);
	Console.WriteLine("row size :"+a.GetLength(0));
	Console.WriteLine("colom size :"+a.GetLength(1));
	for(int i=0;i<a.GetLength(0);i++)
	{
			for(int j=0;j<a.GetLength(1);j++)
			{
				Console.WriteLine(a[i,j]);
			}
		
	}
	
	Console.ReadLine();
}
}