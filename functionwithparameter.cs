//fnction with parameter with return value

using System;
class demo
{
	static void Main()
	{
	abc a=new abc();
	int x=20;
	int r=a.m1(x);
	Console.WriteLine("value of r:"+r);
	Console.WriteLine("value of x:"+x);
	Console.ReadLine();
	}
}
class abc
{
	
	public int m1(int a)
	{
		a+=10;
		return a;
	}
}