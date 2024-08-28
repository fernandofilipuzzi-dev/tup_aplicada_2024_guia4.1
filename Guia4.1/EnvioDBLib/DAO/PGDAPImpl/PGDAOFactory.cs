using EnvioDBLib.DAO.MSSDAOImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvioDBLib.DAO
{
    public class PGDAOFactory : DBDAOFactory
    {
        public override IEnvioDAO EnvioDAO { get { return null; } }

        public override ICostoDAO CostoDAO { get { return null; } }

    }
}
