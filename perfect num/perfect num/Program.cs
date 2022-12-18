using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_num
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
            { while(num1 > num2) {

                 if (  num2 % 2==0 )
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
