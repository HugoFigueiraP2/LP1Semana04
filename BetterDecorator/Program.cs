using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Buscar os 3 argumentos e converter em tipos de valor e referencia!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string frase = args[0];
            char type_of_char = char.Parse(args[1]);
            int rep = int.Parse(args[2]);
            
            Console.WriteLine(Decor(frase, type_of_char, rep));
        }
        
        /// <summary>
        /// Fazer com que os caracteres se repitam.
        /// </summary>
        /// <param name="s"></param> Frase
        /// <param name="dec"></param> Caracteres
        /// <param name="n_vezes"></param> Numero de vezes que os caracteres
        /// vão se repetir!
        /// <returns></returns> Os caracteres da string decoracao repetem-se
        /// tendo em conta o numero de vezes que foi atribuido. E por fim
        /// no meio fica a frase atribuida
        private static string Decor(string s, char dec, int n_vezes)
        {
            string decoracao = new string(dec, n_vezes); 
            //dec = carater | n_vezes = que vai ser impresso esse caracter

            return $"{decoracao} {s} {decoracao}";

        }

    }
}
