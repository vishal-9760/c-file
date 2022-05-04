using System;
class Sum_of_row_and_column
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
		
		for(i=0;i<row;i++)
		{
			sum=0;
			for(j=0;j<col;j++)
			{
				sum=arr[i,j]+sum;
			}
			Console.Write(" the sum of row "+i+"=");
			Console.WriteLine(sum);
		}
		
		for(i=0;i<row;i++)
		{
			sum=0;
		  	for(j=0;j<col;j++)
			{
				sum=arr[j,i]+sum;
			}
			Console.Write("sum of column"+j+"=");
			Console.WriteLine(sum);
		}
	}
}