using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter big number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter small number");
            double num2 = double.Parse(Console.ReadLine());
            




              if (num1 > num2)
              {
                  while (num1 > num2)
                  {

                     if (num2 % 2 != 0 && num2 % 3 != 0 && num2 % 4 != 0 && num2 % 5 != 0 && num2 % 6 != 0
                                && num2 % 9 != 0 && num2 % 8 != 0 && num2 % 7 != 0 )

           
                      {
                          Console.WriteLine(num2);
                      }
                      num2 += 1;

                  }

              }
              else Console.WriteLine("you have error ");

        }
    }
}
