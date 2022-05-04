using System;
	class Switch1
{
public static void Main(string[] args)
{
int a;
System.Console.WriteLine("Enter the first number");
a=Convert.ToInt32(Console.ReadLine());
char choice;
System.Console.WriteLine("Enter operator");
choice=Convert.ToChar(Console.ReadLine());
int b;
System.Console.WriteLine("Enter the second number");
b=Convert.ToInt32(Console.ReadLine());
int result=0;
switch(choice)
{
case '+': result=a+b;
break;
case '-': result =a-b;
break;
case '/': result=a/b;
break;
case '%': result=a%b;
break;
case '*': result=a*b;
break;
default :
System.Console.WriteLine("inavlid input");
break;
}
if(result!=0)
System.Console.WriteLine("result is :"+result);
}
}