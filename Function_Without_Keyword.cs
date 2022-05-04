using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function_Without_Keyword
    {
        public static int  Add(int x,int y,out int mul,out int sub)
        {
            int sum = x + y;
            mul = x * y;
            sub = x - y;
            return sum;
        }
      /*  public static void Main()
        {
            
            int res = Add(10, 5, out int mul,out int sub);
            Console.WriteLine(res);
            Console.WriteLine(mul);
            Console.WriteLine(sub);
        }*/
    }
}
