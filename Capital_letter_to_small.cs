using System;
class Capital_letter_to_small
{
	public static void Main(string []args)
	{
		int num=0;
		char ch='0';
		ch=char.Parse(Console.ReadLine());
		if(ch>=97&&ch<=122)
			num=ch-32;
			Console.Write((char)num);
	}
}
    