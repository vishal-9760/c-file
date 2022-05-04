using System;
class Capital_word_to_small
{
	public static void Main(string []args)
	{
		string num=Console.ReadLine();
		char []ch=num.ToCharArray();
		//ch=char.Parse(Console.ReadLine());
		for(int i=0;i<ch.Length;i++)
		{
		if(ch[i]>='A'&&ch[i]<='Z')
			ch[i]=(char)(ch[i]+32);
		else if(ch[i]>='a'&&ch[i]<='z')
			ch[i]=(char)(ch[i]-32);
		}	
		for(int i=0;i<ch.Length;i++)
		{
			Console.Write(ch[i]);
		}
	}
}
    