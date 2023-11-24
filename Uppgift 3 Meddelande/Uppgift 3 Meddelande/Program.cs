using System;

namespace uppgift_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m?");
            int m = int.Parse(Console.ReadLine());
            string[] rader = new string[n];
            string ordet = "";

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Rad " + (i + 1) +"?");
                rader[i] = Console.ReadLine();
                string[] ord = rader[i].Split('.');
                foreach (string s in ord)
                {
                    ordet += s;
                }
            }
            Console.WriteLine("Svar: "+ ordet);
        }
    }
}