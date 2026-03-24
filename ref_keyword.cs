//ref keyword

using System;
class demo
{
	static void Main()
	{
	abc a=new abc();
	int x=20;
	Console.WriteLine("before value of x:"+x);
	a.m1(ref x);
	
	Console.WriteLine("after value of x:"+x);
	Console.ReadLine();
	}
}
class abc
{
	
	public void m1(ref int a)
	{
		Console.WriteLine("before value of x:"+x);
		a+=10;
		Console.WriteLine("after value of x:"+x);
	}
}