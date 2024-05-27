using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Alumno alumno = new Alumno();


                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Datos del alumno:");
                alumno.Datos();
                alumno.CalcularPuntosARestar();
                alumno.MostrarDatos();
                Console.WriteLine("-------------------------------------------");

                Console.WriteLine("¿Desea continuar con otro alumno? s/n");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "s")
                {
                    break;
                }
            } while (true);

            Console.ReadKey();
        }
    }
}
