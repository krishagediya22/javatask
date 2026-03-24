//duplicate value...
using System;
class demo
{
	static void Main()
	{	
		
		Console.WriteLine("enter row size:");
		int r=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter colom size:");
		int c=Convert.ToInt32(Console.ReadLine());
		int [,] a=new int[r,c];
		
		
		Console.WriteLine("Enter elements of 2D array:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
				a[i,j] =Convert.ToInt32(Console.ReadLine());
				
               
		  }
        }
		Console.WriteLine("tabular format:");
        for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
					Console.Write(arr[i, j]+"/t");
			}
				Console.WriteLine();
		
		} 
		Console.WriteLine("duplicate value:");
		
		bool found = false;
		for(int i=0; i<a.GetLength(0); i++)
		{
			for (int j=0;j<a.GetLength(1);j++)
			{
				
				bool alreadyCounted = false;
				 for (int x=0;x<a.GetLength(0);x++)
				 {
					for (int y=0;y<a.GetLength(1);y++)
					{
						if(x ==i && y==j)
						goto CHECK_COUNT;
					
						if (arr[x,y] ==arr[i,j])
						{
								alreadyCounted = true;
								goto CHECK_COUNT;


						}
					}
				 }	
				 CHECK_COUNT;
				 if(alreadyCounted)
					 continue;
				 
				 int count = 0;
				  for (int x=0;x<a.GetLength(0);x++)
				 {
					for (int y=0;y<a.GetLength(1);y++)
					{
						if (arr[x,y] ==arr[i,j])
							count++;
					}
				 }
					if(count>1)
					{
						Console.WriteLine(arr[i,j]+"appears"+count+"times");
						found=true;
					}
			}
		}
		if(!found)
		{
			Console.WriteLine("no duplicate value found:");
		}
		}
}