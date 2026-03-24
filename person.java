class person
{
	private String name;
	public void Setname(String name)
	{
		this.name=name;
	}
	public String getname()
	{
		return name;
	}
	public class Main
	{
			public static void Main(String[] args)
			{
				person p=new person();
				p.Setname("allice");
				System.out.println(p.getname());
				
			}
		
	}
}

