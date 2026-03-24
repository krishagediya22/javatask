// abstarct method
using System;

class demo
{
    static void Main()
    {
		//abc a=new abc();  //we can't create object of abc bcz it is abstarct
	 xyz x = new xyz();
	 x.fun();  //object of xyz and method of abc
	x.abs_method();
	 Console.ReadLine();
	 
	}
}

public abstract class abc    //it is always be paent class
{
	public abstract void abs_method();
	public  void fun()
	{
		Console.WriteLine("hi abc");
	}
}
public class xyz : abc
{
	public override void abs_method()
	{
		Console.WriteLine("hello abstarct");
	}
}