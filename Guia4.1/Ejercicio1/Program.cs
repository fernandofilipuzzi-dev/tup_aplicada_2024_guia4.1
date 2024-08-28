
using EnvioDBLib.Models;
using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Envio e=new Envio();

            foreach (var env in e.ListarTodo())
            {
                Console.WriteLine(env);
            }

            Console.ReadKey();

        }
    }
}
