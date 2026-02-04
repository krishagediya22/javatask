// 15... tabular format 3d array get from the user size and element
using System;
class demo
{
	static void Main()
	{	
		Console.WriteLine("enter daimention size:");
		int d=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("enter row size:");
		int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter colom size:");
		int c=Convert.ToInt32(Console.ReadLine());
		int [,,] a=new int[d,r,c];
		
		
	
		Console.WriteLine("Enter elements of 3D array:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
				for (int k=0;k<a.GetLength(2);k++)
				{
					a[i,j,k] =Convert.ToInt32(Console.ReadLine());
				
				}
		  }
        }
		for(int i=0;i<a.GetLength(0);i++)
		{
				for(int j=0;j<a.GetLength(1);j++)
				{ 
					for (int k=0;k<a.GetLength(2);k++)
					{
						Console.Write("["+i+","+j+","+k+"]="+a[i,j,k]+"\t");
					}
						Console.WriteLine();
				}
		} 
		
		Console.ReadLine();
}
}