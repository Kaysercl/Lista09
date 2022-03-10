using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Esfera
    {
        public int raio;

        public double ObtemVolume()
        {
            double volume = ((4 * Math.PI * Math.Pow(raio, 3) / 3));

            return volume;
        }
    }
}
