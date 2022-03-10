using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício06
{
    public class TemperaturaCelsius
    {
        public int graus;

        public double ObtemTemperaturaEmFahrenheit()
        {
            double grausFahrenheint = (((9 * graus) + 160) / 5);
            return grausFahrenheint;
        }
    }
}
