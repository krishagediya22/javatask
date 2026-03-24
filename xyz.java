//deep cloning
class xyz
{
	int x;
	int y;
	public String ToString()	
	{
		return "xyz x=="+x+"xyz y=="+y;
	}
	}
class cloning
{
	public static void main(String[]args)
	{
		xyz x=new xyz();
		x.y=5;
		x.y=6;
		xyz x1=new xyz();
		x1.x=x.x;
		x1.y=x.y;
		System.out.println(x);
		System.out.println(x1);
	}
	
}
