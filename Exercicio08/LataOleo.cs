using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    internal class LataOleo
    {
        public int raio;
        public int altura;

        public double ObtemVolume()
        {
            double volume = ((Math.PI * raio) - (2 * altura));
            return volume;
        }
    }
}
