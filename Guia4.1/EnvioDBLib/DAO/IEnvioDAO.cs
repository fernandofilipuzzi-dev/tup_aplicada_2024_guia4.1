using EnvioDBLib.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EnvioDBLib.DAO
{
    public interface IEnvioDAO
    {

        void Add(Envio nuevo);

        void Update(Envio obj);

         List<Envio> ListarTodo();
    }
}
