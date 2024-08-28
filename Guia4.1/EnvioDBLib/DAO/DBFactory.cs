using EnvioDBLib.DAO.SQLImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDBLib.DAO
{
    public class DBFactory
    {

        static public IEnvioDAO getInstancia(string tipo)
        {
            if (tipo == "SQL-SERVER")
                return new EnvioDAOSQImpl();
            return null;
        }

    }
}
