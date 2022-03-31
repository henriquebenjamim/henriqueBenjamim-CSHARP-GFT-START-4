using System;

namespace questaoUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split();
            int A = int.Parse(valor[0]);
            int B = int.Parse(valor[1]);

            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }
}
