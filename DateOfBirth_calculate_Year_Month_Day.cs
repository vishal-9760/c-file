/*using System;
using System.Text;

namespace ConsoleApp1
{
    internal class DateOfBirth_calculate_Year_Month_Day
    {
        static string RemoveSpecialChars(string str)
        {
            string[] chars = {"@","$","%","!","&","*"};
            for(int i= 0; i < chars.Length; i++)
            {
                if(str.Contains(chars[i]))
                {
                    str = str.Remove(chars[i], " ");
                }
            }
            return str;
        }
        public static void Main()
        {
            string str = " @g$hfh%!&df*hu";
            Console.WriteLine(RemoveSpecialChars(str));
        }
    }
}
*/