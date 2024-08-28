

namespace EnvioDBLib.Models
{
    abstract public class Costo
    {
        public int Id { get; set; }
        public string Concepto { get; set; }

        public double ValorFinal { get; set; }

        public int Id_Envio { get; set; }
    }
}
