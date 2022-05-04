using System;
class Jacked_array
{
	public static void Main(string []args)
	{
		int [][]arr=new int[3][];
		arr[0]=new int[3];
		arr[1]=new int[2];
		arr[2]=new int[4];
		
		arr[0][0]=101;
		arr[0][1]=901;
		arr[0][2]=501;
		
		arr[1][0]=121;
		arr[1][1]=181;
		
		arr[2][0]=981;
		arr[2][1]=151;
		arr[2][2]=251;
		arr[2][3]=801;
		
		for(int i=0;i<arr.Length;i++)
		{
			for(int j=0;j<arr[i].Length;j++)
			{
				Console.Write(" "+arr[i][j]);
			}
			Console.WriteLine();
		}
		
		
	}
}