using System;
class Small_to_capital_with_string
{
	public static void Main(string[]args)
	{
		Console.Write("enter the name :"+" ");
		string name=Console.ReadLine();
		for(int i=0;i<name.Length;i++)
		{
		if(name[i]>=97&&name[i]<122)
		{
			Console.Write((char)(name-32));
		}
		}
	}
}