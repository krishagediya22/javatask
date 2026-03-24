//public data member

using System;

class demo
{
    static void Main()
    {
        xyz obj1 = new xyz();
        xyz obj2 = new xyz();
		
		obj2.a=54;
		obj1.a=23;
		
		obj1.show();
		obj2.show();
        Console.ReadLine();
    }
}

public class xyz
{
    public int a; 
	public void show()
    {
        Console.WriteLine("this is show"+a);
    }
}
