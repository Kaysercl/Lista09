using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Percurso
    {
        public int kminicial, kmfinal, consumo;

        public double CalcularGasto()
        {
            double distanciaPercorrida = kmfinal - kminicial;

            double gastoTotal = distanciaPercorrida / consumo;

            return gastoTotal;  
        }       
    }
}
