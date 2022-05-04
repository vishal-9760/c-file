/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface Parent1
    {
        public  void M1();
    }
    public interface Parent2
    {
        public void M2();
    }
     class Interface_Class
    {
        public void M1()
        {
            Console.WriteLine("M1 method ");
        }
        public  void M2()
        {
            Console.WriteLine("M2 method");
        }
    }
    class Base
    {
        public static void M1()
        {
            Console.WriteLine("vishal in Main method");
        }
        public static void Main()
        {
            Interface_Class b =new Interface_Class();
           b.M1();
            M1();
           b.M2();
        }
    }
}
*/