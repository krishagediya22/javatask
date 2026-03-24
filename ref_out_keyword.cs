//ref , out keyword

using System;
class demo
{
	static void Main()
	{
	abc a=new abc();
	int x=20,y;
	Console.WriteLine("before value of x:"+x);
	a.m1(ref x,out y);
	
	Console.WriteLine("after value of x:"+x+y);
	Console.ReadLine();
	}
}
class abc
{
	
	public void m1(ref int a,out int b)
	{
		Console.WriteLine("before value of x:"+a);
		a+=10;
		b=50;
		Console.WriteLine("after value of x:"+a+b);
	}
}