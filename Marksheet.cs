using System;
class Marksheet
{
	public static void Main(string[]args)
	{
		string Name="";
		Console.WriteLine("Enter the student name :");
		Name=Console.ReadLine();
		int Rollno=0;
		Console.WriteLine("Enter the student rollno :");
		Rollno=int.Parse(Console.ReadLine());
		Console.WriteLine("*******************************************");
		Console.WriteLine("SUBJECT");
		int Physics=0;
		Console.WriteLine("Physics :");
		Physics=int.Parse(Console.ReadLine());
		int Chemistry=0;
		Console.WriteLine("Chemistry :");
		Chemistry=int.Parse(Console.ReadLine());
		int Math=0;
		Console.WriteLine("Math :");
		Math=int.Parse(Console.ReadLine());
		Console.WriteLine("*******************************************");
		Console.WriteLine("Student details");
		Console.WriteLine("Name:"+" "+Name);
		Console.WriteLine("Rollno:"+" "+Rollno);
		Console.WriteLine("Physics:"+" "+Physics);
		Console.WriteLine("Chemistry:"+" "+Chemistry);
		Console.WriteLine("Math:"+" "+Math);
		int Total=Physics+Chemistry+Math;
		Console.WriteLine("Total number :"+" "+Total);
		//int num=Total/300;
		double Percentage =(Total*100)/300;
		Console.WriteLine("Percentage :"+" "+Percentage);
		Console.WriteLine("********************END*********************");
		
		
		
	}
}