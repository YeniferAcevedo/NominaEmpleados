using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina
{
    public class Salario : Nomina
    {
        public double calcularSalarioBase()
        {
            return (this.getCantidadHoras() * this.getValorHora());
        }
    }
}
