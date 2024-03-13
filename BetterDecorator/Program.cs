using System;

namespace BetterDecorator
{
    class Program
    {
        /// <summary>
        /// Buscar os 3 argumentos e converter em tipos de valor e referencia!
        /// Caso o utilizador não associe argumentos na linha de comandos,
        /// será impresso uma string usando os argumentos configurados
        /// do metodo Decor().
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(Decor("User dit not specify args!", '=', 3));
            }

            else
            {
                string frase = args[0];
                char type_of_char = char.Parse(args[1]);
                int rep = int.Parse(args[2]);
            
                Console.WriteLine(Decor(frase, type_of_char, rep));
            }

            

            
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
