namespace multiplication_Console
{
    internal class multiplication
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine( );
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + j * i);
                    Console.Write("\n");
                }


            }

        }
    }
}