class Calaulator
{
public static void Main(string[] args)
{
	int number1=20;
	int number2=10;
	char number3='+';
	int result=0;
	if(number3=='+')
	{
		result=number1+number2;
		System.Console.WriteLine("result is:"+number1+"+"+number2+"="+result);
	}
	else if(number3=='-')
	{
		result=number1-number2;
		System.Console.WriteLine("result is:"+number1+"-"+number2+"="+result);
	}
	else if(number3=='/')
	{
		result=number1/number2;
		System.Console.WriteLine("result is:"+number1+"/"+number2+"="+result);
	}
    else if(number3=='%')
	{
		result=number1%number2;
		System.Console.WriteLine("result is:"+number1+"%"+number2+"="+result);
	}
	else if(number3=='*')
	{
		result=number1*number2;
		System.Console.WriteLine("reulst is:"+number1+"*"+number2+"="+result);
	}
	else
		System.Console.WriteLine("invalid input");
	
	}
}