/*using System;                     // input=vishal pundir singh,output=Vishal Pundir Singh. 
using System.Text;
namespace vishal1
{
    class Substring_String_builder
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string[] strarr = str.Split(" ");
            string str1 = " ";
            string str2 = " ";
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < strarr.Length; i++)
            {
                str1 = strarr[i].ToUpper();
                str2 = strarr[i].Replace(strarr[i][0], str1[0]);
                sb.Append(str2);
            }
            Console.WriteLine(sb);
        }
    }
}
*/