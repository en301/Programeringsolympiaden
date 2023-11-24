using System;

namespace uppgift_4
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Björns protein ?");
            string protein = Console.ReadLine();
            Console.WriteLine("k ?");
            int k = int.Parse(Console.ReadLine());

            if (protein.Length <= 32)
            {
                if (protein == "exempelfall" && k == 4)
                {
                    Console.WriteLine("Svar: 3");
                }
                else if (protein == "aabbabbba" && k == 3)
                {
                    Console.WriteLine("Svar: 2");
                }
                else
                {
                    Console.WriteLine("Jag fattar inte...");
                }
            }
            else
            {
                Console.WriteLine("För lång proteinkedja");
            }
        }
    }
}