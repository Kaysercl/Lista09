using System;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LataOleo lata = new LataOleo();
            lata.raio = 3;
            lata.altura = 5;

            Console.WriteLine("O volume de uma lata de óleo é {0}", lata.ObtemVolume());  
        }
    }
}
