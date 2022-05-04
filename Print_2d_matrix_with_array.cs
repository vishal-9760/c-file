using System;
class Print_2d_matrix_with_array
{
	public static void Main(string []args)
	{
		int row;
		Console.Write("enter the size of row:");
		row=int.Parse(Console.ReadLine());
		int col;
		Console.Write("enter the size of column:");
		col=int.Parse(Console.ReadLine());
		int [,]arr=new int[row,col];
		int i=0;
		while(i<row)
		{
			int j=0;
			while(j<col)
			{
				Console.Write("[{0}] [{1}]"+"=",i,j);
				arr[i,j]=int.Parse(Console.ReadLine());
				j++;
			}
			Console.WriteLine();
		i++;
		}
		i=0;
		while(i<row)
		{
			int j=0;
			while(j<col)
			{
				Console.Write(arr[i,j]+" ");
				j++;
			}
			Console.WriteLine();
			i++;
		}
	}
}