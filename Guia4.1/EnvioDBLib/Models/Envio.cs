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

        public List<Envio> ListarTodo()
        {
            var lista = new List<Envio>();

            using (var conn = new SqlConnection() { ConnectionString= "Server=TUPDEV; DATABASE=EnviosDB; user='alumno'; password='alumno'; Trusted_Connection=True; " })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Envios";
                cmd.CommandType = CommandType.Text;

                conn.Open();
                
                var rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    lista.Add(new Envio()
                    {
                        Id = rd.GetInt32(rd.GetOrdinal("Id")),
                        ValorTotal = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Valor_Total"))),
                    });
                }
                conn.Close();
            }

            return lista;
        }
    }
}
