class Breakinloop
{
public static void Main(string[] args)
{
	int i;
	for(i=0;i<=10;i++)
	{
		if(i==8)
			break;
		System.Console.WriteLine(i);
	}
}
}