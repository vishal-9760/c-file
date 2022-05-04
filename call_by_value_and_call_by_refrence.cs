using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Call_by_value_and_call_by_refrence
    {
         public static void Add(int x,int y)
         {
             //call by value
             x += 10;
             y *= 5;
             Console.WriteLine($"inside x{x}");
             Console.WriteLine($"inside y{y}");

         }

      /*  public static void Sum(ref int x, ref int y)
        {
            //call by reference 
            x += 10;
            y *= 5;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }*/

        /*public static void Main(string []args)
        {
            int x=5, y=6;
           // Sum(ref x,ref y);          
            Add(x,y);
            Console.WriteLine($"outside x{x}");
            Console.WriteLine($"outside y{y}");
        }*/

    }
}
