using System;
class text
{
	static void Main()
	{
		Console.WriteLine("enter the number of element:");
		int Size = Convert.ToInt32(Console.ReadLine());
		int [] numbers= new int[Size];
		for(int i=0;i<Size;i++)
		{
			Console.WriteLine("entr element{i+1}:");
			numbers[i]=Convert.ToInt32(Console.ReadLine());
			
		}
		Console.WriteLine("/nelement in the array");
		for(int i=0;i<Size;i++)
		{
			Console.WriteLine(numbers[i]);
			
		}
	}
}