class Countinue
{
	public static void Main(string[] args)
	{
		int i;
		for(i=0;i<=20;i++)
		{
			if(i%2==1)
				continue;
				System.Console.WriteLine(i);
		}
	}
}