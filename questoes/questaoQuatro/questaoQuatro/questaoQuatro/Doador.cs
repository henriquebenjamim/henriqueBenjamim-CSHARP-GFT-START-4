using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questaoQuatro
{
    class Doador
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Doador()
        { 
        }

        public Doador(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string validandoIdadeDoador()
        {
            if(Idade >= 18 && Idade < 67)
            {
                return "Você pode doar sangue.";
            }
            else
            {
                return "Infelizmente você não pode doar sangue, pois não atende o intervalo de idade (entre 18 e 67).";
            }
        }
    }
}
