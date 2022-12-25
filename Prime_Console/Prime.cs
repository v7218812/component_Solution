using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Console
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數的數字！");
            int number = int.Parse(Console.ReadLine());
            int a = 0;

            //if(number==2)

            //{ Console.WriteLine("這個數字是質數"); }

            //else if(number %2==0 || number % 3 == 0|| number % 5 == 0)

            //{ Console.WriteLine("這個數字不是質數"); }

            //else { Console.WriteLine("這個數字是質數"); }



            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    a = a + 1;
                }

            }
            if (a == 2)
                Console.WriteLine("這個數字是質數");
            else
                Console.WriteLine("這個數字不是質數");

        }
    }
}
