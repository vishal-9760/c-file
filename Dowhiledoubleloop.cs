class Dowhiledoubleloop
{
public static void Main(string[] args)
{
int i;
int j;
i=0;
do
{
	j=0;
	do
	{
		System.Console.Write("A");
		j++;
	}while(j<6);
	System.Console.WriteLine();
	i++;
}while(i<6);
}
}