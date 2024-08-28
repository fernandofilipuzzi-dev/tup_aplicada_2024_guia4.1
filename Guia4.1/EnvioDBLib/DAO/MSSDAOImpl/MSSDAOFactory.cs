using EnvioDBLib.DAO.MSSDAOImpl;
namespace EnvioDBLib.DAO
{
    public class MSSDAOFactory : DBDAOFactory
    {

        //autentificación con sql login
        //string connectionString = "Server=TUPDEV; DATABASE=EnviosDB; user='alumno'; password='alumno'; Trusted_Connection=True; ";
        static public string ConnectionString = "Server=TSP; DATABASE=EnviosDB; Integrated Security=true;; Trusted_Connection=True; ";

        public override IEnvioDAO EnvioDAO
        {
            get 
            { return new EnvioMSSDAOImpl(); 
            }
        }

        public override ICostoDAO CostoDAO
        {
            get
            {
                return new CostoMSSDAOImpl();
            }
        }


    }
}
