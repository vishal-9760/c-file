
using System;
class Leapyear
{
public static void Main(string[] args)
{
int a;
a=Convert.ToInt32(Console.ReadLine());
if(a%4==0)
     if(a%100==0)
		 if(a%400==0)
		System.Console.WriteLine("it is a leap year");
	else
		System.Console.WriteLine("not leapyear");
	else
		System.Console.WriteLine("not leapyear");
	else
		System.Console.WriteLine("not leapyear");
}
}