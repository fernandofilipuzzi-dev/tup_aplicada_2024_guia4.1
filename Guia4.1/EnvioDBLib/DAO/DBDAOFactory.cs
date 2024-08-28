using EnvioDBLib.DAO.MSSDAOImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDBLib.DAO
{
    abstract public class DBDAOFactory
    {

        abstract public IEnvioDAO EnvioDAO { get; }

        abstract public ICostoDAO CostoDAO { get; }

        static public DBDAOFactory Create(string tipo)
        {
            if (tipo == "SQL-SERVER")
            { 
                return new MSSDAOFactory();
            }
            else if(tipo=="PG-SERVER")
            {
                return new PGDAOFactory();
            }
            return null;
        }

    }
}
