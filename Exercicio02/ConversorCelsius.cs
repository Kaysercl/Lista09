using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    internal class ConversorCelsius
    {
        public decimal farenheint, celsius;

        public void ConverterParaFarenheint()
        {
            celsius = (farenheint - 32) * 5 / 9;            
        }
    }

}
