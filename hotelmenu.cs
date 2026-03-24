//20...Hotel menu..
using System;
class program
{
	static void Main()
	{
		int choice,quantity;
		int price=0;
		string itemname="";
		char ch;
		
		do
		{
			Console.WriteLine("----HOTEL MENU----");
			Console.WriteLine("1.abc price 10");
			Console.WriteLine("2.pqr price 22");
			Console.WriteLine("3.xyz price 33");
			Console.WriteLine("4.ghj price 19");
			Console.WriteLine("select item:");
			
			choice=Convert.ToInt32(Console.ReadLine());
			
			switch(choice)
			{
				case 1:
					itemname = "abc";
					price = 10;
					break;
					
					case 2:
					itemname = "pqr";
					price = 22;
					break;
					
					case 3:
					itemname = "xyz";
					price = 33;
					break;
					
					case 4:
					itemname = "ghj";
					price = 19;
					break;
					
					default:
						Console.WriteLine("invalid choice");
						break;
				
			}
			
			Console.Write("enter quantity:");
			quantity = Convert.ToInt32(Console.ReadLine());
			
			int total = price * quantity;
			
			Console.WriteLine();
			Console.WriteLine("your selected "+ itemname +" " + price);
			Console.WriteLine("quantity: "+ quantity);
			Console.WriteLine(itemname + " item total "+total);
			
			Console.Write("Do you want to continue(y/n):");
			ch = Convert.ToChar(Console.ReadLine());
			
			if (ch == 'n' || ch == 'N')
			{
				Console.WriteLine();
				Console.WriteLine("your final bill is "+total);
				break;
				
			}
			
			Console.WriteLine();
			}while 
			(ch == 'y' || ch == 'y');
	}
}