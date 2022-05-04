using System;
class Print_2d_array
{
	public static void Main(string[]args)
	{	int [,]arr;
		arr=new int[3,4]; 
		arr[0,0]=10;
		arr[0,1]=60;
		arr[0,2]=40;
		arr[0,3]=20;
		
		arr[1,0]=34;
		arr[1,1]=54;
		arr[1,2]=67;
		arr[1,3]=78;
		
		arr[2,0]=17;
		arr[2,1]=16;
		arr[2,2]=12;
		arr[2,3]=11;
		
		Console.WriteLine(arr[0,0]);
		Console.WriteLine(arr[0,1]);
		Console.WriteLine(arr[0,2]);
		Console.WriteLine(arr[0,3]);
		
		Console.WriteLine(arr[1,0]);
		Console.WriteLine(arr[1,1]);
		Console.WriteLine(arr[1,2]);
		Console.WriteLine(arr[1,3]);
		
		Console.WriteLine(arr[2,0]);
		Console.WriteLine(arr[2,1]);
		Console.WriteLine(arr[2,2]);
		Console.WriteLine(arr[2,3]);
		
	}
}