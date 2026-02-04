// 09....boxing and unboxing
using System;
class demo
{
	static void Main(string [] args)
	{
		int a=10;
		object b=a;//boxing
	    Console.WriteLine("boxing value="+b);
		//unboxing
		int obj=(int)b;
		Console.WriteLine("unboxing value="+obj);
		Console.ReadLine();
	}
}
