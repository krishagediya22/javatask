//static nested:outer class
class outerclass
{
	static int outer_x=10;
	int outer_y=20;
	private static int outer_private=30;
	static class StaticNestedClass
	{
		void display()
		{
			System.out.println("outer_x="+outer_x);
			System.out.println("outer_private="+outer_private);

			outerclass out=new outerclass();
			System.out.println("outer_y="+out.outer_y);
		}
	}
}
public class C1
{
	public static void main(String[]args)
	{
		outerclass.StaticNestedClass nestedobject=
		new outerclass.StaticNestedClass();
		nestedobject.display();
	}
}