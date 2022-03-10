using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class Aluno
    {

        public int nota1;
        public int nota2;   

        public double ObtemMediaPonderada()
        {
            int pesoNota1 = 1;
            int pesoNota2 = 2;

            double mediaPonderada1 = nota1 * pesoNota1;
            double mediaPonderada2 = nota2 * pesoNota2;

            double totalMediaPonderada = (mediaPonderada1 + mediaPonderada2) / (pesoNota1 + pesoNota2);
            return totalMediaPonderada;
        }
    }
}
