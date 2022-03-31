using System;

namespace questaoTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vendinhaDasCriancas compra = new vendinhaDasCriancas("L", 2.0, 5.0);
            vendinhaDasCriancas compra1 = new vendinhaDasCriancas("L", 3.0, 5.0);
            vendinhaDasCriancas compra2 = new vendinhaDasCriancas("L", 6.0, 5.0);
            vendinhaDasCriancas compra3 = new vendinhaDasCriancas("T", 2.0, 7.0);
            vendinhaDasCriancas compra4 = new vendinhaDasCriancas("T", 3.0, 7.0);
            vendinhaDasCriancas compra5 = new vendinhaDasCriancas("T", 6.0, 7.0);

            Console.WriteLine(compra.calculandoDesconto());
            Console.WriteLine(compra1.calculandoDesconto());
            Console.WriteLine(compra2.calculandoDesconto());
            Console.WriteLine(compra3.calculandoDesconto());
            Console.WriteLine(compra4.calculandoDesconto());
            Console.WriteLine(compra5.calculandoDesconto());




        }
    }
}
