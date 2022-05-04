using System;
class Identification
{
public static void Main(string[] args)
{
	int age;
	age=Convert.ToInt32(Console.ReadLine());
string country;
country=Convert.ToString(Console.ReadLine());
if(country=="India")
  if(age>=18)
	System.Console.WriteLine("valid for voting");
else
	System.Console.WriteLine("age is not valid for voting");
else
	System.Console.WriteLine("not indian citizen so do not vote");

}
}