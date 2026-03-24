//jagged array index value print 
using System;
class demo
{
	static void Main()
	{	
		int [][]j_array=new int [4][];
		j_array[0]=new int [5];
		j_array[1]=new int [2];
		j_array[2]=new int [7];
		j_array[3]=new int [1];
		
		//initialization value of array
		
		j_array[0][0]=6;
		j_array[0][1]=23;
		j_array[1][1]=67;
		j_array[3][0]=16;
		j_array[2][4]=10;

		
		Console.WriteLine("j_array[3][0]=="+j_array[3][0]);
		
        /*for (int i=0;i<a.GetLength(0);i++)
        {
            for (int j=0;j<a.GetLength(1);j++)
            {
				a[i,j] =Convert.ToInt32(Console.ReadLine());
               
		  }
        }
		for(int i=0;i<a.GetLength(0);i++)
		{
				for(int j=0;j<a.GetLength(1);j++)
				{ 
					Console.WriteLine("["+i+","+j+"]="+a[i,j]);
					//Console.WriteLine(a[i,j]);
					
				}
		
		} */
		Console.ReadLine();
}
}