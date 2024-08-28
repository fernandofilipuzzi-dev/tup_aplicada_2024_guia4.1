using EnvioDBLib.DAO;
using EnvioDBLib.DAO.MSSDAOImpl;
using EnvioDBLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnvioDAO e = new EnvioMSSDAOImpl();

            #region insertando un envio
            Console.WriteLine("Ejemplo insertando dato");
            var nuevo = new Envio() { ValorTotal = 23.1 };
            e.Add(nuevo);
            Console.WriteLine($"{nuevo}");
            #endregion

            #region actualizando
            Console.WriteLine("Ejemplo insertando dato");
            nuevo.ValorTotal = 58.33;
            e.Update(nuevo);
            Console.WriteLine($"{nuevo}");
            #endregion

            #region listado
            Console.WriteLine("Ejemplo listando datos");
            foreach (var env in e.GetAll())
            {
                Console.WriteLine(env);
            }
            #endregion

            Console.ReadKey();

        }
    }
}
