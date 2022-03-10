using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            Console.WriteLine("Digite a Área Base do cilindro");
            cilindro.areabase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a Altura do cilindro");
            cilindro.altura = Convert.ToInt32(Console.ReadLine());

            cilindro.CalcularVolumeCilindro();

            Console.WriteLine("O volume do cilindro é de " + cilindro.volume);
        }
    }
}
