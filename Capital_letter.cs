using System;
class Capital_letter
{
	public static void Main(string [] args)
	{
		char ch;
		ch=char.Parse(Console.ReadLine());
		if(ch>='a'&&ch<='z')
			Console.Write("small alphabet"+" "+ch);
		else if(ch>='A'&&ch<='Z')
			Console.Write("capital alphabet"+" "+ch);
            else
				Console.Write("invalid ");
	}
}