using System;
namespace inlämning_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            Console.WriteLine("Skriv in tre tal på sammma rad med mellanrum");
            string tal = Console.ReadLine();
            string[] y = tal.Split(' ');

            int a = int.Parse(y[0]);
            int b = int.Parse(y[1]);
            int c = int.Parse(y[2]);

            int sum = (a + b + c);

            Console.WriteLine("Summan av dina tal är " + sum);
            
            Console.ReadKey();
           
        }
    }
}