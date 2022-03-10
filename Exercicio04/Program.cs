using System;

namespace Exercicio04
{
    class TestePercurso
    {
        static void Main(string[] args)
        {
            Percurso viagemPraCasa = new Percurso();
            viagemPraCasa.kminicial = 10;
            viagemPraCasa.kmfinal = 25;
            viagemPraCasa.consumo = 10;

            Console.WriteLine("O consumo de combustível por KM é {0}" ,
                viagemPraCasa.CalcularGasto());

        }
    }
}
