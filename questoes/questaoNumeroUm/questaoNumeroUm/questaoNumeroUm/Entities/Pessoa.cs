using System;
using System.Globalization;

namespace questaoNumeroUm.Entities
{
    internal class Pessoa
    {
        private string Nome { get; set; }
        private DateTime DataDeNascimento { get; set; }
        private double Altura { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, DateTime dataDeNascimento, double altura)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Altura = altura;
        }

        public string calcularIdade()
        {
            // subtraindo data de agora com a data de nascimento.
            int age = (int)((DateTime.Now - DataDeNascimento).TotalDays / 365.242199);
            return "Tem " + age + " anos.";
            
        }
        public override string ToString()
        {
            return "A pessoa: " + Nome
                + " nasceu em " + DataDeNascimento.ToString("dd/MM/yyyy")
                + " tem de altura: " + Altura.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
