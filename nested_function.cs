//nesting of function calling
using System;

class demo
{
    static void Main()
    {
        xyz obj2 = new xyz();//child class
        
		
		
		
		obj2.show();
		obj2.show();
		
		obj2.disp();//parent method using child object

        Console.ReadLine();
    }
}

public class abc //parent class
{
   
	public void disp()
    {
        Console.WriteLine("this is display");
    }
}
public class xyz : abc  //child class
{
	public void show()
	{
		Console.WriteLine("this is show");
		hello();  //nesting of function calling
		disp();   //parent nesting
	}
	public void hello()
	{
		Console.WriteLine("this is hello");

	}
}