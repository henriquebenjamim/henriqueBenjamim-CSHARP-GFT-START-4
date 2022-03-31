using System;
using System.Globalization;

namespace questaoUm.Entities
{
    class Pessoa
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
            DateTime horarioAgora = DateTime.Now;
            TimeSpan idade = horarioAgora.Subtract(DataDeNascimento);
            
            return "Tem " + Math.Ceiling(idade.TotalDays / 365).ToString("F0") + " anos"; 
        }
        public override string ToString()
        {
            return "A pessoa: " + Nome
                + " nasceu em " + DataDeNascimento.ToString("dd/MM/yyyy")
                + " e tem altura: " + Altura.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
