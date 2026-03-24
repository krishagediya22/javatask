//sealed method   method overriding
using System;

class demo
{
    static void Main()
    {
		 pqr p = new pqr();
        xyz x = new xyz();//child class
        
		p.method();
		
		x.method1();
		
        Console.ReadLine();
    }
}

public class abc 
{
   
	public virtual void method()
    {
        Console.WriteLine("hi abc");
    }
}
public class pqr : abc 
{
	public sealed override void method()
	{
		Console.WriteLine("hello pqr");
		
	}
}
public class xyz : abc 
{
	public void method1()
	{
		Console.WriteLine(" hello xyz");

	}
}