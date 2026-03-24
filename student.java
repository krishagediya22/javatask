class student
{
	String name="vinshu";
	int age=21;
	
	public String toString()
	{
		return "student{name='"+name+"',age="+age+"}";
	}
	public static void main(String[]args)
	{
		student s=new student();
		
		System.out.println(s.toString());
	}
}
	
