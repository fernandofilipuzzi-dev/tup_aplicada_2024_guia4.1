
using Ejercicio1.Models;
using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Envio envio = new Envio();

            //
            Console.WriteLine("Ejemplo listando datos");
            foreach (var env in envio.GetAll())
            {
                Console.WriteLine(env);
            }

            Console.ReadKey();

        }
    }
}
