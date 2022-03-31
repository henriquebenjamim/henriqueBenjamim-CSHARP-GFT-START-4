using System;
using System.Globalization;

namespace questaoTres
{
    class vendinhaDasCriancas
    {
        public string TipoSuco { get; set; }
        public double VolumeLitros { get; set; }
        public double PrecoPorTotal { get; set; }

        public vendinhaDasCriancas()
        {
        }

        public vendinhaDasCriancas(string tipoSuco, double volumeLitros, double precoPorTotal)
        {
            TipoSuco = tipoSuco;
            VolumeLitros = volumeLitros;
            PrecoPorTotal = precoPorTotal;
        }

        public string calculandoDesconto()
        {
            //Limao - 3%/Litro(até 2 litros) -- 5%/Litro(Acima de 5 litros)
            //Tamarindo - 4%/Litro(até 2 litros) -- 6%/Litro(Acima de 5 litros)
            if (VolumeLitros <= 2.0)
            {
                // se o tipo do suco for limao
                if (TipoSuco == "L")
                {
                    return "O cliente tem 3% de desconto para suco de limao até 2l e só pagará R$ " + (PrecoPorTotal * (0.03 * (PrecoPorTotal / VolumeLitros))).ToString("F2", CultureInfo.InvariantCulture);
                }
                // se for tamarindo
                else if (TipoSuco == "T")
                {
                    return "O cliente tem 4% de desconto para suco de tamarindo até 2l e só pagará R$ " + (PrecoPorTotal * (0.04 * (PrecoPorTotal / VolumeLitros))).ToString("F2", CultureInfo.InvariantCulture);
                }
                else
                {
                    return "Este suco não existe.";
                }

            }
            else if (VolumeLitros > 5.0)
            {
                // se o tipo do suco for limao
                if (TipoSuco == "L")
                {
                    return "O cliente tem 5% de desconto/Litro para suco de limao acima de 5l e só pagará R$ " + (PrecoPorTotal * (0.05 * (PrecoPorTotal / VolumeLitros))).ToString("F2", CultureInfo.InvariantCulture);
                }
                // se for tamarindo
                else if (TipoSuco == "T")
                {
                    return "O cliente tem 6% de desconto/Litro para suco de tamarindo acima de 5l e só pagará R$ " + (PrecoPorTotal * (0.06 * (PrecoPorTotal / VolumeLitros))).ToString("F2", CultureInfo.InvariantCulture);
                }
                else
                {
                    return "Este suco não existe.";
                }
            }
            else
            {
                return "não existe desconto nessas condicoes.";
            }
        }
    }
}
