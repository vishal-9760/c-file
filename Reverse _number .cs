/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vishal2
{
    internal class Reverse__number
    {   
        public static void Main(string[]args)
        {
            int num ;
            num = Convert.ToInt32(Console.ReadLine());
            int rev =0,rem;
            for( ;num!=0;)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(rev); 

        }
    }
}*/
