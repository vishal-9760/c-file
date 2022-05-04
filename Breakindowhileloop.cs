class Breakindowhileloop
{
public static void Main(string[] args)
{
	int i;
	i=0;
	do
	{
		if(i==7)
			continue;
			System.Console.WriteLine(i);
		i++;
	}while(i<10);
}
}