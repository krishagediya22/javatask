interface A3
{
	void display();
	
}
class B implements A3
{
	public void display()
	{
		System.out.println("Interface method display");
	}
	void two()
	{
		System.out.println("B-two");
	}
}
class C extends B
{
	void three()
	{
		System.out.println("C-three");
	}
}
class D
{
	public static void main(String[]args)
	{
		B b = new B();
        b.two();
        b.display();
		C c = new C();
		c.three();
	}
}
