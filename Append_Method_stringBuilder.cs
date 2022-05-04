using System;
using System.Text;
namespace Vishal12
{
	class Append_Method_stringBuilder
	{
		public static void Main(string[] args)
		{
			string vish = Console.ReadLine();
			StringBuilder sb = new StringBuilder(vish);
			sb.AppendLine("@1234");
			sb.Append("number");
			Console.WriteLine(sb);
		}
	}
}

