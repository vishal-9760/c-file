using System;
class Method_2dmatrix_table
{
	static void Add(int [,]a)
	{
		int i=0;
		int j=0;
		int row=4;
		int col=4;
		for(i=0;i<row;i++)
		{
			
			for(j=0;j<col;j++)
			{
				Console.Write("[{0}] [{1}]"+"=",i,j);
				a[i,j]=int.Parse(Console.ReadLine());
			}
		}
		for(i=0;i<row;i++)
		{
			for(j=0;j<col;j++)
			{
				Console.Write(a[i,j]+" ");
				
			}
			Console.WriteLine();
		}
		
		
	}
	public static void Main(string []args)
	{
		int row=4,col=4;
		int [,]arr=new int[row,col];
			Console.Write(Add(arr));
		
		
	}
}