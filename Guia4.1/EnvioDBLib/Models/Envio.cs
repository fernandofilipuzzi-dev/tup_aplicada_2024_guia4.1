using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EnvioDBLib.Models
{
    public class Envio
    {
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public List<Costo> costos { get; set; } = new List<Costo>();

        public override string ToString()
        {
            return $"{Id} - {ValorTotal}";
        }

        
    }
}
