using System;

namespace questaoQuatro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Doador pessoaDoadora = new Doador(nome, idade);
            Console.WriteLine(pessoaDoadora.validandoIdadeDoador());
        }
    }
}
