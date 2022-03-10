using System;

namespace Exercício06
{
    internal class TesteTemperaturaCelsius
    {
        static void Main(string[] args)
        {
            TemperaturaCelsius temperatura = new TemperaturaCelsius();

            temperatura.graus = 30;

            Console.WriteLine("O resultado da conversão é: {0}", temperatura.ObtemTemperaturaEmFahrenheit());
        }
    }
}
