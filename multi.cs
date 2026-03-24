using System;
class demo
{
	static void Main()
	{
	int [,] a=new int[2,3];
	a[0,0]=6;
	a[0,1]=61;
	a[0,2]=4;
	a[1,0]=43;
	a[1,1]=2;
	a[1,2]=1;
	Console.WriteLine("with message "+a[0,0]+" "+a[0,1]);//with message write,as it is value
	Console.WriteLine(a[0,0]+a[0,1]);//sum
	Console.ReadLine();
	}
}