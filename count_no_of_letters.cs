using System;
class count_no_of_letters
{
	public static void Main(string[]args)
	{	
	int upper=0,lower=0;
	int i=0;
		string n=Console.ReadLine();
		char []name=n.ToCharArray();
		while(i<name.Length)
		{
			if(name[i]>=65&&name[i]<=90)
				upper++;
			else if(name[i]>=97&&name[i]<=122)
				lower++;
			i++;
		}
		Console.WriteLine("{0} {1}",upper,lower);
	}
}