using System;

namespace uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int N = int.Parse(Console.ReadLine());
            int antal = 0;

            for (int i = 0; i < N; i++)
            {
                if ((i+1) * (i+2) * (i+3) < N)
                {
                    antal++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Svar: "+ antal);
        }
    }
}
