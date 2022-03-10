using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class Cilindro
    {

        public int volume, areabase, altura;

        public void CalcularVolumeCilindro ()
        {
            volume = areabase * altura;
        }
    }
}
