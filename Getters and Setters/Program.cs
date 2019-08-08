using System;

namespace Getters_and_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies avengers = new Movies("The Avengers", "Joss Whedon", "PG-13");
            Movies shrek = new Movies("Shrek", "Adam Admson", "PG");
            //G, PG, PG-13, R, NR
            
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
