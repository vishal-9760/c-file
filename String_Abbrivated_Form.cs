/*using System;                //AK.sharma
using System.Text;
namespace vish
{
    class String_builder_abrivation
    {
        public static void Main(string[] args)
        {
            string str = "ajay kumar sharma";
            string[] strarr = str.Split(" ");
            StringBuilder sb = new StringBuilder();
            for(int i= 0; i < strarr.Length-1; i++)
            {
                sb.Append(strarr[i].Substring(0, 1).ToUpper());
            }
            sb.Append(".");
            sb.Append(strarr[2]);
            Console.WriteLine(sb);
        }


    }
}
*/