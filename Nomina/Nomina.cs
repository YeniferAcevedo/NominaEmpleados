using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class Nomina
    {
        private double cantidadHoras;
        private double valorHora;
        
        public Nomina()
        {
            double minimo;
            minimo = 1200000;
            this.valorHora = minimo / 240;
        }

        public void setCantidadHoras(double valor)
        {
            this.cantidadHoras = valor;
        }

        public double getCantidadHoras()
        {
            return this.cantidadHoras;
        }

        public double getValorHora()
        {
            return this.valorHora;
        }
    }
}
