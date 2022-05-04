using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Param_keyword
    {
       
        public static int Add(params int []arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
      /*  public static void Main(string[] args)
        {
            int sum = Add(10,20,30,40,50);
            Console.WriteLine(sum);
        }*/
    }
}
