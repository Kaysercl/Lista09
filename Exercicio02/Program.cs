using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConversorCelsius conversorcelsius = new ConversorCelsius();

            Console.WriteLine("Digite a temperatura em graus FARENHEINT");
            conversorcelsius.farenheint = Convert.ToDecimal(Console.ReadLine());

            conversorcelsius.ConverterParaFarenheint();

            Console.WriteLine("A temperatura em CELSIUS é de " + conversorcelsius.celsius);
        }
    }
}
