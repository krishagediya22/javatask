//copy constructor
using System;

class demo
{
    static void Main()
    {
        xyz obj1 = new xyz(15);//15 is int type
		  //calling parameterised constructor
        xyz obj2 = new xyz(obj1);//obj1 is xyz type
		   //calling of copy constructor
		   
		obj1.show();
		obj2.show();
        Console.ReadLine();
    }
}

public class xyz
{
	int x;
	public xyz(int a)
	{
		x=a;
		Console.WriteLine("hello parameter");
		
	}
	public xyz(xyz temp)
	{
		Console.WriteLine("before copy"+x);
		x=temp.x;
		Console.WriteLine("after copy"+x);
	}
	public void show()
	{
		Console.WriteLine("value "+x);

	}
}
