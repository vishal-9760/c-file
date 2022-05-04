using System;
class Datatypevalue
{
	
	static int  a;
	static uint  b;
	static byte  c;
	static sbyte  d;
	static short e;
	static ushort f;
	static long  g;
	static ulong  h;
	static bool i;
	static float  j;
	static double k;
	static string l;
	static decimal m;
	static char n;
	static bool o;
	//static DateTime q;
	public static void Main(string[]args)
	{
		Console.WriteLine(sizeof(int));
		Console.WriteLine(sizeof(uint));
		Console.WriteLine(sizeof(byte));
		Console.WriteLine(sizeof(sbyte));
		Console.WriteLine(sizeof(short));
		Console.WriteLine(sizeof(ushort));
		Console.WriteLine(sizeof(long));
		Console.WriteLine(sizeof(ulong));
		Console.WriteLine(sizeof(bool));
		Console.WriteLine(sizeof(float));
		Console.WriteLine(sizeof(double));
		//Console.WriteLine(sizeof(string));
		Console.WriteLine(sizeof(decimal));
		Console.WriteLine(sizeof(char));
		Console.WriteLine(sizeof(bool));
		//Console.WriteLine(sizeof(DateTime));
	}
}