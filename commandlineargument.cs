using System;
class commandlineargument
{
	public static void Main(string []args)
	{
		int a,b,result;
		char op;
		a=int.Parse(args[0]);
		b=int.Parse(args[1]);
	    op=char.Parse(args[2]);
		result=0;
		if(op=='+')
			result=a+b;
		 if(op=='-')
			result=a-b;
		 if(op=='*')
			result=a*b;
		 if(op=='/')
			result=a/b;
		 if(op=='%')
			result=a%b;
		else 
			Console.Write("invalid operator");
		if(result!=-1)
			Console.Write("result is :"+result);
	}
}