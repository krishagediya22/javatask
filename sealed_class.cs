//sealed class   hairarchical inheritance
using System;

class demo
{
    static void Main()
    {
		 pqr p = new pqr();
        xyz x = new xyz();//child class
        
		p.method1();
		p.method2();
		x.method3();
		x.method1();
		
        Console.ReadLine();
    }
}

public class abc 
{
   
	public void method1()
    {
        Console.WriteLine("hi abc");
    }
}
public sealed class pqr : abc 
{
	public void method2()
	{
		Console.WriteLine("hello [qr");
		
	}
}
public class xyz : abc 
{
	public void method3()
	{
		Console.WriteLine(" hello xyz");

	}
}