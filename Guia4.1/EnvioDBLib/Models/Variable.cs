using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDBLib.Models
{
    public class Variable:Costo
    {
        public double PrecioPorUnidad { get; set; }
        public double Unidades { get; set; }

    }
}
