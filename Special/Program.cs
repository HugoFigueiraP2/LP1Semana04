using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int user = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(user));
        }

        private static int GetSpecial(int n)
        {
            int result;
            if (n == 1)
            {
                result = 1;
            }
            else
                result = 1-n + 2 * n;
            return result;
        }
    }
}
