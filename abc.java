//shallow object clone
class abc
{
	int i;
	int j;
	public String ToString()
	{
		return"abc i=="+i+ "abc j=="+j;
	}
}
class clone
{
	public static void main(String[]args)
	{
		abc a=new abc();
		a.i=5;
		a.j=6;
		
		abc a1=0;
		a1.j=9;
		System.out.println(a);
		System.out.println(a1);
		
	}
}