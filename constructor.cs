using System;
class program
{
	
	static void Main()
	{
		Console.WriteLine("constructor calling 1");
		demo obj =new demo(10);
		Console.WriteLine("constructor calling 2");
		demo obj1 =new demo(30);
		demo obj2=new demo(obj,obj1);
		Console.WriteLine("show method calling to perform sum:");
		obj2.show(obj,obj1,obj2);
	}
}
class demo
{
	int x;
	public demo (int a)
	{
		x=a;
		Console.WriteLine("value of x:"+x);
	}
	public demo(demo o,demo o1)
	{
		x=o.x+o1.x;
		
	}
	public void show(demo o,demo o1,demo o2)
	{
		Console.WriteLine("sum of "+o.x+"+"+o1.x+"="+o2.x);
	}
}