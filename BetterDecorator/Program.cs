using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = args[0];
            char type_of_char = char.Parse(args[1]);
            int rep = int.Parse(args[2]);
            
            Console.WriteLine(Decor(frase, type_of_char, rep));
        }

        private static string Decor(string s, char dec, int n_vezes)
        {
            string decoracao = new string(dec, n_vezes);
            return $"{decoracao} {s} {decoracao}";

        }

    }
}
