using System;

namespace Exercicio07
{
    class TesteVendedor
    {
        void Main(string[] args)
        {
            Vendedor funcionario = new Vendedor();
            funcionario.salarioFixo = 2000;
            funcionario.totalVendas = 20000;
            funcionario.percentualGanho = 30;

            Console.WriteLine("O salario total do vendedor é: {0}", funcionario.CalcularSalario());
        }
    }
}
