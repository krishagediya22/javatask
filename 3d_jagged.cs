using System;
class demo
{
	static void Main()
	{
		int [][][]a=new int [3][][];
		
		a[0]=new int [3][];
		a[1]=new int [2][];
		a[2]=new int [4][];
		
		a[0][0]=new int [3];
		a[0][1]=new int [2];
		a[0][2]=new int [3];
		
		a[1][0]=new int [4];
		a[1][1]=new int [1];
		
		a[2][0]=new int [3];
		a[2][1]=new int [2];
		a[2][2]=new int [3];
		a[2][3]=new int [3];
		
		/*a[0][0][0]=22;
		a[0][0][1]=12;
		a[0][0][2]=2;
		a[0][1][0]=4;
		a[0][1][1]=34;
		a[0][2][0]=5;
		a[0][2][1]=3;
		a[0][2][2]=6;
		a[0][2][3]=3;*/
		
		
		Console.WriteLine("daimenton size="+a.Length);
		Console.WriteLine("daimenton size="+a.GetLength(0));
		Console.WriteLine();
		
		Console.WriteLine("row size a[0]="+a[0].Length);
		Console.WriteLine("row size a[1]="+a[1].Length);
		Console.WriteLine("row size a[2]="+a[2].Length);
				Console.WriteLine();

		Console.WriteLine("colom a[0][0] size="+a[0][0].Length);
		Console.WriteLine("colom a[1][1] size="+a[1][1].Length);
		Console.WriteLine("colom a[2][3] size="+a[2][3].Length);
				Console.WriteLine();

		Console.WriteLine(a[0][0][0]);
		
		for (int i=0; i<a.Length; i++)
        {
            for (int j=0; j<a[i].Length; j++)
            {
				for (int k=0; k<a[i][j].Length; k++)
                {	
					a[i][j][k]=Convert.ToInt32(Console.ReadLine());
				
				}
		  }
        }
		for(int i=0;i<a.Length;i++)
		{
				for (int j=0;j<a[i].Length;j++)
				{ 
					for (int k=0;k<a[i][j].Length;k++)
					{
					Console.WriteLine(/*"["+i+"]"+"["j+"]"+"["k+"]="+*/a[i][j][k]);
					}
				}
				Console.WriteLine();
		
		} 
	}
}