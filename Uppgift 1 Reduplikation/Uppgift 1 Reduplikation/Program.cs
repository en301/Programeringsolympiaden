using System;

namespace uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordet?");
            string ord = Console.ReadLine();
            Console.WriteLine("Antal upprepningar?");
            int antal = int.Parse(Console.ReadLine());
            string långord = "";

            if (ord.Length <= 9 )
            {
                for (int i = 0; i < antal;i++)
                {
                    långord += ord;
                }
                Console.WriteLine("Svar: " + långord);
            }
            else
            {
                Console.WriteLine("Ordet var mer än 9 bokstäver");
            }
        }
    }
}
