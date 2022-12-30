using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tmp =0;
            Console.WriteLine("Enter the number to start count ");
            int num1 = int.Parse(Console.ReadLine());                                                                                                           
            Console.WriteLine("Enter the number to stop count");    
            int num2 = int.Parse(Console.ReadLine());
            for (int i=num1 ; i <=num2 ; i++)
            {
                for (int c = 1; c <= i; c++)
                {
                    if (i % c == 0)
                    {
                        tmp++;
                    }
                }
                if (tmp==2)
                {
                    double perfect = Math.Pow(2, i) - 1;
                    double perfect2 = Math.Pow(2, i - 1);
                    Console.WriteLine("the prime number is:{0}",i);
                    Console.WriteLine("the perfect numper from it is :{0}\n",perfect*perfect2);

                }
                else
                {
                    tmp = 0;
                }

            }
            
                      
          
            





















        }
    }
}
