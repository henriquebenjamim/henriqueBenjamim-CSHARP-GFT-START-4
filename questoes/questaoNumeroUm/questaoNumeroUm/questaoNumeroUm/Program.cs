using System;
using System.Globalization;
using questaoNumeroUm.Entities;

namespace questaoNumeroUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime dataNasc = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Pessoa pessoa = new Pessoa(nome, dataNasc, altura);

            Console.WriteLine(pessoa.ToString());
            Console.WriteLine(pessoa.calcularIdade());
        }
    }
}
