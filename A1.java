class A1
{
	A1()
	{
		System.out.println("class a's constructor is invoked");	
	}
}
class B extends A
{
	B()
	{
		System.out.println("class b's constructor is invoked");	
	}
}
class Dr1
{
	public static void main(String[]args)
	{
		B obj=new B();
	}
} 