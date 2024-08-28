using EnvioDBLib.Models;
using System.Collections.Generic;
namespace EnvioDBLib.DAO
{
    public interface ICostoDAO
    {
        void Add(Costo nuevo);

        void Update(Costo obj);

        void Delete(int id);

        List<Costo> GetAll();

        List<Costo> GetByIdEnvio(int idEnvio);
    }
}
