/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Palindrome
    {
        public static void Main()
        {
            int num=int.Parse(Console.ReadLine());
            int rem = 0, rev = 0, temp = 0;
            temp = num;
            for(;num!=0;)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(rev);

            if (rev == temp)
            {
                Console.WriteLine("no is pelindrom");
            }
            else
                Console.WriteLine("number is not pelindrome");
        }
    }
}*/
