using System;

namespace Exercicio05
{
    internal class TesteEsfera
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();
            esfera.raio = 10;

            Console.WriteLine("O volume da esfera é: {0}", esfera.ObtemVolume());
        }
    }
}
