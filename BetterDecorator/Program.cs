using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = args[0];
            char 
            Console.WriteLine(Decor
            

        }

        private static string Decor(string s, char dec, int n_vezes)
        {
            string decoracao = new string(dec, n_vezes);
            return $"{decoracao} {s} {decoracao}";


        }

    }
}
