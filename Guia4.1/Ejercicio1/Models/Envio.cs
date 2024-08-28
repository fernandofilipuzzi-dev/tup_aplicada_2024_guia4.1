
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;

namespace Ejercicio1.Models
{
    public class Envio
    {
        #region abstracción de datos
        public int Id { get; set; }
        public double ValorTotal { get; set; }
        public List<Costo> costos { get; set; } = new List<Costo>();

        public override string ToString()
        {
            return $"{Id} - {ValorTotal}";
        }
        #endregion

        #region abstracción de acceso a datos
        // string connectionString = "Server=TUPDEV; DATABASE=EnviosDB; user='alumno'; password='alumno'; Trusted_Connection=True;";
        string connectionString = "Server=TSP; DATABASE=EnviosDB; Integrated Security=true;; Trusted_Connection=True; ";

        public List<Envio> GetAll()
        {
            var lista = new List<Envio>();

            using (var conn = new SqlConnection() { ConnectionString = connectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Envios ORDER BY Valor_Total DESC";
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
            }

            return lista;
        }
        #endregion
    }
}
