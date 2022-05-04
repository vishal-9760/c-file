/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hcf
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("enter the first number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
            y= int.Parse(Console.ReadLine());
            int temp = 0;
            int hcf = 1;
            if(x>y)
            {
                temp = x;
                x = y;
                y = temp;
            }
            for(int i = 2; i <=x; i++)
            {
                if(x%i==0 && y%i==0)
                {
                    hcf = i;
                    
                }
            }
            Console.WriteLine($"HCF of {x} and {y} is : {hcf}");

        }
    }
}*/
