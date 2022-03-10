using System;

namespace Exercicio09
{
    internal class TesteAluno
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nota1 = 10;
            aluno.nota2 = 10;

            Console.WriteLine("A média ponderada do aluno é: {0}", aluno.ObtemMediaPonderada());  
        }
    }
}
