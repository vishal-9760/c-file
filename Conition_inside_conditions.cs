/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Conition_inside_conditions
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int fact = 1;
            int a = 0;
            int b = 1;
            int sum = 0;
            if (num <= 0)
            {
                Console.WriteLine("enter the positive number only");
            }
            else
            {
                if (num > 1)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 2)
                    {
                        Console.WriteLine("number is prime");
                        for (int i = num; i > 0; i--)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine(fact);
                    }
                    else
                    {
                        Console.WriteLine("number is not prime");
                        Console.Write(a + " ");
                        Console.Write(b);
                        for (int i = 2; i < num; i++)
                        {
                            sum = a + b;
                            Console.Write(" " + sum);
                            a = b;
                            b = sum;
                        }
                    }
                }
                Console.WriteLine("number is not prime");
                Console.Write(a + " ");
                Console.Write(b);
                for (int i = 2; i < num; i++)
                {
                    sum = a + b;
                    Console.Write(" " + sum);
                    a = b;
                    b = sum;


                }
            }
        }
    }
}*/
