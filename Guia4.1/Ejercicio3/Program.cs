using EnvioDBLib.DAO;
using EnvioDBLib.Models;
using System;
namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //llamando al factory!
            IEnvioDAO e = DBDAOFactory.Create("SQL-SERVER").EnvioDAO;

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
