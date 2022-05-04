using System;
class Table
{
public static void Main(string[] args)
{
int i=1;
int t;
System.Console.WriteLine("enter number");
t=Convert.ToInt32(Console.ReadLine());
int j;
System.Console.WriteLine("enter number");
j=Convert.ToInt32(Console.ReadLine());
while(i<=j)
{
	int c=t*i;
	System.Console.WriteLine(t+"*"+i+"="+c);
	i++;
}
}
}