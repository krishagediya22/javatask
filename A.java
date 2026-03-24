class A
{
	A()
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
class Dr
{
	public static void main(String[]args)
	{
		A obj=new A();
	}
} 