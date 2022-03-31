using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questaoDois
{
    internal class Saudacao
    {
        public static string opaTudoBem(string saudacoes)
        {
            switch (saudacoes)
            {
                case "M":
                    return "Bom Dia!";
                    
                case "V":
                    return "Boa Tarde!";
                   
                case "N":
                    return "Boa Noite!";
                    
                default:
                    return "Valor inválido";
            }
            
        }
    }
}
