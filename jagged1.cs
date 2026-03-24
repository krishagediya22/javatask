//jagged array length
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
		
		Console.WriteLine("j_array row size use length function ="+j_array.Length);//row size
		Console.WriteLine("j_array row size use Getlength(0) function="+j_array.GetLength(0));//row size
		Console.WriteLine();
		Console.WriteLine(" sizeof j_array[0] ="+j_array[0].Length);//colom size of particular row of [0]
		Console.WriteLine(" sizeof j_array[1] ="+j_array[1].Length);//colom size of particular row of [1]
	
		Console.WriteLine();
		//colom size 
		for(int i=0;i<j_array.Length;i++)
				{ 
					Console.WriteLine("j_array colom size ="+j_array[i].Length);
				
					
				}
				
				Console.WriteLine();

				//element value print
				Console.WriteLine("j_array element value");
				for (int i=0;i<j_array.Length;i++)
				{
					for (int j=0;j<j_array[i].Length;j++)
					{
					//	Console.WriteLine("["+i"]"+"["+j+"]="+j_array[i][j]);   
					    Console.WriteLine("["+i+","+j+"]="+j_array[i][j]);						
					}
				}
	}
}	

