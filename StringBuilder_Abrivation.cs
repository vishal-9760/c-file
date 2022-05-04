using System;
using System.Text;
namespace Vishal12
{
	class StringBuilder_Abrivation
	{
		public static void Main(string[] args)
		{
			string str = "vijay kumar sharma";
			string[] strarr = str.Split(" ");
			StringBuilder sb=new StringBuilder();
			for(int i=0;i<strarr.Length;i++)
            {
				sb.Append(strarr[i].Substring(0, 1).ToUpper());
            }
			sb.Append(strarr[strarr.Length - 1]);
			Console.Write(sb);
		}
	}
}

