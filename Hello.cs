class Hello
{
public static void Main(string[] args)
{
	int number1=20;
	int number2=10;
	char number3='-';
	int result=0;
	if(number3=='+')
		result=number1+number2;
	else if(number3=='-')
		result=number1-number2;
	else if(number3=='/')
		result=number1/number2;
    else if(number3=='%')
		result=number1%number2;
	else if(number3=='*')
		result=number1*number2;
	else
	{
	System.Console.WriteLine("invalid input");
}
	    System.Console.WriteLine("result is:"+result);
	}
}