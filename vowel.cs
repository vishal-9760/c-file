using System;
class Vowel
{
	public static void Main(string []args)
	{
		char v;
		v=char.Parse(Console.ReadLine());
		switch(v)
		{
			case 'a':
			Console.Write("vowel");
			break;
			case 'e':
			Console.Write("vowel");
			break;
			case 'i':
			Console.Write("vowel");
			break;
			case 'o':
			Console.Write("vowel");
			break;
			case 'u':
			Console.Write("vowel");
			break;
			default:
			Console.Write("not vowel");
			break;
		}
	}
}