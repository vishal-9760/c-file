using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class param_keyword_use_of_object
    {
        static double Add(params object []arr)
        {
            double sum = 0;
            foreach(object i in arr)
            {
                sum += Convert.ToDouble(i);
            }
            return sum;
        }
     /*   public static void Main(string []args)
        {
            double res = Add(10,20,30.2,50.60,90);
            Console.WriteLine(res);
        }*/
    }
}
