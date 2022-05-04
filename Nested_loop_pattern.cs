using System;
class Nested_loop_pattern
{
	public static void Main(string[]args)
	{
		int i,j;
		for(i=5;i>0;i--)
		{
			
			for(j=0;j<i;j++)
			{
				Console.Write(j);
				
			}
			Console.WriteLine();
		}
	}
}