using System;
class Sum_of_row_and_column_diagonaly_2
{
	public static void Main(string[]args)
	{
		int row ;
		Console.WriteLine("ENter The Size Of Row :");
		row=int.Parse(Console.ReadLine());
		int col;
		Console.WriteLine("Enter The Size Of Coloumn :");
		col=int.Parse(Console.ReadLine());
		int [,]arr=new int[row,col];
		int i=0;
		int j=0;
		int sum=0;
		int n=col;
		for(i=0;i<row;i++)
		{
			for(j=0;j<col;j++)
			{
				Console.Write("[{0}] [{1}]"+" =",i,j);
				arr[i,j]=int.Parse(Console.ReadLine());
			}
		}
		
		for(i=0;i<row;i++)
		{
			for(j=0;j<col;j++)
			{
				
				Console.Write(arr[i,j]+"  ");
			}
			Console.WriteLine();
		}
		
		sum=0;
		for(i=0;i<row;i++)
		{
			for(j=0;j<col;j++)
			{
				if ((i+j)==(row-1))
				{
					sum=sum+arr[i,j];
				}
			}
		}
		Console.Write(" sum of diagnal is"+"=");
			Console.WriteLine(sum);
		
	}
}





