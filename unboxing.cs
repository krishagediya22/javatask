using System;
class demo
{
	static void Main(string [] args)
	{
		int a;
		object b=10;//unboxing
		a=(int)b;
	    Console.WriteLine(a);
		Console.WriteLine(b);
		Console.ReadLine();
	}
}
