using System;
class Nestedloop
{
	public static void Main(string []args)
	{
	char i='a';
	
	while(i<'f')
	{
		 char j='a';
		while(j<'f')
		{
			Console.Write(j);
			j++;
		}
		Console.WriteLine();
		i++;
	}
	}
}
    