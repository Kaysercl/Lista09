﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    internal class Vendedor
    {
        public int salarioFixo;
        public int totalVendas;
        public int percentualGanho;

        public double CalcularSalario()
        {
            double comissao = totalVendas * (percentualGanho / 100);

            double salarioTotal = (salarioFixo + comissao);

            return salarioTotal;
        }

            
    }
}
