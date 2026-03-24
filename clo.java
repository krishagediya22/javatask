//object cloning
class abc implements Cloneable
{
	int x,y;
	
	public Object clone ()throws CloneNotSupportedException
	{
			return super.clone();	
	}
}
public class clo
{
		public static void main(String[]args)
		throws CloneNotSupportedException
		{
			abc o1=new abc();
			o1.x=200;
			o1.y=900;
			abc o2=(abc) o1.clone();
			o2.x=800;
			System.out.println("o1:"+o1.x+" "+o1.y);
			System.out.println("o2:"+o2.x+" "+o2.y);
		}
	
}