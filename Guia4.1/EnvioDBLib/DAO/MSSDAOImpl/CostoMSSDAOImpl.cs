using EnvioDBLib.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace EnvioDBLib.DAO.MSSDAOImpl
{
    public class CostoMSSDAOImpl : ICostoDAO
    {
        public void Add(Costo nuevo)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Costo obj)
        {
            throw new NotImplementedException();
        }

        public List<Costo> GetAll()
        {
            var lista = new List<Costo>();

            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Costos";
                cmd.CommandType = CommandType.Text;

                conn.Open();

                var rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    Costo costo = null;
                    int tipo = rd.GetInt32(rd.GetOrdinal("Id"));

                    if (tipo == 0)
                    {
                        costo = new Fijo()
                        {
                            Id = rd.GetInt32(rd.GetOrdinal("Id")),
                            ValorFinal = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Valor_Final"))),
                        };
                    }
                    else if (tipo == 1)
                    {
                        costo = new Variable()
                        {
                            Id = rd.GetInt32(rd.GetOrdinal("Id")),
                            PrecioPorUnidad = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Precio_Por_Unidad"))),
                            Unidades = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Unidades"))),
                        };
                    }

                    lista.Add(costo);
                }
            }

            return lista;
        }

        public List<Costo> GetByIdEnvio(int idEnvio)
        {
            var lista = new List<Costo>();

            using (var conn = new SqlConnection() { ConnectionString = MSSDAOFactory.ConnectionString })
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Costos WHERE Id_Envio=@Id_Envio";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Id_Envio", idEnvio);

                conn.Open();

                var rd = cmd.ExecuteReader();
                while (rd.Read() == true)
                {
                    Costo costo = null;
                    int tipo = rd.GetInt32(rd.GetOrdinal("Id"));

                    if (tipo == 0)
                    {
                        costo = new Fijo()
                        {
                            Id = rd.GetInt32(rd.GetOrdinal("Id")),
                            ValorFinal = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Valor_Final"))),
                        };
                    }
                    else if (tipo == 1)
                    {
                        costo = new Variable()
                        {
                            Id = rd.GetInt32(rd.GetOrdinal("Id")),
                            PrecioPorUnidad = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Precio_Por_Unidad"))),
                            Unidades = Convert.ToDouble(rd.GetDecimal(rd.GetOrdinal("Unidades"))),
                        };
                    }

                    lista.Add(costo);
                }
            }

            return lista;
        }
    }
}
