using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista09.Exercício01.ConsoleApp
{
    internal class Caixa
    {

        public int altura, comprimento, largura, volume;

        public void CalcularVolumeCaixa()
        {
            volume = altura * largura * comprimento;
        }                       
    }
}
