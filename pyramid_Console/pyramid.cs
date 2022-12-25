using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class pyramid
    {
        static void Main(string[] args)
        {

            ////左邊三角形
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //右邊三角形
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 5; j > 0; j--)
                {
                    if (j > i)
                    {
                        Console.Write(" ");
                    }
                    else { 
                    Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //等腰三角形
            for (int i = 1; i <= 5; i++)
            {
                for (int a = 1; a <= 5 - i; a++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (i * 2 - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    
    }
}