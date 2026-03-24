//abstract class
abstract class Book1
{
	public abstract void page();
	
}
	public class s extends Book1
{
	public void page()
	{
		System.out.println("old");
		
	}
	public static void main(String args[])
	{
		Book1 obj=new s();
		obj.page();
	}
}