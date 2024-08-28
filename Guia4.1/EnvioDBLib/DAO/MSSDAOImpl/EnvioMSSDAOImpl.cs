using EnvioDBLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EnvioDBLib.DAO.MSSDAOImpl
{
    public class EnvioMSSDAOImpl : IEnvioDAO
    {
        
        public void Add(Envio nuevo)
        {

            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Envios(Valor_Total) VALUES(@ValorTotal); SELECT SCOPE_IDENTITY();";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@ValorTotal", nuevo.ValorTotal);

                conn.Open();

                var result = cmd.ExecuteScalar();

                nuevo.Id = Convert.ToInt32( result);
              
            }
        }

        public void Update(Envio obj)
        {
            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "Update Envios SET Valor_Total=@ValorTotal WHERE Id=@Id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@ValorTotal", obj.ValorTotal);
                cmd.Parameters.Add("@Id", obj.Id);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
        
        public void Delete(int id)
        {
            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Envios WHERE Id=@Id";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("@Id", id);

                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public List<Envio> GetAll()
        {
            var lista = new List<Envio>();

            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
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
    }
}
