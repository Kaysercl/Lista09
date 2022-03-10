using System;

namespace Lista09.Exercício01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caixa caixa = new Caixa();

            Console.WriteLine("Digite a altura da caixa");
            caixa.altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa");
            caixa.largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da caixa");
            caixa.comprimento = Convert.ToInt32(Console.ReadLine());

            caixa.CalcularVolumeCaixa();

            Console.WriteLine("O volume da caixa é " + caixa.volume);
            Console.ReadLine();
        }
    }
}
