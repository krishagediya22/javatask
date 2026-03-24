//string class
class Main
{
	public static void main(String[] args)
	{
		String myst="hello";
		char result=myst.charAt(0);
		System.out.println(result);
			String firstName="johan";
			String lastName="doe";
		System.out.println(firstName.concat(lastName));
		String mystr1="hello";
		String mystr2="hello";
		String mystr3="Another String";
		System.out.println(mystr1.equals(mystr2));
		System.out.println(mystr1.equals(mystr3));
		
		String mystr="hello";
		
		System.out.println(mystr.contains("hel"));
		System.out.println(mystr.contains("e"));
		System.out.println(mystr.contains("hi"));
			String mystr4="hello";	
		System.out.println(mystr4.endsWith("hel"));
		System.out.println(mystr4.endsWith("llo"));
		System.out.println(mystr4.endsWith("o"));
		
		
	}
}