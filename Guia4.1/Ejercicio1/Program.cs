
using EnvioDBLib.DAO;
using EnvioDBLib.DAO.SQLImpl;
using EnvioDBLib.Models;
using System;
using System.Data.Odbc;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnvioDAO e = DBFactory.getInstancia("SQL-SERVER");

            //
            Console.WriteLine("Ejemplo insertando dato");
            var nuevo = new Envio() { ValorTotal = 23.1 };
            e.Add(nuevo);
            Console.WriteLine($"{nuevo}");

            Console.WriteLine("Ejemplo insertando dato");
            nuevo.ValorTotal = 58.33;
            e.Update(nuevo);
            Console.WriteLine($"{nuevo}");


            //
            Console.WriteLine("Ejemplo listando datos");
            foreach (var env in e.ListarTodo())
            {
                Console.WriteLine(env);
            }

            Console.ReadKey();

        }
    }
}
