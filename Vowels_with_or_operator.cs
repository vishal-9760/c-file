using System;
class Vowels_with_or_operator
{
	public static void Main(string []args)
	{
		string name=Console.ReadLine();
		char []n =name.ToCharArray();
		int vowel=0;
		int con=0;
		for(int i=0;i<name.Length;i++)
		{
			if(n[i]=='a'||n[i]=='e'||n[i]=='i'||n[i]=='o'||n[i]=='u'||n[i]=='A'||n[i]=='E'||n[i]=='I'||n[i]=='O'||n[i]=='U')
			{
				vowel++;
			}
			else
				con++;
		}
		Console.WriteLine(vowel+"\n"+con);
	}
}
