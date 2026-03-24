class A2
{
	A2()
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
class C extends B
{
	C()
	{
		System.out.println("class c's constructor is invoked");	
	}

}
class Driver
{
	public static void main(String[]args)
	{
		C obj=new C();
	}
} 