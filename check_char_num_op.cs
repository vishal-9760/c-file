using System;
class check_char_num_op
{
	public static void Main(string []args)
	{
		char ch;
		ch=char.Parse(Console.ReadLine());
		if(ch>='a'&&ch<='z' ||ch>='A'&&ch<='Z')
			Console.Write("alphabet");
		else  if(ch>=48&&ch<=57)
			Console.Write("digits");
		else
			Console.Write("operartor");
	}
}