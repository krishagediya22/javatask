//parent class 
using System;
class demo
{
	static void Main()
	{
		xyz ch = new xyz(); //child class
		abc pr = new abc(); //child class
		
		ch.a=10;
		ch.disp();
		pr.disp();
        Console.ReadLine();

	}
}
public class abc //parent class
{
	public int a;
	public void disp()
    {
        Console.WriteLine("this is display"+a);
    }
}
public class xyz : abc
{
	
}
