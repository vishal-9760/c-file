using System;
class No_of_even_and_odd_with_array
{
	public static void Main(string []args)
	{
		int size;
		Console.Write("Enter The Size Of Array:"+"  ");
		size=int.Parse(Console.ReadLine());
		int []arr=new int[size];
		int i;
		int even=0,odd=0;
		for(i=0;i<size;i++)
		{
			Console.Write("enter the number"+" "+i+"=");
		   arr[i]=int.Parse(Console.ReadLine());
			if(arr[i]%2==0)
				even++;
			else
				odd++;
			
		}
		Console.WriteLine(" even number are:"+even);
		Console.Write(" even number are:"+odd);
		
		
		
	}
}
    